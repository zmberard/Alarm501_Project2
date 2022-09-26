using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Alarm501
{
    public partial class uxMainWindow : Form, INotifyPropertyChanged
    {
        public static uxMainWindow instance;
        public bool edit = false;
        public State s;

        static handleMethodDel handle;

        public uxMainWindow()
        {
            InitializeComponent();
            instance = this;
            uxAlarmList.FormattingEnabled = false;
            uxAlarmList.DataSource = MyAlarms;

            var myTimer = new System.Timers.Timer(1000);
            // Define the event handler
            myTimer.Elapsed += CheckAlarms;
            // Synchronize the timer with the text box
            myTimer.SynchronizingObject = this;
            // Start the timer
            myTimer.AutoReset = true;
            myTimer.Start();
        }


        /// <summary>
        /// Links the View to the controller.
        /// </summary>
        /// <param name="c">The App's main controller object. Later
        /// this shold be a delegate.</param>
        public void SetControllerDelegate(handleMethodDel h)
        {
            handle = h;
        }

        /// <summary>
        /// THis method keepts the GUI controlls enabled/disabled, displaying the
        /// right information based on the App's satate.
        /// </summary>
        /// <param name="state"></param>
        public void DisplayStateDel(State state, Alarm a)
        {
            s = state;
            switch (s)
            {
                case State.Start:
                    uxLabel.Text = "";

                    break;
                case State.SetAlarm:

                    break;
                case State.AddAlarm:
                    uxEdit.Refresh();

                    break;
                case State.EditAlarm:
                    uxEdit.Enabled = true;
                    uxEdit.Refresh();

                    break;
                case State.Snooze:
                    uxLabel.Text = "Snoozed";
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("IsSnoozed"));
                    uxLabel.Refresh();

                    break;
                case State.AlarmGoingOff:
                    uxLabel.Text = a.AlarmSound + " Alarm went OFF";
                    uxStop.Enabled = true;
                    uxSnooze.Enabled = true;
                    uxLabel.Refresh();

                    break;
                case State.StopAlarm:
                    
                    this.uxLabel.Text = "Stopped";
                    a.Toggle = false;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Toggle"));
                    Application.DoEvents();
                    Refresh();

                    break;

                default:

                    break;

            }
        }
      
        //Need to create a del method to allow the Label to be changed
        //public void SignalAlarm(int i, Alarm a)
        //{
        //    uxLabel.Text = a.AlarmSound + " Alarm went OFF";
        //    uxStop.Enabled = true;
        //    uxSnooze.Enabled = true;
        //}

        //////////////////////////////////////////////////////////////////////////
        public BindingList<Alarm> MyAlarms = new BindingList<Alarm>();
        public event PropertyChangedEventHandler PropertyChanged;

        private void uxMainWindow_Load(object sender, EventArgs e)
        {

        }

        //Controller
        private void uxAdd_Click(object sender, EventArgs e)
        {
            Alarm a = new Alarm(DateTime.Now);
            handle(State.AddAlarm, a);
        }

        //public void addToList(Alarm a)
        //{
        //    MyAlarms.Add(a);
        //    uxAlarmList.Refresh();

        //    uxEdit.Enabled = true;
        //}

        private void uxAlarmList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //(uxAlarmList.SelectedItem as Alarm)
        }

        private void uxEdit_Click(object sender, EventArgs e)
        {
            //edit = true;
            //if(MyAlarms.Count < 5)
            //{
            //    AlarmEditor alarmEditor = new AlarmEditor(edit, (uxAlarmList.SelectedItem as Alarm));
            //    alarmEditor.Show();
            //}
            handle(State.EditAlarm, uxAlarmList.SelectedItem as Alarm);
        }

        private void uxSnooze_Click(object sender, EventArgs e)
        {
            //uxLabel.Text = "";
            //(uxAlarmList.SelectedItem as Alarm).IsSnoozed = true;
            //(uxAlarmList.SelectedItem as Alarm).SetTime = (uxAlarmList.SelectedItem as Alarm).SetTime.AddSeconds((uxAlarmList.SelectedItem as Alarm).SnoozeTime);
            //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("IsSnoozed"));
            Alarm alarm = uxAlarmList.SelectedItem as Alarm;
            uxLabel.Text = "Snoozed";
            alarm.SetTime = alarm.SetTime.AddSeconds(alarm.SnoozeTime);
            handle(State.Snooze, uxAlarmList.SelectedItem as Alarm);

        }

        private void uxStop_Click(object sender, EventArgs e)
        {
            uxLabel.Text = "Stopped";
            (uxAlarmList.SelectedItem as Alarm).Toggle = false;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Toggle"));
            Refresh();
            handle(State.StopAlarm, uxAlarmList.SelectedItem as Alarm);

        }


        /// <summary>
        /// Adds the alarm to binding list
        /// </summary>
        /// <param name="a"></param>
        public void addToList(Alarm a)
        {
            MyAlarms.Add(a);
            uxAlarmList.Refresh();
        }

        private void CheckAlarms(object sender, ElapsedEventArgs e)
        {
            DateTime curr = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
            foreach (Alarm a in MyAlarms)
            {
                if (a.Toggle && TimeSpan.Compare(a.SetTime.TimeOfDay, curr.TimeOfDay) == 0)
                {
                    DisplayStateDel(State.AlarmGoingOff, a);
                }
            }
            while(MyAlarms.Count != 0)
            {
                uxEdit.Enabled = true;
                break;
            }
            
        }
    }
}
