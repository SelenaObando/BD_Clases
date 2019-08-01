namespace CapaPresentacionWF
{
    partial class MDIRecurso
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDIRecurso));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileCatalogo = new System.Windows.Forms.ToolStripMenuItem();
            this.recursoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cuentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SolicitudMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.solicitudToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.RespaldoBDtoolBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AyudaMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.AcercadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SalirMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.printToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.printPreviewToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileCatalogo,
            this.SolicitudMenu,
            this.mantenimientoMenu,
            this.AyudaMenu,
            this.SalirMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.MdiWindowListItem = this.SalirMenu;
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(632, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // fileCatalogo
            // 
            this.fileCatalogo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recursoToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.toolStripSeparator3,
            this.cuentasToolStripMenuItem});
            this.fileCatalogo.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.fileCatalogo.Name = "fileCatalogo";
            this.fileCatalogo.Size = new System.Drawing.Size(67, 20);
            this.fileCatalogo.Text = "&Catalogo";
            // 
            // recursoToolStripMenuItem
            // 
            this.recursoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("recursoToolStripMenuItem.Image")));
            this.recursoToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.recursoToolStripMenuItem.Name = "recursoToolStripMenuItem";
            this.recursoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.recursoToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.recursoToolStripMenuItem.Text = "&recursos";
            this.recursoToolStripMenuItem.Click += new System.EventHandler(this.recursosToolStripMenuItem);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("usuariosToolStripMenuItem.Image")));
            this.usuariosToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.usuariosToolStripMenuItem.Text = "&usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.OpenFile);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(158, 6);
            // 
            // cuentasToolStripMenuItem
            // 
            this.cuentasToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cuentasToolStripMenuItem.Image")));
            this.cuentasToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.cuentasToolStripMenuItem.Name = "cuentasToolStripMenuItem";
            this.cuentasToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.cuentasToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.cuentasToolStripMenuItem.Text = "&cuentas";
            // 
            // SolicitudMenu
            // 
            this.SolicitudMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.solicitudToolStripMenuItem});
            this.SolicitudMenu.Name = "SolicitudMenu";
            this.SolicitudMenu.Size = new System.Drawing.Size(65, 20);
            this.SolicitudMenu.Text = "&Solicitud";
            // 
            // solicitudToolStripMenuItem
            // 
            this.solicitudToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("solicitudToolStripMenuItem.Image")));
            this.solicitudToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.solicitudToolStripMenuItem.Name = "solicitudToolStripMenuItem";
            this.solicitudToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.solicitudToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.solicitudToolStripMenuItem.Text = "&Solicitud";
            // 
            // mantenimientoMenu
            // 
            this.mantenimientoMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RespaldoBDtoolBarToolStripMenuItem});
            this.mantenimientoMenu.Name = "mantenimientoMenu";
            this.mantenimientoMenu.Size = new System.Drawing.Size(101, 20);
            this.mantenimientoMenu.Text = "&mantenimiento";
            // 
            // RespaldoBDtoolBarToolStripMenuItem
            // 
            this.RespaldoBDtoolBarToolStripMenuItem.Checked = true;
            this.RespaldoBDtoolBarToolStripMenuItem.CheckOnClick = true;
            this.RespaldoBDtoolBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.RespaldoBDtoolBarToolStripMenuItem.Name = "RespaldoBDtoolBarToolStripMenuItem";
            this.RespaldoBDtoolBarToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.RespaldoBDtoolBarToolStripMenuItem.Text = "&RespaldoBD";
            this.RespaldoBDtoolBarToolStripMenuItem.Click += new System.EventHandler(this.ToolBarToolStripMenuItem_Click);
            // 
            // AyudaMenu
            // 
            this.AyudaMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AcercadeToolStripMenuItem});
            this.AyudaMenu.Name = "AyudaMenu";
            this.AyudaMenu.Size = new System.Drawing.Size(53, 20);
            this.AyudaMenu.Text = "&Ayuda";
            // 
            // AcercadeToolStripMenuItem
            // 
            this.AcercadeToolStripMenuItem.Name = "AcercadeToolStripMenuItem";
            this.AcercadeToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.AcercadeToolStripMenuItem.Text = "&Acercade";
            // 
            // SalirMenu
            // 
            this.SalirMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.SalirMenu.Name = "SalirMenu";
            this.SalirMenu.Size = new System.Drawing.Size(41, 20);
            this.SalirMenu.Text = "&Salir";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.salirToolStripMenuItem.Text = "&Salir";
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.openToolStripButton,
            this.saveToolStripButton,
            this.toolStripSeparator1,
            this.printToolStripButton,
            this.printPreviewToolStripButton,
            this.toolStripSeparator2,
            this.helpToolStripButton});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(632, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "ToolStrip";
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.newToolStripButton.Text = "Nuevo";
            this.newToolStripButton.Click += new System.EventHandler(this.ShowNewForm);
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.openToolStripButton.Text = "Abrir";
            this.openToolStripButton.Click += new System.EventHandler(this.OpenFile);
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveToolStripButton.Text = "Guardar";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // printToolStripButton
            // 
            this.printToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.printToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripButton.Image")));
            this.printToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.printToolStripButton.Name = "printToolStripButton";
            this.printToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.printToolStripButton.Text = "Imprimir";
            // 
            // printPreviewToolStripButton
            // 
            this.printPreviewToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.printPreviewToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("printPreviewToolStripButton.Image")));
            this.printPreviewToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.printPreviewToolStripButton.Name = "printPreviewToolStripButton";
            this.printPreviewToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.printPreviewToolStripButton.Text = "Vista previa de impresión";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.helpToolStripButton.Text = "Ayuda";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 431);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(632, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabel.Text = "Estado";
            // 
            // MDIRecurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.ControlBox = false;
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MDIRecurso";
            this.Text = "MDIRecurso";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem fileCatalogo;
        private System.Windows.Forms.ToolStripMenuItem recursoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SolicitudMenu;
        private System.Windows.Forms.ToolStripMenuItem solicitudToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoMenu;
        private System.Windows.Forms.ToolStripMenuItem RespaldoBDtoolBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AyudaMenu;
        private System.Windows.Forms.ToolStripMenuItem AcercadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SalirMenu;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton printToolStripButton;
        private System.Windows.Forms.ToolStripButton printPreviewToolStripButton;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private System.Windows.Forms.ToolTip toolTip;
    }
}



