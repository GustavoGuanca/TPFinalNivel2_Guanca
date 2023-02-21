using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;

namespace Negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("select  A.Id, Codigo, Nombre, A.Descripcion, M.Id, C.Id,IdMarca, IdCategoria, M.Descripcion Marca, C.Descripcion Tipo, ImagenUrl, Precio from Articulos A, Marcas M, Categorias C where IdMarca = M.Id and IdCategoria = C.Id and IdCategoria = C.Id");
                datos.ejecutarLectura();


                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    if(!(datos.Lector["ImagenUrl"] is DBNull))
                        aux.UrlImagen = (string)datos.Lector["ImagenUrl"];
                    aux.Categoria = new Categoria();
                    aux.Categoria.Id = (int)datos.Lector["IdCategoria"];
                    aux.Categoria.Descripcion = (string)datos.Lector["Tipo"];
                    aux.Marca = new Marca();
                    aux.Marca.Id = (int)datos.Lector["IdMarca"];
                    aux.Marca.Descripcion = (string)datos.Lector["Marca"];
                    aux.Precio = Math.Truncate((decimal)datos.Lector["Precio"] * 100) / 100;
                    lista.Add(aux);
                }

            return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
            finally
            {
                datos.cerrarConexion();
            }


        }
        public void agregar(Articulo nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("insert into articulos(Codigo, Nombre, Descripcion, IdMarca, IdCategoria, ImagenUrl, Precio) values (@Codigo, @Nombre, @Descripcion, @IdMarca, @IdCategoria, @ImagenUrl, @Precio)");
                datos.ConfigurarParametros("@Codigo", nuevo.Codigo);
                datos.ConfigurarParametros("@Nombre", nuevo.Nombre);
                datos.ConfigurarParametros("@Descripcion", nuevo.Descripcion);
                datos.ConfigurarParametros("@IdMarca", nuevo.Marca.Id);
                datos.ConfigurarParametros("@IdCategoria", nuevo.Categoria.Id);
                datos.ConfigurarParametros("@ImagenUrl", nuevo.UrlImagen);
                datos.ConfigurarParametros("@Precio", nuevo.Precio);

                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void modificar(Articulo modificar)
        {
            AccesoDatos datos = new AccesoDatos();
           
            try
            {
                datos.ConfigurarConsulta("update articulos set Codigo = @Codigo, Nombre = @Nombre, Descripcion = @Descripcion, IdMarca = @IdMarca, IdCategoria = @IdCategoria, ImagenUrl = @ImagenUrl, Precio = @Precio where Id = @Id");
                datos.ConfigurarParametros("@Id", modificar.Id);
                datos.ConfigurarParametros("@Codigo", modificar.Codigo);
                datos.ConfigurarParametros("@Nombre", modificar.Nombre);
                datos.ConfigurarParametros("@Descripcion", modificar.Descripcion);
                datos.ConfigurarParametros("@IdMarca", modificar.Marca.Id);
                datos.ConfigurarParametros("@IdCategoria", modificar.Categoria.Id);
                datos.ConfigurarParametros("@ImagenUrl", modificar.UrlImagen);
                datos.ConfigurarParametros("@Precio", modificar.Precio);

                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void eliminar(int id)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                
                datos.ConfigurarConsulta("delete from articulos where id = @Id");
                datos.ConfigurarParametros("@Id", id);
                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public List<Articulo> filtrar(string campo, string criterio, string filtro)
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                string consulta = "select  A.Id, Codigo, Nombre, A.Descripcion, M.Id, C.Id,IdMarca, IdCategoria, M.Descripcion Marca, C.Descripcion Tipo, ImagenUrl, Precio from Articulos A, Marcas M, Categorias C where IdMarca = M.Id and IdCategoria = C.Id and IdCategoria = C.Id";

                switch (campo)
                {
                    case "Código":
                        switch (criterio)
                        {
                            case "Comienza con":
                                consulta += " and Codigo like '" + filtro + "%'";
                                break;
                            case "Termina con":
                                consulta += " and Codigo like '%" + filtro + "'";
                                break;
                            default:
                                consulta += " and Codigo like '%" + filtro + "%'";
                                break;
                        }
                        break;

                    case "Nombre":
                        switch (criterio)
                        {
                            case "Comienza con":
                                consulta += " and Nombre like '" + filtro + "%' ";
                                break;
                            case "Termina con":
                                consulta += " and Nombre like '%" + filtro + "'";
                                break;
                            default:
                                consulta += " and Nombre like '%" + filtro + "%'";
                                break;
                        }
                        break;

                    case "Descripción":
                        switch (criterio)
                        {
                            case "Comienza con":
                                consulta += " and A.Descripcion like '" + filtro + "%'";
                                break;
                            case "Termina con":
                                consulta += " and A.Descripcion like '%" + filtro + "'";
                                break;
                            default:
                                consulta += " and A.Descripcion like '%" + filtro + "%'";
                                break;
                        }
                        break;


                    case "Precio":
                        switch (criterio)
                        {
                            case "Mayor a":
                                consulta += " and Precio > " + filtro;
                                break;
                            case "Menor a":
                                consulta += " and Precio < " + filtro;
                                break;
                            case "Igual a":
                                consulta += " and Precio = " + filtro;
                                break;
                        }
                        break;

                }

                datos.setearConsulta(consulta);
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    if (!(datos.Lector["ImagenUrl"] is DBNull))
                        aux.UrlImagen = (string)datos.Lector["ImagenUrl"];
                    aux.Categoria = new Categoria();
                    aux.Categoria.Id = (int)datos.Lector["IdCategoria"];
                    aux.Categoria.Descripcion = (string)datos.Lector["Tipo"];
                    aux.Marca = new Marca();
                    aux.Marca.Id = (int)datos.Lector["IdMarca"];
                    aux.Marca.Descripcion = (string)datos.Lector["Marca"];
                    aux.Precio = Math.Truncate((decimal)datos.Lector["Precio"] * 100) / 100;
                    lista.Add(aux);
                }

                return lista;

            }
            catch (Exception)
            {

                throw;
            }
        }


    }
}
