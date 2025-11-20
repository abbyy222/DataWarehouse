namespace BigData
{
    partial class Staff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Staff));
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.CancelBtn = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.FacT = new Guna.UI.WinForms.GunaLabel();
            this.FacultyC = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.DeptC = new Guna.UI.WinForms.GunaComboBox();
            this.DepCH = new System.Windows.Forms.CheckedListBox();
            this.NameT = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.CertiC = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.gunaComboBox3 = new Guna.UI.WinForms.GunaComboBox();
            this.PositionC = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            this.gunaGradientButton1 = new Guna.UI.WinForms.GunaGradientButton();
            this.FinishBtn = new Guna.UI.WinForms.GunaGradientButton();
            this.gunaLabel9 = new Guna.UI.WinForms.GunaLabel();
            this.StatusC = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel10 = new Guna.UI.WinForms.GunaLabel();
            this.DateT = new Guna.UI.WinForms.GunaDateTimePicker();
            this.gunaPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.Firebrick;
            this.gunaPanel1.Controls.Add(this.CancelBtn);
            this.gunaPanel1.Controls.Add(this.gunaLabel1);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(1084, 42);
            this.gunaPanel1.TabIndex = 0;
            // 
            // CancelBtn
            // 
            this.CancelBtn.Animated = true;
            this.CancelBtn.AnimationHoverSpeed = 0.07F;
            this.CancelBtn.AnimationSpeed = 0.03F;
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
            this.CancelBtn.Location = new System.Drawing.Point(1042, 4);
            this.CancelBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.CancelBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.CancelBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.CancelBtn.OnHoverImage = null;
            this.CancelBtn.OnPressedColor = System.Drawing.Color.Black;
            this.CancelBtn.Size = new System.Drawing.Size(42, 38);
            this.CancelBtn.TabIndex = 39;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.Black;
            this.gunaLabel1.Location = new System.Drawing.Point(485, 9);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(130, 25);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Staff Console";
            // 
            // FacT
            // 
            this.FacT.AutoSize = true;
            this.FacT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FacT.Font = new System.Drawing.Font("Forte", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FacT.ForeColor = System.Drawing.Color.Red;
            this.FacT.Location = new System.Drawing.Point(78, 188);
            this.FacT.Name = "FacT";
            this.FacT.Size = new System.Drawing.Size(97, 26);
            this.FacT.TabIndex = 2;
            this.FacT.Text = "Faculty";
            // 
            // FacultyC
            // 
            this.FacultyC.BackColor = System.Drawing.Color.Transparent;
            this.FacultyC.BaseColor = System.Drawing.Color.LightGray;
            this.FacultyC.BorderColor = System.Drawing.Color.Silver;
            this.FacultyC.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.FacultyC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FacultyC.FocusedColor = System.Drawing.Color.Empty;
            this.FacultyC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FacultyC.ForeColor = System.Drawing.Color.Black;
            this.FacultyC.FormattingEnabled = true;
            this.FacultyC.Items.AddRange(new object[] {
            "Sciences"});
            this.FacultyC.Location = new System.Drawing.Point(426, 188);
            this.FacultyC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FacultyC.Name = "FacultyC";
            this.FacultyC.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.FacultyC.OnHoverItemForeColor = System.Drawing.Color.White;
            this.FacultyC.Size = new System.Drawing.Size(285, 30);
            this.FacultyC.TabIndex = 3;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gunaLabel2.Font = new System.Drawing.Font("Forte", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.Red;
            this.gunaLabel2.Location = new System.Drawing.Point(78, 64);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(140, 26);
            this.gunaLabel2.TabIndex = 4;
            this.gunaLabel2.Text = "Staff Name";
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gunaLabel3.Font = new System.Drawing.Font("Forte", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.Color.Red;
            this.gunaLabel3.Location = new System.Drawing.Point(78, 442);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(278, 26);
            this.gunaLabel3.TabIndex = 5;
            this.gunaLabel3.Text = "No Of Courses Lecturing";
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gunaLabel4.Font = new System.Drawing.Font("Forte", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.ForeColor = System.Drawing.Color.Red;
            this.gunaLabel4.Location = new System.Drawing.Point(78, 349);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(343, 26);
            this.gunaLabel4.TabIndex = 6;
            this.gunaLabel4.Text = "Highest Certification Attained";
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gunaLabel5.Font = new System.Drawing.Font("Forte", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel5.ForeColor = System.Drawing.Color.Red;
            this.gunaLabel5.Location = new System.Drawing.Point(78, 265);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(139, 26);
            this.gunaLabel5.TabIndex = 7;
            this.gunaLabel5.Text = "Department";
            // 
            // DeptC
            // 
            this.DeptC.BackColor = System.Drawing.Color.LightGray;
            this.DeptC.BaseColor = System.Drawing.Color.LightGray;
            this.DeptC.BorderColor = System.Drawing.Color.Silver;
            this.DeptC.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.DeptC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DeptC.FocusedColor = System.Drawing.Color.Empty;
            this.DeptC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeptC.ForeColor = System.Drawing.Color.Black;
            this.DeptC.FormattingEnabled = true;
            this.DeptC.Items.AddRange(new object[] {
            "Mathematics&ComputerScience"});
            this.DeptC.Location = new System.Drawing.Point(426, 270);
            this.DeptC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DeptC.Name = "DeptC";
            this.DeptC.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DeptC.OnHoverItemForeColor = System.Drawing.Color.White;
            this.DeptC.Size = new System.Drawing.Size(285, 30);
            this.DeptC.TabIndex = 8;
            this.DeptC.SelectedIndexChanged += new System.EventHandler(this.DeptC_SelectedIndexChanged);
            // 
            // DepCH
            // 
            this.DepCH.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.DepCH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepCH.FormattingEnabled = true;
            this.DepCH.Items.AddRange(new object[] {
            ""});
            this.DepCH.Location = new System.Drawing.Point(426, 442);
            this.DepCH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DepCH.Name = "DepCH";
            this.DepCH.Size = new System.Drawing.Size(285, 130);
            this.DepCH.TabIndex = 29;
            // 
            // NameT
            // 
            this.NameT.BackColor = System.Drawing.Color.LightGray;
            this.NameT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NameT.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.NameT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameT.LineColor = System.Drawing.Color.Gainsboro;
            this.NameT.Location = new System.Drawing.Point(426, 64);
            this.NameT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NameT.Name = "NameT";
            this.NameT.PasswordChar = '\0';
            this.NameT.SelectedText = "";
            this.NameT.Size = new System.Drawing.Size(285, 42);
            this.NameT.TabIndex = 30;
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gunaLabel6.Font = new System.Drawing.Font("Forte", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel6.ForeColor = System.Drawing.Color.Red;
            this.gunaLabel6.Location = new System.Drawing.Point(78, 626);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(125, 26);
            this.gunaLabel6.TabIndex = 31;
            this.gunaLabel6.Text = "Net Worth";
            // 
            // CertiC
            // 
            this.CertiC.BackColor = System.Drawing.Color.LightGray;
            this.CertiC.BaseColor = System.Drawing.Color.LightGray;
            this.CertiC.BorderColor = System.Drawing.Color.Silver;
            this.CertiC.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CertiC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CertiC.FocusedColor = System.Drawing.Color.Empty;
            this.CertiC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CertiC.ForeColor = System.Drawing.Color.Black;
            this.CertiC.FormattingEnabled = true;
            this.CertiC.Items.AddRange(new object[] {
            "BSC\\HND\\OND",
            "M.S.Ed",
            "PhD",
            ""});
            this.CertiC.Location = new System.Drawing.Point(426, 345);
            this.CertiC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CertiC.Name = "CertiC";
            this.CertiC.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.CertiC.OnHoverItemForeColor = System.Drawing.Color.White;
            this.CertiC.Size = new System.Drawing.Size(285, 30);
            this.CertiC.TabIndex = 32;
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoSize = true;
            this.gunaLabel7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gunaLabel7.Font = new System.Drawing.Font("Forte", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel7.ForeColor = System.Drawing.Color.Red;
            this.gunaLabel7.Location = new System.Drawing.Point(392, 626);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(29, 26);
            this.gunaLabel7.TabIndex = 33;
            this.gunaLabel7.Text = "#";
            // 
            // gunaComboBox3
            // 
            this.gunaComboBox3.BackColor = System.Drawing.Color.LightGray;
            this.gunaComboBox3.BaseColor = System.Drawing.Color.LightGray;
            this.gunaComboBox3.BorderColor = System.Drawing.Color.Silver;
            this.gunaComboBox3.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.gunaComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gunaComboBox3.FocusedColor = System.Drawing.Color.Empty;
            this.gunaComboBox3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gunaComboBox3.ForeColor = System.Drawing.Color.Black;
            this.gunaComboBox3.FormattingEnabled = true;
            this.gunaComboBox3.Items.AddRange(new object[] {
            "Mathematics&ComputerScience"});
            this.gunaComboBox3.Location = new System.Drawing.Point(427, 626);
            this.gunaComboBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gunaComboBox3.Name = "gunaComboBox3";
            this.gunaComboBox3.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaComboBox3.OnHoverItemForeColor = System.Drawing.Color.White;
            this.gunaComboBox3.Size = new System.Drawing.Size(74, 26);
            this.gunaComboBox3.TabIndex = 34;
            // 
            // PositionC
            // 
            this.PositionC.BackColor = System.Drawing.Color.Transparent;
            this.PositionC.BaseColor = System.Drawing.Color.LightGray;
            this.PositionC.BorderColor = System.Drawing.Color.Silver;
            this.PositionC.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.PositionC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PositionC.FocusedColor = System.Drawing.Color.Empty;
            this.PositionC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PositionC.ForeColor = System.Drawing.Color.Black;
            this.PositionC.FormattingEnabled = true;
            this.PositionC.Items.AddRange(new object[] {
            "Vice-Chancellor",
            "Deputy Vice-Chancellor",
            "Registrar",
            "Vice President Student Services",
            "Deputy Vice President Student services",
            "Deputy Bursar",
            "University Librarian",
            "Deen",
            "HOD",
            "Lecturer",
            "Hall Admin",
            "Chief Security Officer ",
            "Security Officers",
            "Cafeteria Staffs",
            "Others",
            ""});
            this.PositionC.Location = new System.Drawing.Point(426, 133);
            this.PositionC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PositionC.Name = "PositionC";
            this.PositionC.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.PositionC.OnHoverItemForeColor = System.Drawing.Color.White;
            this.PositionC.Size = new System.Drawing.Size(285, 30);
            this.PositionC.TabIndex = 36;
            this.PositionC.SelectedIndexChanged += new System.EventHandler(this.PositionC_SelectedIndexChanged);
            // 
            // gunaLabel8
            // 
            this.gunaLabel8.AutoSize = true;
            this.gunaLabel8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gunaLabel8.Font = new System.Drawing.Font("Forte", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel8.ForeColor = System.Drawing.Color.Red;
            this.gunaLabel8.Location = new System.Drawing.Point(78, 133);
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.Size = new System.Drawing.Size(103, 26);
            this.gunaLabel8.TabIndex = 35;
            this.gunaLabel8.Text = "Position";
            // 
            // gunaGradientButton1
            // 
            this.gunaGradientButton1.AnimationHoverSpeed = 0.07F;
            this.gunaGradientButton1.AnimationSpeed = 0.03F;
            this.gunaGradientButton1.BaseColor1 = System.Drawing.Color.Red;
            this.gunaGradientButton1.BaseColor2 = System.Drawing.Color.IndianRed;
            this.gunaGradientButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaGradientButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaGradientButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaGradientButton1.ForeColor = System.Drawing.Color.White;
            this.gunaGradientButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaGradientButton1.Image")));
            this.gunaGradientButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaGradientButton1.Location = new System.Drawing.Point(926, 638);
            this.gunaGradientButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gunaGradientButton1.Name = "gunaGradientButton1";
            this.gunaGradientButton1.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.gunaGradientButton1.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.gunaGradientButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaGradientButton1.OnHoverImage = null;
            this.gunaGradientButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaGradientButton1.Size = new System.Drawing.Size(160, 49);
            this.gunaGradientButton1.TabIndex = 37;
            this.gunaGradientButton1.Text = "Finish";
            this.gunaGradientButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FinishBtn
            // 
            this.FinishBtn.Animated = true;
            this.FinishBtn.AnimationHoverSpeed = 0.07F;
            this.FinishBtn.AnimationSpeed = 0.03F;
            this.FinishBtn.BaseColor1 = System.Drawing.Color.IndianRed;
            this.FinishBtn.BaseColor2 = System.Drawing.Color.Red;
            this.FinishBtn.BorderColor = System.Drawing.Color.Black;
            this.FinishBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.FinishBtn.FocusedColor = System.Drawing.Color.Empty;
            this.FinishBtn.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinishBtn.ForeColor = System.Drawing.Color.Black;
            this.FinishBtn.Image = ((System.Drawing.Image)(resources.GetObject("FinishBtn.Image")));
            this.FinishBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.FinishBtn.Location = new System.Drawing.Point(912, 551);
            this.FinishBtn.Name = "FinishBtn";
            this.FinishBtn.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.FinishBtn.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.FinishBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.FinishBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.FinishBtn.OnHoverImage = null;
            this.FinishBtn.OnPressedColor = System.Drawing.Color.Black;
            this.FinishBtn.Size = new System.Drawing.Size(160, 42);
            this.FinishBtn.TabIndex = 38;
            this.FinishBtn.Text = "FINISH";
            this.FinishBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FinishBtn.Click += new System.EventHandler(this.FinishBtn_Click);
            // 
            // gunaLabel9
            // 
            this.gunaLabel9.AutoSize = true;
            this.gunaLabel9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gunaLabel9.Font = new System.Drawing.Font("Forte", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel9.ForeColor = System.Drawing.Color.Red;
            this.gunaLabel9.Location = new System.Drawing.Point(896, 366);
            this.gunaLabel9.Name = "gunaLabel9";
            this.gunaLabel9.Size = new System.Drawing.Size(83, 26);
            this.gunaLabel9.TabIndex = 39;
            this.gunaLabel9.Text = "Status";
            // 
            // StatusC
            // 
            this.StatusC.BackColor = System.Drawing.Color.Transparent;
            this.StatusC.BaseColor = System.Drawing.Color.LightGray;
            this.StatusC.BorderColor = System.Drawing.Color.Silver;
            this.StatusC.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.StatusC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StatusC.FocusedColor = System.Drawing.Color.Empty;
            this.StatusC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusC.ForeColor = System.Drawing.Color.Black;
            this.StatusC.FormattingEnabled = true;
            this.StatusC.Items.AddRange(new object[] {
            "Working",
            "Suspended ",
            "Resigned"});
            this.StatusC.Location = new System.Drawing.Point(841, 396);
            this.StatusC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StatusC.Name = "StatusC";
            this.StatusC.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.StatusC.OnHoverItemForeColor = System.Drawing.Color.White;
            this.StatusC.Size = new System.Drawing.Size(209, 30);
            this.StatusC.TabIndex = 40;
            // 
            // gunaLabel10
            // 
            this.gunaLabel10.AutoSize = true;
            this.gunaLabel10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gunaLabel10.Font = new System.Drawing.Font("Forte", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel10.ForeColor = System.Drawing.Color.Red;
            this.gunaLabel10.Location = new System.Drawing.Point(836, 157);
            this.gunaLabel10.Name = "gunaLabel10";
            this.gunaLabel10.Size = new System.Drawing.Size(185, 26);
            this.gunaLabel10.TabIndex = 41;
            this.gunaLabel10.Text = "Date Employed";
            // 
            // DateT
            // 
            this.DateT.BaseColor = System.Drawing.Color.LightGray;
            this.DateT.BorderColor = System.Drawing.Color.Silver;
            this.DateT.CustomFormat = null;
            this.DateT.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.DateT.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DateT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DateT.ForeColor = System.Drawing.Color.Black;
            this.DateT.Location = new System.Drawing.Point(827, 215);
            this.DateT.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateT.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DateT.Name = "DateT";
            this.DateT.OnHoverBaseColor = System.Drawing.Color.White;
            this.DateT.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DateT.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DateT.OnPressedColor = System.Drawing.Color.Black;
            this.DateT.Size = new System.Drawing.Size(223, 30);
            this.DateT.TabIndex = 42;
            this.DateT.Text = "Monday, January 13, 2025";
            this.DateT.Value = new System.DateTime(2025, 1, 13, 9, 23, 10, 151);
            // 
            // Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1084, 605);
            this.Controls.Add(this.DateT);
            this.Controls.Add(this.gunaLabel10);
            this.Controls.Add(this.StatusC);
            this.Controls.Add(this.gunaLabel9);
            this.Controls.Add(this.FinishBtn);
            this.Controls.Add(this.gunaGradientButton1);
            this.Controls.Add(this.PositionC);
            this.Controls.Add(this.gunaLabel8);
            this.Controls.Add(this.gunaComboBox3);
            this.Controls.Add(this.gunaLabel7);
            this.Controls.Add(this.CertiC);
            this.Controls.Add(this.gunaLabel6);
            this.Controls.Add(this.NameT);
            this.Controls.Add(this.DepCH);
            this.Controls.Add(this.DeptC);
            this.Controls.Add(this.gunaLabel5);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.FacultyC);
            this.Controls.Add(this.FacT);
            this.Controls.Add(this.gunaPanel1);
            this.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Staff";
            this.Text = " n";
            this.Load += new System.EventHandler(this.Staff_Load);
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaButton CancelBtn;
        private Guna.UI.WinForms.GunaLabel FacT;
        private Guna.UI.WinForms.GunaComboBox FacultyC;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaComboBox DeptC;
        private System.Windows.Forms.CheckedListBox DepCH;
        private Guna.UI.WinForms.GunaLineTextBox NameT;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaComboBox CertiC;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI.WinForms.GunaComboBox gunaComboBox3;
        private Guna.UI.WinForms.GunaComboBox PositionC;
        private Guna.UI.WinForms.GunaLabel gunaLabel8;
        private Guna.UI.WinForms.GunaGradientButton gunaGradientButton1;
        private Guna.UI.WinForms.GunaGradientButton FinishBtn;
        private Guna.UI.WinForms.GunaLabel gunaLabel9;
        private Guna.UI.WinForms.GunaComboBox StatusC;
        private Guna.UI.WinForms.GunaLabel gunaLabel10;
        private Guna.UI.WinForms.GunaDateTimePicker DateT;
    }
}