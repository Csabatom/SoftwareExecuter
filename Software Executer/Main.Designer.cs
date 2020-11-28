
namespace Software_Executer
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BTN_newScheme = new System.Windows.Forms.Button();
            this.LB_Schemes = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BTN_newSoftware = new System.Windows.Forms.Button();
            this.BTN_deleteSoftware = new System.Windows.Forms.Button();
            this.LB_Programs = new System.Windows.Forms.ListBox();
            this.BTN_stopScheme = new System.Windows.Forms.Button();
            this.BTN_startScheme = new System.Windows.Forms.Button();
            this.BTN_settings = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.BTN_newScheme);
            this.groupBox1.Controls.Add(this.LB_Schemes);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(161, 328);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sémák";
            // 
            // BTN_newScheme
            // 
            this.BTN_newScheme.Location = new System.Drawing.Point(6, 271);
            this.BTN_newScheme.Name = "BTN_newScheme";
            this.BTN_newScheme.Size = new System.Drawing.Size(93, 50);
            this.BTN_newScheme.TabIndex = 5;
            this.BTN_newScheme.Text = "Új séma";
            this.BTN_newScheme.UseVisualStyleBackColor = true;
            this.BTN_newScheme.Click += new System.EventHandler(this.BTN_newScheme_Click);
            // 
            // LB_Schemes
            // 
            this.LB_Schemes.FormattingEnabled = true;
            this.LB_Schemes.ItemHeight = 16;
            this.LB_Schemes.Location = new System.Drawing.Point(6, 21);
            this.LB_Schemes.Name = "LB_Schemes";
            this.LB_Schemes.Size = new System.Drawing.Size(149, 244);
            this.LB_Schemes.TabIndex = 0;
            this.LB_Schemes.SelectedIndexChanged += new System.EventHandler(this.LB_Schemes_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.groupBox2.Controls.Add(this.BTN_newSoftware);
            this.groupBox2.Controls.Add(this.BTN_deleteSoftware);
            this.groupBox2.Controls.Add(this.LB_Programs);
            this.groupBox2.Location = new System.Drawing.Point(185, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(271, 328);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Programok";
            // 
            // BTN_newSoftware
            // 
            this.BTN_newSoftware.Location = new System.Drawing.Point(6, 271);
            this.BTN_newSoftware.Name = "BTN_newSoftware";
            this.BTN_newSoftware.Size = new System.Drawing.Size(125, 50);
            this.BTN_newSoftware.TabIndex = 4;
            this.BTN_newSoftware.Text = "Program hozzáadása";
            this.BTN_newSoftware.UseVisualStyleBackColor = true;
            // 
            // BTN_deleteSoftware
            // 
            this.BTN_deleteSoftware.Location = new System.Drawing.Point(140, 271);
            this.BTN_deleteSoftware.Name = "BTN_deleteSoftware";
            this.BTN_deleteSoftware.Size = new System.Drawing.Size(125, 50);
            this.BTN_deleteSoftware.TabIndex = 3;
            this.BTN_deleteSoftware.Text = "Program eltávolítása";
            this.BTN_deleteSoftware.UseVisualStyleBackColor = true;
            // 
            // LB_Programs
            // 
            this.LB_Programs.FormattingEnabled = true;
            this.LB_Programs.ItemHeight = 16;
            this.LB_Programs.Location = new System.Drawing.Point(6, 21);
            this.LB_Programs.Name = "LB_Programs";
            this.LB_Programs.Size = new System.Drawing.Size(259, 244);
            this.LB_Programs.TabIndex = 2;
            // 
            // BTN_stopScheme
            // 
            this.BTN_stopScheme.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_stopScheme.Enabled = false;
            this.BTN_stopScheme.Location = new System.Drawing.Point(462, 54);
            this.BTN_stopScheme.Name = "BTN_stopScheme";
            this.BTN_stopScheme.Size = new System.Drawing.Size(90, 140);
            this.BTN_stopScheme.TabIndex = 2;
            this.BTN_stopScheme.Text = "Séma leállítása";
            this.BTN_stopScheme.UseVisualStyleBackColor = true;
            // 
            // BTN_startScheme
            // 
            this.BTN_startScheme.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_startScheme.Location = new System.Drawing.Point(462, 200);
            this.BTN_startScheme.Name = "BTN_startScheme";
            this.BTN_startScheme.Size = new System.Drawing.Size(90, 140);
            this.BTN_startScheme.TabIndex = 3;
            this.BTN_startScheme.Text = "Séma elindítása";
            this.BTN_startScheme.UseVisualStyleBackColor = true;
            // 
            // BTN_settings
            // 
            this.BTN_settings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_settings.Location = new System.Drawing.Point(462, 12);
            this.BTN_settings.Name = "BTN_settings";
            this.BTN_settings.Size = new System.Drawing.Size(90, 36);
            this.BTN_settings.TabIndex = 4;
            this.BTN_settings.Text = "Beállítások";
            this.BTN_settings.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(105, 271);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 6;
            this.button1.Text = "🗑";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(565, 352);
            this.Controls.Add(this.BTN_settings);
            this.Controls.Add(this.BTN_startScheme);
            this.Controls.Add(this.BTN_stopScheme);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Software Executer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox LB_Schemes;
        private System.Windows.Forms.Button BTN_newScheme;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BTN_newSoftware;
        private System.Windows.Forms.Button BTN_deleteSoftware;
        private System.Windows.Forms.ListBox LB_Programs;
        private System.Windows.Forms.Button BTN_stopScheme;
        private System.Windows.Forms.Button BTN_startScheme;
        private System.Windows.Forms.Button BTN_settings;
        private System.Windows.Forms.Button button1;
    }
}

