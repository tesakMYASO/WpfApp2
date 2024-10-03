using System;
using System.Linq;
using System.Windows;
using ClassLibrary1;

namespace RandomNumberMaxFinder
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void GenerateButton_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(CountTextBox.Text, out int n) && n > 0)
            {
                Random random = new Random();
                int[] randomNumbers = new int[n];

                for (int i = 0; i < n; i++)
                {
                    randomNumbers[i] = random.Next(0, n + 1);
                }

                NumbersTextBlock.Text = string.Join(", ", randomNumbers);
                MaxTextBlock.Text = randomNumbers.Max().ToString();
            }
            else
            {
                MessageBox.Show(" Введите положительное целое число для n.");
            }
        }

      

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Автор: Исаев Арсений" + "\n" + " Группа ИСП-34 " + "\n" + " Задание: Найти максимум из n целых случайных чисел X, распределенных в диапазоне от 0 до n. Вывести на экран на одной строке сгенерированные числа, на другой строке результат ");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
