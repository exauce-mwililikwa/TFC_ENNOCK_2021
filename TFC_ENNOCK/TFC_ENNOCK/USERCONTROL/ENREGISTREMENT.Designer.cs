namespace TFC_ENNOCK.USERCONTROL
{
    partial class ENREGISTREMENT
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DATE = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.female = new System.Windows.Forms.RadioButton();
            this.Male = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.LIEU = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.prenom = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.POSTNOM = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NOM = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.OPTIONS = new Guna.UI2.WinForms.Guna2ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PROMOTION = new Guna.UI2.WinForms.Guna2ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GroupBox1.SuspendLayout();
            this.bunifuCards1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.label6);
            this.guna2GroupBox1.Controls.Add(this.DATE);
            this.guna2GroupBox1.Controls.Add(this.female);
            this.guna2GroupBox1.Controls.Add(this.Male);
            this.guna2GroupBox1.Controls.Add(this.label5);
            this.guna2GroupBox1.Controls.Add(this.LIEU);
            this.guna2GroupBox1.Controls.Add(this.label4);
            this.guna2GroupBox1.Controls.Add(this.prenom);
            this.guna2GroupBox1.Controls.Add(this.label3);
            this.guna2GroupBox1.Controls.Add(this.POSTNOM);
            this.guna2GroupBox1.Controls.Add(this.label2);
            this.guna2GroupBox1.Controls.Add(this.NOM);
            this.guna2GroupBox1.Controls.Add(this.label1);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(3, 3);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.ShadowDecoration.Parent = this.guna2GroupBox1;
            this.guna2GroupBox1.Size = new System.Drawing.Size(726, 241);
            this.guna2GroupBox1.TabIndex = 0;
            this.guna2GroupBox1.Text = "IDENTITE";
            this.guna2GroupBox1.Click += new System.EventHandler(this.guna2GroupBox1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(227, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "DATE DE NAISSANCE";
            // 
            // DATE
            // 
            this.DATE.AutoRoundedCorners = true;
            this.DATE.BackColor = System.Drawing.Color.White;
            this.DATE.BorderRadius = 17;
            this.DATE.CheckedState.Parent = this.DATE;
            this.DATE.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DATE.ForeColor = System.Drawing.Color.Black;
            this.DATE.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DATE.HoverState.Parent = this.DATE;
            this.DATE.Location = new System.Drawing.Point(227, 161);
            this.DATE.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DATE.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DATE.Name = "DATE";
            this.DATE.ShadowDecoration.Parent = this.DATE;
            this.DATE.Size = new System.Drawing.Size(206, 36);
            this.DATE.TabIndex = 11;
            this.DATE.Value = new System.DateTime(2021, 11, 21, 21, 32, 40, 576);
            // 
            // female
            // 
            this.female.AutoSize = true;
            this.female.BackColor = System.Drawing.Color.White;
            this.female.ForeColor = System.Drawing.Color.Black;
            this.female.Location = new System.Drawing.Point(566, 178);
            this.female.Name = "female";
            this.female.Size = new System.Drawing.Size(31, 19);
            this.female.TabIndex = 10;
            this.female.Text = "F";
            this.female.UseVisualStyleBackColor = false;
            // 
            // Male
            // 
            this.Male.AutoSize = true;
            this.Male.BackColor = System.Drawing.Color.White;
            this.Male.Checked = true;
            this.Male.ForeColor = System.Drawing.Color.Black;
            this.Male.Location = new System.Drawing.Point(466, 179);
            this.Male.Name = "Male";
            this.Male.Size = new System.Drawing.Size(36, 19);
            this.Male.TabIndex = 9;
            this.Male.TabStop = true;
            this.Male.Text = "M";
            this.Male.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(466, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "SEXE";
            // 
            // LIEU
            // 
            this.LIEU.AutoRoundedCorners = true;
            this.LIEU.BackColor = System.Drawing.Color.White;
            this.LIEU.BorderRadius = 20;
            this.LIEU.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LIEU.DefaultText = "";
            this.LIEU.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.LIEU.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.LIEU.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.LIEU.DisabledState.Parent = this.LIEU;
            this.LIEU.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.LIEU.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LIEU.FocusedState.Parent = this.LIEU;
            this.LIEU.ForeColor = System.Drawing.Color.Black;
            this.LIEU.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LIEU.HoverState.Parent = this.LIEU;
            this.LIEU.Location = new System.Drawing.Point(7, 156);
            this.LIEU.Name = "LIEU";
            this.LIEU.PasswordChar = '\0';
            this.LIEU.PlaceholderText = "";
            this.LIEU.SelectedText = "";
            this.LIEU.ShadowDecoration.Parent = this.LIEU;
            this.LIEU.Size = new System.Drawing.Size(201, 42);
            this.LIEU.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(7, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "LIEU DE NAISSANCE";
            // 
            // prenom
            // 
            this.prenom.AutoRoundedCorners = true;
            this.prenom.BackColor = System.Drawing.Color.White;
            this.prenom.BorderRadius = 20;
            this.prenom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.prenom.DefaultText = "";
            this.prenom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.prenom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.prenom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.prenom.DisabledState.Parent = this.prenom;
            this.prenom.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.prenom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.prenom.FocusedState.Parent = this.prenom;
            this.prenom.ForeColor = System.Drawing.Color.Black;
            this.prenom.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.prenom.HoverState.Parent = this.prenom;
            this.prenom.Location = new System.Drawing.Point(466, 77);
            this.prenom.Name = "prenom";
            this.prenom.PasswordChar = '\0';
            this.prenom.PlaceholderText = "";
            this.prenom.SelectedText = "";
            this.prenom.ShadowDecoration.Parent = this.prenom;
            this.prenom.Size = new System.Drawing.Size(240, 42);
            this.prenom.TabIndex = 5;
            this.prenom.TextChanged += new System.EventHandler(this.guna2TextBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(466, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "PRENOM";
            // 
            // POSTNOM
            // 
            this.POSTNOM.AutoRoundedCorners = true;
            this.POSTNOM.BackColor = System.Drawing.Color.White;
            this.POSTNOM.BorderRadius = 20;
            this.POSTNOM.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.POSTNOM.DefaultText = "";
            this.POSTNOM.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.POSTNOM.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.POSTNOM.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.POSTNOM.DisabledState.Parent = this.POSTNOM;
            this.POSTNOM.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.POSTNOM.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.POSTNOM.FocusedState.Parent = this.POSTNOM;
            this.POSTNOM.ForeColor = System.Drawing.Color.Black;
            this.POSTNOM.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.POSTNOM.HoverState.Parent = this.POSTNOM;
            this.POSTNOM.Location = new System.Drawing.Point(227, 77);
            this.POSTNOM.Name = "POSTNOM";
            this.POSTNOM.PasswordChar = '\0';
            this.POSTNOM.PlaceholderText = "";
            this.POSTNOM.SelectedText = "";
            this.POSTNOM.ShadowDecoration.Parent = this.POSTNOM;
            this.POSTNOM.Size = new System.Drawing.Size(206, 42);
            this.POSTNOM.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(227, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "POSTNOM";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // NOM
            // 
            this.NOM.AutoRoundedCorners = true;
            this.NOM.BackColor = System.Drawing.Color.White;
            this.NOM.BorderRadius = 17;
            this.NOM.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NOM.DefaultText = "";
            this.NOM.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.NOM.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.NOM.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NOM.DisabledState.Parent = this.NOM;
            this.NOM.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NOM.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NOM.FocusedState.Parent = this.NOM;
            this.NOM.ForeColor = System.Drawing.Color.Black;
            this.NOM.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NOM.HoverState.Parent = this.NOM;
            this.NOM.Location = new System.Drawing.Point(7, 83);
            this.NOM.Name = "NOM";
            this.NOM.PasswordChar = '\0';
            this.NOM.PlaceholderText = "";
            this.NOM.SelectedText = "";
            this.NOM.ShadowDecoration.Parent = this.NOM;
            this.NOM.Size = new System.Drawing.Size(201, 36);
            this.NOM.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(7, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOM";
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.Tomato;
            this.bunifuCards1.Controls.Add(this.groupBox2);
            this.bunifuCards1.Controls.Add(this.groupBox1);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(3, 250);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(433, 174);
            this.bunifuCards1.TabIndex = 2;
            this.bunifuCards1.Paint += new System.Windows.Forms.PaintEventHandler(this.bunifuCards1_Paint);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.OPTIONS);
            this.groupBox2.Location = new System.Drawing.Point(214, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(198, 72);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "OPTION";
            // 
            // OPTIONS
            // 
            this.OPTIONS.BackColor = System.Drawing.Color.Transparent;
            this.OPTIONS.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.OPTIONS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OPTIONS.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.OPTIONS.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.OPTIONS.FocusedState.Parent = this.OPTIONS;
            this.OPTIONS.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.OPTIONS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.OPTIONS.HoverState.Parent = this.OPTIONS;
            this.OPTIONS.ItemHeight = 30;
            this.OPTIONS.ItemsAppearance.Parent = this.OPTIONS;
            this.OPTIONS.Location = new System.Drawing.Point(6, 19);
            this.OPTIONS.Name = "OPTIONS";
            this.OPTIONS.ShadowDecoration.Parent = this.OPTIONS;
            this.OPTIONS.Size = new System.Drawing.Size(188, 36);
            this.OPTIONS.TabIndex = 0;
            this.OPTIONS.SelectedIndexChanged += new System.EventHandler(this.OPTIONS_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PROMOTION);
            this.groupBox1.Location = new System.Drawing.Point(10, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(198, 72);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PROMOTION";
            // 
            // PROMOTION
            // 
            this.PROMOTION.BackColor = System.Drawing.Color.Transparent;
            this.PROMOTION.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.PROMOTION.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PROMOTION.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PROMOTION.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PROMOTION.FocusedState.Parent = this.PROMOTION;
            this.PROMOTION.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.PROMOTION.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.PROMOTION.HoverState.Parent = this.PROMOTION;
            this.PROMOTION.ItemHeight = 30;
            this.PROMOTION.ItemsAppearance.Parent = this.PROMOTION;
            this.PROMOTION.Location = new System.Drawing.Point(6, 19);
            this.PROMOTION.Name = "PROMOTION";
            this.PROMOTION.ShadowDecoration.Parent = this.PROMOTION;
            this.PROMOTION.Size = new System.Drawing.Size(188, 36);
            this.PROMOTION.TabIndex = 0;
            this.PROMOTION.SelectedIndexChanged += new System.EventHandler(this.PROMOTION_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.linkLabel1);
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Location = new System.Drawing.Point(447, 251);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 186);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "PHOTO";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(99, 170);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(38, 13);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Choisir";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(653, 263);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(499, 401);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(981, 237);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(171, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::TFC_ENNOCK.Properties.Resources.undraw_studying_s3l7;
            this.pictureBox3.Location = new System.Drawing.Point(4, 456);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(278, 232);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TFC_ENNOCK.Properties.Resources.undraw_Team_page_re_cffb;
            this.pictureBox2.Location = new System.Drawing.Point(735, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(417, 231);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // guna2Button3
            // 
            this.guna2Button3.AutoRoundedCorners = true;
            this.guna2Button3.BorderRadius = 21;
            this.guna2Button3.CheckedState.Parent = this.guna2Button3;
            this.guna2Button3.CustomImages.Parent = this.guna2Button3;
            this.guna2Button3.Enabled = false;
            this.guna2Button3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.HoverState.Parent = this.guna2Button3;
            this.guna2Button3.Image = global::TFC_ENNOCK.Properties.Resources.Print_48;
            this.guna2Button3.Location = new System.Drawing.Point(513, 507);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.ShadowDecoration.Parent = this.guna2Button3;
            this.guna2Button3.Size = new System.Drawing.Size(134, 45);
            this.guna2Button3.TabIndex = 7;
            this.guna2Button3.Text = "CARTE";
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.AutoRoundedCorners = true;
            this.guna2Button2.BorderRadius = 21;
            this.guna2Button2.CheckedState.Parent = this.guna2Button2;
            this.guna2Button2.CustomImages.Parent = this.guna2Button2;
            this.guna2Button2.Enabled = false;
            this.guna2Button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.HoverState.Parent = this.guna2Button2;
            this.guna2Button2.Image = global::TFC_ENNOCK.Properties.Resources.Print_48;
            this.guna2Button2.Location = new System.Drawing.Point(372, 507);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
            this.guna2Button2.Size = new System.Drawing.Size(135, 45);
            this.guna2Button2.TabIndex = 4;
            this.guna2Button2.Text = "LISTE";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TFC_ENNOCK.Properties.Resources.User_64;
            this.pictureBox1.Location = new System.Drawing.Point(7, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 143);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // guna2Button1
            // 
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BorderRadius = 21;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Image = global::TFC_ENNOCK.Properties.Resources.Save_as_32;
            this.guna2Button1.Location = new System.Drawing.Point(372, 456);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(275, 45);
            this.guna2Button1.TabIndex = 1;
            this.guna2Button1.Text = "ENREGISTRER";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // ENREGISTREMENT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.guna2Button3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.bunifuCards1);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.guna2GroupBox1);
            this.Name = "ENREGISTREMENT";
            this.Size = new System.Drawing.Size(1155, 705);
            this.Load += new System.EventHandler(this.ENREGISTREMENT_Load);
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.bunifuCards1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2TextBox NOM;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox POSTNOM;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox prenom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton female;
        private System.Windows.Forms.RadioButton Male;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox LIEU;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2DateTimePicker DATE;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private System.Windows.Forms.GroupBox groupBox2;
        private Guna.UI2.WinForms.Guna2ComboBox OPTIONS;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2ComboBox PROMOTION;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}
