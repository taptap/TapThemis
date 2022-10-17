## [TapTap.TapDB](./Documentation/README.md)

## 使用前提

使用 TapTap.Themis 前提是必须依赖以下库:
* [TapTap.Common](https://github.com/TapTap/TapCommon-Unity.git)
* [TapTap.TapDB](https://github.com/TapTap/TapDB-Unity.git)

## 命名空间

```c#
using TapTap.TapDB;
```

## 接口描述

### 设置日志上报等级
```c#
TapDB.ConfigAutoReportLogLevel(LogSeverity.LogError);
```
默认等级为 `LogError`，当应用日志等级高于设置的等级时会自动上报。

### 设置异常时是否退出

```c#
TapDB.ConfigAutoQuitApplication(true);
```
设置当发生未捕获的异常时是否自动退出。

### 注册日志监听

```c#
TapDB.RegisterLogCallback(logcallback);
public void logcallback(string condition, string statckTrace, LogType type ){
        
    }
```
注册应用日志监听，当应用输出日志时，调用对应回调处理。

### 移除日志监听

```c#
TapDB.UnRegisterLogCallback(logcallback);
```

### 上报异常

```c#
TapDB.ReportException(new Exception("crash test from unity"),"crashMessage desc");

```
主动上报异常信息。
