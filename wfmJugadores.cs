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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WfmEstadisticasFutbolPG3
{
    public partial class wfmJugadores : Form
    {
        public wfmJugadores()
        {
            InitializeComponent();
            datosJugadores();
            datosEquipos();
        }

        public void LimpiarJugadores()
        {
            cmbJugadores.SelectedItem = null;
            cmbJugadorEquipo.SelectedItem = null;
            txtNombreJugador.Text = "";
            txtedadJugador.Text = "";
            txtCumpleJugador.Text = "";
            txtCumpleJugadorV2.Text = "";
            txtLigaJugador.Text = "";
            txtTemporadaJugador.Text = "";
            txtPosicion.Text = "";
            txtJugadorGoles.Text = "";
            txtJugadorAsistencias.Text = "";
            txtMinutosTotalJugador.Text = "";
            txtMinutosCasaJugador.Text = "";
            txtMinutosVisitanteJugador.Text = "";
            txtAmarillasJugador.Text = "";
            txtRojasJugador.Text = "";
            txtPenalesJugador.Text = "";
            txtTirosJugador.Text = "";
            txtPasesCortos.Text = "";
            txtDribleosJugador.Text = "";
            txtPasesCompJugador.Text = "";
        }

        public void datosJugadores()
        {
            //LIMPIAMOS EL COMBOBOX ANTES DE AGREGAR UN NUEVO ELEMENTO
            cmbJugadores.Items.Clear();

            //OBTENEMOS EL PRIMER NODO DE LA LISTA
            clsLSNodo nodoActual = WfrmEstadisticas.gObjMiListas.Primero;

            //RECORREMOS TODOS LOS NODOS DE LA LISTA
            while (nodoActual != null)
            {
                //CONVERTIMOS EL ELEMENTO DEL NODO A CLSJUGADOR
                clsJugador jugador = (clsJugador)nodoActual.Elemento;

                //AGREGAMOS EL NOMBRE DEL JUGADOR AL COMBOBOX
                cmbJugadores.Items.Add(jugador.full_name);

                //NOS PASAMOS AL SIGUIENTE NODO
                nodoActual = nodoActual.Siguiente;
            }
        }

        public void datosEquipos()
        {
            //LIMPIAMOS EL COMBOBOX ANTES DE AGREGAR UN NUEVO ELEMENTO
            cmbJugadorEquipo.Items.Clear();

            //LLAMAMOS AL METODO QUE MUESTRA LO QUE NECESITAMOS
            mostrarTeamNames(WfrmEstadisticas.gObjMiarbolAvl.raizArbol());
        }

        private void mostrarTeamNames(clsABNodo nodo)
        {
            if (nodo != null)
            {
                //RECORREMOS EL SUBARBOL IZQUIERDO
                mostrarTeamNames(nodo.subarbolIzdo());

                //OBTENEMOS EL VALOR DEL NODO CON UN OBJETO DE CLASE EQUIPO
                clsEquipo equipo = (clsEquipo)nodo.valorNodo();

                //AGREGAMOS EL NOMBRE DEL EQUIPOAL COMBOBOX Agregar el nombre del equipo al ComboBox
                cmbJugadorEquipo.Items.Add(equipo.common_name);

                //RECORREMOS EL SUBARBOL DERECHO
                mostrarTeamNames(nodo.subarbolDcho());
            }
        }

        private void btnActualizarJugador_Click(object sender, EventArgs e)
        {
            try
            {
                //VERSION 2.0
                //PRIMERO ELIMINAMOS Y DESPUES SE AGREGA EL NUEVO OBJETO
                string nombreJugadorSeleccionado = cmbJugadores.SelectedItem.ToString();
                clsJugador lMiTareaEliminar = new clsJugador(nombreJugadorSeleccionado, 0, "", "", "", "", "", "", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
                clsJugador lMiTareaInsertar = new clsJugador(txtNombreJugador.Text, Int32.Parse(txtedadJugador.Text), txtCumpleJugador.Text, txtCumpleJugadorV2.Text, txtLigaJugador.Text, txtTemporadaJugador.Text, txtPosicion.Text, cmbJugadorEquipo.SelectedItem.ToString(), Int32.Parse(txtMinutosTotalJugador.Text), Int32.Parse(txtMinutosCasaJugador.Text), Int32.Parse(txtMinutosVisitanteJugador.Text), Int32.Parse(txtJugadorGoles.Text), Int32.Parse(txtJugadorAsistencias.Text), Int32.Parse(txtPenalesJugador.Text), Int32.Parse(txtAmarillasJugador.Text), Int32.Parse(txtRojasJugador.Text), Int32.Parse(txtTirosJugador.Text), Int32.Parse(txtPasesCortos.Text), Int32.Parse(txtDribleosJugador.Text), float.Parse(txtPasesCompJugador.Text));

                WfrmEstadisticas.gObjMiListas.EliminarHash(lMiTareaEliminar);
                WfrmEstadisticas.gObjMiListas.InsertarInicio(lMiTareaInsertar);
                MessageBox.Show("JUGADOR MODIFICADO.", "ATENCION");
                LimpiarJugadores();
                datosJugadores();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR AL MODIFICAR JUGADOR.", "ATENCION");
            }
        }

        private void btnEliminarJugador_Click(object sender, EventArgs e)
        {
            try
            {
                //VERSION 2.0
                //BUSCAMOS EL OBJETO PARA LUEGO ELIMINARLO
                string nombreJugadorSeleccionado = cmbJugadores.SelectedItem.ToString();
                clsJugador lMiTareaEliminar = new clsJugador(nombreJugadorSeleccionado, 22, "629712000", "2000/05/18", "Premier League", "2018/2019", "Defender", "Fulham", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
                WfrmEstadisticas.gObjMiListas.EliminarHash(lMiTareaEliminar);
                MessageBox.Show("JUGADOR ELIMINADO.", "ATENCION");
                LimpiarJugadores();
                datosJugadores();

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR AL ELIMINAR JUGADOR.", "ATENCION");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                //VERSION 2.0
                //BUSCAMOS EL OBJETO CON EL VALOR DEL COMBOBOX Y SI LO ENCUENTRA LO MOSTRAMOS EN LOS TEXTBOX
                string nombreJugadorSeleccionado = cmbJugadores.SelectedItem.ToString();
                clsJugador lMiTareaBuscar = new clsJugador(nombreJugadorSeleccionado, 22, "629712000", "2000/05/18", "Premier League", "2018/2019", "Defender", "Fulham", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);

                clsLSNodo nodoActual = WfrmEstadisticas.gObjMiListas.BuscarListaHash(lMiTareaBuscar);
                if (nodoActual != null)
                {
                    //CONVERTIR EL ELEMENTO DEL NODO A CLASE JUGADOR
                    clsJugador jugador = (clsJugador)nodoActual.Elemento;
                    MessageBox.Show("JUGADOR ENCONTRADO.", "ATENCION");
                    txtNombreJugador.Text = jugador.full_name.ToString();
                    txtedadJugador.Text = jugador.age.ToString();
                    txtCumpleJugador.Text = jugador.birthday.ToString();
                    txtCumpleJugadorV2.Text = jugador.birthday_GMT.ToString();
                    txtLigaJugador.Text = jugador.league.ToString();
                    txtTemporadaJugador.Text = jugador.season.ToString();
                    txtPosicion.Text = jugador.position.ToString();
                    txtJugadorGoles.Text = jugador.goals_overall.ToString();
                    txtJugadorAsistencias.Text = jugador.assists_overall.ToString();
                    string valorDeseado = jugador.current_club.ToString();

                    //COMO UN COMBO SE ALIMENTA DE UNA LISTA Y EL OTO DE UN ARBOLAVL
                    //BUSCAMOS EL INDICE DEL VALOR DESEADO EN EL COMBOBOX
                    int indice = cmbJugadorEquipo.FindStringExact(valorDeseado);

                    //SI SE ENCUENTRA EL VALOR LO SELECCIONAMOS
                    if (indice != -1)
                    {
                        cmbJugadorEquipo.SelectedIndex = indice;
                    }
                    txtMinutosTotalJugador.Text = jugador.minutes_played_overall.ToString();
                    txtMinutosCasaJugador.Text = jugador.minutes_played_home.ToString();
                    txtMinutosVisitanteJugador.Text = jugador.minutes_played_away.ToString();
                    txtAmarillasJugador.Text = jugador.yellow_cards_overall.ToString();
                    txtRojasJugador.Text = jugador.red_cards_overall.ToString();
                    txtPenalesJugador.Text = jugador.penalty_goals.ToString();
                    txtTirosJugador.Text = jugador.shots_total_overall.ToString();
                    txtPasesCortos.Text = jugador.short_passes_total_overall.ToString();
                    txtDribleosJugador.Text = jugador.dribbles_successful_total_overall.ToString();
                    txtPasesCompJugador.Text = jugador.pass_completion_rate_overall.ToString();
                }
                else
                {
                    MessageBox.Show("ERROR AL BUSCAR JUGADOR.", "ATENCION");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR AL BUSCAR JUGADOR.", "ATENCION");
            }
        }

        private void txtNombreJugador_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                e.Handled = true;
            }
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtedadJugador.Focus();
            }
        }

        private void txtedadJugador_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtCumpleJugador.Focus();
            }
        }
    }
}
