using Microsoft.Win32;
using System;
using System.IO;
using System.Windows;

namespace Lab1_WPF
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // ===== ДЕПОЗИТ =====
        private void CalculateDeposit_Click(object sender, RoutedEventArgs e)
        {
            if (!double.TryParse(DepositAmount.Text, out double amount) ||
                !double.TryParse(DepositRate.Text, out double percent) ||
                !int.TryParse(DepositMonths.Text, out int term))
            {
                MessageBox.Show("Некоректні дані");
                return;
            }

            if (amount <= 0 || percent <= 0 || term <= 0)
            {
                MessageBox.Show("Значення повинні бути більше 0");
                return;
            }

            double rate = percent / 100;
            double totalAmount = amount * Math.Pow(1 + rate / 12, term);
            double interest = totalAmount - amount;

            string result =
                $"Дата розрахунку: {DateTime.Now}\n\n" +
                $"Початкова сума: {amount:C}\n" +
                $"Ставка: {percent}%\n" +
                $"Термін: {term} місяців\n\n" +
                $"Загальна сума надходжень: {totalAmount:C}\n" +
                $"Отримані відсотки: {interest:C}";

            ResultBox.Text = result;
            SaveToFile(result);
        }

        // ===== КРЕДИТ =====
        private void CalculateLoan_Click(object sender, RoutedEventArgs e)
        {
            if (!double.TryParse(LoanAmount.Text, out double amount) ||
                !double.TryParse(LoanRate.Text, out double percent) ||
                !int.TryParse(LoanMonths.Text, out int term))
            {
                MessageBox.Show("Некоректні дані");
                return;
            }

            if (amount <= 0 || percent <= 0 || term <= 0)
            {
                MessageBox.Show("Значення повинні бути більше 0");
                return;
            }

            double rate = percent / 100;
            double monthly = (amount * (rate / 12)) /
                (1 - Math.Pow(1 + (rate / 12), -term));

            double totalPayment = monthly * term;
            double interest = totalPayment - amount;

            string result =
                $"Дата розрахунку: {DateTime.Now}\n\n" +
                $"Сума кредиту: {amount:C}\n" +
                $"Ставка: {percent}%\n" +
                $"Термін: {term} місяців\n\n" +
                $"Щомісячний платіж: {monthly:C}\n" +
                $"Загальна сума виплат: {totalPayment:C}\n" +
                $"Загальна сума відсотків: {interest:C}";

            ResultBox.Text = result;
            SaveToFile(result);
        }

        // ===== ЗБЕРЕЖЕННЯ =====
        private void SaveToFile(string text)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Text files (*.txt)|*.txt";

            if (dialog.ShowDialog() == true)
            {
                File.WriteAllText(dialog.FileName, text);
            }
        }
    }
}
