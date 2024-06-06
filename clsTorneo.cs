using EstructurasDatosPG3CS.ArbolesBinarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WfmEstadisticasFutbolPG3
{
    public class clsTorneo : clsComparador
    {
        public int Id { get; set; } // Identificador único del torneo
        public string Nombre { get; set; } // Nombre del torneo

        public string Temporada { get; set; } // Temporada del torneo

        //clsEquipo Equipos { get; set; }

        public clsTorneo(int id, string nombre, string temporada) 
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Temporada = temporada;
        }

        public bool igualQue(object torneo)
        {
            clsTorneo lMiEstudiante = (clsTorneo)torneo;
            if (Nombre.CompareTo(lMiEstudiante.Nombre) == 0)// && birthday.CompareTo(lMiEstudiante.birthday) == 0)
                return true;
            else
                return false;
        }

        public bool menorQue(object torneo)
        {
            clsTorneo lMiEstudiante = (clsTorneo)torneo;
            if (Nombre.CompareTo(lMiEstudiante.Nombre) < 0)// && birthday.CompareTo(lMiEstudiante.birthday) < 0)
                return true;
            else
                return false;
        }

        public bool menorIgualQue(object torneo)
        {
            clsTorneo lMiEstudiante = (clsTorneo)torneo;
            if (Nombre.CompareTo(lMiEstudiante.Nombre) <= 0)// && birthday.CompareTo(lMiEstudiante.birthday) <= 0)
                return true;
            else
                return false;
        }

        public bool mayorQue(object torneo)
        {
            clsTorneo lMiEstudiante = (clsTorneo)torneo;
            if (Nombre.CompareTo(lMiEstudiante.Nombre) > 0)//&& birthday.CompareTo(lMiEstudiante.birthday) > 0)
                return true;
            else
                return false;
        }

        public bool mayorIgualQue(object torneo)
        {
            clsTorneo lMiEstudiante = (clsTorneo)torneo;
            if (Nombre.CompareTo(lMiEstudiante.Nombre) >= 0)//&& birthday.CompareTo(lMiEstudiante.birthday) >= 0)
                return true;
            else
                return false;
        }

        public override string ToString()
        {
            return "(Nombre: " + Nombre + ")";
        }
    }
}
