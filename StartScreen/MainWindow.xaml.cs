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
                //todo: load icon from executable file WITHOUT DUMPING IT TO A CACHE FOLDER AND WITHOUT DOWNGRADING BACK TO NET FRAMEWORK 4.X
                //nativemethod is absolutely fucking broken and i am not going to use winforms for this bullshit. the ms2start winform code is
                //hardcode garbage, not going to use it. this is like returning back to poktube because there's a issue with the squarebracket code.
                // -gr 9/1/2021
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
