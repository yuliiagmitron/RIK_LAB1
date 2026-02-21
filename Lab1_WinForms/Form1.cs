using System;
using System.IO;
using System.Windows.Forms;

namespace Lab1_WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Заборона вводу літер
            MoneyAmountTextBox1.KeyPress += OnlyNumbers_KeyPress;
            DepositPercentageTextBox.KeyPress += OnlyNumbers_KeyPress;
            DepositMonths.KeyPress += OnlyNumbers_KeyPress;

            MoneyAmountTextBox2.KeyPress += OnlyNumbers_KeyPress;
            CreditPercentageTextBox.KeyPress += OnlyNumbers_KeyPress;
            CreditMonths.KeyPress += OnlyNumbers_KeyPress;
        }

        // ===================== ДЕПОЗИТ =====================
        private void button1_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(MoneyAmountTextBox1.Text, out double depositAmount) ||
                !double.TryParse(DepositPercentageTextBox.Text, out double percent) ||
                !int.TryParse(DepositMonths.Text, out int termMonths))
            {
                MessageBox.Show("Будь ласка, введіть коректні числові значення!");
                return;
            }

            if (depositAmount <= 0 || percent <= 0 || termMonths <= 0)
            {
                MessageBox.Show("Значення не можуть бути від’ємними або нулем!");
                return;
            }

            double interestRate = percent / 100;

            double totalAmount = depositAmount * Math.Pow(1 + interestRate / 12, termMonths);
            double totalInterest = totalAmount - depositAmount;

            DisplayResults(depositAmount, interestRate, termMonths, 0, totalAmount, totalInterest);
        }

        // ===================== КРЕДИТ =====================
        private void button2_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(MoneyAmountTextBox2.Text, out double loanAmount) ||
                !double.TryParse(CreditPercentageTextBox.Text, out double percent) ||
                !int.TryParse(CreditMonths.Text, out int termMonths))
            {
                MessageBox.Show("Будь ласка, введіть коректні числові значення!");
                return;
            }

            if (loanAmount <= 0 || percent <= 0 || termMonths <= 0)
            {
                MessageBox.Show("Значення не можуть бути від’ємними або нулем!");
                return;
            }

            double interestRate = percent / 100;

            double monthlyPayment = (loanAmount * (interestRate / 12)) /
                (1 - Math.Pow(1 + (interestRate / 12), -termMonths));

            double totalPayment = monthlyPayment * termMonths;
            double totalInterest = totalPayment - loanAmount;

            DisplayResults(loanAmount, interestRate, termMonths, monthlyPayment, totalPayment, totalInterest);
        }

        // ===================== ВИВІД РЕЗУЛЬТАТІВ =====================
        private void DisplayResults(double amount, double rate, int term,
            double monthlyPayment, double totalPayment, double totalInterest)
        {
            string result = $"Дата розрахунку: {DateTime.Now}\r\n\r\n";
            result += $"Початкова сума: {amount:C}\r\n";
            result += $"Відсоткова ставка: {rate:P}\r\n";
            result += $"Термін: {term} місяців\r\n\r\n";
            
            // Якщо це кредит
            if (monthlyPayment > 0)
            {
                result += $"Щомісячний платіж: {monthlyPayment:C}\r\n";
                result += $"Загальна сума виплат: {totalPayment:C}\r\n";
                result += $"Загальна сума відсотків: {totalInterest:C}";
            }
            else
            {
                // Це депозит
                result += $"Загальна сума надходжень: {totalPayment:C}\r\n";
                result += $"Отримані відсотки: {totalInterest:C}";
            }

            ResultBox.Text = result;
            SaveResults(result);
        }


        // ===================== ЗБЕРЕЖЕННЯ =====================
        private void SaveResults(string result)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files (*.txt)|*.txt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog.FileName, result);
            }
        }

        // ===================== ДОЗВОЛЯЄ ЛИШЕ ЧИСЛА =====================
        private void OnlyNumbers_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) &&
                e.KeyChar != ',' &&
                e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }
    }
}
