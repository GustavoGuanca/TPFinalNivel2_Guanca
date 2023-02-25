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
using Negocio;

namespace Presentacion
{
    public partial class frmAltaRelacionales : Form
    {
    private string eleccion;
    public frmAltaRelacionales(string eleccion)
    {
        this.eleccion = eleccion;
        InitializeComponent();

        switch (eleccion)
        {
            case "btnAgregarMarca":
                Text = "Nueva Marca";
                lblRelacional.Text = "Marca:";
                break;

            case "btnAgregarCategoria":
                Text = "Nueva Categoría";
                lblRelacional.Text = "Categoria:";
                    break;
        }
    }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(string.IsNullOrEmpty(txtRelacional.Text)))
                {
                    switch (eleccion)
                    {
                        case "btnAgregarMarca":
                            MarcasNegocio marcaNegocio = new MarcasNegocio();
                            Marca marca = new Marca();
                            marca.Descripcion = txtRelacional.Text;
                            marcaNegocio.Agregar(marca);
                            break;

                        case "btnAgregarCategoria":
                            CategoriasNegocio categoriaNegocio = new CategoriasNegocio();
                            Categoria categoria = new Categoria();
                            categoria.Descripcion = txtRelacional.Text;
                            categoriaNegocio.Agregar(categoria);
                            break;
                    }
                    

                    MessageBox.Show("Operación exitosa.");

                    Close();
                }
                else
                {
                    MessageBox.Show("Debe completar todos los campos.");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        }

    }

