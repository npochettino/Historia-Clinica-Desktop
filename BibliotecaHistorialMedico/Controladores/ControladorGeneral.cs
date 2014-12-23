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
            tablaPacientes.Columns.Add("dni");
            tablaPacientes.Columns.Add("sexo");
            tablaPacientes.Columns.Add("codigoObraSocial");
            tablaPacientes.Columns.Add("descripcionObraSocial");

            ISession nhSesion = ManejoNHibernate.IniciarSesion();

            try
            {
                List<Paciente> listaPacientes = CatalogoPaciente.RecuperarTodos(nhSesion);
                tablaPacientes = (from p in listaPacientes select p).Aggregate(tablaPacientes, (dt, r) => { dt.Rows.Add(r.Codigo, r.ApellidoNombre, r.Telefono, r.Mail, r.Direccion, r.Dni, r.Sexo, r.ObraSocial == null ? 0 : r.ObraSocial.Codigo, r.ObraSocial == null ? "Sin obra social" : r.ObraSocial.Descripcion); return dt; });

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

        public static void InsertarActualizarPaciente(int codigoPaciente, string apellidoNombre, string telefono, string mailPaciente, string direccion, string dni, string sexo, int codigoObraSocial)
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
                paciente.Dni = dni;
                paciente.Sexo = sexo;
                paciente.ObraSocial = CatalogoObraSocial.RecuperarPorCodigo(codigoObraSocial, nhSesion);

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
            tablaPaciente.Columns.Add("dni");
            tablaPaciente.Columns.Add("sexo");
            tablaPaciente.Columns.Add("codigoObraSocial");
            tablaPaciente.Columns.Add("descripcionObraSocial");

            ISession nhSesion = ManejoNHibernate.IniciarSesion();

            try
            {
                Paciente paciente = CatalogoPaciente.RecuperarPorCodigo(codigoPaciente, nhSesion);
                tablaPaciente.Rows.Add(new object[] { paciente.Codigo, paciente.ApellidoNombre, paciente.Telefono, paciente.Mail, paciente.Direccion, paciente.Dni, paciente.Sexo, paciente.ObraSocial == null ? 0 : paciente.ObraSocial.Codigo, paciente.ObraSocial == null ? "Sin obra social" : paciente.ObraSocial.Descripcion });

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

        public static DataTable RecuperarTratamientosConsultaPorConsulta(int codigoConsultaPaciente)
        {
            DataTable tablaTratamientos = new DataTable();
            tablaTratamientos.Columns.Add("codigoTratamiento");
            tablaTratamientos.Columns.Add("descripcion");

            ISession nhSesion = ManejoNHibernate.IniciarSesion();

            try
            {
                ConsultaPaciente consulta = CatalogoConsultaPaciente.RecuperarPorCodigo(codigoConsultaPaciente, nhSesion);
                if (consulta.Tratamientos.Count > 0)
                {
                    tablaTratamientos = (from p in consulta.Tratamientos select p).Aggregate(tablaTratamientos, (dt, r) => { dt.Rows.Add(r.Codigo, r.Descripcion); return dt; });
                }
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

        public static void EliminarTratamientosConsultaPorConsulta(int codigoConsultaPaciente)
        {
            ISession nhSesion = ManejoNHibernate.IniciarSesion();
            ITransaction trans = nhSesion.BeginTransaction();
            try
            {
                ConsultaPaciente consulta = CatalogoConsultaPaciente.RecuperarPorCodigo(codigoConsultaPaciente, nhSesion);
                if (consulta.Tratamientos.Count > 0)
                {
                    consulta.Tratamientos = new List<Tratamiento>();
                    CatalogoConsultaPaciente.InsertarActualizar(consulta, nhSesion);
                    trans.Commit();
                }
                else
                {
                    trans.Rollback();
                }
            }
            catch (Exception ex)
            {
                trans.Rollback();
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
            tablaEstudios.Columns.Add("descripcionEstudio");

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

        public static void EliminarEstudio(int codigoEstudio)
        {
            Estudio estudio;
            ISession nhSesion = ManejoNHibernate.IniciarSesion();

            try
            {
                estudio = CatalogoEstudio.RecuperarPorCodigo(codigoEstudio, nhSesion);
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

        #region ConsultaPaciente

        public static DataSet RecuperarTodosConsultaPaciente(int codigoPaciente)
        {
            DataSet dsConsultaPaciente = new DataSet();

            DataTable tablaConsultasPaciente = new DataTable("tablaConsultaPaciente");
            tablaConsultasPaciente.Columns.Add("codigoConsultaPaciente");
            tablaConsultasPaciente.Columns.Add("codigoPaciente");
            tablaConsultasPaciente.Columns.Add("nombreApellidoPaciente");
            tablaConsultasPaciente.Columns.Add("fecha");
            tablaConsultasPaciente.Columns.Add("comentario");
            tablaConsultasPaciente.Columns.Add("codigoMotivoConsulta");
            tablaConsultasPaciente.Columns.Add("descripcionMotivoConsulta");
            tablaConsultasPaciente.Columns.Add("codigoDiagnostico");
            tablaConsultasPaciente.Columns.Add("descripcionDiagnostico");

            DataTable tablaTratamientos = new DataTable("tablaTratamientos");
            tablaTratamientos.Columns.Add("codigoConsultaPaciente");
            tablaTratamientos.Columns.Add("codigoTratamiento");
            tablaTratamientos.Columns.Add("descripcionTratamiento");

            ISession nhSesion = ManejoNHibernate.IniciarSesion();

            try
            {
                List<ConsultaPaciente> listaConsultasPaciente = CatalogoConsultaPaciente.RecuperarTodos(nhSesion, codigoPaciente);

                tablaConsultasPaciente = (from p in listaConsultasPaciente select p).Aggregate(tablaConsultasPaciente, (dt, r) =>
                {
                    dt.Rows.Add(r.Codigo, r.Paciente.Codigo, r.Paciente.ApellidoNombre, r.Fecha, r.Comentario, r.MotivoConsulta == null ? 0 : r.MotivoConsulta.Codigo,
                        r.MotivoConsulta == null ? "Sin motivo consulta" : r.MotivoConsulta.Descripcion, r.Diagnostico == null ? 0 : r.Diagnostico.Codigo, r.Diagnostico == null ? "Sin diagnóstico" : r.Diagnostico.Descripcion); return dt;
                });

                foreach (ConsultaPaciente cp in listaConsultasPaciente)
                {
                    foreach (Tratamiento t in cp.Tratamientos)
                    {
                        tablaTratamientos.Rows.Add(new object[] { cp.Codigo, t.Codigo, t.Descripcion });
                    }
                }

                dsConsultaPaciente.Tables.Add(tablaConsultasPaciente);
                dsConsultaPaciente.Tables.Add(tablaTratamientos);

                return dsConsultaPaciente;
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

        public static void InsertarActualizarConsultaPaciente(int codigoConsultaPaciente, int codigoPaciente, DateTime fecha, string comentario, int codigoMotivoConsulta, int codigoDiagnostico)
        {
            ISession nhSesion = ManejoNHibernate.IniciarSesion();

            try
            {
                ConsultaPaciente consultaPaciente;

                if (codigoConsultaPaciente == 0)
                {
                    consultaPaciente = new ConsultaPaciente();
                    consultaPaciente.Tratamientos = new List<Tratamiento>();
                }
                else
                {
                    consultaPaciente = CatalogoConsultaPaciente.RecuperarPorCodigo(codigoConsultaPaciente, nhSesion);
                }

                consultaPaciente.Paciente = CatalogoPaciente.RecuperarPorCodigo(codigoPaciente, nhSesion);
                consultaPaciente.Fecha = fecha;
                consultaPaciente.Comentario = comentario;

                if (codigoMotivoConsulta != 0)
                {
                    consultaPaciente.MotivoConsulta = CatalogoMotivoConsulta.RecuperarPorCodigo(codigoMotivoConsulta, nhSesion);
                }

                if (codigoDiagnostico != 0)
                {
                    consultaPaciente.Diagnostico = CatalogoDiagnostico.RecuperarPorCodigo(codigoDiagnostico, nhSesion);
                }

                CatalogoConsultaPaciente.InsertarActualizar(consultaPaciente, nhSesion);
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

        public static void EliminarConsultaPaciente(int codigoConsultaPaciente)
        {
            ConsultaPaciente consultaPaciente;
            ISession nhSesion = ManejoNHibernate.IniciarSesion();

            try
            {
                consultaPaciente = CatalogoConsultaPaciente.RecuperarPorCodigo(codigoConsultaPaciente, nhSesion);
                CatalogoConsultaPaciente.Eliminar(consultaPaciente, nhSesion);
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

        public static DataSet RecuperarConsultaPacientePorCodigo(int codigoConsultaPaciente)
        {
            DataSet dsConsultaPaciente = new DataSet();

            DataTable tablaConsultaPaciente = new DataTable("tablaConsultaPaciente");
            tablaConsultaPaciente.Columns.Add("codigoConsultaPaciente");
            tablaConsultaPaciente.Columns.Add("codigoPaciente");
            tablaConsultaPaciente.Columns.Add("nombreApellidoPaciente");
            tablaConsultaPaciente.Columns.Add("fecha");
            tablaConsultaPaciente.Columns.Add("comentario");
            tablaConsultaPaciente.Columns.Add("codigoMotivoConsulta");
            tablaConsultaPaciente.Columns.Add("descripcionMotivoConsulta");
            tablaConsultaPaciente.Columns.Add("codigoDiagnostico");
            tablaConsultaPaciente.Columns.Add("descripcionDiagnostico");

            DataTable tablaTratamientos = new DataTable("tablaTratamientos");
            tablaTratamientos.Columns.Add("codigoConsultaPaciente");
            tablaTratamientos.Columns.Add("codigoTratamiento");
            tablaTratamientos.Columns.Add("descripcionTratamiento");

            ISession nhSesion = ManejoNHibernate.IniciarSesion();

            try
            {
                ConsultaPaciente consultaPaciente = CatalogoConsultaPaciente.RecuperarPorCodigo(codigoConsultaPaciente, nhSesion);
                tablaConsultaPaciente.Rows.Add(new object[] { consultaPaciente.Codigo, consultaPaciente.Paciente.Codigo, consultaPaciente.Paciente.ApellidoNombre, consultaPaciente.Fecha, consultaPaciente.Comentario, consultaPaciente.MotivoConsulta == null ? 0 : consultaPaciente.MotivoConsulta.Codigo,
                    consultaPaciente.MotivoConsulta == null ? "Sin motivo consulta" : consultaPaciente.MotivoConsulta.Descripcion, consultaPaciente.Diagnostico == null ? 0 : consultaPaciente.Diagnostico.Codigo, consultaPaciente.Diagnostico == null ? "Sin diagnóstico" : consultaPaciente.Diagnostico.Descripcion });

                foreach (Tratamiento t in consultaPaciente.Tratamientos)
                {
                    tablaTratamientos.Rows.Add(new object[] { consultaPaciente.Codigo, t.Codigo, t.Descripcion });
                }

                dsConsultaPaciente.Tables.Add(tablaConsultaPaciente);
                dsConsultaPaciente.Tables.Add(tablaTratamientos);

                return dsConsultaPaciente;
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

        public static void InsertarConsultaTratamiento(int codigoConsultaPaciente, int codigoTratamiento)
        {
            ISession nhSesion = ManejoNHibernate.IniciarSesion();

            try
            {
                ConsultaPaciente consultaPaciente;
                consultaPaciente = CatalogoConsultaPaciente.RecuperarPorCodigo(codigoConsultaPaciente, nhSesion);

                consultaPaciente.Tratamientos.Add(CatalogoTratamiento.RecuperarPorCodigo(codigoTratamiento, nhSesion));

                CatalogoConsultaPaciente.InsertarActualizar(consultaPaciente, nhSesion);
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

        public static DataTable RecuperarConsultaPacientePorMotivoConsultaDiagnosticoYFecha(int codigoMotivoConsulta, int codigoDiagnostico, DateTime fechaDesde, DateTime fechaHasta)
        {
            ISession nhSesion = ManejoNHibernate.IniciarSesion();

            try
            {
                DataTable tablaConsultaPaciente = new DataTable();
                tablaConsultaPaciente.Columns.Add("nombreApellidoPaciente");
                tablaConsultaPaciente.Columns.Add("fecha");
                tablaConsultaPaciente.Columns.Add("comentario");
                tablaConsultaPaciente.Columns.Add("obraSocial");

                List<ConsultaPaciente> listaConsultas = CatalogoConsultaPaciente.RecuperarPorMotivoConsultaDiagnosticoYFecha(codigoMotivoConsulta, codigoDiagnostico, fechaDesde, fechaHasta, nhSesion);

                (from t in listaConsultas select t).Aggregate(tablaConsultaPaciente, (dt, r) => { dt.Rows.Add(r.Paciente.ApellidoNombre, r.Fecha.ToString("dd/MM/yyyy"), r.Comentario, r.Paciente.ObraSocial.Descripcion); return dt; });

                return tablaConsultaPaciente;
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

        #region EstudioConsulta

        public static DataTable RecuperarTodosEstudioConsulta(int codigoConsulta)
        {
            DataTable tablaEstudioConsulta = new DataTable();
            tablaEstudioConsulta.Columns.Add("codigoEstudioConsulta");
            tablaEstudioConsulta.Columns.Add("codigoConsultaPacienteCP");
            tablaEstudioConsulta.Columns.Add("codigoPacienteCP");
            tablaEstudioConsulta.Columns.Add("nombreApellidoPacienteCP");
            tablaEstudioConsulta.Columns.Add("fechaCP");
            tablaEstudioConsulta.Columns.Add("comentarioCP");
            tablaEstudioConsulta.Columns.Add("codigoMotivoConsultaCP");
            tablaEstudioConsulta.Columns.Add("descripcionMotivoConsultaCP");
            tablaEstudioConsulta.Columns.Add("codigoDiagnosticoCP");
            tablaEstudioConsulta.Columns.Add("descripcionDiagnosticoCP");
            tablaEstudioConsulta.Columns.Add("codigoEstudio");
            tablaEstudioConsulta.Columns.Add("descripcionEstudio");
            tablaEstudioConsulta.Columns.Add("resultado");

            ISession nhSesion = ManejoNHibernate.IniciarSesion();

            try
            {
                List<EstudioConsulta> listaEstudiosConsulta = CatalogoEstudioConsulta.RecuperarTodos(nhSesion, codigoConsulta);
                tablaEstudioConsulta = (from p in listaEstudiosConsulta select p).Aggregate(tablaEstudioConsulta, (dt, r) =>
                {
                    dt.Rows.Add(r.Codigo, r.ConsultaPaciente.Codigo, r.ConsultaPaciente.Paciente.Codigo, r.ConsultaPaciente.Paciente.ApellidoNombre, r.ConsultaPaciente.Fecha,
                        r.ConsultaPaciente.Comentario, r.ConsultaPaciente.MotivoConsulta == null ? 0 : r.ConsultaPaciente.MotivoConsulta.Codigo,
                        r.ConsultaPaciente.MotivoConsulta.Descripcion == null ? "Sin motivo consulta" : r.ConsultaPaciente.MotivoConsulta.Descripcion,
                        r.ConsultaPaciente.Diagnostico == null ? 0 : r.ConsultaPaciente.Diagnostico.Codigo, r.ConsultaPaciente.Diagnostico == null ? "Sin diagnóstico" : r.ConsultaPaciente.Diagnostico.Descripcion,
                        r.Estudio == null ? 0 : r.Estudio.Codigo, r.Estudio == null ? "Sin estudio" : r.Estudio.Descripcion, r.Resultado); return dt;
                });
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

            return tablaEstudioConsulta;
        }

        public static void InsertarActualizarEstudioConsulta(int codigoEstudioConsulta, int codigoConsultaPaciente, int codigoEstudio, string resultado)
        {
            ISession nhSesion = ManejoNHibernate.IniciarSesion();

            try
            {
                EstudioConsulta estudioConsulta;

                if (codigoEstudioConsulta == 0)
                {
                    estudioConsulta = new EstudioConsulta();
                }
                else
                {
                    estudioConsulta = CatalogoEstudioConsulta.RecuperarPorCodigo(codigoEstudioConsulta, nhSesion);
                }

                estudioConsulta.ConsultaPaciente = CatalogoConsultaPaciente.RecuperarPorCodigo(codigoConsultaPaciente, nhSesion);
                estudioConsulta.Estudio = CatalogoEstudio.RecuperarPorCodigo(codigoEstudio, nhSesion);
                estudioConsulta.Resultado = resultado;

                CatalogoEstudioConsulta.InsertarActualizar(estudioConsulta, nhSesion);
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

        public static void EliminarEstudioConsulta(int codigoEstudioConsulta)
        {
            EstudioConsulta estudioConsulta;
            ISession nhSesion = ManejoNHibernate.IniciarSesion();

            try
            {
                estudioConsulta = CatalogoEstudioConsulta.RecuperarPorCodigo(codigoEstudioConsulta, nhSesion);
                CatalogoEstudioConsulta.Eliminar(estudioConsulta, nhSesion);
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

        public static DataTable RecuperarEstudioConsultaPorCodigo(int codigoEstudioConsulta)
        {
            DataTable tablaEstudioConsulta = new DataTable();
            tablaEstudioConsulta.Columns.Add("codigoEstudioConsulta");
            tablaEstudioConsulta.Columns.Add("codigoConsultaPacienteCP");
            tablaEstudioConsulta.Columns.Add("codigoPacienteCP");
            tablaEstudioConsulta.Columns.Add("nombreApellidoPacienteCP");
            tablaEstudioConsulta.Columns.Add("fechaCP");
            tablaEstudioConsulta.Columns.Add("comentarioCP");
            tablaEstudioConsulta.Columns.Add("codigoMotivoConsultaCP");
            tablaEstudioConsulta.Columns.Add("descripcionMotivoConsultaCP");
            tablaEstudioConsulta.Columns.Add("codigoDiagnosticoCP");
            tablaEstudioConsulta.Columns.Add("descripcionDiagnosticoCP");
            tablaEstudioConsulta.Columns.Add("codigoEstudio");
            tablaEstudioConsulta.Columns.Add("descripcionEstudio");
            tablaEstudioConsulta.Columns.Add("resultado");


            ISession nhSesion = ManejoNHibernate.IniciarSesion();

            try
            {
                EstudioConsulta estudioConsulta = CatalogoEstudioConsulta.RecuperarPorCodigo(codigoEstudioConsulta, nhSesion);
                tablaEstudioConsulta.Rows.Add(new object[] { estudioConsulta.Codigo, estudioConsulta.ConsultaPaciente.Codigo, estudioConsulta.ConsultaPaciente.Paciente.Codigo, estudioConsulta.ConsultaPaciente.Paciente.ApellidoNombre, estudioConsulta.ConsultaPaciente.Fecha, 
                        estudioConsulta.ConsultaPaciente.Comentario, estudioConsulta.ConsultaPaciente.MotivoConsulta == null ? 0 : estudioConsulta.ConsultaPaciente.MotivoConsulta.Codigo, 
                        estudioConsulta.ConsultaPaciente.MotivoConsulta.Descripcion == null ? "Sin motivo consulta" : estudioConsulta.ConsultaPaciente.MotivoConsulta.Descripcion, 
                        estudioConsulta.ConsultaPaciente.Diagnostico == null ? 0 : estudioConsulta.ConsultaPaciente.Diagnostico.Codigo, estudioConsulta.ConsultaPaciente.Diagnostico == null ? "Sin diagnóstico" : estudioConsulta.ConsultaPaciente.Diagnostico.Descripcion,
                        estudioConsulta.Estudio == null ? 0 : estudioConsulta.Estudio.Codigo, estudioConsulta.Estudio == null ? "Sin estudio" : estudioConsulta.Estudio.Descripcion, estudioConsulta.Resultado });
                return tablaEstudioConsulta;
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

        public static void EliminarEstudioConsultaPorConsulta(int codigoConsulta)
        {
            ISession nhSesion = ManejoNHibernate.IniciarSesion();
            ITransaction trans = nhSesion.BeginTransaction();
            try
            {
                List<EstudioConsulta> listaEstudiosConsulta = CatalogoEstudioConsulta.RecuperarPorCodigoConsulta(codigoConsulta, nhSesion);
                foreach (EstudioConsulta estudioConsulta in listaEstudiosConsulta)
                {
                    CatalogoEstudioConsulta.Eliminar(estudioConsulta, nhSesion);
                }
                trans.Commit();
            }
            catch (Exception ex)
            {
                trans.Rollback();
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
