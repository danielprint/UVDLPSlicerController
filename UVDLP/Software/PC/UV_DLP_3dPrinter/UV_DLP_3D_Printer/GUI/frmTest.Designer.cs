﻿namespace UV_DLP_3D_Printer.GUI
{
    partial class frmTest
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
            this.ctlMCXY1 = new UV_DLP_3D_Printer.GUI.CustomGUI.ctlMCXY();
            this.SuspendLayout();
            // 
            // ctlMCXY1
            // 
            this.ctlMCXY1.BackColor = System.Drawing.Color.Navy;
            this.ctlMCXY1.Gapx = 0;
            this.ctlMCXY1.Gapy = 0;
            this.ctlMCXY1.GLBackgroundImage = null;
            this.ctlMCXY1.GLVisible = false;
            this.ctlMCXY1.GuiAnchor = null;
            this.ctlMCXY1.Location = new System.Drawing.Point(12, 12);
            this.ctlMCXY1.Name = "ctlMCXY1";
            this.ctlMCXY1.Size = new System.Drawing.Size(238, 238);
            this.ctlMCXY1.StyleName = null;
            this.ctlMCXY1.TabIndex = 0;
            // 
            // frmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 397);
            this.Controls.Add(this.ctlMCXY1);
            this.Name = "frmTest";
            this.Text = "frmTest";
            this.ResumeLayout(false);

        }

        #endregion

        private CustomGUI.ctlMCXY ctlMCXY1;
    }
}