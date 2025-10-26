namespace Ejercicio3
{
    partial class ImagenGenerada
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImagenGenerada));
            this.imagenFondo = new System.Windows.Forms.PictureBox();
            this.menuContextual = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ajustarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noDeformarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.imagenFondo)).BeginInit();
            this.menuContextual.SuspendLayout();
            this.SuspendLayout();
            // 
            // imagenFondo
            // 
            this.imagenFondo.ContextMenuStrip = this.menuContextual;
            this.imagenFondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imagenFondo.Location = new System.Drawing.Point(0, 0);
            this.imagenFondo.Name = "imagenFondo";
            this.imagenFondo.Size = new System.Drawing.Size(800, 450);
            this.imagenFondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagenFondo.TabIndex = 0;
            this.imagenFondo.TabStop = false;
            // 
            // menuContextual
            // 
            this.menuContextual.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuContextual.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajustarToolStripMenuItem,
            this.noDeformarToolStripMenuItem});
            this.menuContextual.Name = "contextMenuStrip1";
            this.menuContextual.Size = new System.Drawing.Size(165, 52);
            this.menuContextual.Opening += new System.ComponentModel.CancelEventHandler(this.menuContextual_Opening);
            // 
            // ajustarToolStripMenuItem
            // 
            this.ajustarToolStripMenuItem.Name = "ajustarToolStripMenuItem";
            this.ajustarToolStripMenuItem.Size = new System.Drawing.Size(164, 24);
            this.ajustarToolStripMenuItem.Text = "Ajustar";
            this.ajustarToolStripMenuItem.Click += new System.EventHandler(this.ajustarToolStripMenuItem_Click);
            // 
            // noDeformarToolStripMenuItem
            // 
            this.noDeformarToolStripMenuItem.Name = "noDeformarToolStripMenuItem";
            this.noDeformarToolStripMenuItem.Size = new System.Drawing.Size(164, 24);
            this.noDeformarToolStripMenuItem.Text = "No deformar";
            this.noDeformarToolStripMenuItem.Click += new System.EventHandler(this.noDeformarToolStripMenuItem_Click);
            // 
            // ImagenGenerada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.imagenFondo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ImagenGenerada";
            this.Text = "ImagenGenerada";
            ((System.ComponentModel.ISupportInitialize)(this.imagenFondo)).EndInit();
            this.menuContextual.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox imagenFondo;
        private System.Windows.Forms.ContextMenuStrip menuContextual;
        private System.Windows.Forms.ToolStripMenuItem ajustarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noDeformarToolStripMenuItem;
    }
}