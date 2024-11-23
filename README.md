关于两个脚本在unity中的运用及要求

环境要求

关于Unity的版本我使用的是2022.3.48f1版本
  在代码测试环节中一些代码无法引用，是由于一些代码随着版本升级进行了更改和废除，低版本的unity可能不能使用
  更多可以在官网中的解释进行参考 https://developer.vuforia.com/library/project-migration/how-migrate-unity-project
关于Vuforia Engine的版本我选的是10.27

  
支持AR测试的设备要求
我在unity的导出中选择的是安卓系统（经测试华为的鸿蒙系统同样适用），iOS系统导出需要苹果开发者账号操作相对会困难很多。




2.PinchZoom的使用说明
在Unity中实现双指缩放功能，适用于需要触屏手势交互的移动端应用或游戏 

使用方法
需要将PinchZoom.cs放入Unity项目中，并将其挂载到需要缩放的GameObject上。

注意事项
脚本中未限制缩放范围，如果需要可以根据项目需求添加最小或最大缩放值的限制  
