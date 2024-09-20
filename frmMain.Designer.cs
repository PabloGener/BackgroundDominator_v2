namespace BackgroundDominator_v2
{
    partial class frmMain
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
            this.txtCarpeta = new System.Windows.Forms.TextBox();
            this.cmdCarpeta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCarpeta
            // 
            this.txtCarpeta.AllowDrop = true;
            this.txtCarpeta.Location = new System.Drawing.Point(12, 12);
            this.txtCarpeta.Name = "txtCarpeta";
            this.txtCarpeta.Size = new System.Drawing.Size(731, 20);
            this.txtCarpeta.TabIndex = 0;
            this.txtCarpeta.DragDrop += new System.Windows.Forms.DragEventHandler(this.txtCarpeta_DragDrop);
            this.txtCarpeta.DragEnter += new System.Windows.Forms.DragEventHandler(this.txtCarpeta_DragEnter);
            // 
            // cmdCarpeta
            // 
            this.cmdCarpeta.Location = new System.Drawing.Point(749, 12);
            this.cmdCarpeta.Name = "cmdCarpeta";
            this.cmdCarpeta.Size = new System.Drawing.Size(39, 23);
            this.cmdCarpeta.TabIndex = 1;
            this.cmdCarpeta.Text = "...";
            this.cmdCarpeta.UseVisualStyleBackColor = true;
            this.cmdCarpeta.Click += new System.EventHandler(this.cmdCarpeta_Click);
            // 
            // frmMain
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmdCarpeta);
            this.Controls.Add(this.txtCarpeta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Background Dominator v2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCarpeta;
        private System.Windows.Forms.Button cmdCarpeta;
    }
}

