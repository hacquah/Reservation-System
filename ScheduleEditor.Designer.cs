namespace Reservation_System
{
    partial class ScheduleEditor
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
            this.schedDTP = new System.Windows.Forms.DateTimePicker();
            this.descriptionTB = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.codeTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // schedDTP
            // 
            this.schedDTP.CustomFormat = "MM/dd/yyyy     hh:mm:sstt";
            this.schedDTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.schedDTP.Location = new System.Drawing.Point(33, 30);
            this.schedDTP.Name = "schedDTP";
            this.schedDTP.Size = new System.Drawing.Size(200, 20);
            this.schedDTP.TabIndex = 0;
            // 
            // descriptionTB
            // 
            this.descriptionTB.Location = new System.Drawing.Point(67, 68);
            this.descriptionTB.Name = "descriptionTB";
            this.descriptionTB.Size = new System.Drawing.Size(200, 20);
            this.descriptionTB.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(67, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // codeTB
            // 
            this.codeTB.Location = new System.Drawing.Point(67, 101);
            this.codeTB.Name = "codeTB";
            this.codeTB.Size = new System.Drawing.Size(100, 20);
            this.codeTB.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-1, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Show Code";
            // 
            // ScheduleEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 172);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.codeTB);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.descriptionTB);
            this.Controls.Add(this.schedDTP);
            this.Name = "ScheduleEditor";
            this.Text = "ScheduleEditor";
            this.Load += new System.EventHandler(this.ScheduleEditor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker schedDTP;
        private System.Windows.Forms.TextBox descriptionTB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox codeTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}