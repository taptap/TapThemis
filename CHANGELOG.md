*** 3.2.5.2 ***
Android：
1.优化捕获异常流程
2.修复时序问题导致oneid等信息上报异常
3.优化运行环境检测以及上报
4.修复已知问题

*** 3.2.3.3 ***
iOS：
1.修复设备连接外设键盘输入文字时闪退

*** 3.2.3.2 ***
Android：
1.修改获取 model 异常

*** 3.2.3.1 ***
1.修复轨迹重复上报
2.修复网络多线程安全
3.轨迹增加新特性
4.加速器检测

Windows：
1.新的版本验证码:{71,34,33,-20,-39,102,55,-63,-90,-97,78,63,-60,-96,-22,32,96,-35,-128,5,54,-76,59,-101,-120,39,-112,96,-111,66,-23,65,54,57,55,102,0};
2.修复轨迹数据异常

Android：
1.心跳增加生物探针信息
2.修复 android 14 输入信息捕获
3.修复安卓低版本系统崩溃问题

iOS:
1、修复获取appid时序的bug
2、心跳增加生物探针信息

Mac:
1、修复获取appid时序的bug

*** 3.2.2.9 ***
Windows：
1.修复栈溢出异常避免因为打印日志导致的死锁
2.修复关卡重复关闭导致轨迹数据重复

iOS、Mac
1.修复了游戏内存开销较大的时候，用户手工杀掉进程误报oom的bug
2.修复心跳在多线程的某些情况出现crash
3.修复了轨迹在多线程的某些情况出现crash

*** 3.2.2.8 ***
1.增加 input_data 接口用于自定义上报输入数据
Android：
1.修复mumu模拟器api调用死锁问题
iOS:
Mac:
1、修复了系统强杀使用时长错误的bug

*** 3.2.2.6 ***
1.增加捕获输入设备信息开关

Android：
1.修复轨迹捕获适配问题
2.MUMU指定版本适配（mumu提供具体版本）

iOS:
Mac:
1、修复了oom上报时game log丢失的bug
2、修复了设备总的存储空间数据不对的bug
3、修复了getOneID随机数不随机的bug
4、优化了GetOneidData 初始化的时刻

*** 3.2.2.5 ***
Android：
1.适配x64
2.修复加固问题

*** 3.2.2.3 ***
Android：
Windows：
1.修复加密逻辑的安全判断

iOS:
Mac:
1.修复了心跳接口卡住的bug
2.修复了base64的bug
3.优化了部分代码

*** 3.2.2.2 ***
Windows：
1.修复轨迹最短时间统计错误

Android：
1.修复轨迹最短时间统计错误
2.支持android 11及以上系统非预期闪退捕获
3.增加模拟器特征检测
4.增加系统非预期闪退状态通知（详见接入回调介绍）
5.增加系统非预期闪退回调

iOS:
1.修复了多线程调用的bug
2.优化了部份代码

Mac:
1.修复了多线程调用的bug
2.优化了部份代码


*** 3.2.1.7 ***
1.修复上报日志文件压缩错误

Android：
1.优化崩溃处理

Windows：
1.修复权限问题
2.新增外挂特征信息

iOS:
1、修复了自定义数据上报的bug
2、优化了安全检测及多线程的检测
3、优化了网络上报

Mac:
1、修复了自定义数据上报的bug
2、优化了安全检测及多线程的检测
3、优化了网络上报

*** 3.2.1.3 ***
Android：
1.修复检查apk包签名崩溃

*** 3.2.1.2 ***
1.增加崩溃回调扩展(详见接入文档)

Android:
1.优化反外挂作弊检测
2.优化崩溃处理
3.增加云主机特征

Windows:
1.修复兼容性错误
2.优化崩溃处理

iOS:
1、优化轨迹收集、识别主流手柄输入
2、修复已知bug

Mac:
1、优化轨迹收集、识别主流手柄输入
2、修复已知bug

*** 3.2.0.1 ***
1.心跳结构优化
2.oneid 结构优化
3.轨迹结构优化
4.增加新接口：获取oneid信息

Android：
1.优化轨迹收集，识别主流手柄输入

iOS:
1、修复第三方lz4兼容问题
2、适配了ios17
3、修复已知bug

Mac：
1、修复第三方lz4兼容问题
2、修复已知bug

Windows：
1.虚拟机识别增强
2.正确获取win7显卡列表

*** 3.1.9.1 ***
1.优化用户id上报逻辑,增加打点信息

Android：
1.修复crash处理时anr导致时序问题
2.memtrap信息上报优化
3.外挂检测结果优化
4.修改uuid算法

Windows：
1.修复未初始化导致某些数据显示异常
2.修改uuid算法
3.优化读取执行文件版本

iOS:
1、增加了系统强杀的捕获
2、外挂检测结果优化

Unity:
1.error log 增加关键字：“[themis ignore]”作为忽略标记

*** 3.1.8.3 ***
Android：
1.修复模拟器特征识别

*** 3.1.8.2 ***
1.修复重连后重发大数据包不完整问题

Android：
1.优化抓取 unity mono 崩溃信息

iOS/Mac:
1、修复错误数据的异常进程字段

*** 3.1.8.1 ***
1.优化 crash 信息

Android：
1.manifest 中版本号与code合并，app版本显示为x.x.x(y)
2.修复crash信息堆栈回溯问题

Windows：
1.修改注册表位置
2.允许配置保留未上传成功dump文件
3.crash 容错处理

iOS:
1、修复crash某些时候无法上报

Mac：
1、新增mac平台


*** 3.1.7.5 ***
Android：
1.移除多余日志输出

Windows：
1.移除多余日志输出

iOS:
1、修复弱网下crash 自定义字段丢失bug

*** 3.1.7.2 ***
1.修复网络重发机制

*** 3.1.6.3 ***
windows:
1.修复错误上报回调返回空指针导致崩溃的问题

*** 3.1.6.2 ***
Android：
1.优化 crash 发动回滚机制
2.优化某些数据精度

iOS:
1、调整了OOM接口,各平台接口见sdk文档，下文UE4举例说明
UE4: void SetOOMCallback(uintptr_t message_cb)
      message_cb: 回调函数指针
定义原型 typedef const char* (*get_OOM_message)(float mem_v)
      mem_v OOM 崩溃时的内存值
      返回值表示需要上传游戏日志,允许 NULL


*** 3.1.6.1 ***
1.添加轨迹特征

Android：
1.增加Toast 提示

*** 3.1.5.3 ***
iOS:
1.修复错误信息名字尾部被截取掉一个字符的bug

*** 3.1.5.2 ***
1.unity 增加枚举类型 LogIgnore 用于忽略 THEMIS 捕获上传 error
2.优化错误信息上传
3.限制错误信息名字长度，小于512

Android:
1.mumu 模拟器特征更新
2.沙盒检测优化

iOS:
1、增加oom回调接口
2、添加了crash时部分日志输出
3、themis未初始化的时候自定义消息日志忽略不上报

*** 3.1.5.1 ***
1.增加新的回调函数，允许上报错误信息时调用，用于获取游戏日志
2.增加安全监测（检测线程运行安全）

windows：
1.正确收集U3D crash信息
2.增加一些本地设备信息采集

Android：
1.增加沙盒检测

iOS:
1、修复已知bug


*** 3.1.3.1 ***
1.addCustomField除关键key外，区分大小写
2.正确处理字符串拷贝，修复越界风险
3.修复 custom data 序列化越界风险
4.crash 计数
5.心跳包 计数


Android：
1.新方式获取Renderer和OpenGL信息
2.修复崩溃地址为0时，误获取为themis地址的BUG
3.MUMU12 针对性修改
4.崩溃收集优化
5.ANR收集优化

Windows:
1.crash设置后台标记

ios:
1、修复越界的bug
2、多线程锁的优化
3、修复deviceinfo乱码问题


*** 3.1.2.3 ***
windows：
1.addCustomField除关键key外，区分大小写
2.正确处理字符串拷贝，修复越界风险
3.修复 custom data 序列化越界风险
4.crash设置后台标记
5.THEMIS 初始化改为异步模式


*** 3.1.2.2 ***
windows:
修复低版本系统 kernel 兼容问题

*** 3.1.2 ***
1.修复网络重连问题

windows：
1.修复 windows 11 判断
2.修复 DbgHelp.DLL 版本问题
3.修复获取线程名导致crash收集问题
4.修复 OEM 厂牌显示问题

Android：
1.修复已知问题

ios
1、修复游戏关卡切换黑屏的bug
2、修复crash第二次启动上报崩溃的bug

*** 3.1.0 ***
1.详细分类 description 和 detection
2.支持 unity themis 心跳
3.修复 oneid 回调 message 出现乱码问题
4.修复网路 token 刷新问题
5.Device 强制发送
6.UE4 接口log 修改

windows
1.记录后台时长，单位（秒）
2.通过注册表读取虚拟机状态

android
1.修复 x64 模拟器误报

ios
1、修复 ios 程序主动调用exit 会上报crash
2、优化了 boringssl 的警告


*** 3.0.9.1 ***
windows
1.修复 crash 抓取

iOS
1.默认ue4 iOS 开启

*** 3.0.9 ***
iOS
1.修复 event tracking 乱码
2.修复 crash 捕获并上传2次

windows
1.修复目录包含中文、特殊字符导致crash信息无法上传问题

android
1.修复 ANR 问题
2.crash 上报优化

*** 3.0.8 ***
1. crash 计数器
2. THEMIS 内部通行证 uuid
3. unity 增加宏 TAPTHEMIS_DISABLE 用于关闭 THEMIS
4. unreal 增加宏 XDTHEMIS_WINDOWS、XDTHEMIS_ANDROID、XDTHEMIS_IOS 用于控制每个平台开启关闭

windows:
1. 关闭 UAC 检测
2. 心跳数据添加 UAC 状态信息
3. crash 时检测 Device 发送状态
4. 修复微软虚拟机误报

android:
1. 更准确获取运行时 CPUABI 信息
2. 增加 Context Provider，用于获取 Intent
3. 允许初始化前预设回调函数
4. 切换至后台时记录持续时间 key:appbg

iOS:
1. 保证crash之前一定上传设备信息
2、修复ios弱网崩溃的bug
3、修复ios符号表缺少模块名称的bug

*** 2023.3.22 ***
1.优化网络库

android
1.修复切换后台闪退问题

*** 2023.3.17 ***
1.优化心跳数据处理

android
1.支持 x86、x86_64

iOS
1.修复心跳包闪退bug

*** 2023.3.15 ***
windows
1.新增接口 set_themis_callback，允许在 themis 初始化之前调用
2.优化心跳数据，增加更多埋点数据
3.优化 CPU 占用
4.修复错误上报特殊字符不显示

iOS
1.优化心跳数据，增加更多埋点数据
2.优化了大文件读取方式，防止占用更多内存
3.优化了部分性能

android
1.通过 Intent 专递外部 oneid
2.优化心跳数据，增加更多埋点数据
3.修复错误上报特殊字符不显示


*** 2023.3.9 ***
iOS
1、优化了log日志取最新的日志，及限制当次的大小
2、优化了大文件读取占用很多内存问题
3、优化设备信息上报策略

Android
1.移除获取 android id

*** 2023.3.6 ***
windows
1.修复发送队列过小

iOS
1、优化自定义日志上传的过滤时间
2、修复部分已知问题

*** 2023.3.3 ***
全部：
1.更新 asio 至 1.81
2.添加宏控制是否使用内存池（业务、网络）
3.区分项目支持不同大小附件
4.修复网络重连问题
5.限制附件上传

Android-3.0.3.23030301
1、THEMIS内部判断vulkan
2、处理完crash恢复sigmask，防止后续handle处理异常
3、调增custom_field_serialization位置，接受vulkan字段

*** 2023.2.24 ***
Android-3.0.1.23022301
1.优化检测效率
2.状态回调通知中增加 oneid 通知
3.修复部分已知问题

windows-3.0.1.23022301
1.补充完善错误和崩溃信息
2.修复 UE4 下崩溃捕获问题
3.状态回调通知中增加 oneid 通知
4.支持 unity
5.修复部分已知问题

iOS-3.0.1.23022301
1.状态回调通知中增加 oneid 通知
2.修复部分已知问题

-------------------------------------------------------------------------------------------------------------
更早之前版本：
Android 3.0.0.23021501
1、修改初始化方式，取消资源 THEMIS，dat 资源文件，修改：void FXDThemisModule::StartupModule()中“AppID”变量详见接口文档
2、新接口 ReportCustomExceptionEx：上报自定义错误，可上传日志内容，调用时指定
3、新接口 SetNativeCallback：设置回调
4、windows 下 crash 自动上传 dump 以及指定日志内容
5、iOS and Android crash 自动上传指定日志内容
6、AddCustomField：增加关键字“channel”、“version”,“deviceid”

接口详见：https://xindong.atlassian.net/wiki/spaces/GameSecurity/pages/567115797/UE4+C
状态详见：https://xindong.atlassian.net/wiki/spaces/GameSecurity/pages/598035366/Themis


Android 更新 2.9.6
1、修复getOtherJavaThreadsInfo死循环
2、修复泄露问题
3、修复延迟上报crash double-close问题


Android 更新 2.9.3
1.修复themis java混淆冲突

Android 更新 2.9.2
1.ANR 回调 固定信号量=3
2.运行时检查：动态库、已安装app、外设

Android更新 2.9.1
1.unity android 增加启动引擎时检测 openGL、Vulkan 选择,使用方式见:README.MD

Android更新 2.9.0
1.添加 themis 运行时状态，通过回调函数获取
2.增加 ANR 数据上报
3.更精确的 crash 数据监测上报

Android更新 2.8.8
1.客户端限制相同消息发送的频率
2.修复CustomField异常
3.修复部分已知问题

Android更新 2.8.6
1.增加 one id 用于标识唯一设备
2.添加拥有分类集合功能自定义数据上传
3.修复收集崩溃信息会导致自身崩溃问题
4.修复部分已知问题

Android更新 2.8.3
1、兼容xml FindTag之前未处理的格式
2、修复setAppVersion参数为空时，造成的崩溃

Android更新 2.8.2
1、修复deviceinfo加密错误

Android更新 2.8.1
1、deviceinfo增加custom信息
2、签名从java转native获取

Android更新 2.8.0
1、检测红手指云主机
2、修复轨迹报上受模拟器开关闪退

Android更新 2.7.7
1、修复轨迹获取错误的问题
2、判断port合理范围
3、修复dlclose造成雷电3崩溃的问题

Android更新 2.7.3
1、优化EMFILE时收集crash的方案

Android更新 2.7.2
1、模拟鼠标检测数据修改为实时发送

Android更新 2.7.1
1、修复mumu模拟器下dlopen会造成fd泄露的问题

Android更新 2.7.0
1、APP_PLATFORM降为21

Android更新 2.6.9
1、TMCR Boolean=>boolean
2、修复Crash后台上传进程句柄泄露

Android更新 2.6.8
1、轨迹上报堆栈优化

Android更新 2.6.7
1、kill替换exit，避免退出时出现不必要的crash
2、优化crash上报的过滤重复逻辑
3、黎明前20分钟加入 Tap沙盒only

Android更新 2.6.6
1、优化crash信息填充顺序
2、上传不完整的crash信息
3、修复同步发送超时问题
4、优化编译中的warning

Android更新 2.6.5
1、优化网络库若干项目
2、优化crash捕获若干项目
3、添加轨迹抓取

Android更新 2.6.3
1、修复沙盒环境下创建app_THEMIS目录失败
2、修复xd_dlsym_elf参数filepath为空时，造成的mumu崩溃问题
3、修复xd_dlsym_elf文件句柄泄露

Android更新 2.6.2
1、本进程收集crash添加abort message
2、修复extractNativeLibs: false模式下，加固错误 

Android更新 2.5.9
1、适配android:extractNativeLibs=false模式

Android更新 2.5.8
1、修复ReportExceptionhread中，释放地址被+1的崩溃 
2、修复MemTrap未初始化，导致在oppo手机 free了系统内存并造成崩溃

Android更新 2.5.6
1、修复获取前后端状态时的jni句柄泄露 
2、优化小镇引擎mono里的nullreference exception判断方式
3、crash简报、内存修改上报改为异步发送，减少网络connect次数
4、去除部分不合适的logcat输出
5、优化RegisterNatives注册流程

Android更新 2.5.3
1、包名修改为com.tds.themis
2、为tds添加initThemis接口
3、允许dkplugin运行

Android更新 2.5.0
1、去除va环境下的3个退出hook
2、ReportExceptionhread使用线程发送
3、过滤ACE“异常”代替kill造成的_Unwind_Backtrace崩溃

Android更新 2.4.8
1、修复沙盒中kill处理异常
2、支持小镇获取mono堆栈信息
3、soshell加载so优化
4、CSharpReportException添加logcat信息
5、修改崩溃时的锁为pthread_mutex_trylock

Android更新 2.4.6
1、exit系列hook不再调回old_handle，防止调用到释放后的内存
2、getLibInfo空指针修复
3、getOtherThreadsInfo localref泄露修复
4、修复模拟器内运行arm时rtld_db_dlactivity判断错误
5、SendCrashLogData strlen遇到内存边界，崩溃修复
6、同步协议在初始化时断网，无法重新登录问题修复
7、crash_callback_thread退出上报条件优化
8、io_service超时处理优化
9、crash上传日志优化，并每15分钟，对历史crash进行一次清理
10、添加对va类软件的检测及上报

Android更新 2.4.3
1、修复sandbox环境下，sandbox调用themis时，在线程中无法获取自身路径的问题

Android更新 2.4.2
1、THEMIS版本信息改为只从APK内获取
2、优化上传日志的同步\异步方式

Android更新 2.4.1
1、网络初始化从init调整到线程，防止出现加载卡顿
2、devicesinfo添加插件包信息
3、不上报同uid的trace行为
4、_rtld_db_dlactivity 误报修正
5、__system_property_read_callback过滤
6、心跳时间调整为10分钟一次，并异步发送
7、runtime上报信息量优化
8、AppPath获取方式优化，防止va下出错

Android更新 2.4.0
1、修复connect连接等待超时，造成的启动黑屏时间超过10秒问题
2、logcat main日志条目增加为500条

Android更新 2.3.9
1、支持global-metadata.dat加密
2、修复获取va环境错误的问题
3、Error信息上报添加渠道、va标记、前后台标记
4、修复identityPostTime使用早于初始化造成的崩溃
5、修复substrate\And64InlineHook重复hook时，修复绝对地址不当造成的崩溃
6、修复模拟器上check_hookframe和memtrap冲突造成的hook框架误报

Android更新 2.3.5
1、修复第一次外挂上报可能出现延迟的问题
2、修复小米、红米系列手机取机型错误的问题
3、修复crash_handle重入的问题
4、支持加固模式下防止2次打包功能
5、其他若干优化

Android更新 2.3.3
1、修复com.taptap.sandbox.addon进程遗漏标记，导致插件包名无法获取的问题

Android更新 2.3.2
1、修复JNI ERROR: local reference table overflow崩溃

Android更新 2.3.1
1、修复模拟器上ashmem_create_region执行崩溃问题
2、修复check_java_debug可能存在的崩溃问题

Android更新 2.3.0
1、优化SandboxRuntimeInfo交互信息、加载时机
2、修复GetStaticObjectField失败引起的崩溃
3、修复unity3d Development build模式下，进程发生crash时无法正常退出

Android更新 2.2.6
1、限制相同作弊信息发送间隔为10分钟

Android更新 2.2.5
1、修正SandboxRuntimeInfo被编译优化
2、修正sdkVersion错误的被加密的问题

Android更新 2.2.3 
1、添加外挂上传数据
2、适配TapSandbox，提供回调接口
3、修复内存百分比计算错误
4、修复网络库在进程退出时，低概率发生崩溃重入的问题
5、修复功能开关第二次配置时死锁的问题
6、优化Unity CS接口
