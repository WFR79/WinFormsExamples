using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public class AutoClosingMessageBox
    {
        System.Threading.Timer _timeoutTimer;
        string _caption;
        AutoClosingMessageBox(string text, string caption, int timeout)
        {
            _caption = caption;
            _timeoutTimer = new System.Threading.Timer(OnTimerElapsed,
                null, timeout, System.Threading.Timeout.Infinite);
            using (_timeoutTimer)
                MessageBox.Show(text, caption);
        }
        public static void Show(string text, string caption, int timeout)
        {
            new AutoClosingMessageBox(text, caption, timeout);
        }
        void OnTimerElapsed(object state)
        {
            IntPtr mbWnd = FindWindow("#32770", _caption); // lpClassName is #32770 for MessageBox
            if (mbWnd != IntPtr.Zero)
                SendMessage(mbWnd, WM_CLOSE, IntPtr.Zero, IntPtr.Zero);
            _timeoutTimer.Dispose();
        }
        const int WM_CLOSE = 0x0010;
        [System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
        static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, IntPtr wParam, IntPtr lParam);
    }
    public partial class Form1 : Form
    {
        private Size defaultTbSize = new Size(208, 20);
        private Point defaultlocationTb = new Point { X = 130, Y = 51 };
        public Form1()
        {
            InitializeComponent();
            textBox1.Location = defaultlocationTb;
            LoadTreeView();

            //for (int i = 0; i < 5; i++)
            //{
            //    Multiform test = new Multiform();
            //    test.Show();
            //}
            AutoClosingMessageBox.Show("Text", "Caption", 1000);
        }

        private void LoadTreeView()
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.AutoSize = false;
            tb.BorderStyle = BorderStyle.Fixed3D;
            tb.Font = new Font("Arial", 10);

            Point locationTb = tb.Location;
            int width = tb.Width + 5;
            var heigh = tb.Height + 5;
            int difWidth = tb.Width - width;
            int difheigh = tb.Height - heigh;

            tb.Size = new System.Drawing.Size(width, heigh);
            locationTb.X = locationTb.X + difWidth / 2;
            locationTb.Y = locationTb.Y + difheigh / 2;

            //defaultlocationTb = locationTb;
            tb.Location = locationTb;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Size = defaultTbSize;
            tb.Location = defaultlocationTb;
            Font myfont = new Font("Arial", 10f);

            tb.Font = myfont;
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckedListBox list = (CheckedListBox)sender;
            string str = list.SelectedItem.ToString();
        }

        private void checkedListBox2_ItemCheck(object sender, ItemCheckEventArgs e)
        {

            for (int ix = 0; ix < checkedListBox2.Items.Count; ++ix)
                if (ix != e.Index) checkedListBox2.SetItemChecked(ix, false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //checkedListBox2.Items.Add(comboBox1.SelectedItem);
            checkedListBox2.Items.Insert(0, comboBox1.SelectedItem);
        }
        private void checkedListBox1_MouseHover(object sender, EventArgs e)
        {
            SetToolStipOfProvider(sender);
        }

        private void SetToolStipOfProvider(object sender)
        {
            Point pos = checkedListBox2.PointToClient(MousePosition);

            int tIndex = checkedListBox1.IndexFromPoint(pos);

            if (tIndex > -1)
            {
                pos = this.PointToClient(MousePosition);
                toolTip1.ToolTipTitle = "ToolTip for CheckedListBox";
                toolTip1.SetToolTip(checkedListBox2, checkedListBox2.Items[tIndex].ToString() + "\n" +
                    checkedListBox2.Items[tIndex].ToString() + "\n" +
                    checkedListBox2.Items[tIndex].ToString() + "\n" +
                    checkedListBox2.Items[tIndex].ToString() + "\n\r");

            }

        }


    }
}
