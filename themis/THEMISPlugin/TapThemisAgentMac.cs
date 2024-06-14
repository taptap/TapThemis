using UnityEngine;

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;
using AOT;
//using System.Diagnostics.Debug;


namespace TapTap.Themis
{
#if UNITY_STANDALONE_OSX
    public class TapThemisAgentMac : TapThemisAgent
    {
        private static TapThemisCallBackImp _callbackImp = null;

        // 定义了一个协议
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void onThemisStateCB(int state,string message);
        [MonoPInvokeCallback(typeof(onThemisStateCB))]

        // 实现了该协议？
        static void _onThemisStateCB(int state, string message)
        {
            if (_callbackImp != null)
            {
                _callbackImp.onHandleThemisState(state, message);
            }
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate string getExtraMessageCB();
        [MonoPInvokeCallback(typeof(getExtraMessageCB))]
        static string _getExtraMessageCB()
        {
            if (_callbackImp != null)
            {
                return _callbackImp.getExtraMessage();
            }
            return null;
        }
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate string getExceptionMessageCB();
        [MonoPInvokeCallback(typeof(getExceptionMessageCB))]
        static string _getExceptionMessageCB()
        {
            if (_callbackImp != null)
            {
                return _callbackImp.getExceptionMessage();
            }
            return null;
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate string getOOMMessageCB(float v);
        [MonoPInvokeCallback(typeof(getOOMMessageCB))]
        static string _getOOMMessageCB(float v)
        {
            if (_callbackImp != null)
            {
                return _callbackImp.getOOMMessage(v);
            }
            return null;
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate string getStrongKillMessageCB();
        [MonoPInvokeCallback(typeof(getStrongKillMessageCB))]
        static string _getStrongKillMessageCB()
        {
            if (_callbackImp != null)
            {
                return _callbackImp.getStrongKillMessage();
            }
            return null;
        }

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate string getExtraMessageCBEx(string message);
        [MonoPInvokeCallback(typeof(getExtraMessageCBEx))]
        static string _getExtraMessageCBEx(string message)
        {
            if (_callbackImp != null)
            {
                return _callbackImp.getExtraMessageEx(message);
            }
            return null;
        }

        // --- dllimport start ---
        [DllImport("THEMISMAC")]
        private static extern void lib_init_THEMIS_agent_with_id(string appID);// InitTHEMISAgentWithID

        [DllImport("THEMISMAC")]
        private static extern void lib_report_exception_with_type(string name, string reason, string stackTrace, int exception_type, bool isQuitApp);

        [DllImport("THEMISMAC")]
        private static extern void lib_report_custom_exception_ex(string name, string reason, string message, bool isQuitApp,string extra_message,int extra_len);

        [DllImport("THEMISMAC")]
        private static extern void lib_set_native_callback(IntPtr themis_state_cb, IntPtr extra_message_cb);

        [DllImport("THEMISMAC")]
        private static extern void lib_add_custom_field(string str_key, string str_value);//AddCustomField

        [DllImport("THEMISMAC")]
        private static extern IntPtr lib_get_themis_heartbeat(UInt32 index, UInt64 random);

        [DllImport("THEMISMAC")]
        private static extern void lib_event_tracking(string logData);//EventTracking

        [DllImport("THEMISMAC")]
        private static extern void lib_log_report(string logMessage);

        [DllImport("THEMISMAC")]
        private static extern void lib_debug_log(string lpLogData);

        [DllImport("THEMISMAC")]
        private static extern void lib_enable_debug_mode(bool isTurnOn);

        [DllImport("THEMISMAC")]
        private static extern void lib_set_exception_callback(IntPtr message_cb);

        [DllImport("THEMISMAC")]
        private static extern void lib_set_exception_oom_callback(IntPtr message_cb);

        [DllImport("THEMISMAC")]
        private static extern void lib_set_strong_kill_callback(IntPtr message_cb);

        [DllImport("THEMISMAC")]
        private static extern IntPtr lib_get_oneid_data();

        [DllImport("THEMISMAC")]
        private static extern void lib_set_extra_callback_ex(IntPtr message_cb);

        [DllImport("THEMISMAC")]
        private static extern void lib_set_use_extend_callback(bool b);

        [DllImport("THEMISMAC")]
        private static extern void lib_TMInit(UInt64 message_cb);

        [DllImport("THEMISMAC")]
        private static extern void lib_TMCR(string scene_id,bool on_off);

        

        // dllimport end
        public override void InitTHEMISAgent()
        {
        }

        public override void InitTHEMISAgentWithID(string appID)
        {
            if (!string.IsNullOrEmpty(appID))
            {
                lib_init_THEMIS_agent_with_id(appID);
            }
        }



        public override void SetGamePlayer(string gamePlayer)
        {
            if (!string.IsNullOrEmpty(gamePlayer))
            {
                AddCustomField("playerinfo", gamePlayer);
            }
        }


        public override void AddCustomField(string str_key, string str_value)
        {
            lib_add_custom_field(str_key, str_value);
        }

        public override void SetGameCurrentScene(string sceneId)
        {
            AddCustomField("gamescene", sceneId.ToString());
        }

        public override void EnableDebugMode(bool enable)
        {
            lib_enable_debug_mode(enable);
        }

        public override void ReportException(string name, string message, string stackTrace, bool isQuitApp)
        {
            if ((!string.IsNullOrEmpty(name)) && (!string.IsNullOrEmpty(message)) && (!string.IsNullOrEmpty(stackTrace)))
            {
                lib_report_exception_with_type(name, message, stackTrace, 0, isQuitApp && TapThemis.AutoQuitApplicationAfterReport);
            }
        }

        public override void ReportCustomException(string name, string reason, string message, bool isQuitApp)
        {

            if ((!string.IsNullOrEmpty(name)) && (!string.IsNullOrEmpty(reason)) && (!string.IsNullOrEmpty(message)))
            {

                lib_report_exception_with_type(name, reason, message, 1, isQuitApp && TapThemis.AutoQuitApplicationAfterReport);
            }
        }

        public override void ReportCustomExceptionEx(string name, string reason, string message, bool isQuitApp,string extra_message,int extra_len)
        {
            if ((!string.IsNullOrEmpty(name)) && (!string.IsNullOrEmpty(reason)) && (!string.IsNullOrEmpty(message)))
            {
                lib_report_custom_exception_ex(name, reason, message, isQuitApp && TapThemis.AutoQuitApplicationAfterReport,extra_message,extra_len);
            }
        }

        public override void EventTracking(string strEvent)
        {
            if (!string.IsNullOrEmpty(strEvent))
            {

                lib_event_tracking(strEvent);
            }
        }


        public override void SetCallback(TapThemisCallBackImp cb)
        {
            _callbackImp = cb;

            onThemisStateCB state_handler = new onThemisStateCB(_onThemisStateCB);
            getExtraMessageCB message_handler = new getExtraMessageCB(_getExtraMessageCB);
            getExceptionMessageCB exception_msg_handler = new getExceptionMessageCB(_getExceptionMessageCB);
            getExtraMessageCBEx ex_message_handler = new getExtraMessageCBEx(_getExtraMessageCBEx);
            getOOMMessageCB oom_handler = new getOOMMessageCB(_getOOMMessageCB);
            getStrongKillMessageCB strong_kill_handler = new getStrongKillMessageCB(_getStrongKillMessageCB);

            IntPtr state_cb = Marshal.GetFunctionPointerForDelegate(state_handler);
            IntPtr message_cb = Marshal.GetFunctionPointerForDelegate(message_handler);
            IntPtr exception_msg_cb = Marshal.GetFunctionPointerForDelegate(exception_msg_handler);
            IntPtr message_cb_ex = Marshal.GetFunctionPointerForDelegate(ex_message_handler);
            IntPtr oom_msg_cb = Marshal.GetFunctionPointerForDelegate(oom_handler);
            IntPtr strong_kill_cb = Marshal.GetFunctionPointerForDelegate(strong_kill_handler);

            lib_set_native_callback(state_cb, message_cb);
            lib_set_exception_callback(exception_msg_cb);
            lib_set_exception_oom_callback(oom_msg_cb);
            lib_set_strong_kill_callback(strong_kill_cb);
            lib_set_extra_callback_ex(message_cb_ex);
        }

        public override void SetEngine(bool isCustom, bool isOpenGl)
        {
        }

        public override string GetHeartbeat(int index, long random)
        {

            IntPtr hb = lib_get_themis_heartbeat((uint)index,(ulong)random);

            string str_hb = Marshal.PtrToStringAnsi(hb);
            return str_hb;
        }

        public override string GetOneidData()
        {
            IntPtr hb = lib_get_oneid_data();

            string str_hb = Marshal.PtrToStringAnsi(hb);
            return str_hb;
        }

        public override void SetUseExtendCallback(bool b)
        {
            lib_set_use_extend_callback(b);
        }

        public override void TMInit()
        {
            lib_TMInit(0);
        }
        
        public override void TMCR(string sceneId,bool on_off)
        {
            lib_TMCR(sceneId,on_off);
        }

        public override void InputData(int type,float force,float x,float y,int index, uint source)
        {

        }
    }

#endif
}
