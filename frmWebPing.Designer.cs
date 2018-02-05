namespace WebPing {
	partial class frmWebPing {
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
			this.btnPing = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.lstPings = new System.Windows.Forms.ListBox();
			this.lblURL = new System.Windows.Forms.Label();
			this.txtURL = new System.Windows.Forms.TextBox();
			this.lblPingInterval = new System.Windows.Forms.Label();
			this.txtPingInterval = new System.Windows.Forms.TextBox();
			this.lblMS = new System.Windows.Forms.Label();
			this.lblPingCount = new System.Windows.Forms.Label();
			this.txtPingCount = new System.Windows.Forms.TextBox();
			this.btnStopPinging = new System.Windows.Forms.Button();
			this.lblTimeout = new System.Windows.Forms.Label();
			this.txtTimeout = new System.Windows.Forms.TextBox();
			this.lblTimeoutMS = new System.Windows.Forms.Label();
			this.btnClear = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnPing
			// 
			this.btnPing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnPing.Location = new System.Drawing.Point(453, 520);
			this.btnPing.Name = "btnPing";
			this.btnPing.Size = new System.Drawing.Size(76, 24);
			this.btnPing.TabIndex = 11;
			this.btnPing.Text = "Start Pinging";
			this.btnPing.UseVisualStyleBackColor = true;
			this.btnPing.Click += new System.EventHandler(this.btnPing_Click);
			// 
			// btnClose
			// 
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClose.Location = new System.Drawing.Point(911, 520);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(70, 24);
			this.btnClose.TabIndex = 14;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// lstPings
			// 
			this.lstPings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lstPings.FormattingEnabled = true;
			this.lstPings.Location = new System.Drawing.Point(12, 37);
			this.lstPings.Name = "lstPings";
			this.lstPings.Size = new System.Drawing.Size(969, 472);
			this.lstPings.TabIndex = 2;
			// 
			// lblURL
			// 
			this.lblURL.AutoSize = true;
			this.lblURL.Location = new System.Drawing.Point(12, 9);
			this.lblURL.Name = "lblURL";
			this.lblURL.Size = new System.Drawing.Size(29, 13);
			this.lblURL.TabIndex = 0;
			this.lblURL.Text = "URL";
			// 
			// txtURL
			// 
			this.txtURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtURL.Location = new System.Drawing.Point(47, 6);
			this.txtURL.Name = "txtURL";
			this.txtURL.Size = new System.Drawing.Size(934, 20);
			this.txtURL.TabIndex = 1;
			// 
			// lblPingInterval
			// 
			this.lblPingInterval.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblPingInterval.AutoSize = true;
			this.lblPingInterval.Location = new System.Drawing.Point(187, 526);
			this.lblPingInterval.Name = "lblPingInterval";
			this.lblPingInterval.Size = new System.Drawing.Size(66, 13);
			this.lblPingInterval.TabIndex = 5;
			this.lblPingInterval.Text = "Ping Interval";
			// 
			// txtPingInterval
			// 
			this.txtPingInterval.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.txtPingInterval.Location = new System.Drawing.Point(257, 523);
			this.txtPingInterval.Name = "txtPingInterval";
			this.txtPingInterval.Size = new System.Drawing.Size(31, 20);
			this.txtPingInterval.TabIndex = 6;
			this.txtPingInterval.Text = "250";
			// 
			// lblMS
			// 
			this.lblMS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblMS.AutoSize = true;
			this.lblMS.Location = new System.Drawing.Point(296, 526);
			this.lblMS.Name = "lblMS";
			this.lblMS.Size = new System.Drawing.Size(20, 13);
			this.lblMS.TabIndex = 7;
			this.lblMS.Text = "ms";
			// 
			// lblPingCount
			// 
			this.lblPingCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblPingCount.AutoSize = true;
			this.lblPingCount.Location = new System.Drawing.Point(12, 526);
			this.lblPingCount.Name = "lblPingCount";
			this.lblPingCount.Size = new System.Drawing.Size(98, 13);
			this.lblPingCount.TabIndex = 3;
			this.lblPingCount.Text = "Desired Ping Count";
			// 
			// txtPingCount
			// 
			this.txtPingCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.txtPingCount.Location = new System.Drawing.Point(116, 523);
			this.txtPingCount.Name = "txtPingCount";
			this.txtPingCount.Size = new System.Drawing.Size(51, 20);
			this.txtPingCount.TabIndex = 4;
			this.txtPingCount.Text = "1";
			// 
			// btnStopPinging
			// 
			this.btnStopPinging.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnStopPinging.Location = new System.Drawing.Point(535, 520);
			this.btnStopPinging.Name = "btnStopPinging";
			this.btnStopPinging.Size = new System.Drawing.Size(76, 24);
			this.btnStopPinging.TabIndex = 12;
			this.btnStopPinging.Text = "Stop Pinging";
			this.btnStopPinging.UseVisualStyleBackColor = true;
			this.btnStopPinging.Click += new System.EventHandler(this.btnStopPinging_Click);
			// 
			// lblTimeout
			// 
			this.lblTimeout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblTimeout.AutoSize = true;
			this.lblTimeout.Location = new System.Drawing.Point(336, 526);
			this.lblTimeout.Name = "lblTimeout";
			this.lblTimeout.Size = new System.Drawing.Size(45, 13);
			this.lblTimeout.TabIndex = 8;
			this.lblTimeout.Text = "Timeout";
			// 
			// txtTimeout
			// 
			this.txtTimeout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.txtTimeout.Location = new System.Drawing.Point(382, 523);
			this.txtTimeout.Name = "txtTimeout";
			this.txtTimeout.Size = new System.Drawing.Size(31, 20);
			this.txtTimeout.TabIndex = 9;
			this.txtTimeout.Text = "5000";
			// 
			// lblTimeoutMS
			// 
			this.lblTimeoutMS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblTimeoutMS.AutoSize = true;
			this.lblTimeoutMS.Location = new System.Drawing.Point(416, 526);
			this.lblTimeoutMS.Name = "lblTimeoutMS";
			this.lblTimeoutMS.Size = new System.Drawing.Size(20, 13);
			this.lblTimeoutMS.TabIndex = 10;
			this.lblTimeoutMS.Text = "ms";
			// 
			// btnClear
			// 
			this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnClear.Location = new System.Drawing.Point(617, 521);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(75, 23);
			this.btnClear.TabIndex = 13;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// frmWebPing
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(993, 551);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.lblURL);
			this.Controls.Add(this.txtURL);
			this.Controls.Add(this.lblPingCount);
			this.Controls.Add(this.lblTimeout);
			this.Controls.Add(this.lblPingInterval);
			this.Controls.Add(this.txtPingCount);
			this.Controls.Add(this.txtTimeout);
			this.Controls.Add(this.txtPingInterval);
			this.Controls.Add(this.lblTimeoutMS);
			this.Controls.Add(this.lblMS);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnStopPinging);
			this.Controls.Add(this.btnPing);
			this.Controls.Add(this.lstPings);
			this.Name = "frmWebPing";
			this.Text = "Web Ping";
			this.Load += new System.EventHandler(this.frmWebPing_Load);
			this.Shown += new System.EventHandler(this.frmWebPing_Shown);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnPing;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.ListBox lstPings;
		private System.Windows.Forms.Label lblURL;
		private System.Windows.Forms.TextBox txtURL;
		private System.Windows.Forms.Label lblPingInterval;
		private System.Windows.Forms.TextBox txtPingInterval;
		private System.Windows.Forms.Label lblMS;
		private System.Windows.Forms.Label lblPingCount;
		private System.Windows.Forms.TextBox txtPingCount;
		private System.Windows.Forms.Button btnStopPinging;
		private System.Windows.Forms.Label lblTimeout;
		private System.Windows.Forms.TextBox txtTimeout;
		private System.Windows.Forms.Label lblTimeoutMS;
		private System.Windows.Forms.Button btnClear;
	}
}

