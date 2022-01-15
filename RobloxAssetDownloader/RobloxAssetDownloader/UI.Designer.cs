
namespace RobloxAssetDownloader {
    partial class UI {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
                }
            base.Dispose(disposing);
            }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UI));
            this.URLBox = new System.Windows.Forms.TextBox();
            this.DownloadButton = new System.Windows.Forms.Button();
            this.ImageOutput = new System.Windows.Forms.PictureBox();
            this.Shirt = new System.Windows.Forms.RadioButton();
            this.Pants = new System.Windows.Forms.RadioButton();
            this.noOverlay = new System.Windows.Forms.RadioButton();
            this.templateOverlayBg = new System.Windows.Forms.Panel();
            this.overlayText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.githubLink = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImageOutput)).BeginInit();
            this.templateOverlayBg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.githubLink)).BeginInit();
            this.SuspendLayout();
            // 
            // URLBox
            // 
            this.URLBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.URLBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.URLBox.ForeColor = System.Drawing.Color.Gray;
            this.URLBox.Location = new System.Drawing.Point(16, 581);
            this.URLBox.Margin = new System.Windows.Forms.Padding(7);
            this.URLBox.Name = "URLBox";
            this.URLBox.Size = new System.Drawing.Size(544, 39);
            this.URLBox.TabIndex = 0;
            this.URLBox.Text = "Enter Clothing ID or Catalog URL (eg. 6607924538)";
            this.URLBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.URLBox.TextChanged += new System.EventHandler(this.TextFocus);
            this.URLBox.Enter += new System.EventHandler(this.TextFocus);
            // 
            // DownloadButton
            // 
            this.DownloadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DownloadButton.BackColor = System.Drawing.Color.White;
            this.DownloadButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.DownloadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DownloadButton.Font = new System.Drawing.Font("Segoe UI Light", 16F);
            this.DownloadButton.Location = new System.Drawing.Point(564, 579);
            this.DownloadButton.Name = "DownloadButton";
            this.DownloadButton.Size = new System.Drawing.Size(154, 43);
            this.DownloadButton.TabIndex = 1;
            this.DownloadButton.Text = "Download";
            this.DownloadButton.UseVisualStyleBackColor = false;
            this.DownloadButton.Click += new System.EventHandler(this.Download);
            // 
            // ImageOutput
            // 
            this.ImageOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ImageOutput.Location = new System.Drawing.Point(16, 12);
            this.ImageOutput.Name = "ImageOutput";
            this.ImageOutput.Size = new System.Drawing.Size(585, 559);
            this.ImageOutput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ImageOutput.TabIndex = 2;
            this.ImageOutput.TabStop = false;
            // 
            // Shirt
            // 
            this.Shirt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Shirt.Appearance = System.Windows.Forms.Appearance.Button;
            this.Shirt.BackColor = System.Drawing.Color.White;
            this.Shirt.Checked = true;
            this.Shirt.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.Shirt.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(136)))), ((int)(((byte)(240)))));
            this.Shirt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Shirt.Location = new System.Drawing.Point(2, 54);
            this.Shirt.Name = "Shirt";
            this.Shirt.Size = new System.Drawing.Size(106, 45);
            this.Shirt.TabIndex = 3;
            this.Shirt.TabStop = true;
            this.Shirt.Text = "Shirt";
            this.Shirt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Shirt.UseVisualStyleBackColor = false;
            // 
            // Pants
            // 
            this.Pants.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pants.Appearance = System.Windows.Forms.Appearance.Button;
            this.Pants.BackColor = System.Drawing.Color.White;
            this.Pants.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.Pants.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(136)))), ((int)(((byte)(240)))));
            this.Pants.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Pants.Location = new System.Drawing.Point(2, 101);
            this.Pants.Name = "Pants";
            this.Pants.Size = new System.Drawing.Size(106, 45);
            this.Pants.TabIndex = 4;
            this.Pants.Text = "Pants";
            this.Pants.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Pants.UseVisualStyleBackColor = false;
            // 
            // noOverlay
            // 
            this.noOverlay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.noOverlay.Appearance = System.Windows.Forms.Appearance.Button;
            this.noOverlay.BackColor = System.Drawing.Color.White;
            this.noOverlay.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.noOverlay.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(136)))), ((int)(((byte)(240)))));
            this.noOverlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.noOverlay.Location = new System.Drawing.Point(2, 148);
            this.noOverlay.Name = "noOverlay";
            this.noOverlay.Size = new System.Drawing.Size(106, 45);
            this.noOverlay.TabIndex = 5;
            this.noOverlay.Text = "None";
            this.noOverlay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.noOverlay.UseVisualStyleBackColor = false;
            // 
            // templateOverlayBg
            // 
            this.templateOverlayBg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.templateOverlayBg.BackColor = System.Drawing.Color.White;
            this.templateOverlayBg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.templateOverlayBg.Controls.Add(this.overlayText);
            this.templateOverlayBg.Controls.Add(this.noOverlay);
            this.templateOverlayBg.Controls.Add(this.Shirt);
            this.templateOverlayBg.Controls.Add(this.Pants);
            this.templateOverlayBg.Location = new System.Drawing.Point(606, 12);
            this.templateOverlayBg.Name = "templateOverlayBg";
            this.templateOverlayBg.Size = new System.Drawing.Size(112, 197);
            this.templateOverlayBg.TabIndex = 6;
            // 
            // overlayText
            // 
            this.overlayText.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.overlayText.Location = new System.Drawing.Point(2, 2);
            this.overlayText.Name = "overlayText";
            this.overlayText.Size = new System.Drawing.Size(108, 50);
            this.overlayText.TabIndex = 6;
            this.overlayText.Text = "Template\r\nOverlay";
            this.overlayText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 625);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(702, 59);
            this.label1.TabIndex = 7;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // githubLink
            // 
            this.githubLink.BackColor = System.Drawing.Color.Transparent;
            this.githubLink.Image = global::RobloxAssetDownloader.Properties.Resources.github;
            this.githubLink.Location = new System.Drawing.Point(638, 212);
            this.githubLink.Name = "githubLink";
            this.githubLink.Size = new System.Drawing.Size(48, 48);
            this.githubLink.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.githubLink.TabIndex = 8;
            this.githubLink.TabStop = false;
            this.githubLink.Click += new System.EventHandler(this.GithubLink);
            // 
            // UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RobloxAssetDownloader.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(723, 687);
            this.Controls.Add(this.githubLink);
            this.Controls.Add(this.DownloadButton);
            this.Controls.Add(this.URLBox);
            this.Controls.Add(this.ImageOutput);
            this.Controls.Add(this.templateOverlayBg);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI Light", 18F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "UI";
            this.Text = "Roblox Asset Downloader";
            this.Load += new System.EventHandler(this.Loaded);
            ((System.ComponentModel.ISupportInitialize)(this.ImageOutput)).EndInit();
            this.templateOverlayBg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.githubLink)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion
        private System.Windows.Forms.TextBox URLBox;
        private System.Windows.Forms.Button DownloadButton;
        private System.Windows.Forms.PictureBox ImageOutput;
        private System.Windows.Forms.RadioButton Shirt;
        private System.Windows.Forms.RadioButton Pants;
        private System.Windows.Forms.RadioButton noOverlay;
        private System.Windows.Forms.Panel templateOverlayBg;
        private System.Windows.Forms.Label overlayText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox githubLink;
        }
    }

