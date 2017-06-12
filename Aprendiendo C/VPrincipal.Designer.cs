namespace Aprendiendo_C
{
    partial class VPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mantenimietosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.detallesDelClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadoDeCuentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.antiguedadDeSaldoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.facturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cotizacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devolucionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosYServiciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.multiAlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.almacenesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.movimientoAlInventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeMovimientoAlInventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kardexDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conceptosDeMovimientosAlInventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parámetrosDelSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datosDeLaEmpresaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lbluserlog = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimietosToolStripMenuItem,
            this.toolStripMenuItem2,
            this.inventariosToolStripMenuItem,
            this.toolStripMenuItem3,
            this.configuraciónToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(787, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mantenimietosToolStripMenuItem
            // 
            this.mantenimietosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.detallesDelClienteToolStripMenuItem,
            this.estadoDeCuentaToolStripMenuItem,
            this.antiguedadDeSaldoToolStripMenuItem});
            this.mantenimietosToolStripMenuItem.Name = "mantenimietosToolStripMenuItem";
            this.mantenimietosToolStripMenuItem.Size = new System.Drawing.Size(167, 20);
            this.mantenimietosToolStripMenuItem.Text = "Clientes y cuenta por cobrar";
            this.mantenimietosToolStripMenuItem.Click += new System.EventHandler(this.mantenimietosToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(188, 22);
            this.toolStripMenuItem1.Text = "Clientes";
            // 
            // detallesDelClienteToolStripMenuItem
            // 
            this.detallesDelClienteToolStripMenuItem.Name = "detallesDelClienteToolStripMenuItem";
            this.detallesDelClienteToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.detallesDelClienteToolStripMenuItem.Text = "Detalles del cliente";
            // 
            // estadoDeCuentaToolStripMenuItem
            // 
            this.estadoDeCuentaToolStripMenuItem.Name = "estadoDeCuentaToolStripMenuItem";
            this.estadoDeCuentaToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.estadoDeCuentaToolStripMenuItem.Text = "Estado de cuenta";
            // 
            // antiguedadDeSaldoToolStripMenuItem
            // 
            this.antiguedadDeSaldoToolStripMenuItem.Name = "antiguedadDeSaldoToolStripMenuItem";
            this.antiguedadDeSaldoToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.antiguedadDeSaldoToolStripMenuItem.Text = "Antigüedad de saldos";
            this.antiguedadDeSaldoToolStripMenuItem.Click += new System.EventHandler(this.antiguedadDeSaldoToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.facturasToolStripMenuItem,
            this.pedidosToolStripMenuItem,
            this.cotizacionesToolStripMenuItem,
            this.devolucionesToolStripMenuItem,
            this.vendedoresToolStripMenuItem});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(136, 20);
            this.toolStripMenuItem2.Text = "Facturas y vendedores";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // facturasToolStripMenuItem
            // 
            this.facturasToolStripMenuItem.Name = "facturasToolStripMenuItem";
            this.facturasToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.facturasToolStripMenuItem.Text = "Facturas";
            // 
            // pedidosToolStripMenuItem
            // 
            this.pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
            this.pedidosToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.pedidosToolStripMenuItem.Text = "Pedidos";
            // 
            // cotizacionesToolStripMenuItem
            // 
            this.cotizacionesToolStripMenuItem.Name = "cotizacionesToolStripMenuItem";
            this.cotizacionesToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.cotizacionesToolStripMenuItem.Text = "Cotizaciones";
            // 
            // devolucionesToolStripMenuItem
            // 
            this.devolucionesToolStripMenuItem.Name = "devolucionesToolStripMenuItem";
            this.devolucionesToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.devolucionesToolStripMenuItem.Text = "Devoluciones";
            // 
            // vendedoresToolStripMenuItem
            // 
            this.vendedoresToolStripMenuItem.Name = "vendedoresToolStripMenuItem";
            this.vendedoresToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.vendedoresToolStripMenuItem.Text = "Vendedores";
            // 
            // inventariosToolStripMenuItem
            // 
            this.inventariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productosYServiciosToolStripMenuItem,
            this.multiAlToolStripMenuItem,
            this.almacenesToolStripMenuItem,
            this.toolStripSeparator1,
            this.movimientoAlInventarioToolStripMenuItem,
            this.reporteDeMovimientoAlInventarioToolStripMenuItem,
            this.kardexDeProductosToolStripMenuItem,
            this.conceptosDeMovimientosAlInventarioToolStripMenuItem,
            this.toolStripSeparator2});
            this.inventariosToolStripMenuItem.Name = "inventariosToolStripMenuItem";
            this.inventariosToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.inventariosToolStripMenuItem.Text = "Inventarios";
            // 
            // productosYServiciosToolStripMenuItem
            // 
            this.productosYServiciosToolStripMenuItem.Name = "productosYServiciosToolStripMenuItem";
            this.productosYServiciosToolStripMenuItem.Size = new System.Drawing.Size(288, 22);
            this.productosYServiciosToolStripMenuItem.Text = "Productos y Servicios";
            // 
            // multiAlToolStripMenuItem
            // 
            this.multiAlToolStripMenuItem.Name = "multiAlToolStripMenuItem";
            this.multiAlToolStripMenuItem.Size = new System.Drawing.Size(288, 22);
            this.multiAlToolStripMenuItem.Text = "Multialmacén";
            // 
            // almacenesToolStripMenuItem
            // 
            this.almacenesToolStripMenuItem.Name = "almacenesToolStripMenuItem";
            this.almacenesToolStripMenuItem.Size = new System.Drawing.Size(288, 22);
            this.almacenesToolStripMenuItem.Text = "Almacenes";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(285, 6);
            // 
            // movimientoAlInventarioToolStripMenuItem
            // 
            this.movimientoAlInventarioToolStripMenuItem.Name = "movimientoAlInventarioToolStripMenuItem";
            this.movimientoAlInventarioToolStripMenuItem.Size = new System.Drawing.Size(288, 22);
            this.movimientoAlInventarioToolStripMenuItem.Text = "Movimiento al inventario";
            // 
            // reporteDeMovimientoAlInventarioToolStripMenuItem
            // 
            this.reporteDeMovimientoAlInventarioToolStripMenuItem.Name = "reporteDeMovimientoAlInventarioToolStripMenuItem";
            this.reporteDeMovimientoAlInventarioToolStripMenuItem.Size = new System.Drawing.Size(288, 22);
            this.reporteDeMovimientoAlInventarioToolStripMenuItem.Text = "Reportes de movimiento al inventario";
            // 
            // kardexDeProductosToolStripMenuItem
            // 
            this.kardexDeProductosToolStripMenuItem.Name = "kardexDeProductosToolStripMenuItem";
            this.kardexDeProductosToolStripMenuItem.Size = new System.Drawing.Size(288, 22);
            this.kardexDeProductosToolStripMenuItem.Text = "Kardex de productos";
            // 
            // conceptosDeMovimientosAlInventarioToolStripMenuItem
            // 
            this.conceptosDeMovimientosAlInventarioToolStripMenuItem.Name = "conceptosDeMovimientosAlInventarioToolStripMenuItem";
            this.conceptosDeMovimientosAlInventarioToolStripMenuItem.Size = new System.Drawing.Size(288, 22);
            this.conceptosDeMovimientosAlInventarioToolStripMenuItem.Text = "Conceptos de movimientos al inventario";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(285, 6);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6,
            this.toolStripSeparator4,
            this.toolStripMenuItem7,
            this.toolStripMenuItem8});
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(118, 20);
            this.toolStripMenuItem3.Text = "Proveedores y CXP";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(255, 22);
            this.toolStripMenuItem4.Text = "Proveedores";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(255, 22);
            this.toolStripMenuItem5.Text = "Detalles del proveedor";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(255, 22);
            this.toolStripMenuItem6.Text = "Estado de cuenta del proveedor";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(252, 6);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(255, 22);
            this.toolStripMenuItem7.Text = "Movimientos decuentas por pagar";
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(255, 22);
            this.toolStripMenuItem8.Text = "Conceptos de cuentas por pagar";
            // 
            // configuraciónToolStripMenuItem
            // 
            this.configuraciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.parámetrosDelSistemaToolStripMenuItem,
            this.datosDeLaEmpresaToolStripMenuItem});
            this.configuraciónToolStripMenuItem.Name = "configuraciónToolStripMenuItem";
            this.configuraciónToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.configuraciónToolStripMenuItem.Text = "Configuración";
            // 
            // parámetrosDelSistemaToolStripMenuItem
            // 
            this.parámetrosDelSistemaToolStripMenuItem.Name = "parámetrosDelSistemaToolStripMenuItem";
            this.parámetrosDelSistemaToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.parámetrosDelSistemaToolStripMenuItem.Text = "Parámetros del sistema";
            // 
            // datosDeLaEmpresaToolStripMenuItem
            // 
            this.datosDeLaEmpresaToolStripMenuItem.Name = "datosDeLaEmpresaToolStripMenuItem";
            this.datosDeLaEmpresaToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.datosDeLaEmpresaToolStripMenuItem.Text = "Datos de la empresa";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.Name = "contextMenuStrip3";
            this.contextMenuStrip3.Size = new System.Drawing.Size(61, 4);
            // 
            // lbluserlog
            // 
            this.lbluserlog.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluserlog.Location = new System.Drawing.Point(639, 414);
            this.lbluserlog.Name = "lbluserlog";
            this.lbluserlog.Size = new System.Drawing.Size(143, 18);
            this.lbluserlog.TabIndex = 4;
            this.lbluserlog.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbluserlog.Click += new System.EventHandler(this.label1_Click);
            // 
            // VPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Aprendiendo_C.Properties.Resources.log;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(787, 437);
            this.Controls.Add(this.lbluserlog);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "VPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Smart Business System ";
            this.TransparencyKey = System.Drawing.Color.DarkGray;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.VPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.VPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mantenimietosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem detallesDelClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadoDeCuentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem antiguedadDeSaldoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem facturasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cotizacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem devolucionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosYServiciosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem multiAlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem almacenesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem movimientoAlInventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeMovimientoAlInventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kardexDeProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conceptosDeMovimientosAlInventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem configuraciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parámetrosDelSistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem datosDeLaEmpresaToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip3;
        private System.Windows.Forms.Label lbluserlog;
    }
}