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

namespace StartScreen
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

        //loads a tile from a list
        private void Panel_Loaded(object sender, RoutedEventArgs e)
        {
            string[] pets = { "dog", "cat", "bird" }; //placeholder until i make proper settings
            foreach (string value in pets)
            {
                Tile startTile = new Tile();
                startTile.label.Content = value;
                panelEpic.Children.Add(startTile);
            }
        }

        //creates a custom tile intended to test tiles.
        private void ButtonAddName_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtName.Text))
            {
                Tile startTile = new Tile();
                startTile.label.Content = txtName.Text;
                panelEpic.Children.Add(startTile);
                txtName.Clear();
            }
        }
    }
}
