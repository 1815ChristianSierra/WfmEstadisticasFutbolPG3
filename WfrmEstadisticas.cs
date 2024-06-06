using EstructurasDatosPG3CS.ArbolesBinarios;
using EstructurasDatosPG3CS.ListasSimples;
using EstructurasDatosPG3CS.TablasHash;
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

namespace WfmEstadisticasFutbolPG3
{
    public partial class WfrmEstadisticas : Form
    {
        //INSTANCIAS DE OBJETOS
        public static clsArbolAVL gObjMiarbolAvl;
        public static clsABNodo gObjMiNodoAvl;
        public static clsLSLista gObjMiListas;
        public static clsLSLista gObjMiListasEquipos;
        clsLSLista gObjMiListasPartidos;
        clsJugador gMiJugador;
        clsLSNodo nodoJugador;
        public static clsTablasHashGenericas gObjTablaHash;

        public WfrmEstadisticas()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");

            InitializeComponent();
            gObjMiarbolAvl = new clsArbolAVL();
            gObjMiListas = new clsLSLista();
            gObjMiListasEquipos = new clsLSLista();
            gObjMiListasPartidos = new clsLSLista();
            gObjTablaHash = new clsTablasHashGenericas();
            CargarCSV();// lISTAS ENLAZADAS
            CargarEquipos();// ARBOLES AVL
            CargarPartidos();// TABLA HASH DIRECCIONAMIENTO ENLAZADO (LISTAS)
        }

        //FUNCION PARA OBTENER EL VALOR DE UN STRING
        public static int SumarAscci(string palabra)
        {
            int suma = 0;
            foreach (char letra in palabra)
            {
                suma += (int)letra;
            }
            return suma;
        }

        //LISTA DONDE SE GUARDARAN LOS JUGADORES
        public void CargarCSV()
        {
            int lIntContador = 0;
            string lStrLinea;

            System.IO.StreamReader fArchivo = new System.IO.StreamReader("PremierLeague18_19_Jugadores.csv");

            Char lChrDelimitador = ',';
            while ((lStrLinea = fArchivo.ReadLine()) != null)
            {
                if (lIntContador > 0)
                {
                    String[] SubCadena = lStrLinea.Split(lChrDelimitador);

                    //VALIDAMOS LOS DATOS YA QUE ALGUNOS QUE SON ENTEROS TRAEN N/A
                    int tirosPorteria = SubCadena[91] == "N/A" ? 0 : Convert.ToInt32(SubCadena[91]);
                    int pasesCortos = SubCadena[120] == "N/A" ? 0 : Convert.ToInt32(SubCadena[120]);
                    int dribleos = SubCadena[128] == "N/A" ? 0 : Convert.ToInt32(SubCadena[128]);
                    float pasesCompletados = SubCadena[155] == "N/A" ? 0 : Convert.ToSingle(SubCadena[155]);

                    clsJugador ObjJugador = new clsJugador(
                        SubCadena[0],//NOMBRE
                        Convert.ToInt32(SubCadena[1]),//EDAD
                        SubCadena[2],//CUMPLE
                        SubCadena[3],//CUMPLE2
                        SubCadena[4],//LIGA
                        SubCadena[5],//TEMP
                        SubCadena[6],//POS
                        SubCadena[7],//CLUB
                        Convert.ToInt32(SubCadena[8]),//MIN JUGADOS
                        Convert.ToInt32(SubCadena[9]),//MIN CASA
                        Convert.ToInt32(SubCadena[10]),//MIN VIS
                        Convert.ToInt32(SubCadena[15]),//GOLES MARCADOS
                        Convert.ToInt32(SubCadena[18]),//TOTAL ASISTENCIAS
                        Convert.ToInt32(SubCadena[21]),//TOTAL PENALES
                        Convert.ToInt32(SubCadena[29]),//TARJETAS AMARILLAS
                        Convert.ToInt32(SubCadena[30]),//TARJETAS ROJAS
                        tirosPorteria,//TIROS A PORTERIA N/A
                        pasesCortos,//PASES CORTOS N/A
                        dribleos,//DRIBLEOS N/A
                        pasesCompletados);//PASES COMPLETADOS N/A
                    gObjMiListas.InsertarInicio(ObjJugador);
                    //gObjMiarbolAvl.insertar(ObjJugador);
                    lIntContador++;
                }
                else
                {
                    lIntContador++;
                }
            }
            fArchivo.Close();
        }

        //ARBOLAVL DONDE SE GUARDARAN LOS EQUIPOS
        public void CargarEquipos()
        {
            int lIntContador = 0;
            string lStrLinea;

            System.IO.StreamReader fArchivo = new System.IO.StreamReader("PremierLeague18_19_Equipos.csv");

            Char lChrDelimitador = ',';
            while ((lStrLinea = fArchivo.ReadLine()) != null)
            {
                if (lIntContador > 0)
                {
                    String[] SubCadena = lStrLinea.Split(lChrDelimitador);
                    clsEquipo ObjEquipo = new clsEquipo(
                        SubCadena[0],//NOMBRE
                        SubCadena[1],//NOMBRE COMUN
                        SubCadena[2],//TEMPORADA
                        SubCadena[3],//CIUDAD
                        Convert.ToInt32(SubCadena[4]),//JUEGOSJUGADOS
                        Convert.ToInt32(SubCadena[5]),//JUEGOSJUGADOSCASA
                        Convert.ToInt32(SubCadena[6]),//JUEGOSJUGADOSVISITANTE
                        Convert.ToInt32(SubCadena[7]),//JUEGOSSUSPENDIDOS
                        Convert.ToInt32(SubCadena[8]),//VICTORIAS
                        Convert.ToInt32(SubCadena[11]),//EMPATES
                        Convert.ToInt32(SubCadena[14]),//DERROTAS
                        Convert.ToInt32(SubCadena[20]),//POSICION
                        Convert.ToInt32(SubCadena[27]),//GOLES
                        Convert.ToInt32(SubCadena[54]),//TIROS ESQUINA
                        Convert.ToInt32(SubCadena[57]),//TOTAL FALTAS
                        Convert.ToSingle(SubCadena[60]),//POSESION DEL BALON
                        Convert.ToInt32(SubCadena[72]),//FALTAS
                        Convert.ToSingle(SubCadena[99]),//GOLES X PARTIDO
                        Convert.ToSingle(SubCadena[204]));//PORCENTAJE DE VICTORIAS
                    gObjMiarbolAvl.insertar(ObjEquipo);
                    lIntContador++;
                }
                else
                {
                    lIntContador++;
                }
            }
            fArchivo.Close();
        }

        //TABLA HASH DIRECCIONAMIENTO ENLAZADO DONDE SE GUARDARAN LOS PARTIDOS
        public void CargarPartidos()
        {
            int lIntContador = 0;
            string lStrLinea;

            System.IO.StreamReader fArchivo = new System.IO.StreamReader("PremierLeague18_19_Partidos.csv");

            Char lChrDelimitador = ',';
            int valor = 0;
            while ((lStrLinea = fArchivo.ReadLine()) != null)
            {
                if (lIntContador > 0)
                {
                    string dato1, dato2, dato3, dato4;
                    String[] SubCadena = lStrLinea.Split(lChrDelimitador);
                    clsPartido ObjPartido = new clsPartido(
                        Convert.ToInt32(SubCadena[0]),//codigo
                        SubCadena[1],//fecha
                        SubCadena[2],//status
                        Convert.ToInt32(SubCadena[3]),//aficionados
                        SubCadena[4],//equipo casa
                        SubCadena[5],//equipo visitante
                        SubCadena[6],//referi
                        Convert.ToInt32(SubCadena[7]),//gameweek
                        Convert.ToDouble(SubCadena[8]),//prematchhome
                        Convert.ToDouble(SubCadena[9]),//prematchaway
                        Convert.ToDouble(SubCadena[10]),//homeppg
                        Convert.ToDouble(SubCadena[11]),//awayppg
                        Convert.ToInt32(SubCadena[12]),//hometeamgoalcount
                        Convert.ToInt32(SubCadena[13]),//awayteamgoalcount
                        Convert.ToInt32(SubCadena[14]),//totalgoalcount
                        SubCadena[65]);//estadio
                    dato1 = SubCadena[1];
                    dato2 = SubCadena[4];
                    dato3 = SubCadena[5];
                    dato4 = string.Concat(dato1, dato2, dato3);
                    valor = SumarAscci(dato4);
                    gObjTablaHash.Insertar2(ObjPartido, valor);
                    lIntContador++;
                }
                else
                {
                    lIntContador++;
                }
            }
            fArchivo.Close();
        }

        //LLEVA AL FORM DE JUGADORES
        private void button1_Click(object sender, EventArgs e)
        {
            wfmJugadores jugadores = new wfmJugadores();
            jugadores.Show();
        }
        //LLEVA AL FORM DE EQUIPOS
        private void btnEquipos_Click(object sender, EventArgs e)
        {
            wfmEquipos Equipos = new wfmEquipos();
            Equipos.Show();
        }
        //LLEVA AL FORM DE PARTIDOS
        private void btnPartidos_Click(object sender, EventArgs e)
        {
            wfmPartidos Partidos = new wfmPartidos();
            Partidos.Show();
        }
        //LLEVA AL FORM DE TORNEOS
        private void btnTorneos_Click(object sender, EventArgs e)
        {
            wfmTorneos Torneos = new wfmTorneos();
            Torneos.Show();
        }
    }
}
