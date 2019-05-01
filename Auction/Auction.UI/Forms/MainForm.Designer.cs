namespace User.Forms
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Button Menu_button;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Menu_panel = new System.Windows.Forms.Panel();
            this.LastName_label = new System.Windows.Forms.Label();
            this.FirstName_label = new System.Windows.Forms.Label();
            this.User_pictureBox = new System.Windows.Forms.PictureBox();
            this.Content_panel = new System.Windows.Forms.Panel();
            this.MenuPanel_timer = new System.Windows.Forms.Timer(this.components);
            this.Registration_LotModel_button = new System.Windows.Forms.Button();
            Menu_button = new System.Windows.Forms.Button();
            this.Menu_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.User_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Menu_button
            // 
            Menu_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            Menu_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(80)))), ((int)(((byte)(150)))));
            Menu_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Menu_button.BackgroundImage")));
            Menu_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            Menu_button.FlatAppearance.BorderSize = 0;
            Menu_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Menu_button.Location = new System.Drawing.Point(177, 12);
            Menu_button.Name = "Menu_button";
            Menu_button.Size = new System.Drawing.Size(35, 35);
            Menu_button.TabIndex = 2;
            Menu_button.UseVisualStyleBackColor = false;
            Menu_button.Click += new System.EventHandler(this.Menu_button_Click);
            // 
            // Menu_panel
            // 
            this.Menu_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(80)))), ((int)(((byte)(150)))));
            this.Menu_panel.Controls.Add(this.Registration_LotModel_button);
            this.Menu_panel.Controls.Add(Menu_button);
            this.Menu_panel.Controls.Add(this.LastName_label);
            this.Menu_panel.Controls.Add(this.FirstName_label);
            this.Menu_panel.Controls.Add(this.User_pictureBox);
            this.Menu_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Menu_panel.Location = new System.Drawing.Point(0, 0);
            this.Menu_panel.MaximumSize = new System.Drawing.Size(220, 0);
            this.Menu_panel.MinimumSize = new System.Drawing.Size(50, 0);
            this.Menu_panel.Name = "Menu_panel";
            this.Menu_panel.Size = new System.Drawing.Size(220, 623);
            this.Menu_panel.TabIndex = 0;
            // 
            // LastName_label
            // 
            this.LastName_label.AutoSize = true;
            this.LastName_label.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastName_label.ForeColor = System.Drawing.Color.White;
            this.LastName_label.Location = new System.Drawing.Point(81, 192);
            this.LastName_label.Name = "LastName_label";
            this.LastName_label.Size = new System.Drawing.Size(58, 23);
            this.LastName_label.TabIndex = 1;
            this.LastName_label.Text = "label1";
            // 
            // FirstName_label
            // 
            this.FirstName_label.AutoSize = true;
            this.FirstName_label.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstName_label.ForeColor = System.Drawing.Color.White;
            this.FirstName_label.Location = new System.Drawing.Point(81, 165);
            this.FirstName_label.Name = "FirstName_label";
            this.FirstName_label.Size = new System.Drawing.Size(58, 23);
            this.FirstName_label.TabIndex = 1;
            this.FirstName_label.Text = "label1";
            // 
            // User_pictureBox
            // 
            this.User_pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("User_pictureBox.Image")));
            this.User_pictureBox.Location = new System.Drawing.Point(62, 43);
            this.User_pictureBox.Name = "User_pictureBox";
            this.User_pictureBox.Size = new System.Drawing.Size(96, 96);
            this.User_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.User_pictureBox.TabIndex = 0;
            this.User_pictureBox.TabStop = false;
            // 
            // Content_panel
            // 
            this.Content_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Content_panel.Location = new System.Drawing.Point(220, 0);
            this.Content_panel.Name = "Content_panel";
            this.Content_panel.Size = new System.Drawing.Size(664, 623);
            this.Content_panel.TabIndex = 1;
            // 
            // MenuPanel_timer
            // 
            this.MenuPanel_timer.Interval = 10;
            this.MenuPanel_timer.Tick += new System.EventHandler(this.MenuPanel_timer_Tick);
            // 
            // Registration_LotModel_button
            // 
            this.Registration_LotModel_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(80)))), ((int)(((byte)(150)))));
            this.Registration_LotModel_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Registration_LotModel_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Registration_LotModel_button.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registration_LotModel_button.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Registration_LotModel_button.Image = ((System.Drawing.Image)(resources.GetObject("Registration_LotModel_button.Image")));
            this.Registration_LotModel_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Registration_LotModel_button.Location = new System.Drawing.Point(0, 270);
            this.Registration_LotModel_button.Name = "Registration_LotModel_button";
            this.Registration_LotModel_button.Size = new System.Drawing.Size(220, 50);
            this.Registration_LotModel_button.TabIndex = 3;
            this.Registration_LotModel_button.Tag = "";
            this.Registration_LotModel_button.Text = "    Auction";
            this.Registration_LotModel_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Registration_LotModel_button.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(884, 623);
            this.Controls.Add(this.Content_panel);
            this.Controls.Add(this.Menu_panel);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Menu_panel.ResumeLayout(false);
            this.Menu_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.User_pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Menu_panel;
        private System.Windows.Forms.PictureBox User_pictureBox;
        private System.Windows.Forms.Label LastName_label;
        private System.Windows.Forms.Label FirstName_label;
        private System.Windows.Forms.Panel Content_panel;
        private System.Windows.Forms.Timer MenuPanel_timer;
        private System.Windows.Forms.Button Registration_LotModel_button;
    }
}