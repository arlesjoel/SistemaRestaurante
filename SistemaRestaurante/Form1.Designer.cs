namespace SistemaRestaurante
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            panel2 = new Panel();
            btnLogin = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblNombreUsuario = new Label();
            lblPassword = new Label();
            txtPassword = new TextBox();
            txtNombreUsuario = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            resources.ApplyResources(panel1, "panel1");
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Name = "panel1";
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            resources.ApplyResources(panel2, "panel2");
            panel2.Controls.Add(btnLogin);
            panel2.Name = "panel2";
            panel2.Paint += panel2_Paint;
            // 
            // btnLogin
            // 
            resources.ApplyResources(btnLogin, "btnLogin");
            btnLogin.Name = "btnLogin";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(tableLayoutPanel1, "tableLayoutPanel1");
            tableLayoutPanel1.Controls.Add(lblNombreUsuario, 0, 0);
            tableLayoutPanel1.Controls.Add(lblPassword, 0, 1);
            tableLayoutPanel1.Controls.Add(txtPassword, 1, 1);
            tableLayoutPanel1.Controls.Add(txtNombreUsuario, 1, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint_1;
            // 
            // lblNombreUsuario
            // 
            resources.ApplyResources(lblNombreUsuario, "lblNombreUsuario");
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Click += lblNombreUsuario_Click;
            // 
            // lblPassword
            // 
            resources.ApplyResources(lblPassword, "lblPassword");
            lblPassword.Name = "lblPassword";
            lblPassword.Click += lblPassword_Click;
            // 
            // txtPassword
            // 
            resources.ApplyResources(txtPassword, "txtPassword");
            txtPassword.Name = "txtPassword";
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // txtNombreUsuario
            // 
            resources.ApplyResources(txtNombreUsuario, "txtNombreUsuario");
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.TextChanged += txtNombreUsuario_TextChanged;
            // 
            // Login
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "Login";
            Load += Login_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblNombreUsuario;
        private Label lblPassword;
        private TextBox txtNombreUsuario;
        private TextBox txtPassword;
        private Button btnLogin;
        private Panel panel2;
    }
}
