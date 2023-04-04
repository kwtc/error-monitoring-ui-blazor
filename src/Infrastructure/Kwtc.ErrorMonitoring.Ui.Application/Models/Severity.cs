namespace Kwtc.ErrorMonitoring.Ui.Application.Models;

using System.ComponentModel;

public enum Severity
{
    [Description("info")]
    Info = 1,
    
    [Description("warning")]
    Warning = 2,
    
    [Description("error")]
    Error = 3
}
