namespace Amazon_Scraper
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gbPreview = new System.Windows.Forms.GroupBox();
            this.customWebBrowser1 = new WebScraper.Utils.Clients.CustomWebBrowser();
            this.gbControl = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbAsyncMode = new System.Windows.Forms.CheckBox();
            this.tbMaxThread = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbUseRndDelay = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbRndDelayMin = new System.Windows.Forms.TextBox();
            this.tbRndDelayMax = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblUrl = new System.Windows.Forms.Label();
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gbPreview.SuspendLayout();
            this.gbControl.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(742, 560);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gbPreview);
            this.tabPage1.Controls.Add(this.gbControl);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(734, 534);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Kontrol Paneli";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gbPreview
            // 
            this.gbPreview.Controls.Add(this.customWebBrowser1);
            this.gbPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbPreview.Location = new System.Drawing.Point(3, 123);
            this.gbPreview.Name = "gbPreview";
            this.gbPreview.Size = new System.Drawing.Size(728, 408);
            this.gbPreview.TabIndex = 1;
            this.gbPreview.TabStop = false;
            this.gbPreview.Text = "Ön İzleme";
            // 
            // customWebBrowser1
            // 
            this.customWebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customWebBrowser1.Location = new System.Drawing.Point(3, 16);
            this.customWebBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.customWebBrowser1.Name = "customWebBrowser1";
            this.customWebBrowser1.ScriptErrorsSuppressed = true;
            this.customWebBrowser1.Size = new System.Drawing.Size(722, 389);
            this.customWebBrowser1.TabIndex = 0;
            this.customWebBrowser1.UserAgent = null;
            // 
            // gbControl
            // 
            this.gbControl.Controls.Add(this.groupBox2);
            this.gbControl.Controls.Add(this.groupBox1);
            this.gbControl.Controls.Add(this.btnStart);
            this.gbControl.Controls.Add(this.lblUrl);
            this.gbControl.Controls.Add(this.tbUrl);
            this.gbControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbControl.Location = new System.Drawing.Point(3, 3);
            this.gbControl.Name = "gbControl";
            this.gbControl.Size = new System.Drawing.Size(728, 120);
            this.gbControl.TabIndex = 0;
            this.gbControl.TabStop = false;
            this.gbControl.Text = "Kontrol";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbAsyncMode);
            this.groupBox2.Controls.Add(this.tbMaxThread);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(9, 42);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(168, 69);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            // 
            // cbAsyncMode
            // 
            this.cbAsyncMode.AutoSize = true;
            this.cbAsyncMode.Location = new System.Drawing.Point(6, 46);
            this.cbAsyncMode.Name = "cbAsyncMode";
            this.cbAsyncMode.Size = new System.Drawing.Size(149, 17);
            this.cbAsyncMode.TabIndex = 4;
            this.cbAsyncMode.Text = "Async Mode (No Preview)";
            this.cbAsyncMode.UseVisualStyleBackColor = true;
            this.cbAsyncMode.CheckedChanged += new System.EventHandler(this.cbAsyncMode_CheckedChanged);
            // 
            // tbMaxThread
            // 
            this.tbMaxThread.Location = new System.Drawing.Point(92, 16);
            this.tbMaxThread.Name = "tbMaxThread";
            this.tbMaxThread.Size = new System.Drawing.Size(41, 20);
            this.tbMaxThread.TabIndex = 5;
            this.tbMaxThread.Text = "1";
            this.tbMaxThread.TextChanged += new System.EventHandler(this.NumberOnlyTextBox);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Max Thread: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbUseRndDelay);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbRndDelayMin);
            this.groupBox1.Controls.Add(this.tbRndDelayMax);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(183, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(192, 69);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // cbUseRndDelay
            // 
            this.cbUseRndDelay.AutoSize = true;
            this.cbUseRndDelay.Location = new System.Drawing.Point(37, 46);
            this.cbUseRndDelay.Name = "cbUseRndDelay";
            this.cbUseRndDelay.Size = new System.Drawing.Size(118, 17);
            this.cbUseRndDelay.TabIndex = 7;
            this.cbUseRndDelay.Text = "Use Random Delay";
            this.cbUseRndDelay.UseVisualStyleBackColor = true;
            this.cbUseRndDelay.CheckedChanged += new System.EventHandler(this.cbUseRndDelay_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(145, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "-";
            // 
            // tbRndDelayMin
            // 
            this.tbRndDelayMin.Location = new System.Drawing.Point(115, 16);
            this.tbRndDelayMin.Name = "tbRndDelayMin";
            this.tbRndDelayMin.Size = new System.Drawing.Size(24, 20);
            this.tbRndDelayMin.TabIndex = 8;
            this.tbRndDelayMin.Text = "1";
            this.tbRndDelayMin.TextChanged += new System.EventHandler(this.NumberOnlyTextBox);
            // 
            // tbRndDelayMax
            // 
            this.tbRndDelayMax.Location = new System.Drawing.Point(161, 16);
            this.tbRndDelayMax.Name = "tbRndDelayMax";
            this.tbRndDelayMax.Size = new System.Drawing.Size(24, 20);
            this.tbRndDelayMax.TabIndex = 10;
            this.tbRndDelayMax.Text = "1";
            this.tbRndDelayMax.TextChanged += new System.EventHandler(this.NumberOnlyTextBox);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Random Delay (sn): ";
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.Location = new System.Drawing.Point(642, 17);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(80, 23);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Başlat";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Location = new System.Drawing.Point(6, 22);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(26, 13);
            this.lblUrl.TabIndex = 1;
            this.lblUrl.Text = "Url: ";
            // 
            // tbUrl
            // 
            this.tbUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbUrl.Location = new System.Drawing.Point(38, 19);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(598, 20);
            this.tbUrl.TabIndex = 0;
            this.tbUrl.Text = "https://www.amazon.ca/s?i=merchant-items&me=A1U6PAVBPLQVBI";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(734, 534);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Çıktı Al";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 560);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.gbPreview.ResumeLayout(false);
            this.gbControl.ResumeLayout(false);
            this.gbControl.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox gbControl;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.TextBox tbUrl;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox gbPreview;
        private System.Windows.Forms.CheckBox cbAsyncMode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMaxThread;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbUseRndDelay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbRndDelayMin;
        private System.Windows.Forms.TextBox tbRndDelayMax;
        private System.Windows.Forms.Label label2;
        private WebScraper.Utils.Clients.CustomWebBrowser customWebBrowser1;
    }
}

