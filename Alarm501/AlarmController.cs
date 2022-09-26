
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Alarm501
{
    
    //public enum State
    //{
    //    AddAlarm = 0,
    //    SetAlarm,
    //    EditAlarm,
    //    Snooze,
    //}


    public class AlarmController
    {

        public uxMainWindow mw;
        public State state;
        DisplayState display;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="m"></param>
        /// <param name="v"></param>
        public AlarmController(uxMainWindow m, DisplayState d)
        {
            mw = m;
            display = d;
        }

        /// <summary>
        /// Links the View to the controller.
        /// </summary>
        /// <param name="c">The App's main controller object. Later
        /// this shold be a delegate.</param>
        public void SetDisplayDelegate(DisplayState d)
        {
            display = d;
        }

        public void handleEventsDel(State s, Alarm alarm)
        {
            state = s;
            switch (state)
            {
                case State.AddAlarm:
                    //Adds an alarm
                    if (mw.MyAlarms.Count < 5)
                    {
                        DateTime dt = new DateTime();
                        Alarm a = new Alarm(dt);
                        AlarmEditor alarmPicker = new AlarmEditor(false, a);
                        DialogResult TimePickDialog = alarmPicker.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Unable to add more alarms");

                    }

                    display(State.AddAlarm, alarm);
                    break;

                case State.EditAlarm:
                    //Edits the Alarm
                    mw.edit = true;
                    if (mw.MyAlarms.Count < 5)
                    {
                        AlarmEditor alarmEditor = new AlarmEditor(mw.edit, (alarm));
                        alarmEditor.Show();
                    }
                    break;

                case State.Snooze:
                    alarm.IsSnoozed = true;
                    alarm.SetTime = alarm.SetTime.AddSeconds(alarm.SnoozeTime);
                    display(State.Snooze, alarm);
                    break;

                case State.StopAlarm:
                    alarm.Toggle = false;
                    display(State.StopAlarm, alarm);
                    break;

                default:

                    break;
            }
        }
        /// <summary>
        /// Adds the alarm to binding list
        /// </summary>
        /// <param name="a"></param>
        public void addToList(Alarm a)
        {
            mw.MyAlarms.Add(a);
            mw.uxAlarmList.Refresh();
        }
    }
}
