namespace Auction.UI.UserControls
{
    partial class AuctionRegistrationControl
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
            this.AuctionsRegistrationPages = new System.Windows.Forms.TabControl();
            this.lotRegistrationPage = new System.Windows.Forms.TabPage();
            this.traderRegistrationPage = new System.Windows.Forms.TabPage();
            this.AuctionsRegistrationPages.SuspendLayout();
            this.SuspendLayout();
            // 
            // AuctionsRegistrationPages
            // 
            this.AuctionsRegistrationPages.Controls.Add(this.lotRegistrationPage);
            this.AuctionsRegistrationPages.Controls.Add(this.traderRegistrationPage);
            this.AuctionsRegistrationPages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AuctionsRegistrationPages.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuctionsRegistrationPages.Location = new System.Drawing.Point(0, 0);
            this.AuctionsRegistrationPages.Name = "AuctionsRegistrationPages";
            this.AuctionsRegistrationPages.SelectedIndex = 0;
            this.AuctionsRegistrationPages.Size = new System.Drawing.Size(900, 623);
            this.AuctionsRegistrationPages.TabIndex = 0;
            // 
            // lotRegistrationPage
            // 
            this.lotRegistrationPage.Location = new System.Drawing.Point(4, 29);
            this.lotRegistrationPage.Name = "lotRegistrationPage";
            this.lotRegistrationPage.Padding = new System.Windows.Forms.Padding(3);
            this.lotRegistrationPage.Size = new System.Drawing.Size(892, 590);
            this.lotRegistrationPage.TabIndex = 0;
            this.lotRegistrationPage.Text = "ლოტის დამატება";
            this.lotRegistrationPage.UseVisualStyleBackColor = true;
            // 
            // traderRegistrationPage
            // 
            this.traderRegistrationPage.AutoScroll = true;
            this.traderRegistrationPage.Location = new System.Drawing.Point(4, 29);
            this.traderRegistrationPage.Name = "traderRegistrationPage";
            this.traderRegistrationPage.Padding = new System.Windows.Forms.Padding(3);
            this.traderRegistrationPage.Size = new System.Drawing.Size(892, 590);
            this.traderRegistrationPage.TabIndex = 1;
            this.traderRegistrationPage.Text = "მოვაჭრის დამატება";
            this.traderRegistrationPage.UseVisualStyleBackColor = true;
            // 
            // AuctionRegistrationControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.AuctionsRegistrationPages);
            this.Name = "AuctionRegistrationControl";
            this.Size = new System.Drawing.Size(900, 623);
            this.AuctionsRegistrationPages.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage lotRegistrationPage;
        private System.Windows.Forms.TabPage traderRegistrationPage;
        private System.Windows.Forms.TabControl AuctionsRegistrationPages;
    }
}
