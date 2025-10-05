namespace ContenedorMDI
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirProyectoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copiarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cortarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pegarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deshacerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rehacerToolStripMenuItem;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirProyectoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cortarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pegarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deshacerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rehacerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();

            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();

            // --- MenuStrip principal ---
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.archivoToolStripMenuItem,
                this.editarToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 33);
            this.menuStrip2.TabIndex = 0;
            this.menuStrip2.Text = "menuStrip2";

            // --- Menú Archivo ---
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.nuevoToolStripMenuItem,
                this.abrirProyectoToolStripMenuItem,
                this.cerrarToolStripMenuItem,
                this.guardarToolStripMenuItem,
                this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Text = "Archivo";

            this.nuevoToolStripMenuItem.Text = "Nuevo";
            this.nuevoToolStripMenuItem.ShortcutKeys = (System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N);
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);

            this.abrirProyectoToolStripMenuItem.Text = "Abrir proyecto";
            this.cerrarToolStripMenuItem.Text = "Cerrar";
            this.cerrarToolStripMenuItem.ShortcutKeys = (System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4);
            this.cerrarToolStripMenuItem.Click += new System.EventHandler(this.cerrarToolStripMenuItem_Click);

            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.ShortcutKeys = (System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S);
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);

            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);

            // --- Menú Editar ---
            this.editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.copiarToolStripMenuItem,
                this.cortarToolStripMenuItem,
                this.pegarToolStripMenuItem,
                this.deshacerToolStripMenuItem,
                this.rehacerToolStripMenuItem});
            this.editarToolStripMenuItem.Text = "Editar";

            this.copiarToolStripMenuItem.Text = "Copiar";
            this.cortarToolStripMenuItem.Text = "Cortar";
            this.pegarToolStripMenuItem.Text = "Pegar";
            this.deshacerToolStripMenuItem.Text = "Deshacer";
            this.rehacerToolStripMenuItem.Text = "Rehacer";

            // --- Form1 ---
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip2;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.menuStrip2);
            this.Text = "Contenedor MDI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;

            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}