namespace BigData
{
    partial class Sports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sports));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gunaGradientPanel1 = new Guna.UI.WinForms.GunaGradientPanel();
            this.LABEL = new Guna.UI.WinForms.GunaLabel();
            this.CancelBtn = new Guna.UI.WinForms.GunaButton();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.NewBtn = new Guna.UI.WinForms.GunaButton();
            this.gunaPanel2 = new Guna.UI.WinForms.GunaPanel();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.SportsDGV = new Guna.UI.WinForms.GunaDataGridView();
            this.gunaGradientPanel1.SuspendLayout();
            this.gunaPanel1.SuspendLayout();
            this.gunaPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SportsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaGradientPanel1
            // 
            this.gunaGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gunaGradientPanel1.BackgroundImage")));
            this.gunaGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaGradientPanel1.Controls.Add(this.LABEL);
            this.gunaGradientPanel1.Controls.Add(this.CancelBtn);
            this.gunaGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaGradientPanel1.GradientColor1 = System.Drawing.Color.RosyBrown;
            this.gunaGradientPanel1.GradientColor2 = System.Drawing.Color.Gray;
            this.gunaGradientPanel1.GradientColor3 = System.Drawing.Color.Red;
            this.gunaGradientPanel1.GradientColor4 = System.Drawing.Color.Black;
            this.gunaGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaGradientPanel1.Name = "gunaGradientPanel1";
            this.gunaGradientPanel1.Size = new System.Drawing.Size(1082, 38);
            this.gunaGradientPanel1.TabIndex = 0;
            this.gunaGradientPanel1.Text = "gunaGradientPanel1";
            // 
            // LABEL
            // 
            this.LABEL.AutoSize = true;
            this.LABEL.BackColor = System.Drawing.Color.Transparent;
            this.LABEL.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LABEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL.ForeColor = System.Drawing.Color.LimeGreen;
            this.LABEL.Location = new System.Drawing.Point(456, 9);
            this.LABEL.Name = "LABEL";
            this.LABEL.Size = new System.Drawing.Size(182, 24);
            this.LABEL.TabIndex = 41;
            this.LABEL.Text = "ALL ABOUT SPORT";
            // 
            // CancelBtn
            // 
            this.CancelBtn.Animated = true;
            this.CancelBtn.AnimationHoverSpeed = 0.07F;
            this.CancelBtn.AnimationSpeed = 0.03F;
            this.CancelBtn.BackColor = System.Drawing.Color.Transparent;
            this.CancelBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CancelBtn.BackgroundImage")));
            this.CancelBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelBtn.BaseColor = System.Drawing.Color.Transparent;
            this.CancelBtn.BorderColor = System.Drawing.Color.Black;
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.CancelBtn.FocusedColor = System.Drawing.Color.Empty;
            this.CancelBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CancelBtn.ForeColor = System.Drawing.Color.White;
            this.CancelBtn.Image = null;
            this.CancelBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.CancelBtn.Location = new System.Drawing.Point(1037, 0);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.CancelBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.CancelBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.CancelBtn.OnHoverImage = null;
            this.CancelBtn.OnPressedColor = System.Drawing.Color.Black;
            this.CancelBtn.Size = new System.Drawing.Size(42, 32);
            this.CancelBtn.TabIndex = 40;
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gunaPanel1.BackgroundImage")));
            this.gunaPanel1.Controls.Add(this.NewBtn);
            this.gunaPanel1.Controls.Add(this.gunaPanel2);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 38);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(1082, 195);
            this.gunaPanel1.TabIndex = 1;
            this.gunaPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.gunaPanel1_Paint);
            // 
            // NewBtn
            // 
            this.NewBtn.AnimationHoverSpeed = 0.07F;
            this.NewBtn.AnimationSpeed = 0.03F;
            this.NewBtn.BackColor = System.Drawing.Color.Transparent;
            this.NewBtn.BaseColor = System.Drawing.Color.Transparent;
            this.NewBtn.BorderColor = System.Drawing.Color.Black;
            this.NewBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.NewBtn.FocusedColor = System.Drawing.Color.Empty;
            this.NewBtn.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewBtn.ForeColor = System.Drawing.Color.LimeGreen;
            this.NewBtn.Image = ((System.Drawing.Image)(resources.GetObject("NewBtn.Image")));
            this.NewBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.NewBtn.Location = new System.Drawing.Point(922, 147);
            this.NewBtn.Name = "NewBtn";
            this.NewBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.NewBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.NewBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.NewBtn.OnHoverImage = null;
            this.NewBtn.OnPressedColor = System.Drawing.Color.Black;
            this.NewBtn.Size = new System.Drawing.Size(148, 42);
            this.NewBtn.TabIndex = 3;
            this.NewBtn.Text = "Add New";
            this.NewBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NewBtn.Click += new System.EventHandler(this.NewBtn_Click);
            // 
            // gunaPanel2
            // 
            this.gunaPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaPanel2.Controls.Add(this.gunaPictureBox1);
            this.gunaPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.gunaPanel2.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel2.Name = "gunaPanel2";
            this.gunaPanel2.Size = new System.Drawing.Size(391, 195);
            this.gunaPanel2.TabIndex = 2;
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.Image")));
            this.gunaPictureBox1.Location = new System.Drawing.Point(0, 0);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(391, 195);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox1.TabIndex = 0;
            this.gunaPictureBox1.TabStop = false;
            // 
            // SportsDGV
            // 
            this.SportsDGV.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Empty;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Empty;
            this.SportsDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.SportsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SportsDGV.BackgroundColor = System.Drawing.Color.Black;
            this.SportsDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SportsDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SportsDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.SportsDGV.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SportsDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.SportsDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SportsDGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.SportsDGV.EnableHeadersVisualStyles = false;
            this.SportsDGV.GridColor = System.Drawing.Color.Yellow;
            this.SportsDGV.Location = new System.Drawing.Point(0, 233);
            this.SportsDGV.Name = "SportsDGV";
            this.SportsDGV.ReadOnly = true;
            this.SportsDGV.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.RosyBrown;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.SportsDGV.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.SportsDGV.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Transparent;
            this.SportsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SportsDGV.Size = new System.Drawing.Size(1082, 378);
            this.SportsDGV.TabIndex = 2;
            this.SportsDGV.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.SportsDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.SportsDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.SportsDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.SportsDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.SportsDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.SportsDGV.ThemeStyle.BackColor = System.Drawing.Color.Black;
            this.SportsDGV.ThemeStyle.GridColor = System.Drawing.Color.Yellow;
            this.SportsDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.SportsDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            this.SportsDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.SportsDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.SportsDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.SportsDGV.ThemeStyle.HeaderStyle.Height = 4;
            this.SportsDGV.ThemeStyle.ReadOnly = true;
            this.SportsDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.Transparent;
            this.SportsDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.SportsDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.SportsDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.SportsDGV.ThemeStyle.RowsStyle.Height = 22;
            this.SportsDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.SportsDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.SportsDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gunaDataGridView1_CellContentClick);
            // 
            // Sports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 611);
            this.Controls.Add(this.SportsDGV);
            this.Controls.Add(this.gunaPanel1);
            this.Controls.Add(this.gunaGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Sports";
            this.Text = "Sports";
            this.Load += new System.EventHandler(this.Sports_Load);
            this.gunaGradientPanel1.ResumeLayout(false);
            this.gunaGradientPanel1.PerformLayout();
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SportsDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaGradientPanel gunaGradientPanel1;
        private Guna.UI.WinForms.GunaButton CancelBtn;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaPanel gunaPanel2;
        private Guna.UI.WinForms.GunaDataGridView SportsDGV;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaLabel LABEL;
        private Guna.UI.WinForms.GunaButton NewBtn;
    }
}