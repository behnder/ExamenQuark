
namespace examen
{
    partial class frmPrincipal
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
            this.lblNombreTienda = new System.Windows.Forms.Label();
            this.lblDireccionTienda = new System.Windows.Forms.Label();
            this.lblNombreVendedor = new System.Windows.Forms.Label();
            this.lblCodigoVendedor = new System.Windows.Forms.Label();
            this.groupPrenda = new System.Windows.Forms.GroupBox();
            this.checkChupin = new System.Windows.Forms.CheckBox();
            this.checkCuelloMao = new System.Windows.Forms.CheckBox();
            this.checkMangaCorta = new System.Windows.Forms.CheckBox();
            this.radioPantalon = new System.Windows.Forms.RadioButton();
            this.radioCamisa = new System.Windows.Forms.RadioButton();
            this.groupDisponibles = new System.Windows.Forms.GroupBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblStockDisponible = new System.Windows.Forms.Label();
            this.groupCalidadPrenda = new System.Windows.Forms.GroupBox();
            this.radioPremium = new System.Windows.Forms.RadioButton();
            this.radioStandard = new System.Windows.Forms.RadioButton();
            this.groupPrecioYCantidad = new System.Windows.Forms.GroupBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblPrecioUnitario = new System.Windows.Forms.Label();
            this.txtCantPrenda = new System.Windows.Forms.TextBox();
            this.txtPrecioPrenda = new System.Windows.Forms.TextBox();
            this.btnCotizar = new System.Windows.Forms.Button();
            this.lblCotizacionFinal = new System.Windows.Forms.Label();
            this.lblSignoDinero = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupPrenda.SuspendLayout();
            this.groupDisponibles.SuspendLayout();
            this.groupCalidadPrenda.SuspendLayout();
            this.groupPrecioYCantidad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombreTienda
            // 
            this.lblNombreTienda.AutoSize = true;
            this.lblNombreTienda.Location = new System.Drawing.Point(12, 9);
            this.lblNombreTienda.Name = "lblNombreTienda";
            this.lblNombreTienda.Size = new System.Drawing.Size(80, 13);
            this.lblNombreTienda.TabIndex = 0;
            this.lblNombreTienda.Text = "Nombre Tienda";
            // 
            // lblDireccionTienda
            // 
            this.lblDireccionTienda.AutoSize = true;
            this.lblDireccionTienda.Location = new System.Drawing.Point(286, 9);
            this.lblDireccionTienda.Name = "lblDireccionTienda";
            this.lblDireccionTienda.Size = new System.Drawing.Size(88, 13);
            this.lblDireccionTienda.TabIndex = 1;
            this.lblDireccionTienda.Text = "Direccion Tienda";
            // 
            // lblNombreVendedor
            // 
            this.lblNombreVendedor.AutoSize = true;
            this.lblNombreVendedor.Location = new System.Drawing.Point(12, 55);
            this.lblNombreVendedor.Name = "lblNombreVendedor";
            this.lblNombreVendedor.Size = new System.Drawing.Size(143, 13);
            this.lblNombreVendedor.TabIndex = 2;
            this.lblNombreVendedor.Text = " Nombre y apellido Vendedor";
            // 
            // lblCodigoVendedor
            // 
            this.lblCodigoVendedor.AutoSize = true;
            this.lblCodigoVendedor.Location = new System.Drawing.Point(161, 55);
            this.lblCodigoVendedor.Name = "lblCodigoVendedor";
            this.lblCodigoVendedor.Size = new System.Drawing.Size(89, 13);
            this.lblCodigoVendedor.TabIndex = 3;
            this.lblCodigoVendedor.Text = "Código Vendedor";
            // 
            // groupPrenda
            // 
            this.groupPrenda.Controls.Add(this.checkChupin);
            this.groupPrenda.Controls.Add(this.checkCuelloMao);
            this.groupPrenda.Controls.Add(this.checkMangaCorta);
            this.groupPrenda.Controls.Add(this.radioPantalon);
            this.groupPrenda.Controls.Add(this.radioCamisa);
            this.groupPrenda.Location = new System.Drawing.Point(15, 102);
            this.groupPrenda.Name = "groupPrenda";
            this.groupPrenda.Size = new System.Drawing.Size(359, 114);
            this.groupPrenda.TabIndex = 5;
            this.groupPrenda.TabStop = false;
            this.groupPrenda.Text = "Prenda";
            // 
            // checkChupin
            // 
            this.checkChupin.AutoSize = true;
            this.checkChupin.Location = new System.Drawing.Point(91, 75);
            this.checkChupin.Name = "checkChupin";
            this.checkChupin.Size = new System.Drawing.Size(59, 17);
            this.checkChupin.TabIndex = 4;
            this.checkChupin.Text = "Chupin";
            this.checkChupin.UseVisualStyleBackColor = true;
            this.checkChupin.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkCuelloMao
            // 
            this.checkCuelloMao.AutoSize = true;
            this.checkCuelloMao.Location = new System.Drawing.Point(184, 32);
            this.checkCuelloMao.Name = "checkCuelloMao";
            this.checkCuelloMao.Size = new System.Drawing.Size(79, 17);
            this.checkCuelloMao.TabIndex = 3;
            this.checkCuelloMao.Text = "Cuello Mao";
            this.checkCuelloMao.UseVisualStyleBackColor = true;
            // 
            // checkMangaCorta
            // 
            this.checkMangaCorta.AutoSize = true;
            this.checkMangaCorta.Location = new System.Drawing.Point(91, 32);
            this.checkMangaCorta.Name = "checkMangaCorta";
            this.checkMangaCorta.Size = new System.Drawing.Size(87, 17);
            this.checkMangaCorta.TabIndex = 2;
            this.checkMangaCorta.Text = "Manga Corta";
            this.checkMangaCorta.UseVisualStyleBackColor = true;
            // 
            // radioPantalon
            // 
            this.radioPantalon.AutoSize = true;
            this.radioPantalon.Location = new System.Drawing.Point(18, 75);
            this.radioPantalon.Name = "radioPantalon";
            this.radioPantalon.Size = new System.Drawing.Size(67, 17);
            this.radioPantalon.TabIndex = 1;
            this.radioPantalon.Text = "Pantalon";
            this.radioPantalon.UseVisualStyleBackColor = true;
            this.radioPantalon.CheckedChanged += new System.EventHandler(this.radioPantalon_CheckedChanged);
            // 
            // radioCamisa
            // 
            this.radioCamisa.AutoSize = true;
            this.radioCamisa.Checked = true;
            this.radioCamisa.Location = new System.Drawing.Point(18, 31);
            this.radioCamisa.Name = "radioCamisa";
            this.radioCamisa.Size = new System.Drawing.Size(59, 17);
            this.radioCamisa.TabIndex = 0;
            this.radioCamisa.TabStop = true;
            this.radioCamisa.Text = "Camisa";
            this.radioCamisa.UseVisualStyleBackColor = true;
            this.radioCamisa.CheckedChanged += new System.EventHandler(this.radioCamisa_CheckedChanged);
            // 
            // groupDisponibles
            // 
            this.groupDisponibles.Controls.Add(this.lblStock);
            this.groupDisponibles.Controls.Add(this.lblStockDisponible);
            this.groupDisponibles.Location = new System.Drawing.Point(15, 223);
            this.groupDisponibles.Name = "groupDisponibles";
            this.groupDisponibles.Size = new System.Drawing.Size(359, 40);
            this.groupDisponibles.TabIndex = 6;
            this.groupDisponibles.TabStop = false;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblStock.Location = new System.Drawing.Point(175, 16);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(33, 13);
            this.lblStock.TabIndex = 1;
            this.lblStock.Text = "stock";
            // 
            // lblStockDisponible
            // 
            this.lblStockDisponible.AutoSize = true;
            this.lblStockDisponible.Location = new System.Drawing.Point(15, 16);
            this.lblStockDisponible.Name = "lblStockDisponible";
            this.lblStockDisponible.Size = new System.Drawing.Size(154, 13);
            this.lblStockDisponible.TabIndex = 0;
            this.lblStockDisponible.Text = "Unidades de stock disponibles:";
            // 
            // groupCalidadPrenda
            // 
            this.groupCalidadPrenda.Controls.Add(this.radioPremium);
            this.groupCalidadPrenda.Controls.Add(this.radioStandard);
            this.groupCalidadPrenda.Location = new System.Drawing.Point(15, 280);
            this.groupCalidadPrenda.Name = "groupCalidadPrenda";
            this.groupCalidadPrenda.Size = new System.Drawing.Size(178, 70);
            this.groupCalidadPrenda.TabIndex = 7;
            this.groupCalidadPrenda.TabStop = false;
            this.groupCalidadPrenda.Text = "Calidad de la Prenda";
            // 
            // radioPremium
            // 
            this.radioPremium.AutoSize = true;
            this.radioPremium.Location = new System.Drawing.Point(18, 43);
            this.radioPremium.Name = "radioPremium";
            this.radioPremium.Size = new System.Drawing.Size(65, 17);
            this.radioPremium.TabIndex = 1;
            this.radioPremium.Text = "Premium";
            this.radioPremium.UseVisualStyleBackColor = true;
            // 
            // radioStandard
            // 
            this.radioStandard.AutoSize = true;
            this.radioStandard.Checked = true;
            this.radioStandard.Location = new System.Drawing.Point(18, 20);
            this.radioStandard.Name = "radioStandard";
            this.radioStandard.Size = new System.Drawing.Size(68, 17);
            this.radioStandard.TabIndex = 0;
            this.radioStandard.TabStop = true;
            this.radioStandard.Text = "Standard";
            this.radioStandard.UseVisualStyleBackColor = true;
            // 
            // groupPrecioYCantidad
            // 
            this.groupPrecioYCantidad.Controls.Add(this.lblCantidad);
            this.groupPrecioYCantidad.Controls.Add(this.lblPrecioUnitario);
            this.groupPrecioYCantidad.Controls.Add(this.txtCantPrenda);
            this.groupPrecioYCantidad.Controls.Add(this.txtPrecioPrenda);
            this.groupPrecioYCantidad.Location = new System.Drawing.Point(199, 280);
            this.groupPrecioYCantidad.Name = "groupPrecioYCantidad";
            this.groupPrecioYCantidad.Size = new System.Drawing.Size(175, 70);
            this.groupPrecioYCantidad.TabIndex = 8;
            this.groupPrecioYCantidad.TabStop = false;
            this.groupPrecioYCantidad.Text = "Precio unitario y cantidad";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(6, 47);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(49, 13);
            this.lblCantidad.TabIndex = 3;
            this.lblCantidad.Text = "Cantidad";
            // 
            // lblPrecioUnitario
            // 
            this.lblPrecioUnitario.AutoSize = true;
            this.lblPrecioUnitario.Location = new System.Drawing.Point(42, 22);
            this.lblPrecioUnitario.Name = "lblPrecioUnitario";
            this.lblPrecioUnitario.Size = new System.Drawing.Size(13, 13);
            this.lblPrecioUnitario.TabIndex = 2;
            this.lblPrecioUnitario.Text = "$";
            // 
            // txtCantPrenda
            // 
            this.txtCantPrenda.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtCantPrenda.Location = new System.Drawing.Point(61, 44);
            this.txtCantPrenda.Name = "txtCantPrenda";
            this.txtCantPrenda.Size = new System.Drawing.Size(67, 20);
            this.txtCantPrenda.TabIndex = 1;
            // 
            // txtPrecioPrenda
            // 
            this.txtPrecioPrenda.Location = new System.Drawing.Point(61, 20);
            this.txtPrecioPrenda.Name = "txtPrecioPrenda";
            this.txtPrecioPrenda.Size = new System.Drawing.Size(67, 20);
            this.txtPrecioPrenda.TabIndex = 0;
            // 
            // btnCotizar
            // 
            this.btnCotizar.Location = new System.Drawing.Point(15, 357);
            this.btnCotizar.Name = "btnCotizar";
            this.btnCotizar.Size = new System.Drawing.Size(178, 23);
            this.btnCotizar.TabIndex = 9;
            this.btnCotizar.Text = "COTIZAR";
            this.btnCotizar.UseVisualStyleBackColor = true;
            this.btnCotizar.Click += new System.EventHandler(this.btnCotizar_Click);
            // 
            // lblCotizacionFinal
            // 
            this.lblCotizacionFinal.AutoSize = true;
            this.lblCotizacionFinal.Location = new System.Drawing.Point(241, 367);
            this.lblCotizacionFinal.Name = "lblCotizacionFinal";
            this.lblCotizacionFinal.Size = new System.Drawing.Size(127, 13);
            this.lblCotizacionFinal.TabIndex = 10;
            this.lblCotizacionFinal.Text = "____________________";
            // 
            // lblSignoDinero
            // 
            this.lblSignoDinero.AutoSize = true;
            this.lblSignoDinero.Location = new System.Drawing.Point(222, 367);
            this.lblSignoDinero.Name = "lblSignoDinero";
            this.lblSignoDinero.Size = new System.Drawing.Size(13, 13);
            this.lblSignoDinero.TabIndex = 4;
            this.lblSignoDinero.Text = "$";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(270, 55);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(107, 13);
            this.linkLabel1.TabIndex = 11;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Historial Cotizaciones";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 414);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.lblSignoDinero);
            this.Controls.Add(this.lblCotizacionFinal);
            this.Controls.Add(this.btnCotizar);
            this.Controls.Add(this.groupPrecioYCantidad);
            this.Controls.Add(this.groupCalidadPrenda);
            this.Controls.Add(this.groupDisponibles);
            this.Controls.Add(this.groupPrenda);
            this.Controls.Add(this.lblCodigoVendedor);
            this.Controls.Add(this.lblNombreVendedor);
            this.Controls.Add(this.lblDireccionTienda);
            this.Controls.Add(this.lblNombreTienda);
            this.MaximumSize = new System.Drawing.Size(402, 453);
            this.MinimumSize = new System.Drawing.Size(402, 453);
            this.Name = "frmPrincipal";
            this.Text = "Cotizador de Prendas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupPrenda.ResumeLayout(false);
            this.groupPrenda.PerformLayout();
            this.groupDisponibles.ResumeLayout(false);
            this.groupDisponibles.PerformLayout();
            this.groupCalidadPrenda.ResumeLayout(false);
            this.groupCalidadPrenda.PerformLayout();
            this.groupPrecioYCantidad.ResumeLayout(false);
            this.groupPrecioYCantidad.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombreTienda;
        private System.Windows.Forms.Label lblDireccionTienda;
        private System.Windows.Forms.Label lblNombreVendedor;
        private System.Windows.Forms.Label lblCodigoVendedor;
        private System.Windows.Forms.GroupBox groupPrenda;
        private System.Windows.Forms.CheckBox checkChupin;
        private System.Windows.Forms.CheckBox checkCuelloMao;
        private System.Windows.Forms.CheckBox checkMangaCorta;
        private System.Windows.Forms.RadioButton radioPantalon;
        private System.Windows.Forms.RadioButton radioCamisa;
        private System.Windows.Forms.GroupBox groupDisponibles;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblStockDisponible;
        private System.Windows.Forms.GroupBox groupCalidadPrenda;
        private System.Windows.Forms.RadioButton radioPremium;
        private System.Windows.Forms.RadioButton radioStandard;
        private System.Windows.Forms.GroupBox groupPrecioYCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblPrecioUnitario;
        private System.Windows.Forms.TextBox txtCantPrenda;
        private System.Windows.Forms.TextBox txtPrecioPrenda;
        private System.Windows.Forms.Button btnCotizar;
        private System.Windows.Forms.Label lblCotizacionFinal;
        private System.Windows.Forms.Label lblSignoDinero;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

