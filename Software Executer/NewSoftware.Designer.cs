
namespace Software_Executer
{
    partial class NewSoftware
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewSoftware));
            this.CB_softwares = new System.Windows.Forms.ComboBox();
            this.BTN_selectSoftware = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.SelectSoftware = new System.Windows.Forms.TabPage();
            this.MakeNewSoftware = new System.Windows.Forms.TabPage();
            this.CB_schemes = new System.Windows.Forms.ComboBox();
            this.TXTBOX_schemeName = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BTN_newScheme = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.SelectSoftware.SuspendLayout();
            this.MakeNewSoftware.SuspendLayout();
            this.SuspendLayout();
            // 
            // CB_softwares
            // 
            this.CB_softwares.FormattingEnabled = true;
            this.CB_softwares.Location = new System.Drawing.Point(6, 6);
            this.CB_softwares.Name = "CB_softwares";
            this.CB_softwares.Size = new System.Drawing.Size(311, 26);
            this.CB_softwares.TabIndex = 10;
            this.CB_softwares.SelectedIndexChanged += new System.EventHandler(this.CB_softwares_SelectedIndexChanged);
            // 
            // BTN_selectSoftware
            // 
            this.BTN_selectSoftware.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_selectSoftware.Enabled = false;
            this.BTN_selectSoftware.Location = new System.Drawing.Point(6, 136);
            this.BTN_selectSoftware.Name = "BTN_selectSoftware";
            this.BTN_selectSoftware.Size = new System.Drawing.Size(311, 40);
            this.BTN_selectSoftware.TabIndex = 10;
            this.BTN_selectSoftware.Text = "Szoftver kiválasztása";
            this.BTN_selectSoftware.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.SelectSoftware);
            this.tabControl1.Controls.Add(this.MakeNewSoftware);
            this.tabControl1.Location = new System.Drawing.Point(11, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(331, 216);
            this.tabControl1.TabIndex = 11;
            // 
            // SelectSoftware
            // 
            this.SelectSoftware.Controls.Add(this.CB_softwares);
            this.SelectSoftware.Controls.Add(this.BTN_selectSoftware);
            this.SelectSoftware.Font = new System.Drawing.Font("Montserrat", 8F);
            this.SelectSoftware.Location = new System.Drawing.Point(4, 25);
            this.SelectSoftware.Name = "SelectSoftware";
            this.SelectSoftware.Padding = new System.Windows.Forms.Padding(3);
            this.SelectSoftware.Size = new System.Drawing.Size(323, 187);
            this.SelectSoftware.TabIndex = 0;
            this.SelectSoftware.Text = "Szoftver kiválasztása";
            this.SelectSoftware.UseVisualStyleBackColor = true;
            // 
            // MakeNewSoftware
            // 
            this.MakeNewSoftware.Controls.Add(this.CB_schemes);
            this.MakeNewSoftware.Controls.Add(this.TXTBOX_schemeName);
            this.MakeNewSoftware.Controls.Add(this.textBox1);
            this.MakeNewSoftware.Controls.Add(this.BTN_newScheme);
            this.MakeNewSoftware.Controls.Add(this.button2);
            this.MakeNewSoftware.Controls.Add(this.button1);
            this.MakeNewSoftware.Font = new System.Drawing.Font("Montserrat", 8F);
            this.MakeNewSoftware.Location = new System.Drawing.Point(4, 25);
            this.MakeNewSoftware.Name = "MakeNewSoftware";
            this.MakeNewSoftware.Padding = new System.Windows.Forms.Padding(3);
            this.MakeNewSoftware.Size = new System.Drawing.Size(323, 187);
            this.MakeNewSoftware.TabIndex = 1;
            this.MakeNewSoftware.Text = "Új szoftver létrehozása";
            this.MakeNewSoftware.UseVisualStyleBackColor = true;
            // 
            // CB_schemes
            // 
            this.CB_schemes.FormattingEnabled = true;
            this.CB_schemes.Location = new System.Drawing.Point(13, 23);
            this.CB_schemes.Name = "CB_schemes";
            this.CB_schemes.Size = new System.Drawing.Size(296, 26);
            this.CB_schemes.TabIndex = 11;
            // 
            // TXTBOX_schemeName
            // 
            this.TXTBOX_schemeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TXTBOX_schemeName.ForeColor = System.Drawing.Color.Silver;
            this.TXTBOX_schemeName.Location = new System.Drawing.Point(13, 53);
            this.TXTBOX_schemeName.Name = "TXTBOX_schemeName";
            this.TXTBOX_schemeName.Size = new System.Drawing.Size(296, 24);
            this.TXTBOX_schemeName.TabIndex = 10;
            this.TXTBOX_schemeName.TabStop = false;
            this.TXTBOX_schemeName.Text = "Séma neve";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 82);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(251, 24);
            this.textBox1.TabIndex = 13;
            // 
            // BTN_newScheme
            // 
            this.BTN_newScheme.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_newScheme.Enabled = false;
            this.BTN_newScheme.Location = new System.Drawing.Point(59, 136);
            this.BTN_newScheme.Name = "BTN_newScheme";
            this.BTN_newScheme.Size = new System.Drawing.Size(250, 40);
            this.BTN_newScheme.TabIndex = 15;
            this.BTN_newScheme.Text = "Szoftver létrehozása";
            this.BTN_newScheme.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Montserrat", 10F);
            this.button2.Location = new System.Drawing.Point(269, 82);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 24);
            this.button2.TabIndex = 14;
            this.button2.Text = "°°°";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Montserrat", 10F);
            this.button1.Location = new System.Drawing.Point(13, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 40);
            this.button1.TabIndex = 12;
            this.button1.Text = "📂";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // NewSoftware
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 240);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewSoftware";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Új Program Létrehozása";
            this.tabControl1.ResumeLayout(false);
            this.SelectSoftware.ResumeLayout(false);
            this.MakeNewSoftware.ResumeLayout(false);
            this.MakeNewSoftware.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox CB_softwares;
        private System.Windows.Forms.Button BTN_selectSoftware;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage SelectSoftware;
        private System.Windows.Forms.TabPage MakeNewSoftware;
        private System.Windows.Forms.ComboBox CB_schemes;
        private System.Windows.Forms.TextBox TXTBOX_schemeName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button BTN_newScheme;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}