namespace BigData
{
    partial class Info
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Info));
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.TextT = new Guna.UI.WinForms.GunaTextBox();
            this.ProceedBtn = new Guna.UI.WinForms.GunaButton();
            this.SuspendLayout();
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gunaLabel1.Font = new System.Drawing.Font("Harlow Solid Italic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.Gold;
            this.gunaLabel1.Location = new System.Drawing.Point(233, 10);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(112, 26);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Welcome!!!";
            // 
            // TextT
            // 
            this.TextT.BaseColor = System.Drawing.Color.Black;
            this.TextT.BorderColor = System.Drawing.Color.Gold;
            this.TextT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextT.FocusedBaseColor = System.Drawing.Color.Black;
            this.TextT.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TextT.FocusedForeColor = System.Drawing.Color.Yellow;
            this.TextT.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextT.ForeColor = System.Drawing.Color.Gold;
            this.TextT.Location = new System.Drawing.Point(31, 39);
            this.TextT.Multiline = true;
            this.TextT.Name = "TextT";
            this.TextT.PasswordChar = '\0';
            this.TextT.ReadOnly = true;
            this.TextT.SelectedText = "";
            this.TextT.Size = new System.Drawing.Size(523, 188);
            this.TextT.TabIndex = 1;
            this.TextT.Text = resources.GetString("TextT.Text");
            // 
            // ProceedBtn
            // 
            this.ProceedBtn.Animated = true;
            this.ProceedBtn.AnimationHoverSpeed = 0.04F;
            this.ProceedBtn.AnimationSpeed = 0.07F;
            this.ProceedBtn.BaseColor = System.Drawing.Color.Transparent;
            this.ProceedBtn.BorderColor = System.Drawing.Color.Gold;
            this.ProceedBtn.BorderSize = 2;
            this.ProceedBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ProceedBtn.FocusedColor = System.Drawing.Color.Empty;
            this.ProceedBtn.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProceedBtn.ForeColor = System.Drawing.Color.Gold;
            this.ProceedBtn.Image = null;
            this.ProceedBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.ProceedBtn.Location = new System.Drawing.Point(409, 233);
            this.ProceedBtn.Name = "ProceedBtn";
            this.ProceedBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.ProceedBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.ProceedBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.ProceedBtn.OnHoverImage = null;
            this.ProceedBtn.OnPressedColor = System.Drawing.Color.Black;
            this.ProceedBtn.Size = new System.Drawing.Size(160, 42);
            this.ProceedBtn.TabIndex = 2;
            this.ProceedBtn.Text = "Proceed";
            this.ProceedBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ProceedBtn.Click += new System.EventHandler(this.ProceedBtn_Click);
            // 
            // Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.ProceedBtn);
            this.Controls.Add(this.TextT);
            this.Controls.Add(this.gunaLabel1);
            this.Name = "Info";
            this.Size = new System.Drawing.Size(581, 280);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaTextBox TextT;
        private Guna.UI.WinForms.GunaButton ProceedBtn;
    }
}
