namespace cinema_app
{
    partial class Form2
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
            this.RegButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.RoleComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // RegButton
            // 
            this.RegButton.Location = new System.Drawing.Point(242, 267);
            this.RegButton.Name = "RegButton";
            this.RegButton.Size = new System.Drawing.Size(129, 23);
            this.RegButton.TabIndex = 1;
            this.RegButton.Text = "Зарегистрироваться";
            this.RegButton.UseVisualStyleBackColor = true;
            this.RegButton.Click += new System.EventHandler(this.RegButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(242, 296);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Назад";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(242, 123);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(129, 20);
            this.NameTextBox.TabIndex = 4;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(242, 241);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(129, 20);
            this.PasswordTextBox.TabIndex = 5;
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Location = new System.Drawing.Point(242, 181);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(129, 20);
            this.LoginTextBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(239, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Роль:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(239, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Имя:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(239, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Логин:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(239, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Пароль:";
            // 
            // RoleComboBox
            // 
            this.RoleComboBox.FormattingEnabled = true;
            this.RoleComboBox.Location = new System.Drawing.Point(242, 65);
            this.RoleComboBox.Name = "RoleComboBox";
            this.RoleComboBox.Size = new System.Drawing.Size(129, 21);
            this.RoleComboBox.TabIndex = 12;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RoleComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoginTextBox);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.RegButton);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RegButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox RoleComboBox;
    }
}