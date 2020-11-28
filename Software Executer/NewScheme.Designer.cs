
namespace Software_Executer
{
    partial class NewScheme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewScheme));
            this.TXTBOX_schemeName = new System.Windows.Forms.TextBox();
            this.BTN_newScheme = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TXTBOX_schemeName
            // 
            this.TXTBOX_schemeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TXTBOX_schemeName.ForeColor = System.Drawing.Color.Silver;
            this.TXTBOX_schemeName.Location = new System.Drawing.Point(12, 12);
            this.TXTBOX_schemeName.Name = "TXTBOX_schemeName";
            this.TXTBOX_schemeName.Size = new System.Drawing.Size(358, 22);
            this.TXTBOX_schemeName.TabIndex = 0;
            this.TXTBOX_schemeName.TabStop = false;
            this.TXTBOX_schemeName.Text = "Séma neve";
            this.TXTBOX_schemeName.TextChanged += new System.EventHandler(this.TXTBOX_schemeName_TextChanged);
            this.TXTBOX_schemeName.Enter += new System.EventHandler(this.TXTBOX_schemeName_Enter);
            this.TXTBOX_schemeName.Leave += new System.EventHandler(this.TXTBOX_schemeName_Leave);
            // 
            // BTN_newScheme
            // 
            this.BTN_newScheme.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BTN_newScheme.Enabled = false;
            this.BTN_newScheme.Location = new System.Drawing.Point(12, 73);
            this.BTN_newScheme.Name = "BTN_newScheme";
            this.BTN_newScheme.Size = new System.Drawing.Size(358, 50);
            this.BTN_newScheme.TabIndex = 5;
            this.BTN_newScheme.Text = "Séma létrehozása";
            this.BTN_newScheme.UseVisualStyleBackColor = true;
            this.BTN_newScheme.Click += new System.EventHandler(this.BTN_newScheme_Click);
            // 
            // NewScheme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 153);
            this.Controls.Add(this.BTN_newScheme);
            this.Controls.Add(this.TXTBOX_schemeName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewScheme";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Új séma";
            this.Click += new System.EventHandler(this.NewScheme_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXTBOX_schemeName;
        private System.Windows.Forms.Button BTN_newScheme;
    }
}