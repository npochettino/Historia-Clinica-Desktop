using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaHistorialMedico.Catalogos;
using BibliotecaHistorialMedico.Clases;
using BibliotecaHistorialMedico.ClasesComplementarias;
using NHibernate;

namespace BibliotecaHistorialMedico.Controladores
{
    public class ControladorGeneral
    {
        #region Pacientes

        public static DataTable RecuperarTodosPacientes()
        {
            DataTable tablaPacientes = new DataTable();
            tablaPacientes.Columns.Add("codigoPaciente");
            tablaPacientes.Columns.Add("apellidoNombre");
            tablaPacientes.Columns.Add("telefono");
            tablaPacientes.Columns.Add("mail");
            tablaPacientes.Columns.Add("direccion");

            ISession nhSesion = ManejoNHibernate.IniciarSesion();

            try
            {
                List<Paciente> listaPacientes = CatalogoPaciente.RecuperarTodos(nhSesion);
                tablaPacientes = (from p in listaPacientes select p).Aggregate(tablaPacientes, (dt, r) => { dt.Rows.Add(r.Codigo, r.ApellidoNombre, r.Telefono, r.Mail, r.Direccion); return dt; });

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                nhSesion.Close();
                nhSesion.Dispose();
            }

            return tablaPacientes;
        }

        public static void InsertarActualizarPaciente(int codigoPaciente, string apellidoNombre, string telefono, string mailPaciente, string direccion)
        {
            ISession nhSesion = ManejoNHibernate.IniciarSesion();

            try
            {
                Paciente paciente;

                if (codigoPaciente == 0)
                {
                    paciente = new Paciente();
                }
                else
                {
                    paciente = CatalogoPaciente.RecuperarPorCodigo(codigoPaciente, nhSesion);
                }

                paciente.ApellidoNombre = apellidoNombre;
                paciente.Telefono = telefono;
                paciente.Mail = mailPaciente;
                paciente.Direccion = direccion;

                CatalogoPaciente.InsertarActualizar(paciente, nhSesion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                nhSesion.Close();
                nhSesion.Dispose();
            }
        }

        public static void EliminarPaciente(int codigoPaciente)
        {
            Paciente paciente;
            ISession nhSesion = ManejoNHibernate.IniciarSesion();

            try
            {
                paciente = CatalogoPaciente.RecuperarPorCodigo(codigoPaciente, nhSesion);
                CatalogoPaciente.Eliminar(paciente, nhSesion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                nhSesion.Close();
                nhSesion.Dispose();
            }
        }

        public static DataTable RecuperarPacientePorCodigo(int codigoPaciente)
        {
            DataTable tablaPaciente = new DataTable();
            tablaPaciente.Columns.Add("codigoPaciente");
            tablaPaciente.Columns.Add("apellidoNombre");
            tablaPaciente.Columns.Add("telefono");
            tablaPaciente.Columns.Add("mail");
            tablaPaciente.Columns.Add("direccion");

            ISession nhSesion = ManejoNHibernate.IniciarSesion();

            try
            {
                Paciente paciente = CatalogoPaciente.RecuperarPorCodigo(codigoPaciente, nhSesion);
                tablaPaciente.Rows.Add(new object[] { paciente.Codigo, paciente.ApellidoNombre, paciente.Telefono, paciente.Mail, paciente.Direccion });

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                nhSesion.Close();
                nhSesion.Dispose();
            }

            return tablaPaciente;
        }

        #endregion

        #region Antecedentes

        public static DataTable RecuperarTodosAntecedentes()
        {
            DataTable tablaAntecedentes = new DataTable();
            tablaAntecedentes.Columns.Add("codigoAntecedente");
            tablaAntecedentes.Columns.Add("descripcion");
            tablaAntecedentes.Columns.Add("comentario");

            ISession nhSesion = ManejoNHibernate.IniciarSesion();

            try
            {
                List<Antecedente> listaAntecedentes = CatalogoAntecedente.RecuperarTodos(nhSesion);
                tablaAntecedentes = (from p in listaAntecedentes select p).Aggregate(tablaAntecedentes, (dt, r) => { dt.Rows.Add(r.Codigo, r.Descripcion, r.Comentario); return dt; });
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                nhSesion.Close();
                nhSesion.Dispose();
            }

            return tablaAntecedentes;
        }

        public static void InsertarActualizarAntecedente(int codigoAntecedente, string descripcion, string comentario)
        {
            ISession nhSesion = ManejoNHibernate.IniciarSesion();

            try
            {
                Antecedente antecedente;

                if (codigoAntecedente == 0)
                {
                    antecedente = new Antecedente();
                }
                else
                {
                    antecedente = CatalogoAntecedente.RecuperarPorCodigo(codigoAntecedente, nhSesion);
                }

                antecedente.Comentario = comentario;
                antecedente.Descripcion = descripcion;

                CatalogoAntecedente.InsertarActualizar(antecedente, nhSesion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                nhSesion.Close();
                nhSesion.Dispose();
            }
        }

        public static void EliminarAntecedente(int codigoAntecedente)
        {
            Antecedente antecedente;
            ISession nhSesion = ManejoNHibernate.IniciarSesion();

            try
            {
                antecedente = CatalogoAntecedente.RecuperarPorCodigo(codigoAntecedente, nhSesion);
                CatalogoAntecedente.Eliminar(antecedente, nhSesion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                nhSesion.Close();
                nhSesion.Dispose();
            }
        }

        public static DataTable RecuperarAntecedentePorCodigo(int codigoAntecedente)
        {
            DataTable tablaAntecedente = new DataTable();
            tablaAntecedente.Columns.Add("codigoAntecedente");
            tablaAntecedente.Columns.Add("descripcion");
            tablaAntecedente.Columns.Add("comentario");

            ISession nhSesion = ManejoNHibernate.IniciarSesion();

            try
            {
                Antecedente antecedente = CatalogoAntecedente.RecuperarPorCodigo(codigoAntecedente, nhSesion);
                tablaAntecedente.Rows.Add(new object[] { antecedente.Codigo, antecedente.Descripcion, antecedente.Comentario });

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                nhSesion.Close();
                nhSesion.Dispose();
            }

            return tablaAntecedente;
        }

        #endregion

        #region Diagnostico

        public static DataTable RecuperarTodosDiagnosticos()
        {
            DataTable tablaDiagnosticos = new DataTable();
            tablaDiagnosticos.Columns.Add("codigoDiagnostico");
            tablaDiagnosticos.Columns.Add("descripcion");

            ISession nhSesion = ManejoNHibernate.IniciarSesion();

            try
            {
                List<Diagnostico> listaDiagnosticos = CatalogoDiagnostico.RecuperarTodos(nhSesion);
                tablaDiagnosticos = (from p in listaDiagnosticos select p).Aggregate(tablaDiagnosticos, (dt, r) => { dt.Rows.Add(r.Codigo, r.Descripcion); return dt; });

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                nhSesion.Close();
                nhSesion.Dispose();
            }

            return tablaDiagnosticos;
        }

        public static void InsertarActualizarDiagnostico(int codigoDiagnostico, string descripcion)
        {
            ISession nhSesion = ManejoNHibernate.IniciarSesion();

            try
            {
                Diagnostico diagnostico;

                if (codigoDiagnostico == 0)
                {
                    diagnostico = new Diagnostico();
                }
                else
                {
                    diagnostico = CatalogoDiagnostico.RecuperarPorCodigo(codigoDiagnostico, nhSesion);
                }

                diagnostico.Descripcion = descripcion;

                CatalogoDiagnostico.InsertarActualizar(diagnostico, nhSesion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                nhSesion.Close();
                nhSesion.Dispose();
            }
        }

        public static void EliminarDiagnostico(int codigoDiagnostico)
        {
            Diagnostico Diagnostico;
            ISession nhSesion = ManejoNHibernate.IniciarSesion();

            try
            {
                Diagnostico = CatalogoDiagnostico.RecuperarPorCodigo(codigoDiagnostico, nhSesion);
                CatalogoDiagnostico.Eliminar(Diagnostico, nhSesion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                nhSesion.Close();
                nhSesion.Dispose();
            }
        }

        public static DataTable RecuperarDiagnosticoPorCodigo(int codigoDiagnostico)
        {
            DataTable tablaDiagnostico = new DataTable();
            tablaDiagnostico.Columns.Add("codigoDiagnostico");
            tablaDiagnostico.Columns.Add("descripcion");

            ISession nhSesion = ManejoNHibernate.IniciarSesion();

            try
            {
                Diagnostico diagnostico = CatalogoDiagnostico.RecuperarPorCodigo(codigoDiagnostico, nhSesion);
                tablaDiagnostico.Rows.Add(new object[] { diagnostico.Codigo, diagnostico.Descripcion });
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                nhSesion.Close();
                nhSesion.Dispose();
            }

            return tablaDiagnostico;
        }

        #endregion
    }
}
