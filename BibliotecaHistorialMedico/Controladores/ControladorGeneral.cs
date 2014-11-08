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
            Diagnostico diagnostico;
            ISession nhSesion = ManejoNHibernate.IniciarSesion();

            try
            {
                diagnostico = CatalogoDiagnostico.RecuperarPorCodigo(codigoDiagnostico, nhSesion);
                CatalogoDiagnostico.Eliminar(diagnostico, nhSesion);
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

        #region MotivoConsulta

        public static DataTable RecuperarTodosMotivosConsulta()
        {
            DataTable tablaMotivosConsulta = new DataTable();
            tablaMotivosConsulta.Columns.Add("codigoMotivoConsulta");
            tablaMotivosConsulta.Columns.Add("descripcion");

            ISession nhSesion = ManejoNHibernate.IniciarSesion();

            try
            {
                List<MotivoConsulta> listaMotivosConsulta = CatalogoMotivoConsulta.RecuperarTodos(nhSesion);
                tablaMotivosConsulta = (from p in listaMotivosConsulta select p).Aggregate(tablaMotivosConsulta, (dt, r) => { dt.Rows.Add(r.Codigo, r.Descripcion); return dt; });
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

            return tablaMotivosConsulta;
        }

        public static void InsertarActualizarMotivoConsulta(int codigoMotivoConsulta, string descripcion)
        {
            ISession nhSesion = ManejoNHibernate.IniciarSesion();

            try
            {
                MotivoConsulta motivoConsulta;

                if (codigoMotivoConsulta == 0)
                {
                    motivoConsulta = new MotivoConsulta();
                }
                else
                {
                    motivoConsulta = CatalogoMotivoConsulta.RecuperarPorCodigo(codigoMotivoConsulta, nhSesion);
                }

                motivoConsulta.Descripcion = descripcion;

                CatalogoMotivoConsulta.InsertarActualizar(motivoConsulta, nhSesion);
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

        public static void EliminarMotivoConsulta(int codigoMotivoConsulta)
        {
            MotivoConsulta motivoConsulta;
            ISession nhSesion = ManejoNHibernate.IniciarSesion();

            try
            {
                motivoConsulta = CatalogoMotivoConsulta.RecuperarPorCodigo(codigoMotivoConsulta, nhSesion);
                CatalogoMotivoConsulta.Eliminar(motivoConsulta, nhSesion);
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

        public static DataTable RecuperarMotivoConsultaPorCodigo(int codigoMotivoConsulta)
        {
            DataTable tablaMotivoConsulta = new DataTable();
            tablaMotivoConsulta.Columns.Add("codigoMotivoConsulta");
            tablaMotivoConsulta.Columns.Add("descripcion");

            ISession nhSesion = ManejoNHibernate.IniciarSesion();

            try
            {
                MotivoConsulta motivoConsulta = CatalogoMotivoConsulta.RecuperarPorCodigo(codigoMotivoConsulta, nhSesion);
                tablaMotivoConsulta.Rows.Add(new object[] { motivoConsulta.Codigo, motivoConsulta.Descripcion });
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

            return tablaMotivoConsulta;
        }

        #endregion

        #region ObraSocial

        public static DataTable RecuperarTodosObraSocial()
        {
            DataTable tablaObraSocial = new DataTable();
            tablaObraSocial.Columns.Add("codigoObraSocial");
            tablaObraSocial.Columns.Add("descripcion");

            ISession nhSesion = ManejoNHibernate.IniciarSesion();

            try
            {
                List<ObraSocial> listaObraSocial = CatalogoObraSocial.RecuperarTodos(nhSesion);
                tablaObraSocial = (from p in listaObraSocial select p).Aggregate(tablaObraSocial, (dt, r) => { dt.Rows.Add(r.Codigo, r.Descripcion); return dt; });
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

            return tablaObraSocial;
        }

        public static void InsertarActualizarObraSocial(int codigoObraSocial, string descripcion)
        {
            ISession nhSesion = ManejoNHibernate.IniciarSesion();

            try
            {
                ObraSocial obraSocial;

                if (codigoObraSocial == 0)
                {
                    obraSocial = new ObraSocial();
                }
                else
                {
                    obraSocial = CatalogoObraSocial.RecuperarPorCodigo(codigoObraSocial, nhSesion);
                }

                obraSocial.Descripcion = descripcion;

                CatalogoObraSocial.InsertarActualizar(obraSocial, nhSesion);
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

        public static void EliminarObraSocial(int codigoObraSocial)
        {
            ObraSocial obraSocial;
            ISession nhSesion = ManejoNHibernate.IniciarSesion();

            try
            {
                obraSocial = CatalogoObraSocial.RecuperarPorCodigo(codigoObraSocial, nhSesion);
                CatalogoObraSocial.Eliminar(obraSocial, nhSesion);
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

        public static DataTable RecuperarObraSocialPorCodigo(int codigoObraSocial)
        {
            DataTable tablaObraSocial = new DataTable();
            tablaObraSocial.Columns.Add("codigoObraSocial");
            tablaObraSocial.Columns.Add("descripcion");

            ISession nhSesion = ManejoNHibernate.IniciarSesion();

            try
            {
                ObraSocial obraSocial = CatalogoObraSocial.RecuperarPorCodigo(codigoObraSocial, nhSesion);
                tablaObraSocial.Rows.Add(new object[] { obraSocial.Codigo, obraSocial.Descripcion });
                return tablaObraSocial;
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

        #endregion

        #region Tratamiento

        public static DataTable RecuperarTodosTratamientos()
        {
            DataTable tablaTratamientos = new DataTable();
            tablaTratamientos.Columns.Add("codigoTratamiento");
            tablaTratamientos.Columns.Add("descripcion");

            ISession nhSesion = ManejoNHibernate.IniciarSesion();

            try
            {
                List<Tratamiento> listaTratamientos = CatalogoTratamiento.RecuperarTodos(nhSesion);
                tablaTratamientos = (from p in listaTratamientos select p).Aggregate(tablaTratamientos, (dt, r) => { dt.Rows.Add(r.Codigo, r.Descripcion); return dt; });
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

            return tablaTratamientos;
        }

        public static void InsertarActualizarTratamiento(int codigoTratamiento, string descripcion)
        {
            ISession nhSesion = ManejoNHibernate.IniciarSesion();

            try
            {
                Tratamiento tratamiento;

                if (codigoTratamiento == 0)
                {
                    tratamiento = new Tratamiento();
                }
                else
                {
                    tratamiento = CatalogoTratamiento.RecuperarPorCodigo(codigoTratamiento, nhSesion);
                }

                tratamiento.Descripcion = descripcion;

                CatalogoTratamiento.InsertarActualizar(tratamiento, nhSesion);
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

        public static void EliminarTratamiento(int codigoTratamiento)
        {
            Tratamiento tratamiento;
            ISession nhSesion = ManejoNHibernate.IniciarSesion();

            try
            {
                tratamiento = CatalogoTratamiento.RecuperarPorCodigo(codigoTratamiento, nhSesion);
                CatalogoTratamiento.Eliminar(tratamiento, nhSesion);
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

        public static DataTable RecuperarTratamientoPorCodigo(int codigoTratamiento)
        {
            DataTable tablaTratamiento = new DataTable();
            tablaTratamiento.Columns.Add("codigoTratamiento");
            tablaTratamiento.Columns.Add("descripcion");

            ISession nhSesion = ManejoNHibernate.IniciarSesion();

            try
            {
                Tratamiento tratamiento = CatalogoTratamiento.RecuperarPorCodigo(codigoTratamiento, nhSesion);
                tablaTratamiento.Rows.Add(new object[] { tratamiento.Codigo, tratamiento.Descripcion });
                return tablaTratamiento;
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

        #endregion
        
        #region Estudio

        public static DataTable RecuperarTodosEstudios()
        {
            DataTable tablaEstudios = new DataTable();
            tablaEstudios.Columns.Add("codigoEstudio");
            tablaEstudios.Columns.Add("descripcion");

            ISession nhSesion = ManejoNHibernate.IniciarSesion();

            try
            {
                List<Estudio> listaEstudios = CatalogoEstudio.RecuperarTodos(nhSesion);
                tablaEstudios = (from p in listaEstudios select p).Aggregate(tablaEstudios, (dt, r) => { dt.Rows.Add(r.Codigo, r.Descripcion); return dt; });
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

            return tablaEstudios;
        }

        public static void InsertarActualizarEstudio(int codigoEstudio, string descripcion)
        {
            ISession nhSesion = ManejoNHibernate.IniciarSesion();

            try
            {
                Estudio estudio;

                if (codigoEstudio == 0)
                {
                    estudio = new Estudio();
                }
                else
                {
                    estudio = CatalogoEstudio.RecuperarPorCodigo(codigoEstudio, nhSesion);
                }

                estudio.Descripcion = descripcion;

                CatalogoEstudio.InsertarActualizar(estudio, nhSesion);
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

        public static void EliminarEstudio(int codigoTratamiento)
        {
            Estudio estudio;
            ISession nhSesion = ManejoNHibernate.IniciarSesion();

            try
            {
                estudio = CatalogoEstudio.RecuperarPorCodigo(codigoTratamiento, nhSesion);
                CatalogoEstudio.Eliminar(estudio, nhSesion);
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

        public static DataTable RecuperarEstudioPorCodigo(int codigoEstudio)
        {
            DataTable tablaEstudio = new DataTable();
            tablaEstudio.Columns.Add("codigoEstudio");
            tablaEstudio.Columns.Add("descripcion");

            ISession nhSesion = ManejoNHibernate.IniciarSesion();

            try
            {
                Estudio estudio = CatalogoEstudio.RecuperarPorCodigo(codigoEstudio, nhSesion);
                tablaEstudio.Rows.Add(new object[] { estudio.Codigo, estudio.Descripcion });
                return tablaEstudio;
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

        #endregion
    }
}
