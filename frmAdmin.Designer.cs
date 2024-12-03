namespace SampleGUIAPP2
{
    partial class frmAdmin
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
            label1 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            txtPassword = new TextBox();
            btnInsert = new Button();
            btnClear = new Button();
            label3 = new Label();
            txtUsername = new TextBox();
            btnEdit = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnLogout = new Button();
            dataGridView1 = new DataGridView();
            checkBox1 = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(315, 9);
            label1.Name = "label1";
            label1.Size = new Size(151, 32);
            label1.TabIndex = 0;
            label1.Text = "Admin Panel";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Admin", "User" });
            comboBox1.Location = new Point(574, 120);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(157, 38);
            comboBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            label2.Location = new Point(221, 168);
            label2.Name = "label2";
            label2.Size = new Size(103, 30);
            label2.TabIndex = 11;
            label2.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            txtPassword.Location = new Point(221, 212);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(303, 35);
            txtPassword.TabIndex = 10;
            // 
            // btnInsert
            // 
            btnInsert.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            btnInsert.Location = new Point(41, 305);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(157, 42);
            btnInsert.TabIndex = 9;
            btnInsert.Text = "Create Usert ";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            btnClear.Location = new Point(672, 12);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(116, 42);
            btnClear.TabIndex = 8;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            label3.Location = new Point(221, 74);
            label3.Name = "label3";
            label3.Size = new Size(109, 30);
            label3.TabIndex = 7;
            label3.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            txtUsername.Location = new Point(221, 120);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(303, 35);
            txtUsername.TabIndex = 6;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            btnEdit.Location = new Point(221, 305);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(157, 42);
            btnEdit.TabIndex = 12;
            btnEdit.Text = "Edit Usert ";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            btnUpdate.Location = new Point(395, 305);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(157, 42);
            btnUpdate.TabIndex = 13;
            btnUpdate.Text = "Update User";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            btnDelete.Location = new Point(574, 305);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(157, 42);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Delete User";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnLogout
            // 
            btnLogout.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold);
            btnLogout.Location = new Point(12, 12);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(116, 42);
            btnLogout.TabIndex = 15;
            btnLogout.Text = "Log out";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(41, 383);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(690, 207);
            dataGridView1.TabIndex = 16;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(466, 253);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(58, 19);
            checkBox1.TabIndex = 17;
            checkBox1.Text = "Show ";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // frmAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 602);
            Controls.Add(checkBox1);
            Controls.Add(dataGridView1);
            Controls.Add(btnLogout);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnEdit);
            Controls.Add(label2);
            Controls.Add(txtPassword);
            Controls.Add(btnInsert);
            Controls.Add(btnClear);
            Controls.Add(label3);
            Controls.Add(txtUsername);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Name = "frmAdmin";
            Text = "frmAdmin";
            Load += frmAdmin_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBox1;
        private Label label2;
        private TextBox txtPassword;
        private Button btnInsert;
        private Button btnClear;
        private Label label3;
        private TextBox txtUsername;
        private Button btnEdit;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnLogout;
        private DataGridView dataGridView1;
        private CheckBox checkBox1;
    }
}