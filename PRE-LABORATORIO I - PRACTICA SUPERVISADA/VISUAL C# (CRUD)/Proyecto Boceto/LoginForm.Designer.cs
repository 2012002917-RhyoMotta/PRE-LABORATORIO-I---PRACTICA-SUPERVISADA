namespace Proyecto_PreLab
{
    partial class LoginForm
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
            label1 = new Label();
            label2 = new Label();
            txtUsuario = new TextBox();
            txtContraseña = new TextBox();
            btnLogin = new Button();
            btnCancelar = new Button();
            btnCreditos = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 52);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(104, 25);
            label1.TabIndex = 0;
            label1.Text = "UserName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 152);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(97, 25);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(149, 49);
            txtUsuario.Margin = new Padding(5);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(335, 33);
            txtUsuario.TabIndex = 2;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(149, 149);
            txtContraseña.Margin = new Padding(5);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '●';
            txtContraseña.Size = new Size(335, 33);
            txtContraseña.TabIndex = 3;
            txtContraseña.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(12, 218);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(321, 81);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Iniciar Sesión";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(339, 218);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(233, 81);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnCreditos
            // 
            btnCreditos.BackColor = Color.Black;
            btnCreditos.Image = Properties.Resources.Creditos;
            btnCreditos.Location = new Point(548, 12);
            btnCreditos.Name = "btnCreditos";
            btnCreditos.Size = new Size(24, 24);
            btnCreditos.TabIndex = 6;
            btnCreditos.UseVisualStyleBackColor = false;
            btnCreditos.Click += btnCreditos_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(447, 12);
            label3.Name = "label3";
            label3.Size = new Size(98, 21);
            label3.TabIndex = 7;
            label3.Text = "Creditos >>";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 311);
            Controls.Add(label3);
            Controls.Add(btnCreditos);
            Controls.Add(btnCancelar);
            Controls.Add(btnLogin);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuario);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LOGIN";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtUsuario;
        private TextBox txtContraseña;
        private Button btnLogin;
        private Button btnCancelar;
        private Button btnCreditos;
        private Label label3;
    }
}
