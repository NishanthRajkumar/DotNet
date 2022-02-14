using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLogDemo;


internal class AddNumbers
{
    NLog nLog = new NLog();
    public int Sum(int a, int b)
    {
        if (a == 0 || b == 0)
        {
            nLog.LogDebug("Debug Successfull : Sum()");
            nLog.LogError("Expecting null values");
            nLog.LogWarn("a or b should not equal to 0");
        }
        int c = a + b;
        nLog.LogDebug("Debug Successfull : Sum()");
        nLog.LogInfo("Sum method passed, Result" + c);
        return c;
    }
}