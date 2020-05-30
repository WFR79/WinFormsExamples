using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Application;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Multiform : Form
    {
        public bool subMenu1Visible = true;
        public Point locationPanel3;
        private string text;

        public string Text

        {

            get { return textBox.Text; }

            set { textBox.Text = value; }

        }



        TextBox textBox = new TextBox();

        public Multiform()
        {
            InitializeComponent(); locationPanel3 = panel3.Location;
         
            this.Paint += new PaintEventHandler(UserControl1_Paint);

            this.Resize += new EventHandler(UserControl1_Resize);

            textboxTextFiltrre.Multiline = true;
            textBox.Text = "SUPER";
            //textBox.BorderStyle = BorderStyle.None;
            this.Controls.Add(textBox);
            //this.textboxTextFiltrre.SetStyle(ControlStyles.UserPaint, true);
            Rectangle rect = textboxTextFiltrre.Bounds;
            if (ApplicationDeployment.IsNetworkDeployed)
            {
                System.Deployment.Application.ApplicationDeployment cd =
                System.Deployment.Application.ApplicationDeployment.CurrentDeployment;
                MessageBox.Show(cd.CurrentVersion.ToString());
                this.text += cd.CurrentVersion.ToString();
                // show publish version in title or About box...
            }
            this.text = "qsdqsdqsd";

            //////////////////////////////////////////////////////////////////////////////
            Panel newPanel = new Panel();
            newPanel.BackColor = Color.Red;
            newPanel.Size = new Size((panel5.Size.Width - 5), (panel5.Size.Height - 5));
            panel5.Controls.Add(newPanel);


        }

        private void UserControl1_Resize(object sender, EventArgs e)
        {


            textBox.Size = new Size(textBox.Width - 3, textBox.Height - 2);

            textBox.Location = new Point(30, 30);
        }

        private void UserControl1_Paint(object sender, PaintEventArgs e)
        {
            Rectangle rect = textboxTextFiltrre.Bounds;

            ControlPaint.DrawBorder(e.Graphics, this.textboxTextFiltrre.ClientRectangle, Color.Red, ButtonBorderStyle.Solid);
        }

        private void textboxText_Resize(object sender, EventArgs e)
        {
            Rectangle rect = textboxTextFiltrre.Bounds; textboxTextFiltrre.BorderStyle = BorderStyle.None;
             textboxTextFiltrre.Parent.BackColor = Color.Red;
            Graphics gr = textboxTextFiltrre.CreateGraphics();
            ControlPaint.DrawBorder(gr, rect, Color.Red, ButtonBorderStyle.Solid);
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                comboBox1.Visible = true;
            }
            else
            {
                comboBox1.Visible = false;

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void panel1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (subMenu1Visible)
            {

                panel2.Height -= 2;
                if (panel2.Height == 0)
                {
                    subMenu1Visible = false;
                    panel3.Location = new Point(panel3.Location.X, panel3.Location.Y - panel3.Height);
                    timerMenu.Stop();
                }
            }
            else
            {
                if (locationPanel3 != panel3.Location)
                {
                    panel3.Location = new Point(panel3.Location.X, panel3.Location.Y + panel3.Height);
                    locationPanel3 = panel3.Location;
                }
                panel2.Height += 2;
                if (panel2.Height == panel3.Height)
                {
                    subMenu1Visible = true;
                    timerMenu.Stop();
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            timerMenu.Start();

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                foreach (TreeNode node in treeView1.Nodes)
                {
                    if (node.Text.ToUpper().Contains(textboxText.Text.ToUpper()))
                    {
                        treeView1.SelectedNode = node;
                        node.BackColor = Color.Yellow;
                    }
                    else
                    {
                        node.BackColor = Color.Transparent;

                    }
                    //if (SearchRecursive(node.Nodes, textBox1.Text))
                    //    return true;
                    SearchRecursive(node.Nodes, textboxText.Text);
                }
            }
        }

        public bool SearchRecursive(TreeNodeCollection nodes, string textboxText)
        {

            foreach (TreeNode node in nodes)
            {
                if (node.Text.ToUpper().Contains(textboxText.ToUpper()))
                {
                    treeView1.SelectedNode = node;
                    node.BackColor = Color.Yellow;


                }
                else
                {
                    node.BackColor = Color.Transparent;

                }
                //if (SearchRecursive(node.Nodes, textBox1.Text))
                //    return true;

            }

            return true;

        }

        private void textboxText_Enter(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textboxText_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Multiform_Load(object sender, EventArgs e)
        {

        }
    }
}
