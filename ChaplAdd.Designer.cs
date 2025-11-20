namespace BigData
{
    partial class ChaplAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChaplAdd));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.MatricT = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.FirstC = new Guna.UI.WinForms.GunaComboBox();
            this.ThirdC = new Guna.UI.WinForms.GunaComboBox();
            this.SecondC = new Guna.UI.WinForms.GunaComboBox();
            this.FourthC = new Guna.UI.WinForms.GunaComboBox();
            this.FifthC = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.YesCH = new Guna.UI.WinForms.GunaCheckBox();
            this.NoCH = new Guna.UI.WinForms.GunaCheckBox();
            this.PosiT = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.NoD = new Guna.UI.WinForms.GunaCheckBox();
            this.YesD = new Guna.UI.WinForms.GunaCheckBox();
            this.DemT = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLabel5 = new Guna.UI.WinForms.GunaLabel();
            this.FinishBtn = new Guna.UI.WinForms.GunaGradientButton();
            this.gunaGradientPanel1 = new Guna.UI.WinForms.GunaGradientPanel();
            this.CancelBtn = new Guna.UI.WinForms.GunaButton();
            this.RemT = new Bunifu.UI.WinForms.BunifuTextBox();
            this.timerComboAnimation = new System.Windows.Forms.Timer(this.components);
            this.gunaGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(33, 82);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(275, 25);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Enter Matriculation Number";
            // 
            // MatricT
            // 
            this.MatricT.BackColor = System.Drawing.Color.Peru;
            this.MatricT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MatricT.FocusedLineColor = System.Drawing.Color.Black;
            this.MatricT.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MatricT.LineColor = System.Drawing.Color.Gainsboro;
            this.MatricT.Location = new System.Drawing.Point(339, 82);
            this.MatricT.Name = "MatricT";
            this.MatricT.PasswordChar = '\0';
            this.MatricT.SelectedText = "";
            this.MatricT.Size = new System.Drawing.Size(291, 33);
            this.MatricT.TabIndex = 1;
            this.MatricT.TextChanged += new System.EventHandler(this.MatricT_TextChanged);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(259, 150);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(563, 25);
            this.gunaLabel2.TabIndex = 2;
            this.gunaLabel2.Text = "Worship Centers Attended From 100Level- Till Convocation";
            // 
            // FirstC
            // 
            this.FirstC.BackColor = System.Drawing.Color.Transparent;
            this.FirstC.BaseColor = System.Drawing.Color.Transparent;
            this.FirstC.BorderColor = System.Drawing.Color.Black;
            this.FirstC.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.FirstC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FirstC.FocusedColor = System.Drawing.Color.Empty;
            this.FirstC.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstC.ForeColor = System.Drawing.Color.Black;
            this.FirstC.FormattingEnabled = true;
            this.FirstC.Items.AddRange(new object[] {
            "Emmanuel Chapel",
            "Homeland Chapel",
            "Beulah Chapel",
            "Praise Chapel"});
            this.FirstC.Location = new System.Drawing.Point(38, 223);
            this.FirstC.Name = "FirstC";
            this.FirstC.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.FirstC.OnHoverItemForeColor = System.Drawing.Color.White;
            this.FirstC.Size = new System.Drawing.Size(196, 34);
            this.FirstC.TabIndex = 3;
            // 
            // ThirdC
            // 
            this.ThirdC.BackColor = System.Drawing.Color.Transparent;
            this.ThirdC.BaseColor = System.Drawing.Color.Transparent;
            this.ThirdC.BorderColor = System.Drawing.Color.Black;
            this.ThirdC.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ThirdC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ThirdC.FocusedColor = System.Drawing.Color.Empty;
            this.ThirdC.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThirdC.ForeColor = System.Drawing.Color.Black;
            this.ThirdC.FormattingEnabled = true;
            this.ThirdC.Items.AddRange(new object[] {
            "Emmanuel Chapel",
            "Homeland Chapel",
            "Beulah Chapel",
            "Praise Chapel"});
            this.ThirdC.Location = new System.Drawing.Point(544, 223);
            this.ThirdC.Name = "ThirdC";
            this.ThirdC.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ThirdC.OnHoverItemForeColor = System.Drawing.Color.White;
            this.ThirdC.Size = new System.Drawing.Size(196, 34);
            this.ThirdC.TabIndex = 4;
            // 
            // SecondC
            // 
            this.SecondC.BackColor = System.Drawing.Color.Transparent;
            this.SecondC.BaseColor = System.Drawing.Color.Transparent;
            this.SecondC.BorderColor = System.Drawing.Color.Black;
            this.SecondC.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.SecondC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SecondC.FocusedColor = System.Drawing.Color.Empty;
            this.SecondC.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecondC.ForeColor = System.Drawing.Color.Black;
            this.SecondC.FormattingEnabled = true;
            this.SecondC.Items.AddRange(new object[] {
            "Emmanuel Chapel",
            "Homeland Chapel",
            "Beulah Chapel",
            "Praise Chapel"});
            this.SecondC.Location = new System.Drawing.Point(293, 223);
            this.SecondC.Name = "SecondC";
            this.SecondC.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.SecondC.OnHoverItemForeColor = System.Drawing.Color.White;
            this.SecondC.Size = new System.Drawing.Size(196, 34);
            this.SecondC.TabIndex = 5;
            // 
            // FourthC
            // 
            this.FourthC.BackColor = System.Drawing.Color.Transparent;
            this.FourthC.BaseColor = System.Drawing.Color.Transparent;
            this.FourthC.BorderColor = System.Drawing.Color.Black;
            this.FourthC.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.FourthC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FourthC.FocusedColor = System.Drawing.Color.Empty;
            this.FourthC.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FourthC.ForeColor = System.Drawing.Color.Black;
            this.FourthC.FormattingEnabled = true;
            this.FourthC.Items.AddRange(new object[] {
            "Emmanuel Chapel",
            "Homeland Chapel",
            "Beulah Chapel",
            "Praise Chapel"});
            this.FourthC.Location = new System.Drawing.Point(823, 223);
            this.FourthC.Name = "FourthC";
            this.FourthC.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.FourthC.OnHoverItemForeColor = System.Drawing.Color.White;
            this.FourthC.Size = new System.Drawing.Size(196, 34);
            this.FourthC.TabIndex = 6;
            // 
            // FifthC
            // 
            this.FifthC.BackColor = System.Drawing.Color.Transparent;
            this.FifthC.BaseColor = System.Drawing.Color.Transparent;
            this.FifthC.BorderColor = System.Drawing.Color.Black;
            this.FifthC.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.FifthC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FifthC.FocusedColor = System.Drawing.Color.Empty;
            this.FifthC.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FifthC.ForeColor = System.Drawing.Color.Black;
            this.FifthC.FormattingEnabled = true;
            this.FifthC.Items.AddRange(new object[] {
            "Emmanuel Chapel",
            "Homeland Chapel",
            "Beulah Chapel",
            "Praise Chapel"});
            this.FifthC.Location = new System.Drawing.Point(441, 273);
            this.FifthC.Name = "FifthC";
            this.FifthC.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.FifthC.OnHoverItemForeColor = System.Drawing.Color.White;
            this.FifthC.Size = new System.Drawing.Size(196, 34);
            this.FifthC.TabIndex = 7;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(33, 361);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(138, 25);
            this.gunaLabel3.TabIndex = 8;
            this.gunaLabel3.Text = "Position Held";
            // 
            // YesCH
            // 
            this.YesCH.BaseColor = System.Drawing.Color.White;
            this.YesCH.CheckedOffColor = System.Drawing.Color.Gray;
            this.YesCH.CheckedOnColor = System.Drawing.Color.Black;
            this.YesCH.FillColor = System.Drawing.Color.White;
            this.YesCH.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YesCH.Location = new System.Drawing.Point(193, 364);
            this.YesCH.Name = "YesCH";
            this.YesCH.Size = new System.Drawing.Size(58, 21);
            this.YesCH.TabIndex = 9;
            this.YesCH.Text = "Yes";
            this.YesCH.CheckedChanged += new System.EventHandler(this.YesCH_CheckedChanged);
            // 
            // NoCH
            // 
            this.NoCH.BaseColor = System.Drawing.Color.White;
            this.NoCH.CheckedOffColor = System.Drawing.Color.Gray;
            this.NoCH.CheckedOnColor = System.Drawing.Color.Black;
            this.NoCH.FillColor = System.Drawing.Color.White;
            this.NoCH.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoCH.Location = new System.Drawing.Point(263, 364);
            this.NoCH.Name = "NoCH";
            this.NoCH.Size = new System.Drawing.Size(51, 21);
            this.NoCH.TabIndex = 10;
            this.NoCH.Text = "No";
            this.NoCH.CheckedChanged += new System.EventHandler(this.NoCH_CheckedChanged);
            // 
            // PosiT
            // 
            this.PosiT.Animated = true;
            this.PosiT.BackColor = System.Drawing.Color.Peru;
            this.PosiT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PosiT.FocusedLineColor = System.Drawing.Color.Black;
            this.PosiT.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PosiT.LineColor = System.Drawing.Color.Gainsboro;
            this.PosiT.Location = new System.Drawing.Point(38, 399);
            this.PosiT.Name = "PosiT";
            this.PosiT.PasswordChar = '\0';
            this.PosiT.SelectedText = "";
            this.PosiT.Size = new System.Drawing.Size(291, 33);
            this.PosiT.TabIndex = 11;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.Location = new System.Drawing.Point(759, 361);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(88, 25);
            this.gunaLabel4.TabIndex = 12;
            this.gunaLabel4.Text = "Demerit";
            // 
            // NoD
            // 
            this.NoD.BaseColor = System.Drawing.Color.White;
            this.NoD.CheckedOffColor = System.Drawing.Color.Gray;
            this.NoD.CheckedOnColor = System.Drawing.Color.Black;
            this.NoD.FillColor = System.Drawing.Color.White;
            this.NoD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoD.Location = new System.Drawing.Point(939, 362);
            this.NoD.Name = "NoD";
            this.NoD.Size = new System.Drawing.Size(51, 21);
            this.NoD.TabIndex = 14;
            this.NoD.Text = "No";
            this.NoD.CheckedChanged += new System.EventHandler(this.NoD_CheckedChanged);
            // 
            // YesD
            // 
            this.YesD.BaseColor = System.Drawing.Color.White;
            this.YesD.CheckedOffColor = System.Drawing.Color.Gray;
            this.YesD.CheckedOnColor = System.Drawing.Color.Black;
            this.YesD.FillColor = System.Drawing.Color.White;
            this.YesD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YesD.Location = new System.Drawing.Point(870, 364);
            this.YesD.Name = "YesD";
            this.YesD.Size = new System.Drawing.Size(58, 21);
            this.YesD.TabIndex = 13;
            this.YesD.Text = "Yes";
            this.YesD.CheckedChanged += new System.EventHandler(this.YesD_CheckedChanged);
            // 
            // DemT
            // 
            this.DemT.Animated = true;
            this.DemT.BackColor = System.Drawing.Color.Peru;
            this.DemT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.DemT.FocusedLineColor = System.Drawing.Color.Black;
            this.DemT.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DemT.LineColor = System.Drawing.Color.Gainsboro;
            this.DemT.Location = new System.Drawing.Point(764, 399);
            this.DemT.Name = "DemT";
            this.DemT.PasswordChar = '\0';
            this.DemT.SelectedText = "";
            this.DemT.Size = new System.Drawing.Size(201, 33);
            this.DemT.TabIndex = 15;
            // 
            // gunaLabel5
            // 
            this.gunaLabel5.AutoSize = true;
            this.gunaLabel5.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel5.Location = new System.Drawing.Point(460, 407);
            this.gunaLabel5.Name = "gunaLabel5";
            this.gunaLabel5.Size = new System.Drawing.Size(93, 25);
            this.gunaLabel5.TabIndex = 16;
            this.gunaLabel5.Text = "Remarks";
            // 
            // FinishBtn
            // 
            this.FinishBtn.Animated = true;
            this.FinishBtn.AnimationHoverSpeed = 0.07F;
            this.FinishBtn.AnimationSpeed = 0.03F;
            this.FinishBtn.BaseColor1 = System.Drawing.Color.Transparent;
            this.FinishBtn.BaseColor2 = System.Drawing.Color.Crimson;
            this.FinishBtn.BorderColor = System.Drawing.Color.Black;
            this.FinishBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.FinishBtn.FocusedColor = System.Drawing.Color.Empty;
            this.FinishBtn.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinishBtn.ForeColor = System.Drawing.Color.White;
            this.FinishBtn.Image = ((System.Drawing.Image)(resources.GetObject("FinishBtn.Image")));
            this.FinishBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.FinishBtn.Location = new System.Drawing.Point(907, 552);
            this.FinishBtn.Name = "FinishBtn";
            this.FinishBtn.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.FinishBtn.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.FinishBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.FinishBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.FinishBtn.OnHoverImage = null;
            this.FinishBtn.OnPressedColor = System.Drawing.Color.Black;
            this.FinishBtn.Size = new System.Drawing.Size(160, 42);
            this.FinishBtn.TabIndex = 18;
            this.FinishBtn.Text = "FINISH";
            this.FinishBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FinishBtn.Click += new System.EventHandler(this.FinishBtn_Click);
            // 
            // gunaGradientPanel1
            // 
            this.gunaGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gunaGradientPanel1.BackgroundImage")));
            this.gunaGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaGradientPanel1.Controls.Add(this.CancelBtn);
            this.gunaGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaGradientPanel1.GradientColor1 = System.Drawing.Color.Peru;
            this.gunaGradientPanel1.GradientColor2 = System.Drawing.Color.Chocolate;
            this.gunaGradientPanel1.GradientColor3 = System.Drawing.Color.Black;
            this.gunaGradientPanel1.GradientColor4 = System.Drawing.Color.Red;
            this.gunaGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaGradientPanel1.Name = "gunaGradientPanel1";
            this.gunaGradientPanel1.Size = new System.Drawing.Size(1079, 37);
            this.gunaGradientPanel1.TabIndex = 19;
            this.gunaGradientPanel1.Text = "gunaGradientPanel1";
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
            this.CancelBtn.Location = new System.Drawing.Point(1025, 3);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.CancelBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.CancelBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.CancelBtn.OnHoverImage = null;
            this.CancelBtn.OnPressedColor = System.Drawing.Color.Black;
            this.CancelBtn.Size = new System.Drawing.Size(42, 32);
            this.CancelBtn.TabIndex = 39;
            // 
            // RemT
            // 
            this.RemT.AcceptsReturn = false;
            this.RemT.AcceptsTab = false;
            this.RemT.AnimationSpeed = 200;
            this.RemT.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.RemT.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.RemT.BackColor = System.Drawing.Color.Transparent;
            this.RemT.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RemT.BackgroundImage")));
            this.RemT.BorderColorActive = System.Drawing.Color.OrangeRed;
            this.RemT.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.RemT.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.RemT.BorderColorIdle = System.Drawing.Color.Black;
            this.RemT.BorderRadius = 1;
            this.RemT.BorderThickness = 3;
            this.RemT.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.RemT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RemT.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemT.DefaultText = "";
            this.RemT.FillColor = System.Drawing.Color.Peru;
            this.RemT.HideSelection = true;
            this.RemT.IconLeft = null;
            this.RemT.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.RemT.IconPadding = 10;
            this.RemT.IconRight = null;
            this.RemT.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.RemT.Lines = new string[0];
            this.RemT.Location = new System.Drawing.Point(356, 449);
            this.RemT.MaxLength = 32767;
            this.RemT.MinimumSize = new System.Drawing.Size(1, 1);
            this.RemT.Modified = false;
            this.RemT.Multiline = true;
            this.RemT.Name = "RemT";
            stateProperties5.BorderColor = System.Drawing.Color.OrangeRed;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.RemT.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.RemT.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.RemT.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Black;
            stateProperties8.FillColor = System.Drawing.Color.Peru;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.RemT.OnIdleState = stateProperties8;
            this.RemT.Padding = new System.Windows.Forms.Padding(3);
            this.RemT.PasswordChar = '\0';
            this.RemT.PlaceholderForeColor = System.Drawing.Color.Black;
            this.RemT.PlaceholderText = "Enter text";
            this.RemT.ReadOnly = false;
            this.RemT.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.RemT.SelectedText = "";
            this.RemT.SelectionLength = 0;
            this.RemT.SelectionStart = 0;
            this.RemT.ShortcutsEnabled = true;
            this.RemT.Size = new System.Drawing.Size(400, 158);
            this.RemT.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.RemT.TabIndex = 20;
            this.RemT.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.RemT.TextMarginBottom = 0;
            this.RemT.TextMarginLeft = 3;
            this.RemT.TextMarginTop = 0;
            this.RemT.TextPlaceholder = "Enter text";
            this.RemT.UseSystemPasswordChar = false;
            this.RemT.WordWrap = true;
            // 
            // timerComboAnimation
            // 
            this.timerComboAnimation.Interval = 50;
            this.timerComboAnimation.Tick += new System.EventHandler(this.timerComboAnimation_Tick);
            // 
            // ChaplAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(1079, 606);
            this.Controls.Add(this.RemT);
            this.Controls.Add(this.gunaGradientPanel1);
            this.Controls.Add(this.FinishBtn);
            this.Controls.Add(this.gunaLabel5);
            this.Controls.Add(this.DemT);
            this.Controls.Add(this.NoD);
            this.Controls.Add(this.YesD);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.PosiT);
            this.Controls.Add(this.NoCH);
            this.Controls.Add(this.YesCH);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.FifthC);
            this.Controls.Add(this.FourthC);
            this.Controls.Add(this.SecondC);
            this.Controls.Add(this.ThirdC);
            this.Controls.Add(this.FirstC);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.MatricT);
            this.Controls.Add(this.gunaLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChaplAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChaplAdd";
            this.Load += new System.EventHandler(this.ChaplAdd_Load);
            this.gunaGradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLineTextBox MatricT;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaComboBox FirstC;
        private Guna.UI.WinForms.GunaComboBox ThirdC;
        private Guna.UI.WinForms.GunaComboBox SecondC;
        private Guna.UI.WinForms.GunaComboBox FourthC;
        private Guna.UI.WinForms.GunaComboBox FifthC;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaCheckBox YesCH;
        private Guna.UI.WinForms.GunaCheckBox NoCH;
        private Guna.UI.WinForms.GunaLineTextBox PosiT;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaCheckBox NoD;
        private Guna.UI.WinForms.GunaCheckBox YesD;
        private Guna.UI.WinForms.GunaLineTextBox DemT;
        private Guna.UI.WinForms.GunaLabel gunaLabel5;
        private Guna.UI.WinForms.GunaGradientButton FinishBtn;
        private Guna.UI.WinForms.GunaGradientPanel gunaGradientPanel1;
        private Guna.UI.WinForms.GunaButton CancelBtn;
        private Bunifu.UI.WinForms.BunifuTextBox RemT;
        private System.Windows.Forms.Timer timerComboAnimation;
    }
}