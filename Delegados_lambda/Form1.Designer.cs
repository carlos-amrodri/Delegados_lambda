namespace Delegados_lambda
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.delegadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.primerEjemploToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.segundoEjemploToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linQToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linQsimpleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.delegadosToolStripMenuItem,
            this.linQToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(859, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // delegadosToolStripMenuItem
            // 
            this.delegadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.primerEjemploToolStripMenuItem,
            this.segundoEjemploToolStripMenuItem});
            this.delegadosToolStripMenuItem.Name = "delegadosToolStripMenuItem";
            this.delegadosToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.delegadosToolStripMenuItem.Text = "Delegados";
            // 
            // primerEjemploToolStripMenuItem
            // 
            this.primerEjemploToolStripMenuItem.Name = "primerEjemploToolStripMenuItem";
            this.primerEjemploToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.primerEjemploToolStripMenuItem.Text = "Primer ejemplo";
            this.primerEjemploToolStripMenuItem.Click += new System.EventHandler(this.primerEjemploToolStripMenuItem_Click);
            // 
            // segundoEjemploToolStripMenuItem
            // 
            this.segundoEjemploToolStripMenuItem.Name = "segundoEjemploToolStripMenuItem";
            this.segundoEjemploToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.segundoEjemploToolStripMenuItem.Text = "Segundo ejemplo";
            this.segundoEjemploToolStripMenuItem.Click += new System.EventHandler(this.segundoEjemploToolStripMenuItem_Click);
            // 
            // linQToolStripMenuItem
            // 
            this.linQToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.linQsimpleToolStripMenuItem});
            this.linQToolStripMenuItem.Name = "linQToolStripMenuItem";
            this.linQToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.linQToolStripMenuItem.Text = "LinQ";
            // 
            // linQsimpleToolStripMenuItem
            // 
            this.linQsimpleToolStripMenuItem.Name = "linQsimpleToolStripMenuItem";
            this.linQsimpleToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.linQsimpleToolStripMenuItem.Text = "LinQsimple";
            this.linQsimpleToolStripMenuItem.Click += new System.EventHandler(this.linQsimpleToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 461);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem delegadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem primerEjemploToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem segundoEjemploToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem linQToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem linQsimpleToolStripMenuItem;
    }
}

