namespace Reservation_System
{
    partial class EmployeePortal
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
            this.LastnameTB = new System.Windows.Forms.TextBox();
            this.FirstnameTBE = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.adminBN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LastnameTB
            // 
            this.LastnameTB.Location = new System.Drawing.Point(318, 160);
            this.LastnameTB.Name = "LastnameTB";
            this.LastnameTB.Size = new System.Drawing.Size(100, 20);
            this.LastnameTB.TabIndex = 1;
            // 
            // FirstnameTBE
            // 
            this.FirstnameTBE.Location = new System.Drawing.Point(318, 85);
            this.FirstnameTBE.Name = "FirstnameTBE";
            this.FirstnameTBE.Size = new System.Drawing.Size(100, 20);
            this.FirstnameTBE.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(287, 288);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 25);
            this.button1.TabIndex = 3;
            this.button1.Text = "Update Customer Information";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.UpdateCinfo);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Location = new System.Drawing.Point(287, 385);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 25);
            this.button2.TabIndex = 5;
            this.button2.Text = "Sell Tickets ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.SellTickets_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(257, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Firstname:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(256, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Lastname:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.Location = new System.Drawing.Point(287, 225);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(156, 25);
            this.button3.TabIndex = 2;
            this.button3.Text = "Create";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.createCustomer_Click);
            // 
            // adminBN
            // 
            this.adminBN.Location = new System.Drawing.Point(287, 340);
            this.adminBN.Name = "adminBN";
            this.adminBN.Size = new System.Drawing.Size(156, 25);
            this.adminBN.TabIndex = 4;
            this.adminBN.Text = "Administrator";
            this.adminBN.UseVisualStyleBackColor = true;
            this.adminBN.Click += new System.EventHandler(this.AddEdit_click);
            // 
            // EmployeePortal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(694, 446);
            this.Controls.Add(this.adminBN);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.FirstnameTBE);
            this.Controls.Add(this.LastnameTB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "EmployeePortal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeePortal";
            this.Load += new System.EventHandler(this.EmployeePortal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LastnameTB;
        private System.Windows.Forms.TextBox FirstnameTBE;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button adminBN;
    }
}