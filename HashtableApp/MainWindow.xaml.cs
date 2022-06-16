using System;
using System.Collections;
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

namespace HashtableApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Hashtable hashtable;
        public MainWindow()
        {
            InitializeComponent();
            hashtable = new Hashtable();
        }

        private void Add_Button_Click(object sender, RoutedEventArgs e)
        {
            if(KeyBox.Text == "" && ValueBox.Text == "")
            {
                MessageBox.Show("Please insert Key & Value Data.");
            }
            else if(KeyBox.Text != "" && ValueBox.Text == "")
            {
                MessageBox.Show("Please insert Value Data.");
            }
            else if(KeyBox.Text == "" && ValueBox.Text != "")
            {
                MessageBox.Show("Please insert Key Data.");
            }
            else
            {
                hashtable.Add(KeyBox.Text,ValueBox.Text);
                MessageBox.Show(KeyBox.Text + " Key" + "," + ValueBox.Text + " Value" + " has Add.");
                KeyBox.Clear();
                ValueBox.Clear();
            }
        }

        private void Remove_Button_Click(object sender, RoutedEventArgs e)
        {
            //Remove
            hashtable.Clear();
            MessageBox.Show("All Data Remove.");
            KeyBox.Clear();
            ValueBox.Clear();
        }

        private void ShowAll_Button_Click(object sender, RoutedEventArgs e)
        {
            ICollection icollection = hashtable.Keys;
            //Show All
            foreach(string Key in icollection)
            {
                MessageBox.Show(hashtable[Key].ToString());
            }
        }
    }
}
