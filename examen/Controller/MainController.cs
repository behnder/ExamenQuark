using examen.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace examen.Controller
{
    class MainController
    {
        public Tienda tienda;
        public Vendedor vendedor;
        int stock = 0;
        public Cotizacion cotizacion;
        List<Cotizacion> historialCotizaciones = new List<Cotizacion>();
        public void Inicializar()
        {
            tienda = new Tienda("Tienda Mayo", "Colombres 899");
            vendedor = new Vendedor("Nicolas", "Nuñez");
            Cotizacion cotizacion;


            tienda.CargarCamisas();
            tienda.CargarPantalones();



        }


        public void PrendaSeleccionada(RadioButton radioCamisa, CheckBox checkMangaCorta, CheckBox checkCuelloMao,
            CheckBox checkChupin, ref Label lblStock, RadioButton radioStandard, ref TextBox txtPrecioPrenda,
            ref TextBox txtCantPrenda, ref Label lblCotizacionFinal)
        {
            int mangacorta = 0;
            int mangaLarga = 0;
            int pantaChupin = 0;
            int pantaNormal = 0;
            string calidad = "";

            Prenda prendaCotizada;

            if (radioCamisa.Checked)
            {
                foreach (var v in tienda.ListadoPrendas)
                {

                    if (v is Camisa)// SI ES CAMISA-
                    {
                        Camisa cami = (Camisa)v;
                        //si tildo solo  manga corta(manga corta y cuello comun)
                        if (checkMangaCorta.Checked && !checkCuelloMao.Checked)
                        {

                            //selecciono manga corta y cuello comun
                            if (cami.TipoManga == "corta" && cami.TipoCuello == "comun")
                            {
                                if (radioStandard.Checked)
                                {
                                    if (cami.Calidad == "Standard")
                                    {
                                        MessageBox.Show("SOY STANDARD!" + cami.Calidad + " " + cami.Stock + " " + cami.TipoManga + " " + cami.TipoCuello);
                                        stock = cami.Stock;
                                        prendaCotizada = cami;
                                        CrearCotizacion(cami, ref txtCantPrenda, ref txtPrecioPrenda, ref lblCotizacionFinal);

                                    }

                                }
                                else if (!radioStandard.Checked)
                                {

                                    if (cami.Calidad == "Premium")
                                    {
                                        MessageBox.Show("SOY premium!" + cami.Calidad + " " + cami.Stock + " " + cami.TipoManga + " " + cami.TipoCuello);
                                        stock = cami.Stock;
                                        prendaCotizada = cami;
                                        CrearCotizacion(cami, ref txtCantPrenda, ref txtPrecioPrenda, ref lblCotizacionFinal);

                                    }


                                }

                            }

                        }

                        //si tildo manga corta y cuello mao
                        if (checkCuelloMao.Checked && checkMangaCorta.Checked)
                        {
                            //selecciono manga corta  y cuello mao
                            if (cami.TipoManga == "corta" && cami.TipoCuello == "mao")
                            {
                                if (radioStandard.Checked)
                                {
                                    if (v.Calidad == "Standard")
                                    {

                                        stock = cami.Stock;
                                        prendaCotizada = cami;
                                        MessageBox.Show("SOY STANDARD!" + cami.Calidad + " " + cami.Stock + " " + cami.TipoManga + " " + cami.TipoCuello);
                                        CrearCotizacion(cami, ref txtCantPrenda, ref txtPrecioPrenda, ref lblCotizacionFinal);

                                    }
                                }
                                else if (!radioStandard.Checked)
                                {
                                    if (v.Calidad == "Premium")
                                    {
                                        stock += v.Stock;
                                        prendaCotizada = v;
                                        MessageBox.Show("SOY PREMIUM!" + cami.Calidad + " " + cami.Stock + " " + cami.TipoManga + " " + cami.TipoCuello);
                                        CrearCotizacion(cami, ref txtCantPrenda, ref txtPrecioPrenda, ref lblCotizacionFinal);

                                    }
                                }
                            }

                        }
                        //si NO tildo  manga corta Y NO TILDO cuello comun)
                        if (!checkCuelloMao.Checked && !checkMangaCorta.Checked)
                        {

                            //selecciono manga larga  y cuello comun
                            if (cami.TipoManga == "larga" && cami.TipoCuello == "comun")
                            {

                                if (radioStandard.Checked)
                                {
                                    if (v.Calidad == "Standard")
                                    {
                                        stock = cami.Stock;
                                        prendaCotizada = cami;
                                        CrearCotizacion(cami, ref txtCantPrenda, ref txtPrecioPrenda, ref lblCotizacionFinal);
                                    }

                                }
                                else if (!radioStandard.Checked)
                                {
                                    if (v.Calidad == "Premium")
                                    {
                                        stock = cami.Stock;
                                        prendaCotizada = cami;
                                        CrearCotizacion(cami, ref txtCantPrenda, ref txtPrecioPrenda, ref lblCotizacionFinal);
                                    }

                                }
                            }

                        }
                        //si NO tildo  manga corta y tildo  cuello mao)
                        if (!checkMangaCorta.Checked && checkCuelloMao.Checked)
                        {

                            //selecciono manga larga  y cuello mao
                            if (cami.TipoManga == "larga" && cami.TipoCuello == "mao")
                            {


                                if (radioStandard.Checked)
                                {
                                    if (v.Calidad == "Standard")
                                    {
                                        stock = cami.Stock;
                                        prendaCotizada = cami;
                                        CrearCotizacion(cami, ref txtCantPrenda, ref txtPrecioPrenda, ref lblCotizacionFinal);
                                    }

                                }
                                else if (!radioStandard.Checked)
                                {
                                    if (v.Calidad == "Premium")
                                    {
                                        stock = cami.Stock;
                                        prendaCotizada = cami;
                                        CrearCotizacion(cami, ref txtCantPrenda, ref txtPrecioPrenda, ref lblCotizacionFinal);
                                    }

                                }

                            }

                        }
                        //cotizacion = new Cotizacion(vendedor.CodigoVendedor, prendaCotizada, (mangacorta + mangaLarga));
                    }
                }



                lblStock.Text = stock.ToString();

            }
            //si en vez de camisa es pantalon
            else
            {
                foreach (var v in tienda.ListadoPrendas)
                {
                    if (v is Pantalon)
                    {
                        Pantalon panta = (Pantalon)v;
                        //si es chupin
                        if (checkChupin.Checked)
                        {

                            if (panta.TipoCorte == "chupin")
                            {

                                if (radioStandard.Checked)//-
                                {
                                    if (panta.Calidad == "Standard")
                                    {
                                        MessageBox.Show("SOY STANDARD!" + panta.Calidad + " " + panta.Stock + " " + panta.TipoCorte);
                                        stock = panta.Stock;
                                        prendaCotizada = panta;
                                        CrearCotizacion(panta, ref txtCantPrenda, ref txtPrecioPrenda, ref lblCotizacionFinal);
                                    }
                                }
                                else if (!radioStandard.Checked)
                                {
                                    if (panta.Calidad == "Premium")
                                    {
                                        MessageBox.Show("SOY premium!" + panta.Calidad + " " + panta.Stock + " " + panta.TipoCorte);
                                        stock = panta.Stock;
                                        prendaCotizada = panta;
                                        CrearCotizacion(panta, ref txtCantPrenda, ref txtPrecioPrenda, ref lblCotizacionFinal);

                                    }
                                }//-
                            }
                        }
                        //si NO es chupin
                        else
                        {
                            if (panta.TipoCorte == "normal")
                            {
                                if (radioStandard.Checked)
                                {
                                    if (panta.Calidad == "Standard")
                                    {
                                        stock = panta.Stock;
                                        prendaCotizada = panta;
                                        CrearCotizacion(panta, ref txtCantPrenda, ref txtPrecioPrenda, ref lblCotizacionFinal);
                                    }

                                }
                                else if (!radioStandard.Checked)
                                {

                                    if (panta.Calidad == "Premium")
                                    {
                                        stock = panta.Stock;
                                        prendaCotizada = panta;
                                        CrearCotizacion(panta, ref txtCantPrenda, ref txtPrecioPrenda, ref lblCotizacionFinal);
                                    }


                                }
                            }
                        }
                    }
                }


                lblStock.Text = stock.ToString();

            }



        }
        public void CrearCotizacion(Prenda prendaACotizar, ref TextBox cantidadPrendas, ref TextBox precio, ref Label lblCotizacionFinal)
        {
           
            
            if (prendaACotizar.Stock < int.Parse(cantidadPrendas.Text))
            {
                MessageBox.Show("NO HAY SUFICIENTE STOCK");
            }
            else
            {

                try
                {
                    int cantidad = int.Parse(cantidadPrendas.Text);
                    float precioPrenda = float.Parse(precio.Text);

                    if (prendaACotizar is Camisa)
                    {
                        Camisa camisa = (Camisa)prendaACotizar;
                        if (camisa.TipoManga == "corta")
                        {
                            precioPrenda = precioPrenda * 0.90f;
                            if (camisa.TipoCuello == "mao")
                            {
                                precioPrenda = precioPrenda * 1.03f;
                            }

                        }
                        else if (camisa.TipoCuello == "mao")
                        {
                            precioPrenda = precioPrenda * 1.03f;
                        }

                    }
                    if (prendaACotizar is Pantalon)
                    {
                        Pantalon pantalon = (Pantalon)prendaACotizar;
                        if (pantalon.TipoCorte == "chupin")
                        {
                            precioPrenda = precioPrenda * 0.88f;
                        }
                    }

                    if (prendaACotizar.Calidad == "Premium")
                    {
                        precioPrenda = precioPrenda * 1.3f;
                    }

                    historialCotizaciones.Add(new Cotizacion(this.vendedor.CodigoVendedor, prendaACotizar, cantidad));
                    lblCotizacionFinal.Text = (cantidad * precioPrenda).ToString();

                }
                catch (Exception e)
                {
                    MessageBox.Show("Debe ingresar una cantidad y precio");
                }
            }


        }

        public string MostrarHistorial(string listado)
        {
          
            foreach (Cotizacion v in historialCotizaciones)
            {

                listado += $"\n {v.CodigoVendedor} {vendedor.Nombre} {v.FechaYHora} " +(v.PrendaCotizada is Camisa ? "camisa" : "pantalon");
            }
            return listado;
        }


    }
}

