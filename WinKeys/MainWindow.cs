using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IEB.Utils.WinKeys
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();

            Closed += MainWindow_Closed;
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == NativeMethods.WM_HOTKEY)
                Visible = !Visible;
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            bool b = NativeMethods.RegisterHotKey((IntPtr)Handle, GetHashCode(), (uint)NativeMethods.MOD_WIN, (uint)Keys.W);
            if (!b)
                throw new Exception("RegisterHotKey returned false");
        }

        void MainWindow_Closed(object sender, EventArgs e)
        {
            NativeMethods.UnregisterHotKey((IntPtr) Handle, GetHashCode());
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}