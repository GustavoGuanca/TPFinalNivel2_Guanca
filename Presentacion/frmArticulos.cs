using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace Presentacion
{
    public partial class frmArticulos : Form
    {
        private List<Articulo> listaArticulo;
        public frmArticulos()
        {
            InitializeComponent();
        }

        private void frmArticulos_Load(object sender, EventArgs e)
        {
            cargar();
            cboCampo.Items.Add("Código");
            cboCampo.Items.Add("Nombre");
            cboCampo.Items.Add("Descripción");
            cboCampo.Items.Add("Precio");
            cboCampo.Items.Add("Marca");
            cboCampo.Items.Add("Categoría");
        }

      
        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvArticulos.CurrentRow != null)
            {
                 Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                 cargarImagen(seleccionado.UrlImagen);
            }
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

        private void cargar()
        {
            try
            {
                ArticuloNegocio negocio = new ArticuloNegocio();
                listaArticulo = negocio.listar();
                dgvArticulos.DataSource = listaArticulo;
                ocultarColumnas();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }
 

 

        private void ocultarColumnas()
        {
            dgvArticulos.Columns["UrlImagen"].Visible = false;
            dgvArticulos.Columns["Id"].Visible = false;
        }

   
    

            private void cboCampos_SelectedIndexChanged(object sender, EventArgs e)
            {
            CategoriasNegocio categoriasNegocio = new CategoriasNegocio();
            MarcasNegocio marcasNegocio = new MarcasNegocio();
            if (cboCampo.SelectedIndex == -1)
            {
                cboCriterio.DataSource = null;
                cboCriterio.Items.Clear();
            }

            else
            {
            string opcion = cboCampo.SelectedItem.ToString();
                if (opcion == "Precio")
                {
                    txtFiltroAvanzado.Text = "";
                    txtFiltroAvanzado.Enabled = true;
                    cboCriterio.DataSource = null;
                    cboCriterio.Items.Clear();
                    cboCriterio.Items.Add("Mayor a");
                    cboCriterio.Items.Add("Menor a");
                    cboCriterio.Items.Add("Igual a");
                }

                else if (opcion == "Marca")
                {
                    txtFiltroAvanzado.Text = "";
                    txtFiltroAvanzado.Enabled = false;
                    cboCriterio.DataSource = marcasNegocio.listar();
                    cboCriterio.ValueMember = "Id";
                    cboCriterio.DisplayMember = "Descripcion";
                    cboCriterio.SelectedIndex = -1;
                }

                else if (opcion == "Categoría")
                {
                    txtFiltroAvanzado.Text = "";
                    txtFiltroAvanzado.Enabled = false;
                    cboCriterio.DataSource = categoriasNegocio.listar();
                    cboCriterio.ValueMember = "Id";
                    cboCriterio.DisplayMember = "Descripcion";
                    cboCriterio.SelectedIndex = -1;
                }

                else
            {
                txtFiltroAvanzado.Text = "";
                txtFiltroAvanzado.Enabled = true;
                cboCriterio.DataSource = null;
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Comienza con");
                cboCriterio.Items.Add("Termina con");
                cboCriterio.Items.Add("Contiene");
            }
          }
        }

       
        private bool validarBusquedaAvanzada()
        {
            if(cboCampo.SelectedIndex < 0)
            {
                SystemSounds.Exclamation.Play();
                MessageBox.Show("Debes seleccionar un campo");
                return true;
            }
      
            if (cboCriterio.SelectedIndex < 0)
            {
                SystemSounds.Exclamation.Play();
                MessageBox.Show("Debes seleccionar un Criterio");
                return true;
            }

            if (cboCampo.SelectedItem.ToString() == "Precio")
            {
                if (string.IsNullOrEmpty(txtFiltroAvanzado.Text))
                {
                    SystemSounds.Exclamation.Play();
                    MessageBox.Show("Debes ingresar un filtro");
                    return true;
                }

                if (!(validarSoloNumeros(txtFiltroAvanzado.Text)))
                {
                    SystemSounds.Exclamation.Play();
                    MessageBox.Show("Debes ingresar sólo números");
                    return true;
                }
            }

            if (cboCampo.SelectedIndex == 0 || cboCampo.SelectedIndex == 1 || cboCampo.SelectedIndex == 2 || cboCampo.SelectedIndex == 3 && txtFiltroAvanzado.Text != "")
            { 

                    SystemSounds.Exclamation.Play();
                    MessageBox.Show("Debe escribir caracteres en la caja de texto");
                    return true;
                
            }            
            return false;
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int indiceCampo = cboCampo.SelectedIndex;
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                if (validarBusquedaAvanzada())
                    return;

                string campo = cboCampo.SelectedItem.ToString();
                string criterio = cboCriterio.SelectedItem.ToString();
                string filtro;
                if (indiceCampo == 4 || indiceCampo == 5)
                {
                    filtro = criterio;
                }
                else
                {
                    filtro = txtFiltroAvanzado.Text;
                }
                    dgvArticulos.DataSource = negocio.filtrar(campo, criterio, filtro);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarBusqueda();
        }

        private void limpiarBusqueda()
        {
            txtFiltroAvanzado.Enabled = true;
            cboCampo.SelectedIndex = -1;
            cboCriterio.SelectedIndex = -1;
            txtFiltroAvanzado.Text = "";
            cargar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaArticulo alta = new frmAltaArticulo();
            alta.ShowDialog();
            limpiarBusqueda();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentCell != null)
            {
            Articulo seleccionado;
            seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            frmAltaArticulo modificar = new frmAltaArticulo(seleccionado);
            modificar.ShowDialog();
            limpiarBusqueda();
            }
                else
            {
                SystemSounds.Exclamation.Play();
                MessageBox.Show("No tiene ningún artículo seleccionado");
                limpiarBusqueda();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentCell != null)
            {
                SystemSounds.Exclamation.Play();
                ArticuloNegocio negocio = new ArticuloNegocio();
                Articulo seleccionado;
                try
                {
                    SystemSounds.Exclamation.Play();
                    DialogResult respuesta = MessageBox.Show("¿Estás seguro de eliminar?", "¿Eliminar?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (respuesta == DialogResult.Yes)
                    {
                        seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                        negocio.eliminar(seleccionado.Id);
                        limpiarBusqueda();
                    }
                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }

            else
            {
                SystemSounds.Exclamation.Play();
                MessageBox.Show("No tiene ningún artículo seleccionado");
                limpiarBusqueda();
            }
        }
        private void btnVerDetalle_Click(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentCell != null)
            { 
            Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            frmDetalle detalle = new frmDetalle(seleccionado);
            detalle.ShowDialog();
            }
            else
            {
                MessageBox.Show("Elija un articulo");
            }
        }

        private void btnAgregarMarca_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            frmAltaRelacionales alta = new frmAltaRelacionales(btn.Name);
            alta.ShowDialog();
        }

        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            frmAltaRelacionales alta = new frmAltaRelacionales(btn.Name);
            alta.ShowDialog();
        }

        private void btnEliminarMarca_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            frmBajaRelacionales baja = new frmBajaRelacionales(btn.Name);
            baja.ShowDialog();
        }

        private void btnEliminarCategoria_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            frmBajaRelacionales baja = new frmBajaRelacionales(btn.Name);
            baja.ShowDialog();
        }

       
    }
}
