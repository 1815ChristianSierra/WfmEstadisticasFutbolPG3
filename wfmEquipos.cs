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
    public partial class wfmEquipos : Form
    {
        public wfmEquipos()
        {
            InitializeComponent();
            datosEquipos();
        }

        public void datosEquipos()
        {
            //LIMPIAMOS EL COMBO ANTES DE AGREGAR UN ELEMENTO
            cmbEquipos.Items.Clear();

            //LLAMAMOS AL METODO QUE MOSTRARA LA INFORMACION
            mostrarTeamNames(WfrmEstadisticas.gObjMiarbolAvl.raizArbol());
        }

        private void mostrarTeamNames(clsABNodo nodo)
        {
            if (nodo != null)
            {
                //RECORREMOS EL SUBARBOL IZQUIERDO
                mostrarTeamNames(nodo.subarbolIzdo());

                //OBTENEMOS EL VALOR DEL NODO COMO OBJETO EQUIPO
                clsEquipo equipo = (clsEquipo)nodo.valorNodo();

                //AGREGAMOS EL NOMBRE DEL EQUIPO AL COMBO
                cmbEquipos.Items.Add(equipo.team_name);

                //RECORREMOS EL SUBARBOL DERECHO
                mostrarTeamNames(nodo.subarbolDcho());
            }
        }

        public void limpiarEquipos() 
        {
            cmbEquipos.SelectedItem = null;
            txtEquipoNombre.Text = "";
            txtEquipoNombreComun.Text = "";
            txtEquipoTemporada.Text = "";
            txtEquipoCiudad.Text = "";
            txtEquipoJuegos.Text = "";
            txtEquipoCasa.Text = "";
            txtEquipoVisitante.Text = "";
            txtEquipoSuspendido.Text = "";
            txtEquipoVictorias.Text = "";
            txtEquipoEmpates.Text = "";
            txtEquipoDerrotas.Text = "";
            txtEquipoGoles.Text = "";
            txtEquipoEsquina.Text = "";
            txtEquipoTarjetas.Text = "";
            txtEquipoPosicion.Text = "";
            txtEquipoPosesion.Text = "";
            txtEquipoFaltas.Text = "";
            txtEquipoGolesPartido.Text = "";
            txtEquipoPtgVictorias.Text = "";
        }

        private void btnActualizarEquipo_Click(object sender, EventArgs e)
        {
            try
            {
                //OBTENEMOS EL NOMBRE DEL EQUIPO
                string nombreEquipoSeleccionado = cmbEquipos.SelectedItem.ToString();

                //CREAMOS UN OBJETO EQUIPO
                clsEquipo lMiEquipoBuscarAVL = new clsEquipo(nombreEquipoSeleccionado, "", "", "", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);

                //ELIMINAMOS EL EQUIPO DEL ARBOLAVL
                WfrmEstadisticas.gObjMiarbolAvl.eliminar(lMiEquipoBuscarAVL);

                //CREAMOS OTRO OBJETO EQUIPO CON LOS VALORES DE LOS TXT
                clsEquipo lMiEquipoInsertarAVL = new clsEquipo(txtEquipoNombre.Text.Trim(), txtEquipoNombreComun.Text.Trim(), txtEquipoTemporada.Text.Trim(), txtEquipoCiudad.Text.Trim(), Int32.Parse(txtEquipoJuegos.Text), Int32.Parse(txtEquipoCasa.Text), Int32.Parse(txtEquipoVisitante.Text), Int32.Parse(txtEquipoSuspendido.Text), Int32.Parse(txtEquipoVictorias.Text), Int32.Parse(txtEquipoEmpates.Text), Int32.Parse(txtEquipoDerrotas.Text), Int32.Parse(txtEquipoGoles.Text), Int32.Parse(txtEquipoEsquina.Text), Int32.Parse(txtEquipoTarjetas.Text), Int32.Parse(txtEquipoPosicion.Text), float.Parse(txtEquipoPosesion.Text), Int32.Parse(txtEquipoFaltas.Text), float.Parse(txtEquipoGolesPartido.Text), float.Parse(txtEquipoPtgVictorias.Text));
                
                //LO INSERTAMOS EN EL ARBOLAVL
                WfrmEstadisticas.gObjMiarbolAvl.insertar(lMiEquipoInsertarAVL);

                MessageBox.Show("EQUIPO MODIFICADO.", "ATENCION");

                //LIMPIAMOS EL COMBO
                limpiarEquipos();

                //LLENAMOS EL COMBO CON LA INFO ACTUALIZADA
                datosEquipos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR AL MODIFICAR EQUIPO.", "ATENCION");
            }
        }

        private void btnEliminarEquipo_Click(object sender, EventArgs e)
        {
            try
            {
                //OBTENEMOS EL NOMBRE DEL EQUIPO
                string nombreEquipoSeleccionado = cmbEquipos.SelectedItem.ToString();

                //CREAMOS UN OBJETO EQUIPO
                clsEquipo lMiEquipoBuscarAVL = new clsEquipo(nombreEquipoSeleccionado, "", "", "", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);

                //ELIMINAMOS EL EQUIPO DEL ARBOLAVL
                WfrmEstadisticas.gObjMiarbolAvl.eliminar(lMiEquipoBuscarAVL);
                MessageBox.Show("EQUIPO ELIMINADO.", "ATENCION");

                //LIMPIAMOS EL COMBO
                limpiarEquipos();

                //LLENAMOS EL COMBO CON LA INFO ACTUALIZADA
                datosEquipos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR AL ELIMINAR EQUIPO.", "ATENCION");
            }

        }

        private void btnBuscarEquipo_Click(object sender, EventArgs e)
        {
            try
            {
                //OBTENEMOS EL NOMBRE DEL EQUIPO
                string nombreEquipoSeleccionado = cmbEquipos.SelectedItem.ToString();
                //CREAMOS UN OBJETO EQUIPO
                clsEquipo lMiEquipoBuscarAVL = new clsEquipo(nombreEquipoSeleccionado, "", "", "", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);
                //BUSCAMOS EL EQUIPO EN EL ARBOLAVL
                lMiEquipoBuscarAVL = (clsEquipo)WfrmEstadisticas.gObjMiarbolAvl.buscarIterativo(lMiEquipoBuscarAVL).valorNodo();
                MessageBox.Show("EQUIPO ENCONTRADO.", "ATENCION");
                txtEquipoNombre.Text = lMiEquipoBuscarAVL.team_name.ToString();
                txtEquipoNombreComun.Text = lMiEquipoBuscarAVL.common_name.ToString();
                txtEquipoTemporada.Text = lMiEquipoBuscarAVL.season.ToString();
                txtEquipoCiudad.Text = lMiEquipoBuscarAVL.country.ToString();
                txtEquipoJuegos.Text = lMiEquipoBuscarAVL.matches_played.ToString();
                txtEquipoCasa.Text = lMiEquipoBuscarAVL.matches_played_home.ToString();
                txtEquipoVisitante.Text = lMiEquipoBuscarAVL.matches_played_away.ToString();
                txtEquipoSuspendido.Text = lMiEquipoBuscarAVL.suspended_matches.ToString();
                txtEquipoVictorias.Text = lMiEquipoBuscarAVL.wins.ToString();
                txtEquipoEmpates.Text = lMiEquipoBuscarAVL.draws.ToString();
                txtEquipoDerrotas.Text = lMiEquipoBuscarAVL.losses.ToString();
                txtEquipoGoles.Text = lMiEquipoBuscarAVL.total_goal_count.ToString();
                txtEquipoEsquina.Text = lMiEquipoBuscarAVL.corners_total.ToString();
                txtEquipoTarjetas.Text = lMiEquipoBuscarAVL.cards_total.ToString();
                txtEquipoPosicion.Text = lMiEquipoBuscarAVL.league_position.ToString();
                txtEquipoPosesion.Text = lMiEquipoBuscarAVL.average_possession.ToString();
                txtEquipoFaltas.Text = lMiEquipoBuscarAVL.fouls.ToString();
                txtEquipoGolesPartido.Text = lMiEquipoBuscarAVL.goals_scored_per_match.ToString();
                txtEquipoPtgVictorias.Text = lMiEquipoBuscarAVL.win_percentage.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR AL BUSCAR EQUIPO.", "ATENCION");
            }
        }
    }
}
