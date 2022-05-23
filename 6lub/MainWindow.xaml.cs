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

namespace _6lub
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Queue<string> queue;
        public MainWindow()
        {
            InitializeComponent();
            queue = new Queue<string>();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            queue.Enqueue(InputValue.Text);
            NumberGrid.Items.Add(InputValue.Text);
            InputValue.Clear();
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string firstelement = Convert.ToString(queue.Dequeue());
            NumberGrid.Items.Remove(firstelement);
        }
        
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string first = queue.First();
            string pechat = "";
            double summ = 0;
            string Text = "";
            foreach (string item in queue)
            {
                pechat += Convert.ToString(item) + ", ";
                Text += Convert.ToString(item);
            }          
            Sum.Text = "Количество символов = " + (Text.Length - first.Length);
            Print.Text = "Print: " + pechat;
        }
    }
}
