using examen.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace examen
{
    public partial class frmPrincipal : Form
    {

        MainController inicio;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Habilita por defecto los radiobutton
            if (radioCamisa.Checked == true)
            {
                checkChupin.Enabled = false;
                checkMangaCorta.Enabled = true;
                checkCuelloMao.Enabled = true;
            }
            //-------------------------------------

            inicio = new MainController();
            inicio.Inicializar();
            lblNombreTienda.Text = inicio.tienda.Nombre;
            lblDireccionTienda.Text = inicio.tienda.Direccion;
            lblNombreVendedor.Text = inicio.vendedor.Nombre + " " + inicio.vendedor.Apellido;
            lblCodigoVendedor.Text = "ID " + inicio.vendedor.CodigoVendedor.ToString();



        }

        private void radioPantalon_CheckedChanged(object sender, EventArgs e)
        {
            if (radioPantalon.Checked == true)
            {
                checkChupin.Enabled = true;
                checkMangaCorta.Enabled = false;
                checkCuelloMao.Enabled = false;
            }
        }

        private void radioCamisa_CheckedChanged(object sender, EventArgs e)
        {
            if (radioCamisa.Checked == true)
            {
                checkChupin.Enabled = false;
                checkMangaCorta.Enabled = true;
                checkCuelloMao.Enabled = true;
            }

        }

        private void btnCotizar_Click(object sender, EventArgs e)
        {

            inicio.PrendaSeleccionada(radioCamisa, checkMangaCorta, checkCuelloMao, checkChupin,
               ref lblStock, radioStandard, ref txtPrecioPrenda, ref txtCantPrenda);
        }
    }
}
