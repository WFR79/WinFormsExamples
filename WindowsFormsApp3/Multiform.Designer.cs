namespace WindowsFormsApp3
{
    partial class Multiform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("formation1.1");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("formation1.2");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("formation1.3");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("formation1.4");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Matrice Incendie", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("formation1.4");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("formation1.3");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("formation1.2");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Matrice Incendie Master", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7,
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("formation1.2");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("formation1.1");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Matrice contremaitre", new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode11});
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("qsdqsdqsd");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("qsdqsdqsd");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("qsdqsdqs");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("qsdqsdqsd");
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("sqdqsdqsdqsd");
            this.textboxText = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.timerMenu = new System.Windows.Forms.Timer(this.components);
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.textboxTextFiltrre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.buttonModified1 = new WindowsFormsApp3.ButtonModified();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // textboxText
            // 
            this.textboxText.Location = new System.Drawing.Point(123, 28);
            this.textboxText.Multiline = true;
            this.textboxText.Name = "textboxText";
            this.textboxText.Size = new System.Drawing.Size(213, 20);
            this.textboxText.TabIndex = 1;
            this.textboxText.TextChanged += new System.EventHandler(this.textboxText_TextChanged);
            this.textboxText.Enter += new System.EventHandler(this.textboxText_Enter);
            this.textboxText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.textboxText.Resize += new System.EventHandler(this.textboxText_Resize);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(461, 579);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(461, 612);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Coral;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(596, 533);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(171, 46);
            this.panel1.TabIndex = 4;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp3.Properties.Resources.image;
            this.pictureBox1.Location = new System.Drawing.Point(136, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.Location = new System.Drawing.Point(596, 579);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(171, 46);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.WindowText;
            this.panel3.Location = new System.Drawing.Point(596, 625);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(171, 46);
            this.panel3.TabIndex = 6;
            // 
            // timerMenu
            // 
            this.timerMenu.Interval = 50;
            this.timerMenu.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(32, 114);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node1";
            treeNode1.Text = "formation1.1";
            treeNode2.Name = "Node2";
            treeNode2.Text = "formation1.2";
            treeNode3.Name = "Node3";
            treeNode3.Text = "formation1.3";
            treeNode4.Name = "Node4";
            treeNode4.Text = "formation1.4";
            treeNode5.Name = "Node0";
            treeNode5.Text = "Matrice Incendie";
            treeNode6.Name = "Node6";
            treeNode6.Text = "formation1.4";
            treeNode7.Name = "Node7";
            treeNode7.Text = "formation1.3";
            treeNode8.Name = "Node8";
            treeNode8.Text = "formation1.2";
            treeNode9.Name = "Node5";
            treeNode9.Text = "Matrice Incendie Master";
            treeNode10.Name = "Node10";
            treeNode10.Text = "formation1.2";
            treeNode11.Name = "Node11";
            treeNode11.Text = "formation1.1";
            treeNode12.Name = "Node9";
            treeNode12.Text = "Matrice contremaitre";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode9,
            treeNode12});
            this.treeView1.Size = new System.Drawing.Size(324, 298);
            this.treeView1.TabIndex = 7;
            // 
            // textboxTextFiltrre
            // 
            this.textboxTextFiltrre.Dock = System.Windows.Forms.DockStyle.Right;
            this.textboxTextFiltrre.Location = new System.Drawing.Point(2, 0);
            this.textboxTextFiltrre.Multiline = true;
            this.textboxTextFiltrre.Name = "textboxTextFiltrre";
            this.textboxTextFiltrre.Size = new System.Drawing.Size(203, 23);
            this.textboxTextFiltrre.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filtre matrice";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Filtre formation";
            // 
            // listView1
            // 
            this.listView1.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listView1.Font = new System.Drawing.Font("Arial", 18.25F);
            this.listView1.HideSelection = false;
            listViewItem1.StateImageIndex = 0;
            listViewItem2.StateImageIndex = 0;
            listViewItem3.StateImageIndex = 0;
            listViewItem4.StateImageIndex = 0;
            listViewItem5.StateImageIndex = 0;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5});
            this.listView1.Location = new System.Drawing.Point(551, 31);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(567, 410);
            this.listView1.TabIndex = 10;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Tile;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "xcwsdqsd";
            this.columnHeader1.Width = 400;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "qdqsdqs",
            "qsdqs",
            "d",
            "qsdqs",
            "d",
            "qs",
            "d",
            "qsd",
            "qsdqsd",
            "qsdqqsd",
            "q",
            "sd"});
            this.listBox1.Location = new System.Drawing.Point(391, 179);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 11;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.textboxTextFiltrre);
            this.panel4.Location = new System.Drawing.Point(29, 457);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(205, 23);
            this.panel4.TabIndex = 12;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.HotPink;
            this.panel5.Location = new System.Drawing.Point(26, 579);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 100);
            this.panel5.TabIndex = 13;
            // 
            // buttonModified1
            // 
            this.buttonModified1.BackColor = System.Drawing.Color.White;
            this.buttonModified1.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.buttonModified1.FlatAppearance.BorderSize = 5;
            this.buttonModified1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModified1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.buttonModified1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(33)))), ((int)(((byte)(107)))));
            this.buttonModified1.Location = new System.Drawing.Point(404, 502);
            this.buttonModified1.Name = "buttonModified1";
            this.buttonModified1.Size = new System.Drawing.Size(75, 23);
            this.buttonModified1.TabIndex = 14;
            this.buttonModified1.Text = "buttonModified1";
            this.buttonModified1.UseVisualStyleBackColor = false;
            // 
            // Multiform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1147, 739);
            this.Controls.Add(this.buttonModified1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textboxText);
            this.Controls.Add(this.label1);
            this.Name = "Multiform";
            this.Text = "qsdqsd";
            this.Load += new System.EventHandler(this.Multiform_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textboxText;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Timer timerMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TextBox textboxTextFiltrre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private ButtonModified buttonModified1;
    }
}