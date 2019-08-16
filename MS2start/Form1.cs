using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//thanks to craftplacer for helping me
namespace MS2start
{
    public partial class Form1 : Form
    {
        private readonly Image explorerIcon = Icon.ExtractAssociatedIcon(@"C:\Windows\explorer.exe").ToBitmap();
        private readonly Image myPCIcon = Icon.ExtractAssociatedIcon(@"C:\Windows\system32\colorcpl.exe").ToBitmap();
        private readonly Image controlPanelIcon = NativeHelpers.ExtractIcon(@"%SystemRoot%\system32\imageres.dll", -197);

        public Form1()
        {
            InitializeComponent();
        }

        private void Explorer_Paint(object sender, PaintEventArgs e)
        {
            //                              X -\/  \/- Y
            e.Graphics.DrawImage(explorerIcon, 15, 15); //Change position if you want.
            e.Graphics.DrawString("Windows Explorer", Explorer.Font, new SolidBrush(Explorer.ForeColor), new RectangleF(14, 84, 100, 0));
            //                                                                                                      X  Y  Width Height
        }

        private void myPC_Paint(object sender, PaintEventArgs e)
        {
            //                              X -\/  \/- Y
            e.Graphics.DrawImage(myPCIcon, 15, 15); //Change position if you want.
            e.Graphics.DrawString("Windows Explorer", Explorer.Font, new SolidBrush(Explorer.ForeColor), new RectangleF(14, 84, 100, 0));
            //                                                                                                      X  Y  Width Height
        }

        private void controlPanel_Paint(object sender, PaintEventArgs e)
        {
            //                              X -\/  \/- Y
            e.Graphics.DrawImage(controlPanelIcon, 15, 15); //Change position if you want.
            e.Graphics.DrawString("Windows Explorer", Explorer.Font, new SolidBrush(Explorer.ForeColor), new RectangleF(14, 84, 100, 0));
            //                                                                                                      X  Y  Width Height
        }
    }
}