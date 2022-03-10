namespace TFC_ENNOCK.ABOUTBOXERS
{
    partial class AUDITOIRE
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PROMOTION = new Guna.UI2.WinForms.Guna2ComboBox();
            this.OPTION = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(289, 150);
            this.dataGridView1.TabIndex = 0;
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
            this.PROMOTION.Location = new System.Drawing.Point(12, 214);
            this.PROMOTION.Name = "PROMOTION";
            this.PROMOTION.ShadowDecoration.Parent = this.PROMOTION;
            this.PROMOTION.Size = new System.Drawing.Size(289, 36);
            this.PROMOTION.TabIndex = 1;
            // 
            // OPTION
            // 
            this.OPTION.BackColor = System.Drawing.Color.Transparent;
            this.OPTION.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.OPTION.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OPTION.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.OPTION.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.OPTION.FocusedState.Parent = this.OPTION;
            this.OPTION.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.OPTION.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.OPTION.HoverState.Parent = this.OPTION;
            this.OPTION.ItemHeight = 30;
            this.OPTION.ItemsAppearance.Parent = this.OPTION;
            this.OPTION.Location = new System.Drawing.Point(12, 304);
            this.OPTION.Name = "OPTION";
            this.OPTION.ShadowDecoration.Parent = this.OPTION;
            this.OPTION.Size = new System.Drawing.Size(289, 36);
            this.OPTION.TabIndex = 2;
            this.OPTION.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox2_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "PROMOTION";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "OPTION";
            // 
            // guna2Button1
            // 
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(15, 373);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(286, 45);
            this.guna2Button1.TabIndex = 5;
            this.guna2Button1.Text = "ENREGISTRER";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AUDITOIRE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 450);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OPTION);
            this.Controls.Add(this.PROMOTION);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AUDITOIRE";
            this.Padding = new System.Windows.Forms.Padding(9);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AUDITOIRE";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Guna.UI2.WinForms.Guna2ComboBox PROMOTION;
        private Guna.UI2.WinForms.Guna2ComboBox OPTION;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.ErrorProvider errorProvider1;

    }
}
