namespace BackgroundDominator_v2
{
    partial class frmFullScreen
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
            this.pbFullscreen = new System.Windows.Forms.PictureBox();
            this.tlpComandos = new System.Windows.Forms.TableLayoutPanel();
            this.cmdStretch = new System.Windows.Forms.Button();
            this.cmdCenter = new System.Windows.Forms.Button();
            this.cmdTile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbFullscreen)).BeginInit();
            this.tlpComandos.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbFullscreen
            // 
            this.pbFullscreen.BackColor = System.Drawing.SystemColors.Highlight;
            this.pbFullscreen.Location = new System.Drawing.Point(0, 0);
            this.pbFullscreen.Name = "pbFullscreen";
            this.pbFullscreen.Size = new System.Drawing.Size(463, 300);
            this.pbFullscreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFullscreen.TabIndex = 0;
            this.pbFullscreen.TabStop = false;
            // 
            // tlpComandos
            // 
            this.tlpComandos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpComandos.AutoSize = true;
            this.tlpComandos.ColumnCount = 5;
            this.tlpComandos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpComandos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpComandos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpComandos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpComandos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpComandos.Controls.Add(this.cmdStretch, 1, 0);
            this.tlpComandos.Controls.Add(this.cmdCenter, 2, 0);
            this.tlpComandos.Controls.Add(this.cmdTile, 3, 0);
            this.tlpComandos.Location = new System.Drawing.Point(24, 138);
            this.tlpComandos.Name = "tlpComandos";
            this.tlpComandos.RowCount = 1;
            this.tlpComandos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpComandos.Size = new System.Drawing.Size(404, 74);
            this.tlpComandos.TabIndex = 1;
            // 
            // cmdStretch
            // 
            this.cmdStretch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdStretch.Image = global::BackgroundDominator_v2.Properties.Resources.stretch;
            this.cmdStretch.Location = new System.Drawing.Point(23, 6);
            this.cmdStretch.Name = "cmdStretch";
            this.cmdStretch.Size = new System.Drawing.Size(115, 62);
            this.cmdStretch.TabIndex = 0;
            this.cmdStretch.UseVisualStyleBackColor = true;
            this.cmdStretch.Click += new System.EventHandler(this.cmdStretch_Click);
            // 
            // cmdCenter
            // 
            this.cmdCenter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCenter.Image = global::BackgroundDominator_v2.Properties.Resources.center;
            this.cmdCenter.Location = new System.Drawing.Point(144, 6);
            this.cmdCenter.Name = "cmdCenter";
            this.cmdCenter.Size = new System.Drawing.Size(115, 62);
            this.cmdCenter.TabIndex = 1;
            this.cmdCenter.UseVisualStyleBackColor = true;
            this.cmdCenter.Click += new System.EventHandler(this.cmdCenter_Click);
            // 
            // cmdTile
            // 
            this.cmdTile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdTile.Image = global::BackgroundDominator_v2.Properties.Resources.tile;
            this.cmdTile.Location = new System.Drawing.Point(265, 6);
            this.cmdTile.Name = "cmdTile";
            this.cmdTile.Size = new System.Drawing.Size(115, 62);
            this.cmdTile.TabIndex = 2;
            this.cmdTile.UseVisualStyleBackColor = true;
            this.cmdTile.Click += new System.EventHandler(this.cmdTile_Click);
            // 
            // frmFullScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tlpComandos);
            this.Controls.Add(this.pbFullscreen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "frmFullScreen";
            this.ShowInTaskbar = false;
            this.Text = "frmFullScreen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmFullScreen_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmFullScreen_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbFullscreen)).EndInit();
            this.tlpComandos.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbFullscreen;
        private System.Windows.Forms.TableLayoutPanel tlpComandos;
        private System.Windows.Forms.Button cmdStretch;
        private System.Windows.Forms.Button cmdCenter;
        private System.Windows.Forms.Button cmdTile;
    }
}