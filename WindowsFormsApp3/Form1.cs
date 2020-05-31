using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace WindowsFormsApp3
{

    public partial class Form1 : Form
    {
        private Size defaultTbSize = new Size(208, 20);
        private Point defaultlocationTb = new Point { X = 130, Y = 51 };

        public string pattern { get; private set; }

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
            //AutoClosingMessageBox.Show("Text", "Caption", 1000);+
            tbBorderBottomLeft.Text += Environment.UserDomainName + "/" + Environment.UserName;
            timer1.Start();
        }

        private void LoadTreeView()
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {

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
            Popup popup = new Popup();
            popup.ShowDialog();

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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonModified1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;

            panel3.Visible = false;

            panel1.Visible = false;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tbBorderBottomRight.Text = " " + DateTime.Now.ToString("HH:mm:ss"); ;

        }

        private void cbExt1_Enter(object sender, EventArgs e)
        {

        }

        private void tbExtRegex_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError(tbExtRegex, "");

            pattern = string.Empty;
            String input = tbExtRegex.Text;

            char[] sepearator = new char[] { '.', ',' };
            char[] sepearatorExponent = new char[] { 'e', 'E' };
            char[] sepearatorSymbol= new char[] { '+', '-' };

            var IsExponent = input.IndexOfAny(sepearatorExponent) != -1;
            var IsFloat = input.IndexOfAny(sepearator) != -1;

            String[] inputAr = input.Split(sepearator);

            if (IsFloat && inputAr[inputAr.Length - 1] != "") // FLOAT
            {
                int nbrLeftComma = inputAr[0].Length;
                int nbrRightComma = inputAr[1].Length;
                int MinLimitUnity = Convert.ToInt32(inputAr[0]);

                pattern = @"[-+]?["+ MinLimitUnity + @"-9]{" + nbrLeftComma + @"}[\.\,]?[0-9]{" + nbrRightComma + @"}";
            }
            else if (IsExponent) // Exponent
            {
                if (input.Length > 2)
                {
                    inputAr = input.Split(sepearatorExponent);
                    int nbrLeftComma = inputAr[0].Length;
                    int nbrRightComma = inputAr[1].Length;
                    pattern = @"[-+]?[0-9]*\.?[0-9]{" + nbrRightComma + @"}([eE]?[0-9]{" + nbrRightComma + @"})"; 
                }
            }
            else // INTEGER
            {  
                int value;
                if (int.TryParse(input, out value))
                {
                    int indexAddSymbol = input.IndexOf("+");
                    int indexMinusSymbol = input.IndexOf("-");

                    int nbrLeftComma = inputAr[0].Length;
                    if (indexAddSymbol >= 0)
                        pattern = @"[+]?[0-9]{" + (nbrLeftComma - 1) + "}";
                    else if (indexMinusSymbol >= 0)
                        pattern = @"[-]?[0-9]{" + (nbrLeftComma - 1) + "}";
                    else
                        pattern = @"[-+]?[0-9]{" + nbrLeftComma + "}";

                }
                else { // IS_STRING
                    errorProvider1.SetError(tbExtRegex, "Doesn't contain numbers");

                }


            }
        }

        private void tbValueRegex_TextChanged(object sender, EventArgs e)
        {
            string input = tbValueRegex.Text;
            Match match = Regex.Match(input, pattern);
            if (match.Success)
            {
                errorProvider1.SetError(tbValueRegex, "");

                decimal value;
                match = Regex.Match(input, pattern);
                if (match.Success)
                {
                    if (Decimal.TryParse(input, out value))
                    {

                    }
                }
            }
            else
            {
                errorProvider1.SetError(tbValueRegex, "Erreur regex");

            }
        }
    }
}
