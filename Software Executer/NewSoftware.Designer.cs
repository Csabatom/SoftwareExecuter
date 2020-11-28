
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.SelectSoftware = new System.Windows.Forms.TabPage();
            this.BTN_selectSoftware = new System.Windows.Forms.Button();
            this.MakeNewSoftware = new System.Windows.Forms.TabPage();
            this.TXTBOX_executePath = new System.Windows.Forms.TextBox();
            this.BTN_executePathExplorer = new System.Windows.Forms.Button();
            this.TXTBOX_softwareName = new System.Windows.Forms.TextBox();
            this.TXTBOX_openPath = new System.Windows.Forms.TextBox();
            this.BTN_newSoftware = new System.Windows.Forms.Button();
            this.BTN_openPathExplorer = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.SelectSoftware.SuspendLayout();
            this.MakeNewSoftware.SuspendLayout();
            this.SuspendLayout();
            // 
            // CB_softwares
            // 
            this.CB_softwares.FormattingEnabled = true;
            this.CB_softwares.Location = new System.Drawing.Point(13, 10);
            this.CB_softwares.Name = "CB_softwares";
            this.CB_softwares.Size = new System.Drawing.Size(296, 26);
            this.CB_softwares.TabIndex = 10;
            this.CB_softwares.SelectedIndexChanged += new System.EventHandler(this.CB_softwares_SelectedIndexChanged);
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
            this.SelectSoftware.Controls.Add(this.BTN_selectSoftware);
            this.SelectSoftware.Controls.Add(this.CB_softwares);
            this.SelectSoftware.Font = new System.Drawing.Font("Montserrat", 8F);
            this.SelectSoftware.Location = new System.Drawing.Point(4, 25);
            this.SelectSoftware.Name = "SelectSoftware";
            this.SelectSoftware.Padding = new System.Windows.Forms.Padding(3);
            this.SelectSoftware.Size = new System.Drawing.Size(323, 187);
            this.SelectSoftware.TabIndex = 0;
            this.SelectSoftware.Text = "Szoftver kiválasztása";
            this.SelectSoftware.UseVisualStyleBackColor = true;
            // 
            // BTN_selectSoftware
            // 
            this.BTN_selectSoftware.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_selectSoftware.Enabled = false;
            this.BTN_selectSoftware.Location = new System.Drawing.Point(13, 140);
            this.BTN_selectSoftware.Name = "BTN_selectSoftware";
            this.BTN_selectSoftware.Size = new System.Drawing.Size(296, 40);
            this.BTN_selectSoftware.TabIndex = 16;
            this.BTN_selectSoftware.Text = "Szoftver kiválasztása";
            this.BTN_selectSoftware.UseVisualStyleBackColor = true;
            this.BTN_selectSoftware.Click += new System.EventHandler(this.BTN_selectSoftware_Click);
            // 
            // MakeNewSoftware
            // 
            this.MakeNewSoftware.Controls.Add(this.TXTBOX_executePath);
            this.MakeNewSoftware.Controls.Add(this.BTN_executePathExplorer);
            this.MakeNewSoftware.Controls.Add(this.TXTBOX_softwareName);
            this.MakeNewSoftware.Controls.Add(this.TXTBOX_openPath);
            this.MakeNewSoftware.Controls.Add(this.BTN_newSoftware);
            this.MakeNewSoftware.Controls.Add(this.BTN_openPathExplorer);
            this.MakeNewSoftware.Font = new System.Drawing.Font("Montserrat", 8F);
            this.MakeNewSoftware.Location = new System.Drawing.Point(4, 25);
            this.MakeNewSoftware.Name = "MakeNewSoftware";
            this.MakeNewSoftware.Padding = new System.Windows.Forms.Padding(3);
            this.MakeNewSoftware.Size = new System.Drawing.Size(323, 187);
            this.MakeNewSoftware.TabIndex = 1;
            this.MakeNewSoftware.Text = "Új szoftver létrehozása";
            this.MakeNewSoftware.UseVisualStyleBackColor = true;
            // 
            // TXTBOX_executePath
            // 
            this.TXTBOX_executePath.ForeColor = System.Drawing.Color.Silver;
            this.TXTBOX_executePath.Location = new System.Drawing.Point(13, 40);
            this.TXTBOX_executePath.Name = "TXTBOX_executePath";
            this.TXTBOX_executePath.Size = new System.Drawing.Size(251, 24);
            this.TXTBOX_executePath.TabIndex = 16;
            this.TXTBOX_executePath.Text = "Alkalmazás (.exe) fájlt elérési útja";
            this.TXTBOX_executePath.TextChanged += new System.EventHandler(this.TXTBOX_executePath_TextChanged);
            this.TXTBOX_executePath.Enter += new System.EventHandler(this.TXTBOX_executePath_FocusEnter);
            this.TXTBOX_executePath.Leave += new System.EventHandler(this.TXTBOX_executePath_FocusLeave);
            // 
            // BTN_executePathExplorer
            // 
            this.BTN_executePathExplorer.Font = new System.Drawing.Font("Montserrat", 10F);
            this.BTN_executePathExplorer.Location = new System.Drawing.Point(269, 40);
            this.BTN_executePathExplorer.Name = "BTN_executePathExplorer";
            this.BTN_executePathExplorer.Size = new System.Drawing.Size(40, 24);
            this.BTN_executePathExplorer.TabIndex = 17;
            this.BTN_executePathExplorer.Text = "°°°";
            this.BTN_executePathExplorer.UseVisualStyleBackColor = true;
            this.BTN_executePathExplorer.Click += new System.EventHandler(this.BTN_pathExplorer_Click);
            // 
            // TXTBOX_softwareName
            // 
            this.TXTBOX_softwareName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TXTBOX_softwareName.ForeColor = System.Drawing.Color.Silver;
            this.TXTBOX_softwareName.Location = new System.Drawing.Point(13, 10);
            this.TXTBOX_softwareName.Name = "TXTBOX_softwareName";
            this.TXTBOX_softwareName.Size = new System.Drawing.Size(296, 24);
            this.TXTBOX_softwareName.TabIndex = 10;
            this.TXTBOX_softwareName.TabStop = false;
            this.TXTBOX_softwareName.Text = "Szoftver neve";
            this.TXTBOX_softwareName.TextChanged += new System.EventHandler(this.TXTBOX_softwareName_TextChanged);
            this.TXTBOX_softwareName.Enter += new System.EventHandler(this.TXTBOX_softwareName_FocusEnter);
            this.TXTBOX_softwareName.Leave += new System.EventHandler(this.TXTBOX_softwareName_FocusLeave);
            // 
            // TXTBOX_openPath
            // 
            this.TXTBOX_openPath.ForeColor = System.Drawing.Color.Silver;
            this.TXTBOX_openPath.Location = new System.Drawing.Point(13, 70);
            this.TXTBOX_openPath.Name = "TXTBOX_openPath";
            this.TXTBOX_openPath.Size = new System.Drawing.Size(251, 24);
            this.TXTBOX_openPath.TabIndex = 13;
            this.TXTBOX_openPath.Text = "Betöltendő mappa, fájl vagy URL";
            this.TXTBOX_openPath.TextChanged += new System.EventHandler(this.TXTBOX_openPath_TextChanged);
            this.TXTBOX_openPath.Enter += new System.EventHandler(this.TXTBOX_openPath_FocusEnter);
            this.TXTBOX_openPath.Leave += new System.EventHandler(this.TXTBOX_openPath_FocusLeave);
            // 
            // BTN_newSoftware
            // 
            this.BTN_newSoftware.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_newSoftware.Enabled = false;
            this.BTN_newSoftware.Location = new System.Drawing.Point(13, 140);
            this.BTN_newSoftware.Name = "BTN_newSoftware";
            this.BTN_newSoftware.Size = new System.Drawing.Size(296, 40);
            this.BTN_newSoftware.TabIndex = 15;
            this.BTN_newSoftware.Text = "Szoftver létrehozása";
            this.BTN_newSoftware.UseVisualStyleBackColor = true;
            this.BTN_newSoftware.Click += new System.EventHandler(this.BTN_newSoftware_Click);
            // 
            // BTN_openPathExplorer
            // 
            this.BTN_openPathExplorer.Font = new System.Drawing.Font("Montserrat", 10F);
            this.BTN_openPathExplorer.Location = new System.Drawing.Point(269, 70);
            this.BTN_openPathExplorer.Name = "BTN_openPathExplorer";
            this.BTN_openPathExplorer.Size = new System.Drawing.Size(40, 24);
            this.BTN_openPathExplorer.TabIndex = 14;
            this.BTN_openPathExplorer.Text = "°°°";
            this.BTN_openPathExplorer.UseVisualStyleBackColor = true;
            this.BTN_openPathExplorer.Click += new System.EventHandler(this.BTN_openPathFile_Click);
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
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage SelectSoftware;
        private System.Windows.Forms.TabPage MakeNewSoftware;
        private System.Windows.Forms.TextBox TXTBOX_softwareName;
        private System.Windows.Forms.TextBox TXTBOX_openPath;
        private System.Windows.Forms.Button BTN_newSoftware;
        private System.Windows.Forms.Button BTN_openPathExplorer;
        private System.Windows.Forms.Button BTN_selectSoftware;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TextBox TXTBOX_executePath;
        private System.Windows.Forms.Button BTN_executePathExplorer;
    }
}