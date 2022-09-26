﻿
namespace Alarm501
{
    partial class uxMainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.uxEdit = new System.Windows.Forms.Button();
            this.uxAdd = new System.Windows.Forms.Button();
            this.uxSnooze = new System.Windows.Forms.Button();
            this.uxStop = new System.Windows.Forms.Button();
            this.uxAlarmList = new System.Windows.Forms.ListBox();
            this.uxLabel = new System.Windows.Forms.Label();
            this.alarmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.alarmBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // uxEdit
            // 
            this.uxEdit.Enabled = false;
            this.uxEdit.Location = new System.Drawing.Point(29, 33);
            this.uxEdit.Name = "uxEdit";
            this.uxEdit.Size = new System.Drawing.Size(104, 48);
            this.uxEdit.TabIndex = 0;
            this.uxEdit.Text = "Edit";
            this.uxEdit.UseVisualStyleBackColor = true;
            this.uxEdit.Click += new System.EventHandler(this.uxEdit_Click);
            // 
            // uxAdd
            // 
            this.uxAdd.Location = new System.Drawing.Point(160, 33);
            this.uxAdd.Name = "uxAdd";
            this.uxAdd.Size = new System.Drawing.Size(104, 48);
            this.uxAdd.TabIndex = 1;
            this.uxAdd.Text = "+";
            this.uxAdd.UseVisualStyleBackColor = true;
            this.uxAdd.Click += new System.EventHandler(this.uxAdd_Click);
            // 
            // uxSnooze
            // 
            this.uxSnooze.Enabled = false;
            this.uxSnooze.Location = new System.Drawing.Point(29, 404);
            this.uxSnooze.Name = "uxSnooze";
            this.uxSnooze.Size = new System.Drawing.Size(104, 48);
            this.uxSnooze.TabIndex = 3;
            this.uxSnooze.Text = "Snooze";
            this.uxSnooze.UseVisualStyleBackColor = true;
            this.uxSnooze.Click += new System.EventHandler(this.uxSnooze_Click);
            // 
            // uxStop
            // 
            this.uxStop.Enabled = false;
            this.uxStop.Location = new System.Drawing.Point(160, 404);
            this.uxStop.Name = "uxStop";
            this.uxStop.Size = new System.Drawing.Size(104, 48);
            this.uxStop.TabIndex = 4;
            this.uxStop.Text = "Stop";
            this.uxStop.UseVisualStyleBackColor = true;
            this.uxStop.Click += new System.EventHandler(this.uxStop_Click);
            // 
            // uxAlarmList
            // 
            this.uxAlarmList.FormattingEnabled = true;
            this.uxAlarmList.Location = new System.Drawing.Point(29, 99);
            this.uxAlarmList.Name = "uxAlarmList";
            this.uxAlarmList.Size = new System.Drawing.Size(235, 264);
            this.uxAlarmList.TabIndex = 5;
            this.uxAlarmList.SelectedIndexChanged += new System.EventHandler(this.uxAlarmList_SelectedIndexChanged);
            // 
            // uxLabel
            // 
            this.uxLabel.AutoSize = true;
            this.uxLabel.Location = new System.Drawing.Point(126, 376);
            this.uxLabel.Name = "uxLabel";
            this.uxLabel.Size = new System.Drawing.Size(0, 13);
            this.uxLabel.TabIndex = 6;
            // 
            // alarmBindingSource
            // 
            this.alarmBindingSource.DataSource = typeof(Alarm501.Alarm);
            // 
            // uxMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 464);
            this.Controls.Add(this.uxLabel);
            this.Controls.Add(this.uxAlarmList);
            this.Controls.Add(this.uxStop);
            this.Controls.Add(this.uxSnooze);
            this.Controls.Add(this.uxAdd);
            this.Controls.Add(this.uxEdit);
            this.Name = "uxMainWindow";
            this.Text = "Alarm501";
            this.Load += new System.EventHandler(this.uxMainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.alarmBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uxEdit;
        private System.Windows.Forms.Button uxAdd;
        private System.Windows.Forms.Button uxSnooze;
        private System.Windows.Forms.Button uxStop;
        public System.Windows.Forms.ListBox uxAlarmList;
        private System.Windows.Forms.BindingSource alarmBindingSource;
        private System.Windows.Forms.Label uxLabel;
    }
}

