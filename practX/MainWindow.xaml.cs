using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace practX
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _out.Clear();
            int size = 0;
            try
            {
                size = Convert.ToInt32(_in.Text);
            }
            catch
            {
                MessageBox.Show("Введите натуральное число (целое и > 0)");
                _in.Focus();
            }
            if (size > 0)
            {
                List <int> mas = new List <int> ();
                for (int i = 0; i < size; i++)
                {
                    mas.Add(i + 1);
                }
                int j = 0;
                while (mas.Count != 1)
                {
                    if (j + 2 < mas.Count - 1)
                    {
                        mas.RemoveAt(j + 2);
                        j = j + 2;
                    }
                    if (j + 2 == mas.Count-1)
                    {
                        mas.RemoveAt(mas.Count-1);
                        j = 0;
                    }
                    if (j + 1 == mas.Count-1)
                    {
                        mas.RemoveAt(0);
                        j = 0;
                    }
                    if (j == mas.Count-1 && mas.Count != 1)
                    {
                        mas.RemoveAt(1);
                        j = 1;
                    }
                }
                _out.Text = Convert.ToString(mas[0]);
            }
            else
            {
                MessageBox.Show("Введите число > 0");
            }
        }

        private void _in_TextChanged(object sender, TextChangedEventArgs e)
        {
            _out.Clear();
        }
    }
}
