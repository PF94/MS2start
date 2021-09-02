using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Diagnostics;

namespace StartScreen
{
    /// <summary>
    /// Interaction logic for tile.xaml
    /// </summary>
    public partial class Tile : UserControl
    {
        public Tile()
        {
            InitializeComponent();
            Debug.WriteLine("Spawned tile");
        }
        private void Tile_Click(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("You just clicked tile " + label); //this is a placeholder
        }
    }
}
