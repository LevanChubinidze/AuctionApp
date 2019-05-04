namespace Auction.UI.UserControls
{
    partial class RegistrationControl
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
            this.Users_comboBox = new System.Windows.Forms.ComboBox();
            this.Registration_button = new System.Windows.Forms.Button();
            this.RepeatPassword_label = new System.Windows.Forms.Label();
            this.Password_label = new System.Windows.Forms.Label();
            this.UserName_label = new System.Windows.Forms.Label();
            this.LastName_label = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Name_label = new System.Windows.Forms.Label();
            this.RepeatPassword_textBox = new System.Windows.Forms.TextBox();
            this.Password_textBox = new System.Windows.Forms.TextBox();
            this.UserName_textBox = new System.Windows.Forms.TextBox();
            this.LastName_textBox = new System.Windows.Forms.TextBox();
            this.Name_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Users_comboBox
            // 
            this.Users_comboBox.Font = new System.Drawing.Font("Sylfaen", 12.75F);
            this.Users_comboBox.FormattingEnabled = true;
            this.Users_comboBox.Location = new System.Drawing.Point(389, 35);
            this.Users_comboBox.Name = "Users_comboBox";
            this.Users_comboBox.Size = new System.Drawing.Size(485, 30);
            this.Users_comboBox.TabIndex = 16;
            this.Users_comboBox.SelectedIndexChanged += new System.EventHandler(this.Users_comboBox_SelectedIndexChanged);
            // 
            // Registration_button
            // 
            this.Registration_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(80)))), ((int)(((byte)(150)))));
            this.Registration_button.FlatAppearance.BorderSize = 0;
            this.Registration_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Registration_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registration_button.ForeColor = System.Drawing.Color.White;
            this.Registration_button.Location = new System.Drawing.Point(24, 519);
            this.Registration_button.Name = "Registration_button";
            this.Registration_button.Size = new System.Drawing.Size(850, 43);
            this.Registration_button.TabIndex = 15;
            this.Registration_button.Text = "რეგისტრაცია";
            this.Registration_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Registration_button.UseVisualStyleBackColor = false;
            this.Registration_button.Click += new System.EventHandler(this.Registration_button_Click);
            // 
            // RepeatPassword_label
            // 
            this.RepeatPassword_label.AutoSize = true;
            this.RepeatPassword_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RepeatPassword_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(80)))), ((int)(((byte)(150)))));
            this.RepeatPassword_label.Location = new System.Drawing.Point(24, 431);
            this.RepeatPassword_label.Name = "RepeatPassword_label";
            this.RepeatPassword_label.Size = new System.Drawing.Size(266, 29);
            this.RepeatPassword_label.TabIndex = 9;
            this.RepeatPassword_label.Text = "გაიმეორეთ პაროლი";
            // 
            // Password_label
            // 
            this.Password_label.AutoSize = true;
            this.Password_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(80)))), ((int)(((byte)(150)))));
            this.Password_label.Location = new System.Drawing.Point(19, 354);
            this.Password_label.Name = "Password_label";
            this.Password_label.Size = new System.Drawing.Size(115, 29);
            this.Password_label.TabIndex = 10;
            this.Password_label.Text = "პაროლი";
            // 
            // UserName_label
            // 
            this.UserName_label.AutoSize = true;
            this.UserName_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(80)))), ((int)(((byte)(150)))));
            this.UserName_label.Location = new System.Drawing.Point(19, 278);
            this.UserName_label.Name = "UserName_label";
            this.UserName_label.Size = new System.Drawing.Size(205, 29);
            this.UserName_label.TabIndex = 11;
            this.UserName_label.Text = "მომხმარებელი";
            // 
            // LastName_label
            // 
            this.LastName_label.AutoSize = true;
            this.LastName_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastName_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(80)))), ((int)(((byte)(150)))));
            this.LastName_label.Location = new System.Drawing.Point(24, 201);
            this.LastName_label.Name = "LastName_label";
            this.LastName_label.Size = new System.Drawing.Size(87, 29);
            this.LastName_label.TabIndex = 12;
            this.LastName_label.Text = "გვარი";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(80)))), ((int)(((byte)(150)))));
            this.label6.Location = new System.Drawing.Point(19, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(385, 29);
            this.label6.TabIndex = 13;
            this.label6.Text = "მომხმარებლის რედაქტირება";
            // 
            // Name_label
            // 
            this.Name_label.AutoSize = true;
            this.Name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(80)))), ((int)(((byte)(150)))));
            this.Name_label.Location = new System.Drawing.Point(24, 123);
            this.Name_label.Name = "Name_label";
            this.Name_label.Size = new System.Drawing.Size(108, 29);
            this.Name_label.TabIndex = 14;
            this.Name_label.Text = "სახელი";
            // 
            // RepeatPassword_textBox
            // 
            this.RepeatPassword_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.RepeatPassword_textBox.Font = new System.Drawing.Font("Sylfaen", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RepeatPassword_textBox.Location = new System.Drawing.Point(24, 462);
            this.RepeatPassword_textBox.Name = "RepeatPassword_textBox";
            this.RepeatPassword_textBox.Size = new System.Drawing.Size(850, 30);
            this.RepeatPassword_textBox.TabIndex = 4;
            this.RepeatPassword_textBox.UseSystemPasswordChar = true;
            // 
            // Password_textBox
            // 
            this.Password_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Password_textBox.Font = new System.Drawing.Font("Sylfaen", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_textBox.Location = new System.Drawing.Point(24, 385);
            this.Password_textBox.Name = "Password_textBox";
            this.Password_textBox.Size = new System.Drawing.Size(850, 30);
            this.Password_textBox.TabIndex = 5;
            this.Password_textBox.UseSystemPasswordChar = true;
            // 
            // UserName_textBox
            // 
            this.UserName_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.UserName_textBox.Font = new System.Drawing.Font("Sylfaen", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName_textBox.Location = new System.Drawing.Point(24, 309);
            this.UserName_textBox.Name = "UserName_textBox";
            this.UserName_textBox.Size = new System.Drawing.Size(850, 30);
            this.UserName_textBox.TabIndex = 6;
            // 
            // LastName_textBox
            // 
            this.LastName_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LastName_textBox.Font = new System.Drawing.Font("Sylfaen", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastName_textBox.Location = new System.Drawing.Point(24, 232);
            this.LastName_textBox.Name = "LastName_textBox";
            this.LastName_textBox.Size = new System.Drawing.Size(850, 30);
            this.LastName_textBox.TabIndex = 7;
            // 
            // Name_textBox
            // 
            this.Name_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Name_textBox.Font = new System.Drawing.Font("Sylfaen", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_textBox.Location = new System.Drawing.Point(24, 154);
            this.Name_textBox.Name = "Name_textBox";
            this.Name_textBox.Size = new System.Drawing.Size(850, 30);
            this.Name_textBox.TabIndex = 8;
            // 
            // RegistrationControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.Users_comboBox);
            this.Controls.Add(this.Registration_button);
            this.Controls.Add(this.RepeatPassword_label);
            this.Controls.Add(this.Password_label);
            this.Controls.Add(this.UserName_label);
            this.Controls.Add(this.LastName_label);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Name_label);
            this.Controls.Add(this.RepeatPassword_textBox);
            this.Controls.Add(this.Password_textBox);
            this.Controls.Add(this.UserName_textBox);
            this.Controls.Add(this.LastName_textBox);
            this.Controls.Add(this.Name_textBox);
            this.Name = "RegistrationControl";
            this.Size = new System.Drawing.Size(892, 597);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Users_comboBox;
        private System.Windows.Forms.Button Registration_button;
        private System.Windows.Forms.Label RepeatPassword_label;
        private System.Windows.Forms.Label Password_label;
        private System.Windows.Forms.Label UserName_label;
        private System.Windows.Forms.Label LastName_label;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Name_label;
        private System.Windows.Forms.TextBox RepeatPassword_textBox;
        private System.Windows.Forms.TextBox Password_textBox;
        private System.Windows.Forms.TextBox UserName_textBox;
        private System.Windows.Forms.TextBox LastName_textBox;
        private System.Windows.Forms.TextBox Name_textBox;
    }
}
