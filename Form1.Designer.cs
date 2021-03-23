
namespace APP_SIVENTU
{
    partial class presentacion
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(presentacion));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtMini = new System.Windows.Forms.PictureBox();
            this.BtSalir = new System.Windows.Forms.PictureBox();
            this.btAcces = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtMini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtSalir)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.BtMini);
            this.panel1.Controls.Add(this.BtSalir);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(808, 40);
            this.panel1.TabIndex = 0;
            // 
            // BtMini
            // 
            this.BtMini.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtMini.BackgroundImage")));
            this.BtMini.Image = ((System.Drawing.Image)(resources.GetObject("BtMini.Image")));
            this.BtMini.Location = new System.Drawing.Point(721, 5);
            this.BtMini.Name = "BtMini";
            this.BtMini.Size = new System.Drawing.Size(30, 30);
            this.BtMini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtMini.TabIndex = 1;
            this.BtMini.TabStop = false;
            this.BtMini.Click += new System.EventHandler(this.BtMini_Click);
            // 
            // BtSalir
            // 
            this.BtSalir.Image = ((System.Drawing.Image)(resources.GetObject("BtSalir.Image")));
            this.BtSalir.Location = new System.Drawing.Point(766, 5);
            this.BtSalir.Name = "BtSalir";
            this.BtSalir.Size = new System.Drawing.Size(30, 30);
            this.BtSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtSalir.TabIndex = 0;
            this.BtSalir.TabStop = false;
            this.BtSalir.Click += new System.EventHandler(this.BtSalir_Click);
            // 
            // btAcces
            // 
            this.btAcces.Activecolor = System.Drawing.Color.CornflowerBlue;
            this.btAcces.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btAcces.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btAcces.BorderRadius = 0;
            this.btAcces.ButtonText = "INGRESAR";
            this.btAcces.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAcces.DisabledColor = System.Drawing.Color.Gray;
            this.btAcces.Iconcolor = System.Drawing.Color.Transparent;
            this.btAcces.Iconimage = ((System.Drawing.Image)(resources.GetObject("btAcces.Iconimage")));
            this.btAcces.Iconimage_right = null;
            this.btAcces.Iconimage_right_Selected = null;
            this.btAcces.Iconimage_Selected = null;
            this.btAcces.IconMarginLeft = 0;
            this.btAcces.IconMarginRight = 0;
            this.btAcces.IconRightVisible = true;
            this.btAcces.IconRightZoom = 0D;
            this.btAcces.IconVisible = true;
            this.btAcces.IconZoom = 90D;
            this.btAcces.IsTab = false;
            this.btAcces.Location = new System.Drawing.Point(303, 476);
            this.btAcces.Margin = new System.Windows.Forms.Padding(4);
            this.btAcces.Name = "btAcces";
            this.btAcces.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btAcces.OnHovercolor = System.Drawing.Color.CornflowerBlue;
            this.btAcces.OnHoverTextColor = System.Drawing.Color.White;
            this.btAcces.selected = false;
            this.btAcces.Size = new System.Drawing.Size(186, 59);
            this.btAcces.TabIndex = 1;
            this.btAcces.Text = "INGRESAR";
            this.btAcces.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAcces.Textcolor = System.Drawing.Color.White;
            this.btAcces.TextFont = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAcces.Click += new System.EventHandler(this.btAcces_Click);
            // 
            // presentacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(808, 575);
            this.Controls.Add(this.btAcces);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "presentacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtMini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtSalir)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton btAcces;
        private System.Windows.Forms.PictureBox BtSalir;
        private System.Windows.Forms.PictureBox BtMini;
    }
}

