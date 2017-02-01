namespace Reservation_System
{
    partial class EmployeeSellTickets
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
            this.TicketsTab = new System.Windows.Forms.TabControl();
            this.Tab1 = new System.Windows.Forms.TabPage();
            this.removeBN = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.timeDisplayLBL = new System.Windows.Forms.Label();
            this.editBN = new System.Windows.Forms.Button();
            this.addBN = new System.Windows.Forms.Button();
            this.timeLBL = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.schedLB = new System.Windows.Forms.ListBox();
            this.schedMC = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.Tab2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.remove2BN = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.edit2BN = new System.Windows.Forms.Button();
            this.add2BN = new System.Windows.Forms.Button();
            this.timeLBL2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.schedLB2 = new System.Windows.Forms.ListBox();
            this.schedMC2 = new System.Windows.Forms.MonthCalendar();
            this.label6 = new System.Windows.Forms.Label();
            this.Tab3 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.remove3BN = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.edit3BN = new System.Windows.Forms.Button();
            this.add3BN = new System.Windows.Forms.Button();
            this.timeLBL3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.schedLB3 = new System.Windows.Forms.ListBox();
            this.schedMC3 = new System.Windows.Forms.MonthCalendar();
            this.label10 = new System.Windows.Forms.Label();
            this.TicketsTab.SuspendLayout();
            this.Tab1.SuspendLayout();
            this.Tab2.SuspendLayout();
            this.Tab3.SuspendLayout();
            this.SuspendLayout();
            // 
            // TicketsTab
            // 
            this.TicketsTab.Controls.Add(this.Tab1);
            this.TicketsTab.Controls.Add(this.Tab2);
            this.TicketsTab.Controls.Add(this.Tab3);
            this.TicketsTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TicketsTab.Location = new System.Drawing.Point(0, 0);
            this.TicketsTab.Name = "TicketsTab";
            this.TicketsTab.SelectedIndex = 0;
            this.TicketsTab.Size = new System.Drawing.Size(736, 357);
            this.TicketsTab.TabIndex = 0;
            this.TicketsTab.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Tab3_Click);
            // 
            // Tab1
            // 
            this.Tab1.BackColor = System.Drawing.Color.Gray;
            this.Tab1.Controls.Add(this.removeBN);
            this.Tab1.Controls.Add(this.button5);
            this.Tab1.Controls.Add(this.timeDisplayLBL);
            this.Tab1.Controls.Add(this.editBN);
            this.Tab1.Controls.Add(this.addBN);
            this.Tab1.Controls.Add(this.timeLBL);
            this.Tab1.Controls.Add(this.label5);
            this.Tab1.Controls.Add(this.schedLB);
            this.Tab1.Controls.Add(this.schedMC);
            this.Tab1.Controls.Add(this.label1);
            this.Tab1.Location = new System.Drawing.Point(4, 22);
            this.Tab1.Name = "Tab1";
            this.Tab1.Padding = new System.Windows.Forms.Padding(3);
            this.Tab1.Size = new System.Drawing.Size(728, 331);
            this.Tab1.TabIndex = 0;
            this.Tab1.Text = "GbadeTheatre";
            // 
            // removeBN
            // 
            this.removeBN.Location = new System.Drawing.Point(319, 263);
            this.removeBN.Name = "removeBN";
            this.removeBN.Size = new System.Drawing.Size(75, 23);
            this.removeBN.TabIndex = 9;
            this.removeBN.Text = "Remove";
            this.removeBN.UseVisualStyleBackColor = true;
            this.removeBN.Click += new System.EventHandler(this.Remove_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(307, 134);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(99, 39);
            this.button5.TabIndex = 8;
            this.button5.Text = "Select A Seat";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // timeDisplayLBL
            // 
            this.timeDisplayLBL.AutoSize = true;
            this.timeDisplayLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeDisplayLBL.ForeColor = System.Drawing.SystemColors.InfoText;
            this.timeDisplayLBL.Location = new System.Drawing.Point(41, 256);
            this.timeDisplayLBL.Name = "timeDisplayLBL";
            this.timeDisplayLBL.Size = new System.Drawing.Size(49, 18);
            this.timeDisplayLBL.TabIndex = 7;
            this.timeDisplayLBL.Text = "Times";
            // 
            // editBN
            // 
            this.editBN.Location = new System.Drawing.Point(604, 263);
            this.editBN.Name = "editBN";
            this.editBN.Size = new System.Drawing.Size(75, 23);
            this.editBN.TabIndex = 6;
            this.editBN.Text = "Edit";
            this.editBN.UseVisualStyleBackColor = true;
            this.editBN.Click += new System.EventHandler(this.editBN_click);
            // 
            // addBN
            // 
            this.addBN.Location = new System.Drawing.Point(477, 263);
            this.addBN.Name = "addBN";
            this.addBN.Size = new System.Drawing.Size(75, 23);
            this.addBN.TabIndex = 5;
            this.addBN.Text = "Add";
            this.addBN.UseVisualStyleBackColor = true;
            this.addBN.Click += new System.EventHandler(this.addBN_Click);
            // 
            // timeLBL
            // 
            this.timeLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLBL.ForeColor = System.Drawing.Color.Coral;
            this.timeLBL.Location = new System.Drawing.Point(38, 279);
            this.timeLBL.Name = "timeLBL";
            this.timeLBL.Size = new System.Drawing.Size(208, 23);
            this.timeLBL.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Coral;
            this.label5.Location = new System.Drawing.Point(51, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(245, 23);
            this.label5.TabIndex = 3;
            this.label5.Text = "Available Shows";
            // 
            // schedLB
            // 
            this.schedLB.FormattingEnabled = true;
            this.schedLB.Location = new System.Drawing.Point(41, 76);
            this.schedLB.Name = "schedLB";
            this.schedLB.Size = new System.Drawing.Size(255, 173);
            this.schedLB.TabIndex = 2;
            this.schedLB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ShowTime);
            // 
            // schedMC
            // 
            this.schedMC.Location = new System.Drawing.Point(418, 76);
            this.schedMC.Name = "schedMC";
            this.schedMC.TabIndex = 1;
            this.schedMC.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.schedMC_selected);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(722, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to Gbade Theatre ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Tab2
            // 
            this.Tab2.BackColor = System.Drawing.Color.Aqua;
            this.Tab2.Controls.Add(this.button1);
            this.Tab2.Controls.Add(this.remove2BN);
            this.Tab2.Controls.Add(this.label2);
            this.Tab2.Controls.Add(this.edit2BN);
            this.Tab2.Controls.Add(this.add2BN);
            this.Tab2.Controls.Add(this.timeLBL2);
            this.Tab2.Controls.Add(this.label4);
            this.Tab2.Controls.Add(this.schedLB2);
            this.Tab2.Controls.Add(this.schedMC2);
            this.Tab2.Controls.Add(this.label6);
            this.Tab2.Location = new System.Drawing.Point(4, 22);
            this.Tab2.Name = "Tab2";
            this.Tab2.Padding = new System.Windows.Forms.Padding(3);
            this.Tab2.Size = new System.Drawing.Size(728, 331);
            this.Tab2.TabIndex = 1;
            this.Tab2.Text = "Segun Theatre";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(307, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 39);
            this.button1.TabIndex = 17;
            this.button1.Text = "Select A Seat";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button5_Click);
            // 
            // remove2BN
            // 
            this.remove2BN.Location = new System.Drawing.Point(306, 276);
            this.remove2BN.Name = "remove2BN";
            this.remove2BN.Size = new System.Drawing.Size(75, 23);
            this.remove2BN.TabIndex = 16;
            this.remove2BN.Text = "Remove";
            this.remove2BN.UseVisualStyleBackColor = true;
            this.remove2BN.Click += new System.EventHandler(this.Remove_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 18);
            this.label2.TabIndex = 15;
            this.label2.Text = "Times";
            // 
            // edit2BN
            // 
            this.edit2BN.Location = new System.Drawing.Point(548, 276);
            this.edit2BN.Name = "edit2BN";
            this.edit2BN.Size = new System.Drawing.Size(75, 23);
            this.edit2BN.TabIndex = 14;
            this.edit2BN.Text = "Edit";
            this.edit2BN.UseVisualStyleBackColor = true;
            this.edit2BN.Click += new System.EventHandler(this.editBN_click);
            // 
            // add2BN
            // 
            this.add2BN.Location = new System.Drawing.Point(418, 276);
            this.add2BN.Name = "add2BN";
            this.add2BN.Size = new System.Drawing.Size(75, 23);
            this.add2BN.TabIndex = 13;
            this.add2BN.Text = "Add";
            this.add2BN.UseVisualStyleBackColor = true;
            this.add2BN.Click += new System.EventHandler(this.addBN_Click);
            // 
            // timeLBL2
            // 
            this.timeLBL2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLBL2.Location = new System.Drawing.Point(38, 292);
            this.timeLBL2.Name = "timeLBL2";
            this.timeLBL2.Size = new System.Drawing.Size(208, 23);
            this.timeLBL2.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(51, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(245, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "Available Shows";
            // 
            // schedLB2
            // 
            this.schedLB2.FormattingEnabled = true;
            this.schedLB2.Location = new System.Drawing.Point(41, 89);
            this.schedLB2.Name = "schedLB2";
            this.schedLB2.Size = new System.Drawing.Size(255, 173);
            this.schedLB2.TabIndex = 10;
            this.schedLB2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ShowTime);
            // 
            // schedMC2
            // 
            this.schedMC2.Location = new System.Drawing.Point(418, 89);
            this.schedMC2.Name = "schedMC2";
            this.schedMC2.TabIndex = 9;
            this.schedMC2.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.schedMC_selected);
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(722, 43);
            this.label6.TabIndex = 8;
            this.label6.Text = "Welcome to Segun Theatre";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Tab3
            // 
            this.Tab3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Tab3.Controls.Add(this.button2);
            this.Tab3.Controls.Add(this.remove3BN);
            this.Tab3.Controls.Add(this.label7);
            this.Tab3.Controls.Add(this.edit3BN);
            this.Tab3.Controls.Add(this.add3BN);
            this.Tab3.Controls.Add(this.timeLBL3);
            this.Tab3.Controls.Add(this.label9);
            this.Tab3.Controls.Add(this.schedLB3);
            this.Tab3.Controls.Add(this.schedMC3);
            this.Tab3.Controls.Add(this.label10);
            this.Tab3.Location = new System.Drawing.Point(4, 22);
            this.Tab3.Name = "Tab3";
            this.Tab3.Padding = new System.Windows.Forms.Padding(3);
            this.Tab3.Size = new System.Drawing.Size(728, 331);
            this.Tab3.TabIndex = 2;
            this.Tab3.Text = "Dom Theatre";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(307, 147);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 39);
            this.button2.TabIndex = 25;
            this.button2.Text = "Select A Seat";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button5_Click);
            // 
            // remove3BN
            // 
            this.remove3BN.Location = new System.Drawing.Point(306, 282);
            this.remove3BN.Name = "remove3BN";
            this.remove3BN.Size = new System.Drawing.Size(75, 23);
            this.remove3BN.TabIndex = 24;
            this.remove3BN.Text = "Remove";
            this.remove3BN.UseVisualStyleBackColor = true;
            this.remove3BN.Click += new System.EventHandler(this.Remove_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(41, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 18);
            this.label7.TabIndex = 23;
            this.label7.Text = "Times";
            // 
            // edit3BN
            // 
            this.edit3BN.Location = new System.Drawing.Point(548, 282);
            this.edit3BN.Name = "edit3BN";
            this.edit3BN.Size = new System.Drawing.Size(75, 23);
            this.edit3BN.TabIndex = 22;
            this.edit3BN.Text = "Edit";
            this.edit3BN.UseVisualStyleBackColor = true;
            this.edit3BN.Click += new System.EventHandler(this.editBN_click);
            // 
            // add3BN
            // 
            this.add3BN.Location = new System.Drawing.Point(418, 282);
            this.add3BN.Name = "add3BN";
            this.add3BN.Size = new System.Drawing.Size(75, 23);
            this.add3BN.TabIndex = 21;
            this.add3BN.Text = "Add";
            this.add3BN.UseVisualStyleBackColor = true;
            this.add3BN.Click += new System.EventHandler(this.addBN_Click);
            // 
            // timeLBL3
            // 
            this.timeLBL3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLBL3.Location = new System.Drawing.Point(38, 298);
            this.timeLBL3.Name = "timeLBL3";
            this.timeLBL3.Size = new System.Drawing.Size(208, 23);
            this.timeLBL3.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(51, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(245, 23);
            this.label9.TabIndex = 19;
            this.label9.Text = "Available Shows";
            // 
            // schedLB3
            // 
            this.schedLB3.FormattingEnabled = true;
            this.schedLB3.Location = new System.Drawing.Point(41, 95);
            this.schedLB3.Name = "schedLB3";
            this.schedLB3.Size = new System.Drawing.Size(255, 173);
            this.schedLB3.TabIndex = 18;
            this.schedLB3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ShowTime);
            // 
            // schedMC3
            // 
            this.schedMC3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.schedMC3.Location = new System.Drawing.Point(418, 95);
            this.schedMC3.Name = "schedMC3";
            this.schedMC3.TabIndex = 17;
            this.schedMC3.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.schedMC_selected);
            // 
            // label10
            // 
            this.label10.Dock = System.Windows.Forms.DockStyle.Top;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(722, 43);
            this.label10.TabIndex = 16;
            this.label10.Text = "Welcome to Dom theatre";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EmployeeSellTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 357);
            this.Controls.Add(this.TicketsTab);
            this.MaximizeBox = false;
            this.Name = "EmployeeSellTickets";
            this.Text = "EmployeeSellTickets";
            this.Load += new System.EventHandler(this.EmployeeSellTickets_Load);
            this.TicketsTab.ResumeLayout(false);
            this.Tab1.ResumeLayout(false);
            this.Tab1.PerformLayout();
            this.Tab2.ResumeLayout(false);
            this.Tab2.PerformLayout();
            this.Tab3.ResumeLayout(false);
            this.Tab3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TicketsTab;
        private System.Windows.Forms.TabPage Tab1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox schedLB;
        private System.Windows.Forms.MonthCalendar schedMC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label timeLBL;
        private System.Windows.Forms.Button editBN;
        private System.Windows.Forms.Button addBN;
        private System.Windows.Forms.Label timeDisplayLBL;
        private System.Windows.Forms.TabPage Tab2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button edit2BN;
        private System.Windows.Forms.Button add2BN;
        private System.Windows.Forms.Label timeLBL2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox schedLB2;
        private System.Windows.Forms.MonthCalendar schedMC2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage Tab3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button edit3BN;
        private System.Windows.Forms.Button add3BN;
        private System.Windows.Forms.Label timeLBL3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox schedLB3;
        private System.Windows.Forms.MonthCalendar schedMC3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button removeBN;
        private System.Windows.Forms.Button remove2BN;
        private System.Windows.Forms.Button remove3BN;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}