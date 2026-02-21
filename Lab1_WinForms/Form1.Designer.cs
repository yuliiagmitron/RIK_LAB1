namespace Lab1_WinForms
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
            MoneyAmountTextBox1 = new TextBox();
            DepositPercentageTextBox = new TextBox();
            Label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            CreditPercentageTextBox = new TextBox();
            MoneyAmountTextBox2 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            Result = new Label();
            DepositMonths = new TextBox();
            label5 = new Label();
            label6 = new Label();
            CreditMonths = new TextBox();
            button2 = new Button();
            ResultBox = new RichTextBox();
            SuspendLayout();
            // 
            // MoneyAmountTextBox1
            // 
            MoneyAmountTextBox1.Location = new Point(71, 65);
            MoneyAmountTextBox1.Name = "MoneyAmountTextBox1";
            MoneyAmountTextBox1.Size = new Size(100, 23);
            MoneyAmountTextBox1.TabIndex = 0;
            // 
            // DepositPercentageTextBox
            // 
            DepositPercentageTextBox.Location = new Point(71, 112);
            DepositPercentageTextBox.Name = "DepositPercentageTextBox";
            DepositPercentageTextBox.Size = new Size(100, 23);
            DepositPercentageTextBox.TabIndex = 1;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new Point(71, 47);
            Label1.Name = "Label1";
            Label1.Size = new Size(128, 15);
            Label1.TabIndex = 2;
            Label1.Text = "Введіть суму депозиту";
            // 
            // button1
            // 
            button1.BackColor = Color.Fuchsia;
            button1.Location = new Point(71, 216);
            button1.Name = "button1";
            button1.Size = new Size(97, 43);
            button1.TabIndex = 3;
            button1.Text = "Розрахувати ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(71, 94);
            label2.Name = "label2";
            label2.Size = new Size(136, 15);
            label2.TabIndex = 6;
            label2.Text = "Введіть річний відсоток";
            // 
            // CreditPercentageTextBox
            // 
            CreditPercentageTextBox.Location = new Point(467, 112);
            CreditPercentageTextBox.Name = "CreditPercentageTextBox";
            CreditPercentageTextBox.Size = new Size(100, 23);
            CreditPercentageTextBox.TabIndex = 5;
            // 
            // MoneyAmountTextBox2
            // 
            MoneyAmountTextBox2.Location = new Point(467, 65);
            MoneyAmountTextBox2.Name = "MoneyAmountTextBox2";
            MoneyAmountTextBox2.Size = new Size(100, 23);
            MoneyAmountTextBox2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(467, 47);
            label3.Name = "label3";
            label3.Size = new Size(122, 15);
            label3.TabIndex = 8;
            label3.Text = "Введіть суму кредиту";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(467, 94);
            label4.Name = "label4";
            label4.Size = new Size(96, 15);
            label4.TabIndex = 9;
            label4.Text = "Кредитна ставка";
            // 
            // Result
            // 
            Result.AutoSize = true;
            Result.Location = new Point(429, 182);
            Result.Name = "Result";
            Result.Size = new Size(0, 15);
            Result.TabIndex = 10;
            // 
            // DepositMonths
            // 
            DepositMonths.Location = new Point(71, 158);
            DepositMonths.Name = "DepositMonths";
            DepositMonths.Size = new Size(100, 23);
            DepositMonths.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(71, 140);
            label5.Name = "label5";
            label5.Size = new Size(138, 15);
            label5.TabIndex = 13;
            label5.Text = "Введіть термін депозиту";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(467, 147);
            label6.Name = "label6";
            label6.Size = new Size(132, 15);
            label6.TabIndex = 15;
            label6.Text = "Введіть термін кредиту";
            // 
            // CreditMonths
            // 
            CreditMonths.Location = new Point(467, 165);
            CreditMonths.Name = "CreditMonths";
            CreditMonths.Size = new Size(100, 23);
            CreditMonths.TabIndex = 14;
            // 
            // button2
            // 
            button2.BackColor = Color.Magenta;
            button2.Location = new Point(466, 216);
            button2.Name = "button2";
            button2.Size = new Size(97, 43);
            button2.TabIndex = 16;
            button2.Text = "Розрахувати ";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // ResultBox
            // 
            ResultBox.Location = new Point(191, 286);
            ResultBox.Name = "ResultBox";
            ResultBox.Size = new Size(300, 142);
            ResultBox.TabIndex = 17;
            ResultBox.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 450);
            Controls.Add(ResultBox);
            Controls.Add(button2);
            Controls.Add(label6);
            Controls.Add(CreditMonths);
            Controls.Add(label5);
            Controls.Add(DepositMonths);
            Controls.Add(Result);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(CreditPercentageTextBox);
            Controls.Add(MoneyAmountTextBox2);
            Controls.Add(button1);
            Controls.Add(Label1);
            Controls.Add(DepositPercentageTextBox);
            Controls.Add(MoneyAmountTextBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox MoneyAmountTextBox1;
        private TextBox DepositPercentageTextBox;
        private Label Label1;
        private Button button1;
        private Label label2;
        private TextBox CreditPercentageTextBox;
        private TextBox MoneyAmountTextBox2;
        private Label label3;
        private Label label4;
        private Label Result;
        private TextBox DepositMonths;
        private Label label5;
        private Label label6;
        private TextBox CreditMonths;
        private Button button2;
        private RichTextBox ResultBox;
    }
}
