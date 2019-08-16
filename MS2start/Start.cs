using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TweakUtility.Helpers;
//thanks to craftplacer for helping me
namespace MS2start
{
    public partial class Start : Form
    {
        private readonly Image explorerIcon = Icon.ExtractAssociatedIcon(@"C:\Windows\explorer.exe").ToBitmap();
        private readonly Image myPCIcon = NativeHelpers.ExtractIcon(@"%SystemRoot%\system32\imageres.dll", -109).ToBitmap();
        private readonly Image controlPanelIcon = NativeHelpers.ExtractIcon(@"%SystemRoot%\system32\imageres.dll", -27).ToBitmap();
        private readonly Image desktopIcon = NativeHelpers.ExtractIcon(@"%SystemRoot%\system32\imageres.dll", -110).ToBitmap();

        public Start()
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
            e.Graphics.DrawString("Computer", Explorer.Font, new SolidBrush(myPC.ForeColor), new RectangleF(14, 84, 100, 0));
            //                                                                                                      X  Y  Width Height
        }

        private void controlPanel_Paint(object sender, PaintEventArgs e)
        {
            //                              X -\/  \/- Y
            e.Graphics.DrawImage(controlPanelIcon, 15, 15); //Change position if you want.
            e.Graphics.DrawString("Control Panel", Explorer.Font, new SolidBrush(controlPanel.ForeColor), new RectangleF(14, 84, 0, 0));
            //                                                                                                      X  Y  Width Height
        }

        private void Desktop_Paint(object sender, PaintEventArgs e)
        {
            //                              X -\/  \/- Y
            e.Graphics.DrawImage(desktopIcon, 15, 15); //Change position if you want.
            e.Graphics.DrawString("Desktop", Explorer.Font, new SolidBrush(controlPanel.ForeColor), new RectangleF(14, 84, 0, 0));
            //                                                                                                      X  Y  Width Height
        }
    }
}