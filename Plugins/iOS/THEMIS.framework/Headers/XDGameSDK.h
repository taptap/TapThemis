//
//  XDGameSDK.h
//  XDGameCrash
//
//  Created by tianguo on 2021/9/14.
//

#import <Foundation/Foundation.h>

NS_ASSUME_NONNULL_BEGIN

//typedef void (*ptrNonStaticFun_p)(float*,float*);

//typedef void (^crashBlock)(int si_code,void* si_addr);

typedef void (*onInfoReceiverFunc)(uint64_t,uint64_t);

@interface XDGameSDK : NSObject

/**
 *  初始化THEMIS
 *  @param appId 注册THEMIS分配的 App Key
 */
+(void)startWithAppId:(NSString*)appId;

/**
 *  初始化THEMIS
 *  描述：采用服务器地址、端口、项目id的方式初始化 themis
 *  @param server 服务器地址
 *  @param prot 服务器端口
 *  @param appid 项目id
 */
+(void)initAll:(NSString*)server prot:(int)prot appid:(NSString*)appid;

/**
 *  描述：设置属性
 *  @param gamePlayerName 游戏玩家name
 */
+(void)setGamePlayerName:(NSString*)gamePlayerName;

/**
 *  描述：设置属性
 *  @param gameScene 游戏场景
 */
+(void)setGameScene:(NSString*)gameScene;

/**
 *  自定义数据,以json字符串做为参数传递,可添加多个
 *    长度不要超过250个字符
 *  @param key 对应的json中的key
 *  @param value 对应的json中的value
 */
+(void)customData:(NSString*)key value:(NSString*)value;

/**
 *  自定义标签，可为自定义json设置标签，
 *  @param message 为自定义消息的标题头
 */
+(void)addMessage:(NSString*)message;


+(void)onInfoReceiver:(onInfoReceiverFunc)func_p;


+(void)TMInit:(uint64_t)p;

+(void)TMCR:(const char *)SceneID on_off:(bool)on_off;

+(NSString*)vsrsion;

@end

NS_ASSUME_NONNULL_END
