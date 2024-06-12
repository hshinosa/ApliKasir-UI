namespace ApliKasir_UI
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
            Username = new Label();
            Password = new Label();
            textBoxUsername = new TextBox();
            textBoxPassword = new TextBox();
            buttonLogin = new Button();
            buttonRegister = new Button();
            buttonClose = new Button();
            SuspendLayout();
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.Location = new Point(102, 95);
            Username.Name = "Username";
            Username.Size = new Size(75, 20);
            Username.TabIndex = 0;
            Username.Text = "Username";
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Location = new Point(101, 161);
            Password.Name = "Password";
            Password.Size = new Size(70, 20);
            Password.TabIndex = 1;
            Password.Text = "Password";
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(102, 119);
            textBoxUsername.Margin = new Padding(3, 4, 3, 4);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(207, 27);
            textBoxUsername.TabIndex = 2;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(102, 185);
            textBoxPassword.Margin = new Padding(3, 4, 3, 4);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(207, 27);
            textBoxPassword.TabIndex = 3;
            textBoxPassword.UseSystemPasswordChar = true;
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(102, 239);
            buttonLogin.Margin = new Padding(3, 4, 3, 4);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(86, 31);
            buttonLogin.TabIndex = 4;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // buttonRegister
            // 
            buttonRegister.Location = new Point(224, 239);
            buttonRegister.Margin = new Padding(3, 4, 3, 4);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(86, 31);
            buttonRegister.TabIndex = 5;
            buttonRegister.Text = "Register";
            buttonRegister.UseVisualStyleBackColor = true;
            buttonRegister.Click += buttonRegister_Click;
            // 
            // buttonClose
            // 
            buttonClose.Location = new Point(319, 351);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(94, 29);
            buttonClose.TabIndex = 6;
            buttonClose.Text = "Close";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(425, 392);
            Controls.Add(buttonClose);
            Controls.Add(buttonRegister);
            Controls.Add(buttonLogin);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUsername);
            Controls.Add(Password);
            Controls.Add(Username);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Login";
            Text = "ApliKasir";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Username;
        private Label Password;
        private TextBox textBoxUsername;
        private TextBox textBoxPassword;
        private Button buttonLogin;
        private Button buttonRegister;
        private Button buttonClose;
    }
}
