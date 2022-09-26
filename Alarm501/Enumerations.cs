using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alarm501
{
    /// <summary>
    /// The valid App states.
    /// </summary>
    public enum State
    {
        Start = 0,
        AddAlarm,
        SetAlarm,
        EditAlarm,
        Snooze,
        AlarmGoingOff,
        StopAlarm
    }

    public enum Sound
    {
        Radar,
        Beacon,
        Chimes,
        Circuit,
        Reflection
    }

}
