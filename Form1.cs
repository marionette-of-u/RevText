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
            Program.ReadConfig(this);
        }

        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.WriteConfig();
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
            if (Clipboard.ContainsText() && (keyFlags.Contains(Keys.LControlKey) || keyFlags.Contains(Keys.RControlKey)) && keyFlags.Contains(Program.hotKey))
            {
                e.Cancel = Program.through;
                Clipboard.SetDataObject(Program.RevProc(Clipboard.GetText()), true);
            }
        }

        KeyboardHook hook = new KeyboardHook(KeyboardHookedEventHandler1);
        static Hashtable keyFlags = new Hashtable();

        private void translateCodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            translateCodeToolStripMenuItem.Checked = !translateCodeToolStripMenuItem.Checked;
            Program.translateCode = translateCodeToolStripMenuItem.Checked;
        }

        private void throughHotKeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            throughHotKeyToolStripMenuItem.Checked = !throughHotKeyToolStripMenuItem.Checked;
            Program.through = throughHotKeyToolStripMenuItem.Checked;
        }

        private void kanaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kanaToolStripMenuItem.Checked = !kanaToolStripMenuItem.Checked;
            Program.qKana = kanaToolStripMenuItem.Checked;
        }

        private void kanjiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kanjiToolStripMenuItem.Checked = !kanjiToolStripMenuItem.Checked;
            Program.qJi = kanjiToolStripMenuItem.Checked;
        }
    }
}
