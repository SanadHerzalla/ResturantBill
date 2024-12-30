namespace ResturantBill
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            waiterName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            tableNumber = new TextBox();
            groupBox2 = new GroupBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            comboBoxDessert = new ComboBox();
            comboBoxMainCourse = new ComboBox();
            comboBoxAppetizer = new ComboBox();
            comboBoxBeverage = new ComboBox();
            ClearBill = new Button();
            labelSubtotal = new Label();
            labelTax = new Label();
            labelTotal = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(295, -1);
            label1.Name = "label1";
            label1.Size = new Size(158, 38);
            label1.TabIndex = 0;
            label1.Text = "Restaurant";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(waiterName);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(tableNumber);
            groupBox1.Location = new Point(256, 50);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 125);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Waiter Information";
            // 
            // waiterName
            // 
            waiterName.Location = new Point(117, 65);
            waiterName.Name = "waiterName";
            waiterName.Size = new Size(127, 27);
            waiterName.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 68);
            label3.Name = "label3";
            label3.Size = new Size(106, 20);
            label3.TabIndex = 2;
            label3.Text = "Waiter`s name:\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(4, 29);
            label2.Name = "label2";
            label2.Size = new Size(102, 20);
            label2.TabIndex = 1;
            label2.Text = "Table number:\r\n";
            // 
            // tableNumber
            // 
            tableNumber.Location = new Point(117, 26);
            tableNumber.Name = "tableNumber";
            tableNumber.Size = new Size(110, 27);
            tableNumber.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(comboBoxDessert);
            groupBox2.Controls.Add(comboBoxMainCourse);
            groupBox2.Controls.Add(comboBoxAppetizer);
            groupBox2.Controls.Add(comboBoxBeverage);
            groupBox2.Location = new Point(256, 181);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(263, 207);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Menu items";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(18, 174);
            label7.Name = "label7";
            label7.Size = new Size(58, 20);
            label7.TabIndex = 6;
            label7.Text = "Dessert";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 126);
            label6.Name = "label6";
            label6.Size = new Size(89, 20);
            label6.TabIndex = 5;
            label6.Text = "Main course";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 77);
            label5.Name = "label5";
            label5.Size = new Size(74, 20);
            label5.TabIndex = 4;
            label5.Text = "Appetizer";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 29);
            label4.Name = "label4";
            label4.Size = new Size(71, 20);
            label4.TabIndex = 3;
            label4.Text = "Beverage";
            // 
            // comboBoxDessert
            // 
            comboBoxDessert.FormattingEnabled = true;
            comboBoxDessert.Location = new Point(99, 173);
            comboBoxDessert.Name = "comboBoxDessert";
            comboBoxDessert.Size = new Size(151, 28);
            comboBoxDessert.TabIndex = 3;
            // 
            // comboBoxMainCourse
            // 
            comboBoxMainCourse.FormattingEnabled = true;
            comboBoxMainCourse.Location = new Point(99, 123);
            comboBoxMainCourse.Name = "comboBoxMainCourse";
            comboBoxMainCourse.Size = new Size(151, 28);
            comboBoxMainCourse.TabIndex = 2;
            // 
            // comboBoxAppetizer
            // 
            comboBoxAppetizer.FormattingEnabled = true;
            comboBoxAppetizer.Location = new Point(99, 74);
            comboBoxAppetizer.Name = "comboBoxAppetizer";
            comboBoxAppetizer.Size = new Size(151, 28);
            comboBoxAppetizer.TabIndex = 1;
            // 
            // comboBoxBeverage
            // 
            comboBoxBeverage.FormattingEnabled = true;
            comboBoxBeverage.Location = new Point(99, 26);
            comboBoxBeverage.Name = "comboBoxBeverage";
            comboBoxBeverage.Size = new Size(151, 28);
            comboBoxBeverage.TabIndex = 0;
            // 
            // ClearBill
            // 
            ClearBill.Location = new Point(334, 394);
            ClearBill.Name = "ClearBill";
            ClearBill.Size = new Size(94, 29);
            ClearBill.TabIndex = 3;
            ClearBill.Text = "Clear Bill";
            ClearBill.UseVisualStyleBackColor = true;
            ClearBill.Click += ClearBill_Click;
            // 
            // labelSubtotal
            // 
            labelSubtotal.AutoSize = true;
            labelSubtotal.Location = new Point(334, 430);
            labelSubtotal.Name = "labelSubtotal";
            labelSubtotal.Size = new Size(44, 20);
            labelSubtotal.TabIndex = 5;
            labelSubtotal.Text = "$0.00";
            // 
            // labelTax
            // 
            labelTax.AutoSize = true;
            labelTax.Location = new Point(334, 464);
            labelTax.Name = "labelTax";
            labelTax.Size = new Size(44, 20);
            labelTax.TabIndex = 7;
            labelTax.Text = "$0.00";
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.Location = new Point(334, 495);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(44, 20);
            labelTotal.TabIndex = 9;
            labelTotal.Text = "$0.00";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(260, 495);
            label10.Name = "label10";
            label10.Size = new Size(45, 20);
            label10.TabIndex = 8;
            label10.Text = "Total:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(260, 464);
            label9.Name = "label9";
            label9.Size = new Size(33, 20);
            label9.TabIndex = 6;
            label9.Text = "Tax:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(256, 430);
            label8.Name = "label8";
            label8.Size = new Size(72, 20);
            label8.TabIndex = 4;
            label8.Text = "Subtotal :";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 540);
            Controls.Add(labelTotal);
            Controls.Add(label10);
            Controls.Add(labelTax);
            Controls.Add(label9);
            Controls.Add(labelSubtotal);
            Controls.Add(label8);
            Controls.Add(ClearBill);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox waiterName;
        private Label label3;
        private Label label2;
        private TextBox tableNumber;
        private GroupBox groupBox2;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private ComboBox comboBoxDessert;
        private ComboBox comboBoxMainCourse;
        private ComboBox comboBoxAppetizer;
        private ComboBox comboBoxBeverage;
        private Button ClearBill;
        private Label labelSubtotal;
        private Label labelTax;
        private Label labelTotal;
        private Label label10;
        private Label label9;
        private Label label8;
    }
}
