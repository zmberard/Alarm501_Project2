
namespace Alarm501
{
    partial class AlarmEditor
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
            this.uxSet = new System.Windows.Forms.Button();
            this.uxCancel = new System.Windows.Forms.Button();
            this.uxToggle = new System.Windows.Forms.CheckBox();
            this.uxComboBox = new System.Windows.Forms.ComboBox();
            this.uxSnoozeTime = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uxSnoozeTime)).BeginInit();
            this.SuspendLayout();
            // 
            // uxSet
            // 
            this.uxSet.Location = new System.Drawing.Point(146, 123);
            this.uxSet.Name = "uxSet";
            this.uxSet.Size = new System.Drawing.Size(75, 23);
            this.uxSet.TabIndex = 1;
            this.uxSet.Text = "Set";
            this.uxSet.UseVisualStyleBackColor = true;
            this.uxSet.Click += new System.EventHandler(this.uxSet_Click);
            // 
            // uxCancel
            // 
            this.uxCancel.Location = new System.Drawing.Point(26, 123);
            this.uxCancel.Name = "uxCancel";
            this.uxCancel.Size = new System.Drawing.Size(75, 23);
            this.uxCancel.TabIndex = 2;
            this.uxCancel.Text = "Cancel";
            this.uxCancel.UseVisualStyleBackColor = true;
            this.uxCancel.Click += new System.EventHandler(this.uxCancel_Click);
            // 
            // uxToggle
            // 
            this.uxToggle.AutoSize = true;
            this.uxToggle.Location = new System.Drawing.Point(181, 32);
            this.uxToggle.Name = "uxToggle";
            this.uxToggle.Size = new System.Drawing.Size(40, 17);
            this.uxToggle.TabIndex = 3;
            this.uxToggle.Text = "On";
            this.uxToggle.UseVisualStyleBackColor = true;
            this.uxToggle.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // uxComboBox
            // 
            this.uxComboBox.FormattingEnabled = true;
            this.uxComboBox.Location = new System.Drawing.Point(26, 59);
            this.uxComboBox.Name = "uxComboBox";
            this.uxComboBox.Size = new System.Drawing.Size(195, 21);
            this.uxComboBox.TabIndex = 4;
            // 
            // uxSnoozeTime
            // 
            this.uxSnoozeTime.Location = new System.Drawing.Point(26, 97);
            this.uxSnoozeTime.Name = "uxSnoozeTime";
            this.uxSnoozeTime.Size = new System.Drawing.Size(120, 20);
            this.uxSnoozeTime.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Snooze Time(0-30)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // AlarmEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 158);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uxSnoozeTime);
            this.Controls.Add(this.uxComboBox);
            this.Controls.Add(this.uxToggle);
            this.Controls.Add(this.uxCancel);
            this.Controls.Add(this.uxSet);
            this.Name = "AlarmEditor";
            this.Text = "AlarmEditor";
            this.Load += new System.EventHandler(this.AlarmEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uxSnoozeTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uxSet;
        private System.Windows.Forms.Button uxCancel;
        private System.Windows.Forms.CheckBox uxToggle;
        private System.Windows.Forms.ComboBox uxComboBox;
        private System.Windows.Forms.NumericUpDown uxSnoozeTime;
        private System.Windows.Forms.Label label1;
    }
}