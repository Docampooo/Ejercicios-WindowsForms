namespace EjerciciosWindowsForms
{
    partial class MouseTester
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MouseTester));
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(245, 41);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(101, 80);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "Izquierdo";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ratonEnBoton);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(441, 41);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(100, 80);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "Derecho";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ratonEnBoton);
            // 
            // MouseTester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MouseTester";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MouseTester_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MouseTester_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseTester_MouseDown);
            this.MouseLeave += new System.EventHandler(this.MouseTester_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseTester_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseTester_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
    }
}

