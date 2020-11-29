
namespace Software_Executer
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.BTN_saveDatabase = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BTN_loadDatabase = new System.Windows.Forms.Button();
            this.CB_languages = new System.Windows.Forms.ComboBox();
            this.BTN_languageApply = new System.Windows.Forms.Button();
            this.saveDatabase = new System.Windows.Forms.SaveFileDialog();
            this.loadDatabase = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTN_saveDatabase
            // 
            this.BTN_saveDatabase.Font = new System.Drawing.Font("Montserrat", 12F);
            this.BTN_saveDatabase.Location = new System.Drawing.Point(17, 31);
            this.BTN_saveDatabase.Name = "BTN_saveDatabase";
            this.BTN_saveDatabase.Size = new System.Drawing.Size(140, 50);
            this.BTN_saveDatabase.TabIndex = 6;
            this.BTN_saveDatabase.TabStop = false;
            this.BTN_saveDatabase.Text = "💾";
            this.BTN_saveDatabase.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BTN_loadDatabase);
            this.groupBox1.Controls.Add(this.BTN_saveDatabase);
            this.groupBox1.Location = new System.Drawing.Point(12, 148);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 100);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sémák mentése és betöltése";
            // 
            // BTN_loadDatabase
            // 
            this.BTN_loadDatabase.Font = new System.Drawing.Font("Montserrat", 12F);
            this.BTN_loadDatabase.Location = new System.Drawing.Point(164, 31);
            this.BTN_loadDatabase.Name = "BTN_loadDatabase";
            this.BTN_loadDatabase.Size = new System.Drawing.Size(140, 50);
            this.BTN_loadDatabase.TabIndex = 7;
            this.BTN_loadDatabase.TabStop = false;
            this.BTN_loadDatabase.Text = "📁";
            this.BTN_loadDatabase.UseVisualStyleBackColor = true;
            // 
            // CB_languages
            // 
            this.CB_languages.FormattingEnabled = true;
            this.CB_languages.Location = new System.Drawing.Point(12, 13);
            this.CB_languages.Name = "CB_languages";
            this.CB_languages.Size = new System.Drawing.Size(199, 24);
            this.CB_languages.TabIndex = 8;
            this.CB_languages.TabStop = false;
            // 
            // BTN_languageApply
            // 
            this.BTN_languageApply.Location = new System.Drawing.Point(217, 12);
            this.BTN_languageApply.Name = "BTN_languageApply";
            this.BTN_languageApply.Size = new System.Drawing.Size(107, 25);
            this.BTN_languageApply.TabIndex = 9;
            this.BTN_languageApply.TabStop = false;
            this.BTN_languageApply.Text = "Alkalmaz";
            this.BTN_languageApply.UseVisualStyleBackColor = true;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 256);
            this.Controls.Add(this.BTN_languageApply);
            this.Controls.Add(this.CB_languages);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Beállítások";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTN_saveDatabase;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BTN_loadDatabase;
        private System.Windows.Forms.ComboBox CB_languages;
        private System.Windows.Forms.Button BTN_languageApply;
        private System.Windows.Forms.SaveFileDialog saveDatabase;
        private System.Windows.Forms.OpenFileDialog loadDatabase;
    }
}