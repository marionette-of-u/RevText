using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RevText
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ShowInTaskbar = false;
            Visible = false;
        }

        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hook.Dispose();
            Dispose();
        }

        static public void KeyboardHookedEventHandler1(object sender, KeyboardHookedEventArgs e)
        {
            if (e.UpDown == KeyboardUpDown.Down && e.AltDown && e.KeyCode == Keys.J && Clipboard.ContainsText())
            {
                Clipboard.SetDataObject(Program.RevProc(Clipboard.GetText()), true);
            }
        }

        private KeyboardHook Hook = new KeyboardHook(KeyboardHookedEventHandler1);
    }
}
