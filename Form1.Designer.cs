namespace SampleGUIAPP2
{
    partial class Form1
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
            txtUsername = new TextBox();
            label1 = new Label();
            btnClear = new Button();
            btnLogin = new Button();
            label2 = new Label();
            txtPassword = new TextBox();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            txtUsername.Location = new Point(240, 79);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(303, 35);
            txtUsername.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            label1.Location = new Point(341, 30);
            label1.Name = "label1";
            label1.Size = new Size(109, 30);
            label1.TabIndex = 1;
            label1.Text = "Username";
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            btnClear.Location = new Point(480, 342);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(116, 42);
            btnClear.TabIndex = 2;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            btnLogin.Location = new Point(202, 342);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(116, 42);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Log in";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            label2.Location = new Point(341, 175);
            label2.Name = "label2";
            label2.Size = new Size(103, 30);
            label2.TabIndex = 5;
            label2.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            txtPassword.Location = new Point(240, 228);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(303, 35);
            txtPassword.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(txtPassword);
            Controls.Add(btnLogin);
            Controls.Add(btnClear);
            Controls.Add(label1);
            Controls.Add(txtUsername);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsername;
        private Label label1;
        private Button btnClear;
        private Button btnLogin;
        private Label label2;
        private TextBox txtPassword;
    }
}
