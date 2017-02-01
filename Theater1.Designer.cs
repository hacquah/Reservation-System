namespace Reservation_System
{
    partial class Theater1
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
            this.numberofSeatsLBL = new System.Windows.Forms.Label();
            this.totalLBL = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.numSeatsTB = new System.Windows.Forms.TextBox();
            this.totalTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.exitBN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // numberofSeatsLBL
            // 
            this.numberofSeatsLBL.Location = new System.Drawing.Point(3, 107);
            this.numberofSeatsLBL.Name = "numberofSeatsLBL";
            this.numberofSeatsLBL.Size = new System.Drawing.Size(90, 21);
            this.numberofSeatsLBL.TabIndex = 1;
            this.numberofSeatsLBL.Text = "Number of Seats:";
            // 
            // totalLBL
            // 
            this.totalLBL.AutoSize = true;
            this.totalLBL.Location = new System.Drawing.Point(59, 175);
            this.totalLBL.Name = "totalLBL";
            this.totalLBL.Size = new System.Drawing.Size(34, 13);
            this.totalLBL.TabIndex = 2;
            this.totalLBL.Text = "Total:";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(99, 224);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 31);
            this.button2.TabIndex = 4;
            this.button2.Text = "Buy Ticket";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // numSeatsTB
            // 
            this.numSeatsTB.Location = new System.Drawing.Point(99, 107);
            this.numSeatsTB.Name = "numSeatsTB";
            this.numSeatsTB.Size = new System.Drawing.Size(100, 20);
            this.numSeatsTB.TabIndex = 5;
            // 
            // totalTB
            // 
            this.totalTB.Location = new System.Drawing.Point(99, 175);
            this.totalTB.Name = "totalTB";
            this.totalTB.Size = new System.Drawing.Size(100, 20);
            this.totalTB.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(256, 383);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(526, 383);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 8;
            // 
            // exitBN
            // 
            this.exitBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBN.Location = new System.Drawing.Point(99, 278);
            this.exitBN.Name = "exitBN";
            this.exitBN.Size = new System.Drawing.Size(87, 31);
            this.exitBN.TabIndex = 9;
            this.exitBN.Text = "Exit";
            this.exitBN.UseVisualStyleBackColor = true;
            this.exitBN.Click += new System.EventHandler(this.exitBN_Click);
            // 
            // Theater1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 442);
            this.Controls.Add(this.exitBN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.totalTB);
            this.Controls.Add(this.numSeatsTB);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.totalLBL);
            this.Controls.Add(this.numberofSeatsLBL);
            this.MaximizeBox = false;
            this.Name = "Theater1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Theater1";
            this.Load += new System.EventHandler(this.Theater1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label numberofSeatsLBL;
        private System.Windows.Forms.Label totalLBL;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox numSeatsTB;
        private System.Windows.Forms.TextBox totalTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button exitBN;
    }
}