using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Alarm501
{
    public partial class AlarmEditor : Form
    {
        

        //public static AlarmEditor instance;
        private bool IsEditing;
        private Alarm alarm;

        public AlarmEditor(bool e, Alarm a)
        {
            InitializeComponent();
            InitializeTimePick();
            //instance = this;
            this.IsEditing = e;
            alarm = a;
            if (IsEditing)
            {
                uxToggle.Checked = a.Toggle;
                timePicker.Value = a.SetTime;
                uxSnoozeTime.Value = a.SnoozeTime;
            }
            uxComboBox.DataSource = Enum.GetValues(typeof(Alarm.Sound));
        }

        handleMethodDel handle;
        /// <summary>
        /// Links the View to the controller.
        /// </summary>
        /// <param name="c">The App's main controller object. Later
        /// this shold be a delegate.</param>
        public void SetControllerDelegate(handleMethodDel h)
        {
            handle = h;
        }

        private DateTimePicker _timePicker;

        public DateTimePicker timePicker
        {
            get { return _timePicker; }
            set {_timePicker = value;}
        }


        private void InitializeTimePick()
        {
            timePicker = new DateTimePicker();
            timePicker.Format = DateTimePickerFormat.Time;
            timePicker.ShowUpDown = true;
            timePicker.Location = new Point(20, 30);
            timePicker.Width = 150;
            timePicker.Height = 20;
            Controls.Add(timePicker);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //if (uxToggle.Checked) 
            //{
            //    isChecked = true;
            //}
            //else
            //{
            //    isChecked = false;
            //}
        }


        /// Sets alarm and adds it to the list
        private void uxSet_Click(object sender, EventArgs e)
        {
            if (IsEditing)
            {
                alarm.Toggle = uxToggle.Checked;
                alarm.SetTime = timePicker.Value;
                uxSnoozeTime.Value = alarm.SnoozeTime;
                uxComboBox.Text = alarm.AlarmSound.ToString();
            }
            if (IsEditing == false)
            {
                Alarm alarmToAdd = createAlarm();
                uxMainWindow.instance.addToList(alarmToAdd);
                Close();
            }
            Close();
        }

        private Alarm createAlarm()
        {
            DateTime currAlarmTime = timePicker.Value;
            Alarm a = new Alarm(timePicker.Value);
            a.SetTime = currAlarmTime;
            a.AlarmSound = uxComboBox.SelectedItem.ToString();

            if (uxToggle.Checked)
            {
                a.Toggle = true;
                uxSnoozeTime.Value = a.SnoozeTime;
                uxComboBox.SelectedItem = a.AlarmSound.ToString();


            }
            else
            {
                a.Toggle = false;
                uxSnoozeTime.Value = a.SnoozeTime;
                uxComboBox.Text = a.AlarmSound.ToString();
            }
            return a;
        }

        /// <summary>
        /// Click event that causes form to close
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AlarmEditor_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
