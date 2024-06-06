using EstructurasDatosPG3CS.ArbolesBinarios;
using EstructurasDatosPG3CS.ListasSimples;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WfmEstadisticasFutbolPG3;

namespace WfmEstadisticasFutbolPG3
{
    public partial class wfmPartidos : Form
    {
        public wfmPartidos()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");

            InitializeComponent();

            datosEquiposA();
            datosEquiposB();
            datosEquiposLocal();
            datosEquiposVisitantes();
            //CONFIGURAMOS EL TIMEPICKER1
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "MMM dd yyyy - h:mmtt";
            //CONFIGURAMOS EL TIMEPICKER2
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "MMM dd yyyy - h:mmtt";
            //LIMPIAMOS
            LimpiarPartidos();
        }

        public void LimpiarPartidos()
        {
            txtFechaPartido.Text = "";
            dateTimePicker2.Text = DateTime.Now.ToString();
            txtStatusPartido.Text = "";
            txtAficionadosPartidos.Text = "";
            cmbxLocales.SelectedItem = null;
            cmbxVisistantes.SelectedItem = null;
            cmbPartidosA.SelectedItem = null;
            cmbPartidosB.SelectedItem = null;
            txtRefereePartidos.Text = "";
            txtDiaPartido.Text = "";
            txtPreCasaPartidos.Text = "";
            txtPreVisitantePartidos.Text = "";
            txtCasaPPGPartidos.Text = "";
            txtVisitantePPGPartidos.Text = "";
            txtGolesCasaPartidos.Text = "";
            txtGolesVisitantePartidos.Text = "";
            txtGolesTotalesPartidos.Text = "";
            txtEstadioPartido.Text = "";
        }

        public void datosEquiposA()
        {
            //LIMPIAMOS EL COMBO ANTES DE AGREGAR ELEMENTOS
            cmbPartidosA.Items.Clear();

            //LLAMAMOS AL METODO QUE MOSTRARA LA INFORMACION
            mostrarTeamNamesA(WfrmEstadisticas.gObjMiarbolAvl.raizArbol());
        }

        private void mostrarTeamNamesA(clsABNodo nodo)
        {
            if (nodo != null)
            {
                //RECORREMOS EL SUBARBOL IZQUIERDO
                mostrarTeamNamesA(nodo.subarbolIzdo());

                //OBTENEMOS EL VALOR DEL NODO COMO CLASE EQUIPO
                clsEquipo equipo = (clsEquipo)nodo.valorNodo();

                //AGREGAMOS EL NOMBRE AL COMBO
                cmbPartidosA.Items.Add(equipo.common_name);

                //RECORREMOS EL SUBARBOL DERECHO
                mostrarTeamNamesA(nodo.subarbolDcho());
            }
        }

        public void datosEquiposB()
        {
            //LIMPIAMOS EL COMBO ANTES DE AGREGAR ELEMENTOS
            cmbPartidosB.Items.Clear();

            //LLAMAMOS AL METODO QUE MOSTRARA LA INFORMACION
            mostrarTeamNamesB(WfrmEstadisticas.gObjMiarbolAvl.raizArbol());
        }

        private void mostrarTeamNamesB(clsABNodo nodo)
        {
            if (nodo != null)
            {
                //RECORREMOS EL SUBARBOL IZQUIERDO
                mostrarTeamNamesB(nodo.subarbolIzdo());

                //OBTENEMOS EL VALOR DEL NODO COMO CLASE EQUIPO
                clsEquipo equipo = (clsEquipo)nodo.valorNodo();

                //AGREGAMOS EL NOMBRE AL COMBO
                cmbPartidosB.Items.Add(equipo.common_name);

                //RECORREMOS EL SUBARBOL DERECHO
                mostrarTeamNamesB(nodo.subarbolDcho());
            }
        }

        public void datosEquiposLocal()
        {
            //LIMPIAMOS EL COMBO ANTES DE AGREGAR ELEMENTOS
            cmbxLocales.Items.Clear();

            //LLAMAMOS AL METODO QUE MOSTRARA LA INFORMACION
            mostrarTeamNamesLocal(WfrmEstadisticas.gObjMiarbolAvl.raizArbol());
        }

        private void mostrarTeamNamesLocal(clsABNodo nodo)
        {
            if (nodo != null)
            {
                //RECORREMOS EL SUBARBOL IZQUIERDO
                mostrarTeamNamesLocal(nodo.subarbolIzdo());

                //OBTENEMOS EL VALOR DEL NODO COMO CLASE EQUIPO
                clsEquipo equipo = (clsEquipo)nodo.valorNodo();

                //AGREGAMOS EL NOMBRE AL COMBO
                cmbxLocales.Items.Add(equipo.common_name);

                //RECORREMOS EL SUBARBOL DERECHO
                mostrarTeamNamesLocal(nodo.subarbolDcho());
            }
        }

        public void datosEquiposVisitantes()
        {
            //LIMPIAMOS EL COMBO ANTES DE AGREGAR ELEMENTOS
            cmbxVisistantes.Items.Clear();

            //LLAMAMOS AL METODO QUE MOSTRARA LA INFORMACION
            mostrarTeamNamesVisitante(WfrmEstadisticas.gObjMiarbolAvl.raizArbol());
        }

        private void mostrarTeamNamesVisitante(clsABNodo nodo)
        {
            if (nodo != null)
            {
                //RECORREMOS EL SUBARBOL IZQUIERDO
                mostrarTeamNamesVisitante(nodo.subarbolIzdo());

                //OBTENEMOS EL VALOR DEL NODO COMO CLASE EQUIPO
                clsEquipo equipo = (clsEquipo)nodo.valorNodo();

                //AGREGAMOS EL NOMBRE AL COMBO
                cmbxVisistantes.Items.Add(equipo.common_name);

                //RECORREMOS EL SUBARBOL DERECHO
                mostrarTeamNamesVisitante(nodo.subarbolDcho());
            }
        }

        private void btnActualizarPartidos_Click(object sender, EventArgs e)
        {
            try
            {
                //OBTENEMOS EL NOMBRE DEL LOS EQUIPOS A LOCAL Y B VISITANTE
                string nombreEquipoASeleccionado = cmbPartidosA.SelectedItem.ToString();
                string nombreEquipoBSeleccionado = cmbPartidosB.SelectedItem.ToString();

                string Fecha = dateTimePicker1.Value.ToString("MMM dd yyyy - h:mmtt");
                //REEMPLAZAMOS "PM" POR "pm" SI ES NECESARIO
                if (Fecha.Contains("PM"))
                {
                    Fecha = Fecha.Replace("PM", "pm");
                }
                //REEMPLAZAMOS "AM" POR "am" SI ES NECESARIO
                else if (Fecha.Contains("AM"))
                {
                    Fecha = Fecha.Replace("AM", "am");
                }

                string cadenaConcatenada = string.Concat(Fecha, nombreEquipoASeleccionado, nombreEquipoBSeleccionado);
                if (string.IsNullOrWhiteSpace(nombreEquipoASeleccionado) || string.IsNullOrWhiteSpace(nombreEquipoBSeleccionado))
                {
                    MessageBox.Show("DEBE INGRESAR EL EQUIPO LOCAL Y EL EQUIPO VISITANTE.", "ATENCION");
                    return;
                }

                //CALCULAMOS LA CLAVE HASH
                int clave = WfrmEstadisticas.SumarAscci(cadenaConcatenada);

                //CREAMOS UN OBJETO PARTIDO
                clsPartido lMiTareaEliminar = new clsPartido(0, Fecha, "", 0, nombreEquipoASeleccionado, nombreEquipoBSeleccionado, "", 0, 0, 0, 0, 0, 0, 0, 0, "");
                //LLAMAMOS AL METODO ELIMINAR2 DE LA CLASE TABLASHASH GENERICAS
                WfrmEstadisticas.gObjTablaHash.Eliminar2(lMiTareaEliminar, clave);

                //PARA INSERTAR
                //OBTENEMOS LOS NOMBRES DEL EQUIPO LOCAL Y VISITANTE
                string nombreEquipoLocalSeleccionado = cmbxLocales.SelectedItem.ToString();
                string nombreEquipoVisitanteSeleccionado = cmbxVisistantes.SelectedItem.ToString();

                string Fecha2 = dateTimePicker2.Value.ToString("MMM dd yyyy - h:mmtt");
                //REEMPLAZAMOS "PM" POR "pm" SI ES NECESARIO
                if (Fecha2.Contains("PM"))
                {
                    Fecha2 = Fecha2.Replace("PM", "pm");
                }
                //REEMPLAZAMOS "AM" POR "am" SI ES NECESARIO
                else if (Fecha2.Contains("AM"))
                {
                    Fecha2 = Fecha2.Replace("AM", "am");
                }

                string cadenaConcatenada2 = string.Concat(Fecha2, nombreEquipoLocalSeleccionado, nombreEquipoVisitanteSeleccionado);
                if (string.IsNullOrWhiteSpace(nombreEquipoLocalSeleccionado) || string.IsNullOrWhiteSpace(nombreEquipoVisitanteSeleccionado))
                {
                    MessageBox.Show("DEBE INGRESAR EL EQUIPO LOCAL Y EL EQUIPO VISITANTE.", "ATENCION");
                    return;
                }

                //CALCULAMOS LA CLAVE
                int clave2 = WfrmEstadisticas.SumarAscci(cadenaConcatenada2);

                //CREAMOS UN OBJETO PARTIDO
                clsPartido lMiTareaInsertar = new clsPartido(Int32.Parse(txtFechaPartido.Text), Fecha, txtStatusPartido.Text.Trim(), Int32.Parse(txtAficionadosPartidos.Text), nombreEquipoLocalSeleccionado, nombreEquipoVisitanteSeleccionado, txtRefereePartidos.Text, Int32.Parse(txtDiaPartido.Text), Double.Parse(txtPreCasaPartidos.Text), Double.Parse(txtPreVisitantePartidos.Text), Double.Parse(txtCasaPPGPartidos.Text), Double.Parse(txtVisitantePPGPartidos.Text), Int32.Parse(txtGolesCasaPartidos.Text), Int32.Parse(txtGolesVisitantePartidos.Text), Int32.Parse(txtGolesTotalesPartidos.Text), "");

                //LLAMAMOS AL METODO INSERTAR2 DE LA CLASE TABLASHASH GENERICAS
                WfrmEstadisticas.gObjTablaHash.Insertar2(lMiTareaInsertar, clave2);

                MessageBox.Show("PARTIDO MODIFICADO.", "ATENCION");

                //LIMPIAMOS LOS CAMPOS
                LimpiarPartidos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR AL MODIFICAR PARTIDO: " + ex.Message, "ATENCION");
            }
        }

        private void btnEliminarPartidos_Click(object sender, EventArgs e)
        {
            try
            {
                //OBTENEMOS EL NOMBRE DEL LOS EQUIPOS A LOCAL Y B VISITANTE
                string nombreEquipoASeleccionado = cmbPartidosA.SelectedItem.ToString();
                string nombreEquipoBSeleccionado = cmbPartidosB.SelectedItem.ToString();

                string Fecha = dateTimePicker1.Value.ToString("MMM dd yyyy - h:mmtt");
                //REEMPLAZAMOS "PM" POR "pm" SI ES NECESARIO
                if (Fecha.Contains("PM"))
                {
                    Fecha = Fecha.Replace("PM", "pm");
                }
                //REEMPLAZAMOS "AM" POR "am" SI ES NECESARIO
                else if (Fecha.Contains("AM"))
                {
                    Fecha = Fecha.Replace("AM", "am");
                }

                string cadenaConcatenada = string.Concat(Fecha, nombreEquipoASeleccionado, nombreEquipoBSeleccionado);
                if (string.IsNullOrWhiteSpace(nombreEquipoASeleccionado) || string.IsNullOrWhiteSpace(nombreEquipoBSeleccionado))
                {
                    MessageBox.Show("DEBE INGRESAR EL EQUIPO LOCAL Y EL EQUIPO VISITANTE.", "ATENCION");
                    return;
                }

                //CALCULAMOS LA CLAVE
                int clave = WfrmEstadisticas.SumarAscci(cadenaConcatenada);

                //CREAMOS UN OBJETO PARTIDO
                clsPartido lMiTareaEliminar = new clsPartido(0, Fecha, "", 0, nombreEquipoASeleccionado, nombreEquipoBSeleccionado, "", 0, 0, 0, 0, 0, 0, 0, 0, "");
                //LLAMAMOS AL METODO ELIMINAR2 DE LA CLASE TABLASHASH GENERICAS
                WfrmEstadisticas.gObjTablaHash.Eliminar2(lMiTareaEliminar, clave);

                MessageBox.Show("PARTIDO ELIMINADO.", "ATENCION");

                //LIMPIAMOS LOS CAMPOS
                LimpiarPartidos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR AL ELIMINAR PARTIDO: " + ex.Message, "ATENCION");
            }
        }

        private void btnBuscarPartidos_Click(object sender, EventArgs e)
        {
            try
            {
                //OBTENEMOS EL NOMBRE DEL LOS EQUIPOS A LOCAL Y B VISITANTE
                string nombreEquipoASeleccionado = cmbPartidosA.SelectedItem.ToString();
                string nombreEquipoBSeleccionado = cmbPartidosB.SelectedItem.ToString();

                string Fecha = dateTimePicker1.Value.ToString("MMM dd yyyy - h:mmtt");
                //REEMPLAZAMOS "PM" POR "pm" SI ES NECESARIO
                if (Fecha.Contains("PM"))
                {
                    Fecha = Fecha.Replace("PM", "pm");
                }
                //REEMPLAZAMOS "AM" POR "am" SI ES NECESARIO
                else if (Fecha.Contains("AM"))
                {
                    Fecha = Fecha.Replace("AM", "am");
                }

                string cadenaConcatenada = string.Concat(Fecha, nombreEquipoASeleccionado, nombreEquipoBSeleccionado);
                if (string.IsNullOrWhiteSpace(nombreEquipoASeleccionado) || string.IsNullOrWhiteSpace(nombreEquipoBSeleccionado))
                {
                    MessageBox.Show("DEBE INGRESAR EL EQUIPO LOCAL Y EL EQUIPO VISITANTE.", "ATENCION");
                    return;
                }

                //CALCULAMOS LA CLAVE
                int clave = WfrmEstadisticas.SumarAscci(cadenaConcatenada);

                //CREAMOS UN OBJETO PARTIDO
                clsPartido lMiTareaBuscar = new clsPartido(0, Fecha, "", 0, nombreEquipoASeleccionado, nombreEquipoBSeleccionado, "", 0, 0, 0, 0, 0, 0, 0, 0, "");
                //LLAMAMOS AL METODO CONSULTAR2 DE LA CLASE TABLASHASH GENERICAS
                object resultado = WfrmEstadisticas.gObjTablaHash.Consultar2(lMiTareaBuscar, clave);// as clsLSLista;

                if (resultado != null)
                {
                    MessageBox.Show("PARTIDO ENCONTRADO.", "ATENCION");
                    clsPartido partidoEncontrado = (clsPartido)resultado;
                    txtFechaPartido.Text = partidoEncontrado.timestamp.ToString();
                    dateTimePicker2.Value = dateTimePicker1.Value;
                    txtStatusPartido.Text = partidoEncontrado.status.ToString();
                    txtAficionadosPartidos.Text = partidoEncontrado.attendance.ToString();
                    cmbxLocales.SelectedItem = cmbPartidosA.SelectedItem;
                    cmbxVisistantes.SelectedItem = cmbPartidosB.SelectedItem;
                    txtRefereePartidos.Text = partidoEncontrado.referee.ToString();
                    txtDiaPartido.Text = partidoEncontrado.GameWeek.ToString();
                    txtPreCasaPartidos.Text = partidoEncontrado.PreMatchPPGHome.ToString();
                    txtPreVisitantePartidos.Text = partidoEncontrado.PreMatchPPGAway.ToString();
                    txtCasaPPGPartidos.Text = partidoEncontrado.home_ppg.ToString();
                    txtVisitantePPGPartidos.Text = partidoEncontrado.away_ppg.ToString();
                    txtGolesCasaPartidos.Text = partidoEncontrado.home_team_goal_count.ToString();
                    txtGolesVisitantePartidos.Text = partidoEncontrado.away_team_goal_count.ToString();
                    txtGolesTotalesPartidos.Text = partidoEncontrado.total_goal_count.ToString();
                    //txtEstadioPartido.Text = partidoEncontrado.stadium_name.ToString();
                }
                else
                {
                    MessageBox.Show("PARTIDO NO ENCONTRADO.", "ATENCION");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("PARTIDO NO ENCONTRADO: " + ex.Message, "ATENCION");
            }
        }

        private void txtAficionadosPartidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                cmbxLocales.Focus();
            }
        }

        private void txtGolesCasaPartidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtGolesVisitantePartidos.Focus();
            }
        }

        private void txtGolesVisitantePartidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtGolesTotalesPartidos.Focus();
            }
        }
    }
}


