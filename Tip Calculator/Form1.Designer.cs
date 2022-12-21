namespace Tip_Calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Bill = new System.Windows.Forms.TextBox();
            this.Tip = new System.Windows.Forms.TextBox();
            this.PeopleCount = new System.Windows.Forms.TextBox();
            this.TipPerson = new System.Windows.Forms.TextBox();
            this.TotalPerson = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Calculate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.IncrementTip = new System.Windows.Forms.Button();
            this.DecrementTip = new System.Windows.Forms.Button();
            this.IncrementPeople = new System.Windows.Forms.Button();
            this.DecrementPeople = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Bill
            // 
            this.Bill.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Bill.Location = new System.Drawing.Point(30, 105);
            this.Bill.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Bill.Multiline = true;
            this.Bill.Name = "Bill";
            this.Bill.Size = new System.Drawing.Size(234, 48);
            this.Bill.TabIndex = 0;
            this.Bill.Text = "0.00";
            this.Bill.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.Bill.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Bill_KeyPress);
            // 
            // Tip
            // 
            this.Tip.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Tip.Location = new System.Drawing.Point(85, 205);
            this.Tip.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Tip.Multiline = true;
            this.Tip.Name = "Tip";
            this.Tip.Size = new System.Drawing.Size(140, 48);
            this.Tip.TabIndex = 1;
            this.Tip.Text = "0";
            this.Tip.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tip_KeyPress);
            // 
            // PeopleCount
            // 
            this.PeopleCount.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PeopleCount.Location = new System.Drawing.Point(85, 323);
            this.PeopleCount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PeopleCount.Multiline = true;
            this.PeopleCount.Name = "PeopleCount";
            this.PeopleCount.Size = new System.Drawing.Size(140, 48);
            this.PeopleCount.TabIndex = 2;
            this.PeopleCount.Text = "0";
            this.PeopleCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PeopleCount_KeyPress);
            // 
            // TipPerson
            // 
            this.TipPerson.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TipPerson.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TipPerson.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TipPerson.Location = new System.Drawing.Point(589, 123);
            this.TipPerson.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TipPerson.Multiline = true;
            this.TipPerson.Name = "TipPerson";
            this.TipPerson.ReadOnly = true;
            this.TipPerson.Size = new System.Drawing.Size(311, 51);
            this.TipPerson.TabIndex = 3;
            this.TipPerson.Text = "₹0.00";
            // 
            // TotalPerson
            // 
            this.TotalPerson.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TotalPerson.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TotalPerson.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TotalPerson.Location = new System.Drawing.Point(589, 303);
            this.TotalPerson.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TotalPerson.Multiline = true;
            this.TotalPerson.Name = "TotalPerson";
            this.TotalPerson.ReadOnly = true;
            this.TotalPerson.Size = new System.Drawing.Size(311, 51);
            this.TotalPerson.TabIndex = 4;
            this.TotalPerson.Text = "₹0.00\r\n\r\n\r\n";
            // 
            // label
            // 
            this.label.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label.Location = new System.Drawing.Point(30, 63);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(66, 39);
            this.label.TabIndex = 5;
            this.label.Text = "Bill";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(30, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tip %";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(30, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 36);
            this.label2.TabIndex = 7;
            this.label2.Text = "Number  of people";
            // 
            // Calculate
            // 
            this.Calculate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Calculate.Location = new System.Drawing.Point(61, 440);
            this.Calculate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(130, 43);
            this.Calculate.TabIndex = 8;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(496, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 31);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tip";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(480, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Per Person";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(496, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 22);
            this.label6.TabIndex = 12;
            this.label6.Text = "Total";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label8.Location = new System.Drawing.Point(491, 327);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Per Person";
            // 
            // IncrementTip
            // 
            this.IncrementTip.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.IncrementTip.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.IncrementTip.Location = new System.Drawing.Point(216, 205);
            this.IncrementTip.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.IncrementTip.Name = "IncrementTip";
            this.IncrementTip.Size = new System.Drawing.Size(48, 49);
            this.IncrementTip.TabIndex = 15;
            this.IncrementTip.Text = "+";
            this.IncrementTip.UseVisualStyleBackColor = false;
            this.IncrementTip.Click += new System.EventHandler(this.IncrementTip_Click);
            // 
            // DecrementTip
            // 
            this.DecrementTip.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DecrementTip.Location = new System.Drawing.Point(30, 204);
            this.DecrementTip.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DecrementTip.Name = "DecrementTip";
            this.DecrementTip.Size = new System.Drawing.Size(56, 51);
            this.DecrementTip.TabIndex = 16;
            this.DecrementTip.Text = "-";
            this.DecrementTip.UseVisualStyleBackColor = true;
            this.DecrementTip.Click += new System.EventHandler(this.DecrementTip_Click);
            // 
            // IncrementPeople
            // 
            this.IncrementPeople.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.IncrementPeople.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.IncrementPeople.Location = new System.Drawing.Point(216, 321);
            this.IncrementPeople.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.IncrementPeople.Name = "IncrementPeople";
            this.IncrementPeople.Size = new System.Drawing.Size(48, 52);
            this.IncrementPeople.TabIndex = 17;
            this.IncrementPeople.Text = "+";
            this.IncrementPeople.UseVisualStyleBackColor = true;
            this.IncrementPeople.Click += new System.EventHandler(this.IncrementPeople_Click);
            // 
            // DecrementPeople
            // 
            this.DecrementPeople.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DecrementPeople.Location = new System.Drawing.Point(30, 321);
            this.DecrementPeople.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DecrementPeople.Name = "DecrementPeople";
            this.DecrementPeople.Size = new System.Drawing.Size(56, 51);
            this.DecrementPeople.TabIndex = 18;
            this.DecrementPeople.Text = "-";
            this.DecrementPeople.UseVisualStyleBackColor = true;
            this.DecrementPeople.Click += new System.EventHandler(this.DecrementPeople_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.DecrementPeople);
            this.Controls.Add(this.IncrementPeople);
            this.Controls.Add(this.DecrementTip);
            this.Controls.Add(this.IncrementTip);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label);
            this.Controls.Add(this.TotalPerson);
            this.Controls.Add(this.TipPerson);
            this.Controls.Add(this.PeopleCount);
            this.Controls.Add(this.Tip);
            this.Controls.Add(this.Bill);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox Bill;
        private TextBox Tip;
        private TextBox PeopleCount;
        private TextBox TipPerson;
        private TextBox TotalPerson;
        private Label label;
        private Label label1;
        private Label label2;
        private Button Calculate;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label label8;
        private Button IncrementTip;
        private Button DecrementTip;
        private Button IncrementPeople;
        private Button DecrementPeople;
        private TextBox BillWarning;
    }
}