using EstructurasDatosPG3CS.ArbolesBinarios;
using EstructurasDatosPG3CS.ListasSimples;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WfmEstadisticasFutbolPG3;

namespace WfmEstadisticasFutbolPG3
{
    public partial class wfmTorneos : Form
    {
        public static clsLSLista gObjMiListaTorneos;
        public wfmTorneos()
        {
            InitializeComponent();
            gObjMiListaTorneos = new clsLSLista();
            datosEquiposTorneo();
            datosTorneoEquipo();
            datosTorneoEquipo();
            datosVerEquiposxTorneo();
        }

        public void LimpiarTorneos()
        {
            cmbxTorneos.SelectedItem = null;
            txtNombreTorneo.Text = "";
            txtTemporadaTorneo.Text = "";
            cmbxMostrarTorneos.SelectedItem = null;
        }

        public void datosTorneoEquipo()
        {
            //LIMPIAMOS EL COMBO ANTES DE AGREGAR ELEMENTOS
            cmbxMostrarTorneos.Items.Clear();

            //OBTENEMOS EL PRIMER NODO DE LA LISTA
            clsLSNodo nodoActual = gObjMiListaTorneos.Primero;

            //RECORREMOS TODOS LOS NODOS DE LA LISTA
            while (nodoActual != null)
            {
                //CONVERTIMOS EL ELEMENTO A CLASE JUGADOR
                clsTorneo torneo = (clsTorneo)nodoActual.Elemento;

                //AGREGAMOS EL NOMBRE DEL JUGADOR AL COMBO
                cmbxMostrarTorneos.Items.Add(torneo.Nombre);

                //PASAMOS AL SIGUIENTE NODO
                nodoActual = nodoActual.Siguiente;
            }
        }

        public void datosTorneo()
        {
            //LIMPIAMOS EL COMBO ANTES DE AGREGAR NUEVO ELEMENTOS
            cmbxTorneos.Items.Clear();

            //OBTENEMOS EL PRIMER NODO DE LA LISTA
            clsLSNodo nodoActual = gObjMiListaTorneos.Primero;

            //RECORREMOS TODOS LOS NODOS DE LA LISTA
            while (nodoActual != null)
            {
                //CONVERTIMOS EL ELEMENTO DEL NODO A CLASE JUGADOR
                clsTorneo torneo = (clsTorneo)nodoActual.Elemento;

                //AGREGAMOS EL NOMBRE DEL JUGADOR AL COMBO
                cmbxTorneos.Items.Add(torneo.Nombre);

                //PASAMOS AL SIGUIENTE NODO
                nodoActual = nodoActual.Siguiente;
            }
        }

        public void datosVerEquiposxTorneo()
        {
            //LIMPIAMOS EL COMBO ANTES DE AGREGAR NUEVO ELEMENTOS
            cmbxVerEquiposTorneo.Items.Clear();

            //OBTENEMOS EL PRIMER NODO DE LA LISTA
            clsLSNodo nodoActual = gObjMiListaTorneos.Primero;

            //RECORREMOS TODOS LOS NODOS DE LA LISTA
            while (nodoActual != null)
            {
                //CONVERTIMOS EL ELEMENTO DEL NODO A CLASE JUGADOR
                clsTorneo torneo = (clsTorneo)nodoActual.Elemento;

                //AGREGAMOS EL NOMBRE DEL JUGADOR AL COMBO
                cmbxVerEquiposTorneo.Items.Add(torneo.Nombre);

                //PASAMOS AL SIGUIENTE NODO
                nodoActual = nodoActual.Siguiente;
            }
        }

        public void datosEquiposTorneo()
        {
            //LIMPIAMOS EL COMBO ANTES DE AGREGAR NUEVO ELEMENTOS
            cmbxMostrarEquipos.Items.Clear();

            //LLAMMOS AL METODO QUE MUESTRA LA INFORMACION
            mostrarTeamNames(WfrmEstadisticas.gObjMiarbolAvl.raizArbol());
        }

        private void mostrarTeamNames(clsABNodo nodo)
        {
            if (nodo != null)
            {
                //RECORREMOS EL SUBARBOL IZQUIERDO
                mostrarTeamNames(nodo.subarbolIzdo());

                //OBTENEMOS EL VALOR DEL NODO COMO UN OBJETO DE CLASE EQUIPO
                clsEquipo equipo = (clsEquipo)nodo.valorNodo();

                //AGREGAMOS EL NOMBRE DEL EQUIPO AL COMBO
                cmbxMostrarEquipos.Items.Add(equipo.team_name);

                //RECORREMOS EL SUBARBOL DERECHO
                mostrarTeamNames(nodo.subarbolDcho());
            }
        }

        private void btnCrearTorneo_Click(object sender, EventArgs e)
        {
            try
            {
                int clave = WfrmEstadisticas.SumarAscci(txtNombreTorneo.Text);

                //CREAMOS UN BJETO DE CLASE EQUIPO CON EL NOMBRE DEL TORNEO SELECCIONADO
                clsTorneo ObjTorneo = new clsTorneo(clave, txtNombreTorneo.Text, txtTemporadaTorneo.Text);
                gObjMiListaTorneos.InsertarInicio(ObjTorneo);
                MessageBox.Show("TORNEO CREADO.", "ATENCION");
                LimpiarTorneos();
                datosTorneo();
                datosTorneoEquipo();
                datosVerEquiposxTorneo();

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR AL CREAR EL TORNEO.", "ATENCION");
            }
        }

        private void btnModificarTorneo_Click(object sender, EventArgs e)
        {
            try
            {
                //PRIMERO ELIMINAMOS Y DESPUES AGREGAMOS EL NUEVO ELEMENTO
                int clave = WfrmEstadisticas.SumarAscci(txtNombreTorneo.Text);
                string nombreTorneoSeleccionado = cmbxTorneos.SelectedItem.ToString();

                clsTorneo lMiTareaEliminar = new clsTorneo(0, nombreTorneoSeleccionado, "");
                clsTorneo lMiTareaInsertar = new clsTorneo(clave, txtNombreTorneo.Text, txtTemporadaTorneo.Text);

                gObjMiListaTorneos.EliminarHash(lMiTareaEliminar);
                gObjMiListaTorneos.InsertarInicio(lMiTareaInsertar);
                MessageBox.Show("JUGADOR MODIFICADO.", "ATENCION");
                LimpiarTorneos();
                datosTorneo();
                datosTorneoEquipo();
                datosVerEquiposxTorneo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR AL MODIFICAR JUGADOR.", "ATENCION");
            }
        }

        private void btnEliminarTorneo_Click(object sender, EventArgs e)
        {
            try
            {
                //SI ENCONTRAMOS EL OBJETO LO ELIMINAMOS
                int clave = WfrmEstadisticas.SumarAscci(txtNombreTorneo.Text);
                string nombreTorneoSeleccionado = cmbxTorneos.SelectedItem.ToString();

                clsTorneo lMiTareaEliminar = new clsTorneo(0, nombreTorneoSeleccionado, "");

                gObjMiListaTorneos.EliminarHash(lMiTareaEliminar);

                MessageBox.Show("TORNEO ELIMINADO.", "ATENCION");
                LimpiarTorneos();
                datosTorneo();
                datosTorneoEquipo();
                datosVerEquiposxTorneo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR AL ELIMINAR TORNEO.", "ATENCION");
            }
        }

        private void btnBuscarTorneo_Click(object sender, EventArgs e)
        {
            try
            {
                //BUSCAMOS EL TORNEO
                string nombreTorneoSeleccionado = cmbxTorneos.SelectedItem.ToString();
                clsTorneo lMiTareaBuscar = new clsTorneo(0, nombreTorneoSeleccionado, "");
                clsLSNodo nodoActual = gObjMiListaTorneos.BuscarListaHash(lMiTareaBuscar);

                MessageBox.Show("TORNEO ENCONTRADO.", "ATENCION");
                //CONVERTIMOS EL ELEMENTO DEL NODO A CLASE TORNEO
                clsTorneo torneo = (clsTorneo)nodoActual.Elemento;
                txtNombreTorneo.Text = torneo.Nombre.ToString();
                txtTemporadaTorneo.Text = torneo.Temporada.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR AL BUSCAR TORNEO.", "ATENCION");
            }
        }

        private void btnAgregarEquipoTorneo_Click(object sender, EventArgs e)
        {
            try
            {
                //AGREGAMOS EQUIPOS AL TORNEOS
                string nombreTorneoSeleccionado = cmbxMostrarTorneos.SelectedItem.ToString();
                int clave = WfrmEstadisticas.SumarAscci(nombreTorneoSeleccionado);

                string nombreEquipoTorneoSeleccionado = cmbxMostrarEquipos.SelectedItem.ToString();
                clsEquipo lMiEquipoBuscarAVL = new clsEquipo(nombreEquipoTorneoSeleccionado, "", "", "", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
                lMiEquipoBuscarAVL = (clsEquipo)WfrmEstadisticas.gObjMiarbolAvl.buscarIterativo(lMiEquipoBuscarAVL).valorNodo();
                WfrmEstadisticas.gObjTablaHash.InsertarAVL(lMiEquipoBuscarAVL, clave);
                MessageBox.Show("EQUIPO AGREGADO AL TORNEO.", "ATENCION");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR AL AGREGAR EQUIPO AL TORNEO.", "ATENCION");
            }
        }

        private void btnEliminarEquipoTorneo_Click(object sender, EventArgs e)
        {
            try
            {
                //ELIMINAMOS UN EQUIPO DEL TORNEO
                string nombreTorneoSeleccionado = cmbxMostrarTorneos.SelectedItem.ToString();
                int clave = WfrmEstadisticas.SumarAscci(nombreTorneoSeleccionado);

                string nombreEquipoTorneoSeleccionado = cmbxMostrarEquipos.SelectedItem.ToString();
                clsEquipo lMiEquipoEliminarAVL = new clsEquipo(nombreEquipoTorneoSeleccionado, "", "", "", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
                var resultado = WfrmEstadisticas.gObjTablaHash.EliminarAVL(lMiEquipoEliminarAVL, clave);
                if (resultado == null)
                {
                    MessageBox.Show("EQUIPO ELIMINADO DEL TORNEO.", "ATENCION");
                }
                else
                {
                    MessageBox.Show("ERROR AL ELIMINAR EQUIPO AL TORNEO.", "ATENCION");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR AL ELIMINAR EQUIPO AL TORNEO.", "ATENCION");
            }
        }

        private void btnVerEquipos_Click(object sender, EventArgs e)
        {
            try
            {
                //OBTENEMOS EL NOMBRE DEL TORNEO SELECCIONADO
                string nombreTorneoSeleccionado = cmbxVerEquiposTorneo.SelectedItem.ToString();
                int clave = WfrmEstadisticas.SumarAscci(nombreTorneoSeleccionado);

                //CONSULTAMOS Y BUSCAMOS LOS EQUIPOS QUE ESTAN ASOCIADOS AL TORNEO SELECCIONADO
                string resultadoAVL = WfrmEstadisticas.gObjTablaHash.ConsultarAVL(clave);

                //LIMPIAMOS EL LSTBOX ANTES DE MOSTRAR LOS DATOS
                lstbxInformacion.Items.Clear();

                if (!string.IsNullOrEmpty(resultadoAVL))
                {
                    //SPLITEAMOS LA CADENA POR EL SEPARADOR
                    string[] equipos = resultadoAVL.Split(')');

                    //AGREGAMOS CADA EQUIPO AL LISTBOX EN UNA LINEA DIFERENTE
                    foreach (string equipo in equipos)
                    {
                        //REEMPLAZAMOS EL PARENTESIS DEL INICIO POR VACIO Y LO AGREGAMOS AL LISTBOX
                        string nombreEquipo = equipo.Replace("(", "");
                        lstbxInformacion.Items.Add(nombreEquipo);
                    }

                    MessageBox.Show("SE ENCONTRARON EQUIPOS EN EL TORNEO.", "ATENCION");
                }
                else
                {
                    MessageBox.Show("NO SE ENCONTRO EQUIPOS PARA EL TORNEO SELECCIONADO.", "ATENCION");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR AL MOSTRAR EQUIPOS.", "ATENCION");
            }
        }

        private void txtTemporadaTorneo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && e.KeyChar != '/' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnCrearTorneo.Focus();
            }
        }

        private void txtNombreTorneo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && !(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                e.Handled = true;
            }
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtTemporadaTorneo.Focus();
            }
        }
    }
}
