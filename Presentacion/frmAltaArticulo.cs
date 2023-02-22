using Dominio;
using Negocio;
using System;
using System.IO;
using System.Windows.Forms;
using System.Configuration;

namespace Presentacion
{
    public partial class frmAltaArticulo : Form
    {
        private OpenFileDialog archivo = null;
        private Articulo articulo = null;
        public frmAltaArticulo()
        {
            InitializeComponent();
        }
        public frmAltaArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar Articulo";
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            borrarMensajeError();
            if (validarAltaArticulo())
            { 
                ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                if (articulo == null)
                    articulo = new Articulo();
                articulo.Codigo = txtCodigo.Text;
                articulo.Nombre = txtNombre.Text;
                articulo.Descripcion = txtDescripcion.Text;
                articulo.Categoria = (Categoria)cboCategoria.SelectedItem;
                articulo.Marca = (Marca)cboMarca.SelectedItem;
                articulo.Precio = decimal.Parse(txtPrecio.Text);
                articulo.UrlImagen = txtUrlImagen.Text;

                if(articulo.Id != 0) 
                {
                negocio.modificar(articulo);
                MessageBox.Show("Operación exitosa");
                }
                else 
                { 
                negocio.agregar(articulo);
                MessageBox.Show("Operación exitosa");
                }
                Close();
                
                if(archivo != null && !(txtUrlImagen.Text.ToUpper().Contains("HTTP")))
                    File.Copy(archivo.FileName, ConfigurationManager.AppSettings["images-folder"] + archivo.SafeFileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        }
        private void frmAltaArticulo_Load(object sender, EventArgs e)
        {
            CategoriasNegocio categoriasNegocio = new CategoriasNegocio();
            MarcasNegocio marcasNegocio = new MarcasNegocio();
            try
            {
                cboCategoria.DataSource = categoriasNegocio.listar();
                cboCategoria.ValueMember = "Id";
                cboCategoria.DisplayMember = "Descripcion";
                cboCategoria.SelectedIndex = -1;
                cboMarca.DataSource = marcasNegocio.listar();
                cboMarca.ValueMember = "Id";
                cboMarca.DisplayMember = "Descripcion";
                cboMarca.SelectedIndex = -1;

                if (articulo != null)
                {
                    txtCodigo.Text = articulo.Codigo;
                    txtNombre.Text = articulo.Nombre;
                    txtDescripcion.Text = articulo.Descripcion;
                    txtUrlImagen.Text = articulo.UrlImagen;
                    cargarImagen(articulo.UrlImagen);
                    txtPrecio.Text = articulo.Precio.ToString();
                    cboCategoria.SelectedValue = articulo.Categoria.Id;
                    cboMarca.SelectedValue = articulo.Marca.Id;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtUrlImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtUrlImagen.Text);
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

        private void btnImagen_Click(object sender, EventArgs e)
        {
            archivo = new OpenFileDialog();
            archivo.Filter = "jpg|*.jpg;|png|*.png";
            if (archivo.ShowDialog() == DialogResult.OK)
            {
                txtUrlImagen.Text = archivo.FileName;
                cargarImagen(archivo.FileName);
            }
        }



        private bool validarAltaArticulo()
        {
            bool ok = true;

            if (txtNombre.Text == "")
            {
                ok = false;
                errNombre.SetError(txtNombre, "Debe ingresar un nombre");

            }
            if (txtPrecio.Text == "")
            {
                ok = false;
                errPrecio.SetError(txtPrecio, "Debe ingresar un precio");
                
            }

            if (cboMarca.Text == "")
            {
                ok = false;
                errMarca.SetError(cboMarca, "Debe ingresar una marca");

            }

            if (cboCategoria.Text == "")
            {
                ok = false;
                errCategoria.SetError(cboCategoria, "Debe ingresar una Categoria");

            }


            if (!validarSoloNumeros(txtPrecio.Text))
            {
                ok = false;
                MessageBox.Show("Debes ingresar sólo números en el campo 'Precio'");
            }

            if (txtDescripcion.Text == "")
            {
                ok = false;
                errDescripcion.SetError(txtDescripcion, "Debe ingresar una descripcion");

            }

            if (txtCodigo.Text == "")
            {
                ok = false;
                errCodigo.SetError(txtCodigo, "Debe ingresar un Código");

            }


            return ok;
        }

        private bool validarSoloNumeros(string cadena)
        {
            foreach (char caracter in cadena)
            {
                if (!(char.IsNumber(caracter)))
                    return false;
            }
            return true;
        }

        private void borrarMensajeError()
        {
            errNombre.SetError(txtNombre, "");
            errPrecio.SetError(txtPrecio, "");
            errDescripcion.SetError(txtDescripcion, "");
            errCodigo.SetError(txtCodigo, "");
            errMarca.SetError(cboMarca, "");
            errCategoria.SetError(cboCategoria, "");
        }
    }
}
