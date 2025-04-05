namespace SistemaRestaurante
{
    partial class FRM_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Login));
            tableLayoutPanel1 = new TableLayoutPanel();
            TxtUsername = new TextBox();
            TxtPassword = new TextBox();
            LblNombreUsuario = new Label();
            LblPassword = new Label();
            panel1 = new Panel();
            LblForgotPassword = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            chkShowPassword = new CheckBox();
            BtnLogin = new Button();
            panel3 = new Panel();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.8F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 61.2F));
            tableLayoutPanel1.Controls.Add(TxtUsername, 1, 0);
            tableLayoutPanel1.Controls.Add(TxtPassword, 1, 1);
            tableLayoutPanel1.Controls.Add(LblNombreUsuario, 0, 0);
            tableLayoutPanel1.Controls.Add(LblPassword, 0, 1);
            tableLayoutPanel1.Location = new Point(92, 36);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(416, 84);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // TxtUsername
            // 
            TxtUsername.ForeColor = SystemColors.ControlText;
            TxtUsername.Location = new Point(164, 3);
            TxtUsername.Name = "TxtUsername";
            TxtUsername.PlaceholderText = "Ingrese su nombre de usuario";
            TxtUsername.Size = new Size(249, 31);
            TxtUsername.TabIndex = 0;
            TxtUsername.TextChanged += TxtUsername_TextChanged;
            // 
            // TxtPassword
            // 
            TxtPassword.ForeColor = SystemColors.ControlText;
            TxtPassword.Location = new Point(164, 45);
            TxtPassword.Name = "TxtPassword";
            TxtPassword.PasswordChar = '*';
            TxtPassword.PlaceholderText = "Ingrese la contraseña";
            TxtPassword.Size = new Size(249, 31);
            TxtPassword.TabIndex = 1;
            TxtPassword.TextAlign = HorizontalAlignment.Center;
            TxtPassword.TextChanged += TxtPassword_TextChanged;
            // 
            // LblNombreUsuario
            // 
            LblNombreUsuario.AutoSize = true;
            LblNombreUsuario.Location = new Point(3, 0);
            LblNombreUsuario.Name = "LblNombreUsuario";
            LblNombreUsuario.Size = new Size(108, 42);
            LblNombreUsuario.TabIndex = 2;
            LblNombreUsuario.Text = "Nombre de usuario";
            // 
            // LblPassword
            // 
            LblPassword.AutoSize = true;
            LblPassword.Location = new Point(3, 42);
            LblPassword.Name = "LblPassword";
            LblPassword.Size = new Size(101, 25);
            LblPassword.TabIndex = 3;
            LblPassword.Text = "Contraseña";
            // 
            // panel1
            // 
            panel1.Controls.Add(LblForgotPassword);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(6, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(618, 587);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // LblForgotPassword
            // 
            LblForgotPassword.AutoSize = true;
            LblForgotPassword.ForeColor = SystemColors.Highlight;
            LblForgotPassword.Location = new Point(186, 537);
            LblForgotPassword.Name = "LblForgotPassword";
            LblForgotPassword.Size = new Size(214, 25);
            LblForgotPassword.TabIndex = 0;
            LblForgotPassword.Text = "¿Olvidaste tu contraseña?";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.user_person_profile_account_icon_259756;
            pictureBox1.Location = new Point(221, 38);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(152, 119);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(chkShowPassword);
            panel2.Controls.Add(BtnLogin);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(tableLayoutPanel1);
            panel2.Location = new Point(0, 163);
            panel2.Name = "panel2";
            panel2.Size = new Size(615, 211);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // chkShowPassword
            // 
            chkShowPassword.AutoSize = true;
            chkShowPassword.Location = new Point(354, 126);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(154, 29);
            chkShowPassword.TabIndex = 4;
            chkShowPassword.Text = "Ver contraseña";
            chkShowPassword.UseVisualStyleBackColor = true;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
            // 
            // BtnLogin
            // 
            BtnLogin.FlatStyle = FlatStyle.System;
            BtnLogin.Location = new Point(221, 173);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(152, 34);
            BtnLogin.TabIndex = 0;
            BtnLogin.Text = "Iniciar Sesión";
            BtnLogin.UseVisualStyleBackColor = true;
            BtnLogin.Click += BtnLogin_Click;
            // 
            // panel3
            // 
            panel3.Location = new Point(3, 268);
            panel3.Name = "panel3";
            panel3.Size = new Size(612, 153);
            panel3.TabIndex = 2;
            // 
            // FRM_Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(630, 588);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FRM_Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio de sesión";
            Load += FRM_Login_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TextBox TxtUsername;
        private TextBox TxtPassword;
        private Label LblNombreUsuario;
        private Label LblPassword;
        private Panel panel1;
        private Panel panel2;
        private Button BtnLogin;
        private Panel panel3;
        private Label LblForgotPassword;
        private PictureBox pictureBox1;
        private CheckBox chkShowPassword;
    }
}