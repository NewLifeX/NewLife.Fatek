using System.ComponentModel;
using NewLife.IoT.Drivers;

namespace NewLife.Fatek.Drivers;

/// <summary>
/// 永宏PLC协议封装
/// </summary>
[Driver("FatekPLC")]
[DisplayName("永宏PLC")]
public class FatekDriver : DriverBase<FatekNode, FatekParameter>
{
}