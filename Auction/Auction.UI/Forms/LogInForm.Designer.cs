namespace User
{
    partial class LogInForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.UserName_textBox = new System.Windows.Forms.TextBox();
            this.UserName_label = new System.Windows.Forms.Label();
            this.Password_textBox = new System.Windows.Forms.TextBox();
            this.Password_label = new System.Windows.Forms.Label();
            this.LogIn_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(342, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // UserName_textBox
            // 
            this.UserName_textBox.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName_textBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(80)))), ((int)(((byte)(150)))));
            this.UserName_textBox.Location = new System.Drawing.Point(242, 218);
            this.UserName_textBox.Name = "UserName_textBox";
            this.UserName_textBox.Size = new System.Drawing.Size(300, 29);
            this.UserName_textBox.TabIndex = 1;
            this.UserName_textBox.TextChanged += new System.EventHandler(this.UserName_textBox_TextChanged);
            // 
            // UserName_label
            // 
            this.UserName_label.AutoSize = true;
            this.UserName_label.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(130)))));
            this.UserName_label.Location = new System.Drawing.Point(241, 193);
            this.UserName_label.Name = "UserName_label";
            this.UserName_label.Size = new System.Drawing.Size(140, 23);
            this.UserName_label.TabIndex = 2;
            this.UserName_label.Text = "მომხმარებელი";
            this.UserName_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Password_textBox
            // 
            this.Password_textBox.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_textBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(80)))), ((int)(((byte)(150)))));
            this.Password_textBox.Location = new System.Drawing.Point(242, 281);
            this.Password_textBox.Name = "Password_textBox";
            this.Password_textBox.Size = new System.Drawing.Size(300, 29);
            this.Password_textBox.TabIndex = 2;
            this.Password_textBox.UseSystemPasswordChar = true;
            this.Password_textBox.TextChanged += new System.EventHandler(this.UserName_textBox_TextChanged);
            // 
            // Password_label
            // 
            this.Password_label.AutoSize = true;
            this.Password_label.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(130)))));
            this.Password_label.Location = new System.Drawing.Point(241, 256);
            this.Password_label.Name = "Password_label";
            this.Password_label.Size = new System.Drawing.Size(81, 23);
            this.Password_label.TabIndex = 2;
            this.Password_label.Text = "პაროლი";
            this.Password_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LogIn_button
            // 
            this.LogIn_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(80)))), ((int)(((byte)(150)))));
            this.LogIn_button.FlatAppearance.BorderSize = 0;
            this.LogIn_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(150)))), ((int)(((byte)(250)))));
            this.LogIn_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogIn_button.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogIn_button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LogIn_button.Location = new System.Drawing.Point(242, 341);
            this.LogIn_button.Name = "LogIn_button";
            this.LogIn_button.Size = new System.Drawing.Size(300, 30);
            this.LogIn_button.TabIndex = 3;
            this.LogIn_button.Text = "სისტემაში შესვლა";
            this.LogIn_button.UseVisualStyleBackColor = false;
            this.LogIn_button.Click += new System.EventHandler(this.LogIn_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.label1.Location = new System.Drawing.Point(223, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "მომხმარებელი ან პაროლი არასწორია";
            this.label1.Visible = false;
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LogIn_button);
            this.Controls.Add(this.Password_label);
            this.Controls.Add(this.UserName_label);
            this.Controls.Add(this.Password_textBox);
            this.Controls.Add(this.UserName_textBox);
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "LogInForm";
            this.Text = "LogIn";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox UserName_textBox;
        private System.Windows.Forms.Label UserName_label;
        private System.Windows.Forms.TextBox Password_textBox;
        private System.Windows.Forms.Label Password_label;
        private System.Windows.Forms.Button LogIn_button;
        private System.Windows.Forms.Label label1;
    }
}

