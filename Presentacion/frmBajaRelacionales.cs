using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Dominio;

namespace Presentacion
{
    public partial class frmBajaRelacionales : Form
    {
        private string eleccion;
        public frmBajaRelacionales(string eleccion)
        {
            this.eleccion = eleccion;
            InitializeComponent();

            switch (eleccion)
            {
                case "btnAgregarMarca":
                    Text = "Eliminar Marca";
                    break;

                case "btnAgregarCategoria":
                    Text = "Eliminar Categoría";
                    break;
            }
        }



        private void frmBajaRelacionales_Load(object sender, EventArgs e)
        {
            lblRelacional.BackColor = Color.Transparent;
            switch (eleccion)
            {
                case "btnEliminarMarca":
                    lblRelacional.Text = "Marca:";
                    MarcasNegocio marcaNegocio = new MarcasNegocio();
                    cboRelacional.DataSource = marcaNegocio.listar();
                    break;
                case "btnEliminarCategoria":
                    lblRelacional.Text = "Categoria:";
                    CategoriasNegocio categoriaNegocio = new CategoriasNegocio();
                    cboRelacional.DataSource = categoriaNegocio.listar();
                    break;
            }
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (eleccion == "btnEliminarMarca")
            {
                if (validarEliminacionMarca((Marca)cboRelacional.SelectedItem))
                    return;
                if (cboRelacional.SelectedIndex != -1)
                {
                    DialogResult respuesta = MessageBox.Show("¿Estás seguro de eliminar?", "¿Eliminar?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (respuesta == DialogResult.Yes)
                    {

                        Marca marca = new Marca();
                        MarcasNegocio marcaNegocio = new MarcasNegocio();
                        marca = (Marca)cboRelacional.SelectedItem;
                        marcaNegocio.Eliminar(marca.Id);
                        Close();

                    }
                }
                else
                {
                    MessageBox.Show("No hay elementos para eliminar.");
                }
                
            }
            else if (eleccion == "btnEliminarCategoria")
            {
                if (validarEliminacionCategoria((Categoria)cboRelacional.SelectedItem))
                    return;
                if (cboRelacional.SelectedIndex != -1)
                {
                    DialogResult respuesta = MessageBox.Show("¿Estás seguro de eliminar?", "¿Eliminar?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (respuesta == DialogResult.Yes)
                    {
                        Categoria categoria = new Categoria();
                        CategoriasNegocio categoriaNegocio = new CategoriasNegocio();
                        categoria = (Categoria)cboRelacional.SelectedItem;
                        categoriaNegocio.Eliminar(categoria.Id);
                        Close();
                    }
                }
                else
                {
                    MessageBox.Show("No hay elementos para eliminar.");
                }
            }
               
            }




            private static bool validarEliminacionMarca(Marca marca)
            {
                ArticuloNegocio Negocio = new ArticuloNegocio();
                List<Articulo> lista = Negocio.listar();

                foreach (Articulo a in lista)
                {
                    if (a.Marca.Id == marca.Id)
                    {
                        MessageBox.Show("Imposible completar la operación, hay articulos en la base de datos pertenecientes a " + a.Marca.Descripcion);
                        return true;
                    }
                }

                return false;
            }


            private static bool validarEliminacionCategoria(Categoria categoria)
            {
                ArticuloNegocio Negocio = new ArticuloNegocio();
                List<Articulo> lista = Negocio.listar();

                foreach (Articulo a in lista)
                {
                    if (a.Categoria.Id == categoria.Id)
                    {
                        MessageBox.Show("Imposible completar la operación, hay articulos en la base de datos pertenecientes a " + a.Categoria.Descripcion);
                        return true;
                    }
                }

                return false;
            }



        }
    
}
