//
//  libXDCrash.h
//  libXDCrash
//
//  Created by tianguo on 2021/9/28.
//

#import <Foundation/Foundation.h>



@interface libXDTHEMIS : NSObject
#ifdef __cplusplus
extern "C" {
#endif
extern void _lib_init_THEMIS_agent();
    
extern void _lib_init_THEMIS_agent_with_id(const char* appId);

extern void _lib_set_game_player(const char *game_player);
extern void _lib_set_game_current_scene(int sceneID);
extern void _lib_enable_debug_mode(bool isTurnOn);
extern void _lib_csharp_report_exception(const char* name, const char* reason, const char* stackTrace,int nType, bool isQuitApp);
extern void _lib_event_tracking(const char *logData);
extern void _lib_log_report(const char *logMessage);

extern void _lib_debug_log(const char *lpLogData);
    

extern void _add_custom_field(const char * str_key,const char * str_value);
    
extern void _report_custom_message(const char * str_message);
    
    
#ifdef __cplusplus
}
#endif
@end
