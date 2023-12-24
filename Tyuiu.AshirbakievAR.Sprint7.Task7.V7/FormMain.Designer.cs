
namespace Tyuiu.AshirbakievAR.Sprint7.Task7.V7
{
    partial class FormMain
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
            this.panelMainMenu_AAR = new System.Windows.Forms.Panel();
            this.btnHelp_AAR = new System.Windows.Forms.Button();
            this.btnProducts_AAR = new System.Windows.Forms.Button();
            this.panelLogo_AAR = new System.Windows.Forms.Panel();
            this.LblLogo_AAR = new System.Windows.Forms.Label();
            this.panelTitleBar_AAR = new System.Windows.Forms.Panel();
            this.lblTittle_AAR = new System.Windows.Forms.Label();
            this.panelDesktopPanel_AAR = new System.Windows.Forms.Panel();
            this.panelMainMenu_AAR.SuspendLayout();
            this.panelLogo_AAR.SuspendLayout();
            this.panelTitleBar_AAR.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMainMenu_AAR
            // 
            this.panelMainMenu_AAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMainMenu_AAR.Controls.Add(this.btnHelp_AAR);
            this.panelMainMenu_AAR.Controls.Add(this.btnProducts_AAR);
            this.panelMainMenu_AAR.Controls.Add(this.panelLogo_AAR);
            this.panelMainMenu_AAR.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMainMenu_AAR.Location = new System.Drawing.Point(0, 0);
            this.panelMainMenu_AAR.Name = "panelMainMenu_AAR";
            this.panelMainMenu_AAR.Size = new System.Drawing.Size(220, 541);
            this.panelMainMenu_AAR.TabIndex = 0;
            // 
            // btnHelp_AAR
            // 
            this.btnHelp_AAR.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHelp_AAR.FlatAppearance.BorderSize = 0;
            this.btnHelp_AAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp_AAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnHelp_AAR.ForeColor = System.Drawing.Color.White;
            this.btnHelp_AAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelp_AAR.Location = new System.Drawing.Point(0, 140);
            this.btnHelp_AAR.Name = "btnHelp_AAR";
            this.btnHelp_AAR.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnHelp_AAR.Size = new System.Drawing.Size(220, 60);
            this.btnHelp_AAR.TabIndex = 3;
            this.btnHelp_AAR.Text = "   Help";
            this.btnHelp_AAR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelp_AAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHelp_AAR.UseVisualStyleBackColor = true;
            this.btnHelp_AAR.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnProducts_AAR
            // 
            this.btnProducts_AAR.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProducts_AAR.FlatAppearance.BorderSize = 0;
            this.btnProducts_AAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducts_AAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnProducts_AAR.ForeColor = System.Drawing.Color.White;
            this.btnProducts_AAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProducts_AAR.Location = new System.Drawing.Point(0, 80);
            this.btnProducts_AAR.Name = "btnProducts_AAR";
            this.btnProducts_AAR.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnProducts_AAR.Size = new System.Drawing.Size(220, 60);
            this.btnProducts_AAR.TabIndex = 1;
            this.btnProducts_AAR.Text = "   Product";
            this.btnProducts_AAR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProducts_AAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProducts_AAR.UseVisualStyleBackColor = true;
            this.btnProducts_AAR.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // panelLogo_AAR
            // 
            this.panelLogo_AAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo_AAR.Controls.Add(this.LblLogo_AAR);
            this.panelLogo_AAR.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo_AAR.Location = new System.Drawing.Point(0, 0);
            this.panelLogo_AAR.Name = "panelLogo_AAR";
            this.panelLogo_AAR.Size = new System.Drawing.Size(220, 80);
            this.panelLogo_AAR.TabIndex = 0;
            // 
            // LblLogo_AAR
            // 
            this.LblLogo_AAR.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblLogo_AAR.AutoSize = true;
            this.LblLogo_AAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblLogo_AAR.ForeColor = System.Drawing.Color.White;
            this.LblLogo_AAR.Location = new System.Drawing.Point(8, 29);
            this.LblLogo_AAR.Name = "LblLogo_AAR";
            this.LblLogo_AAR.Size = new System.Drawing.Size(209, 26);
            this.LblLogo_AAR.TabIndex = 2;
            this.LblLogo_AAR.Text = "House management";
            // 
            // panelTitleBar_AAR
            // 
            this.panelTitleBar_AAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panelTitleBar_AAR.Controls.Add(this.lblTittle_AAR);
            this.panelTitleBar_AAR.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar_AAR.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar_AAR.Name = "panelTitleBar_AAR";
            this.panelTitleBar_AAR.Size = new System.Drawing.Size(864, 80);
            this.panelTitleBar_AAR.TabIndex = 1;
            // 
            // lblTittle_AAR
            // 
            this.lblTittle_AAR.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTittle_AAR.AutoSize = true;
            this.lblTittle_AAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTittle_AAR.ForeColor = System.Drawing.Color.White;
            this.lblTittle_AAR.Location = new System.Drawing.Point(375, 29);
            this.lblTittle_AAR.Name = "lblTittle_AAR";
            this.lblTittle_AAR.Size = new System.Drawing.Size(78, 26);
            this.lblTittle_AAR.TabIndex = 0;
            this.lblTittle_AAR.Text = "HOME";
            // 
            // panelDesktopPanel_AAR
            // 
            this.panelDesktopPanel_AAR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPanel_AAR.Location = new System.Drawing.Point(220, 80);
            this.panelDesktopPanel_AAR.Name = "panelDesktopPanel_AAR";
            this.panelDesktopPanel_AAR.Size = new System.Drawing.Size(864, 461);
            this.panelDesktopPanel_AAR.TabIndex = 2;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 541);
            this.Controls.Add(this.panelDesktopPanel_AAR);
            this.Controls.Add(this.panelTitleBar_AAR);
            this.Controls.Add(this.panelMainMenu_AAR);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.panelMainMenu_AAR.ResumeLayout(false);
            this.panelLogo_AAR.ResumeLayout(false);
            this.panelLogo_AAR.PerformLayout();
            this.panelTitleBar_AAR.ResumeLayout(false);
            this.panelTitleBar_AAR.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMainMenu_AAR;
        private System.Windows.Forms.Button btnProducts_AAR;
        private System.Windows.Forms.Panel panelLogo_AAR;
        private System.Windows.Forms.Button btnHelp_AAR;
        private System.Windows.Forms.Panel panelTitleBar_AAR;
        private System.Windows.Forms.Label lblTittle_AAR;
        private System.Windows.Forms.Panel panelDesktopPanel_AAR;
        private System.Windows.Forms.Label LblLogo_AAR;
    }
}

