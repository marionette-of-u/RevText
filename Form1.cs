using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RevText
{
    [DefaultEvent("KeyboardHooked")]
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
            hook.Dispose();
            Dispose();
        }

        static public void KeyboardHookedEventHandler1(object sender, KeyboardHookedEventArgs e)
        {
            if (e.UpDown == KeyboardUpDown.Down)
            {
                keyFlags[e.KeyCode] = true;
            }
            else
            {
                keyFlags.Remove(e.KeyCode);
            }
            if (Clipboard.ContainsText() && (keyFlags.Contains(Keys.LControlKey) || keyFlags.Contains(Keys.RControlKey)) && keyFlags.Contains(Keys.Q))
            {
                e.Cancel = true;
                Clipboard.SetDataObject(Program.RevProc(Clipboard.GetText()), true);
            }
        }

        KeyboardHook hook = new KeyboardHook(KeyboardHookedEventHandler1);
        static Hashtable keyFlags = new Hashtable();
    }
}
