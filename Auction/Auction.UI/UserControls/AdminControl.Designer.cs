namespace Auction.UI.UserControls
{
    partial class AdminControl
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
            this.adminControlPages = new System.Windows.Forms.TabControl();
            this.RegistrationPage = new System.Windows.Forms.TabPage();
            this.LotPage = new System.Windows.Forms.TabPage();
            this.adminControlPages.SuspendLayout();
            this.SuspendLayout();
            // 
            // adminControlPages
            // 
            this.adminControlPages.Controls.Add(this.RegistrationPage);
            this.adminControlPages.Controls.Add(this.LotPage);
            this.adminControlPages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adminControlPages.Font = new System.Drawing.Font("BPG Nino Mtavruli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminControlPages.Location = new System.Drawing.Point(0, 0);
            this.adminControlPages.Name = "adminControlPages";
            this.adminControlPages.SelectedIndex = 0;
            this.adminControlPages.Size = new System.Drawing.Size(900, 623);
            this.adminControlPages.TabIndex = 0;
            // 
            // RegistrationPage
            // 
            this.RegistrationPage.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegistrationPage.Location = new System.Drawing.Point(4, 28);
            this.RegistrationPage.Name = "RegistrationPage";
            this.RegistrationPage.Padding = new System.Windows.Forms.Padding(3);
            this.RegistrationPage.Size = new System.Drawing.Size(892, 591);
            this.RegistrationPage.TabIndex = 0;
            this.RegistrationPage.Text = "რეგისტრაცია";
            this.RegistrationPage.UseVisualStyleBackColor = true;
            // 
            // LotPage
            // 
            this.LotPage.Font = new System.Drawing.Font("Sylfaen", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LotPage.Location = new System.Drawing.Point(4, 22);
            this.LotPage.Name = "LotPage";
            this.LotPage.Padding = new System.Windows.Forms.Padding(3);
            this.LotPage.Size = new System.Drawing.Size(892, 597);
            this.LotPage.TabIndex = 1;
            this.LotPage.Text = "ლოტები";
            this.LotPage.UseVisualStyleBackColor = true;
            // 
            // AdminControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.adminControlPages);
            this.Name = "AdminControl";
            this.Size = new System.Drawing.Size(900, 623);
            this.adminControlPages.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl adminControlPages;
        private System.Windows.Forms.TabPage RegistrationPage;
        private System.Windows.Forms.TabPage LotPage;
    }
}
