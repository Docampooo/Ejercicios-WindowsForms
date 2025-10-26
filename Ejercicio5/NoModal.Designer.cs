namespace Ejercicio5
{
    partial class NoModal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NoModal));
            this.txtAgenda = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtAgenda
            // 
            this.txtAgenda.BackColor = System.Drawing.Color.Black;
            this.txtAgenda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAgenda.ForeColor = System.Drawing.Color.White;
            this.txtAgenda.Location = new System.Drawing.Point(0, 0);
            this.txtAgenda.Multiline = true;
            this.txtAgenda.Name = "txtAgenda";
            this.txtAgenda.ReadOnly = true;
            this.txtAgenda.Size = new System.Drawing.Size(348, 450);
            this.txtAgenda.TabIndex = 0;
            this.txtAgenda.TextChanged += new System.EventHandler(this.txtAgenda_TextChanged);
            // 
            // NoModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 450);
            this.Controls.Add(this.txtAgenda);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NoModal";
            this.Text = "NoModal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtAgenda;
    }
}