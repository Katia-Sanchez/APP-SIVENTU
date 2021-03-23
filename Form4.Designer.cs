
namespace APP_SIVENTU
{
    partial class MenuTotal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuTotal));
            this.panel4 = new System.Windows.Forms.Panel();
            this.btRegresar = new System.Windows.Forms.PictureBox();
            this.BtMini3 = new System.Windows.Forms.PictureBox();
            this.BtSalir3 = new System.Windows.Forms.PictureBox();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btRegresar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtMini3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtSalir3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel4.Controls.Add(this.btRegresar);
            this.panel4.Controls.Add(this.BtMini3);
            this.panel4.Controls.Add(this.BtSalir3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(800, 40);
            this.panel4.TabIndex = 3;
            // 
            // btRegresar
            // 
            this.btRegresar.Image = ((System.Drawing.Image)(resources.GetObject("btRegresar.Image")));
            this.btRegresar.Location = new System.Drawing.Point(12, 5);
            this.btRegresar.Name = "btRegresar";
            this.btRegresar.Size = new System.Drawing.Size(30, 30);
            this.btRegresar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btRegresar.TabIndex = 2;
            this.btRegresar.TabStop = false;
            // 
            // BtMini3
            // 
            this.BtMini3.Image = ((System.Drawing.Image)(resources.GetObject("BtMini3.Image")));
            this.BtMini3.Location = new System.Drawing.Point(721, 5);
            this.BtMini3.Name = "BtMini3";
            this.BtMini3.Size = new System.Drawing.Size(30, 30);
            this.BtMini3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtMini3.TabIndex = 1;
            this.BtMini3.TabStop = false;
            // 
            // BtSalir3
            // 
            this.BtSalir3.Image = ((System.Drawing.Image)(resources.GetObject("BtSalir3.Image")));
            this.BtSalir3.Location = new System.Drawing.Point(766, 5);
            this.BtSalir3.Name = "BtSalir3";
            this.BtSalir3.Size = new System.Drawing.Size(30, 30);
            this.BtSalir3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtSalir3.TabIndex = 0;
            this.BtSalir3.TabStop = false;
            // 
            // MenuTotal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 575);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuTotal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btRegresar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtMini3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtSalir3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox btRegresar;
        private System.Windows.Forms.PictureBox BtMini3;
        private System.Windows.Forms.PictureBox BtSalir3;
    }
}