using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;

namespace Presentacion
{
    public partial class frmDetalle : Form
    {
        private Articulo seleccionado;
        public frmDetalle(Articulo seleccionado)
        {
            InitializeComponent();
            this.seleccionado = seleccionado;
        }

        private void cargarImagen(string imagen)
        {
            try
            {

                pbxArticulo.Load(imagen);

            }
            catch (Exception)
            {
                pbxArticulo.Load("https://developers.elementor.com/docs/assets/img/elementor-placeholder-image.png");
            }
        }

        private void frmDetalle_Load(object sender, EventArgs e)
        {
            cargarImagen(seleccionado.UrlImagen);
            lblNombreSeleccionado.Text = seleccionado.Nombre;                
            lblPrecioSeleccionado.Text = seleccionado.Precio.ToString("C");  
            lblCodigoSeleccionado.Text = seleccionado.Codigo;
            lblMarcaSeleccionada.Text = seleccionado.Marca.Descripcion;
            lblCategoriaSeleccionada.Text = seleccionado.Categoria.Descripcion;
            lblDescripcionSeleccionada.Text = seleccionado.Descripcion;
        }
    }
}
