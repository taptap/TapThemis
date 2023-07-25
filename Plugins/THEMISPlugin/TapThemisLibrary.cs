using System.Diagnostics.CodeAnalysis;
using UnityEngine;

namespace TapTap.Themis
{
    public interface TapThemisCallBack
    {
        void onHandleThemisState(int state, string message);
        string getExtraMessage();
        string getExceptionMessage();
        string getOOMMessage(float v);
    }
#if UNITY_EDITOR
    public class TapThemisCallBackImp
    {
        public TapThemisCallBackImp(TapThemisCallBack cb)
        {
        }
        public void onHandleThemisState(int state, string message)
        {

        }

        public string getExtraMessage()
        {
            return null;
        }

        public string getExceptionMessage()
        {
            return null;
        }

        public string getOOMMessage(float v)
        {
            return null;
        }
    }
#elif UNITY_ANDROID
    [SuppressMessage("ReSharper","InconsistentNaming")]
    public class TapThemisCallBackImp : AndroidJavaProxy
    {
        private static readonly string GAME_AGENT_CALLBACK_CLASS = "com.tds.themis.ThemisCallBack";
        private static TapThemisCallBack _callback;
        public TapThemisCallBackImp(TapThemisCallBack cb):base(GAME_AGENT_CALLBACK_CLASS)
        {
            _callback = cb;
        }
        public void onHandleThemisState(int state,string message)
        {
            if(_callback != null){
                _callback.onHandleThemisState(state,message);
            }
        }
        public string getExtraMessage()
        {
            if (_callback != null)
            {
                return _callback.getExtraMessage();
            }
            return null;
        }
        public string getExceptionMessage()
        {
            if (_callback != null)
            {
                return _callback.getExceptionMessage();
            }
            return null;
        }
        public string getOOMMessage(float v)
        {
            if (_callback != null)
            {
                return _callback.getOOMMessage(v);
            }
            return null;
        }
    }
#elif UNITY_IPHONE || UNITY_IOS
    public class TapThemisCallBackImp
    {
        private static TapThemisCallBack _callback;
        public TapThemisCallBackImp(TapThemisCallBack cb)
        {
            _callback = cb;
        }

        public void onHandleThemisState(int state, string message)
        {
            if (_callback != null)
            {
                _callback.onHandleThemisState(state, message);
            }
        }

        public string getExtraMessage()
        {
            if (_callback != null)
            {
                return _callback.getExtraMessage();
            }
            return null;
        }

        public string getExceptionMessage()
        {
            if (_callback != null)
            {
                return _callback.getExceptionMessage();
            }
            return null;
        }
        public string getOOMMessage(float v)
        {
            if (_callback != null)
            {
                return _callback.getOOMMessage(v);
            }
            return null;
        }
    }
#elif UNITY_STANDALONE && UNITY_STANDALONE_WIN
    public class TapThemisCallBackImp
    {
        private static TapThemisCallBack _callback;
        public TapThemisCallBackImp(TapThemisCallBack cb)
        {
            _callback = cb;
        }

        public void onHandleThemisState(int state, string message)
        {
            if (_callback != null)
            {
                _callback.onHandleThemisState(state, message);
            }
        }

        public string getExtraMessage()
        {
            if (_callback != null)
            {
                return _callback.getExtraMessage();
            }
            return null;
        }

        public string getExceptionMessage()
        {
            if (_callback != null)
            {
                return _callback.getExceptionMessage();
            }
            return null;
        }
        public string getOOMMessage(float v)
        {
            if (_callback != null)
            {
                return _callback.getOOMMessage(v);
            }
            return null;
        }
    }
#else
    public class TapThemisCallBackImp
    {
        public TapThemisCallBackImp(TapThemisCallBack cb)
        {
        }

        public void onHandleThemisState(int state, string message)
        {

        }

        public string getExtraMessage()
        {
            return null;
        }

        public string getExceptionMessage()
        {
            return null;
        }
        public string getOOMMessage(float v)
        {
            return null;
        }
    }
#endif
}