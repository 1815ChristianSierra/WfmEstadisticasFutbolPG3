using EstructurasDatosPG3CS.ArbolesBinarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WfmEstadisticasFutbolPG3
{
    public class clsPartido : clsComparador
    {

        public int timestamp { get; set; }//1
        public string date_GMT { get; set; }//2
        public string status { get; set; }//3
        public int attendance { get; set; }//4
        public string hometeamname { get; set; }//5
        public string awayteamname { get; set; }//6
        public string referee { get; set; }//7
        public int GameWeek { get; set; }//8
        public double PreMatchPPGHome { get; set; }//9
        public double PreMatchPPGAway { get; set; }//10
        public double home_ppg { get; set; }//11
        public double away_ppg { get; set; }//12
        public int home_team_goal_count { get; set; }//13
        public int away_team_goal_count { get; set; }//14
        public int total_goal_count { get; set; }//15
                                           //16_30
                                           // total_goals_at_half_time,
                                           // home_team_goal_count_half_time,
                                           // away_team_goal_count_half_time,
                                           // home_team_goal_timings,
                                           // away_team_goal_timings,
                                           // home_team_corner_count,
                                           // away_team_corner_count,
                                           // home_team_yellow_cards,
                                           // home_team_red_cards,
                                           // away_team_yellow_cards,
                                           // away_team_red_cards,
                                           // home_team_first_half_cards,
                                           // home_team_second_half_cards,
                                           // away_team_first_half_cards,
                                           // away_team_second_half_cards,
                                           //31-40
                                           // home_team_shots,
                                           // away_team_shots,
                                           // home_team_shots_on_target,
                                           // away_team_shots_on_target,
                                           // home_team_shots_off_target,
                                           // away_team_shots_off_target,
                                           // home_team_fouls,
                                           // away_team_fouls,
                                           // home_team_possession,
                                           // away_team_possession,
                                           //41-50
                                           // Home Team Pre-Match xG,
                                           // Away Team Pre-Match xG,
                                           // team_a_xg,
                                           // team_b_xg,
                                           // average_goals_per_match_pre_match,
                                           // btts_percentage_pre_match,
                                           // over_15_percentage_pre_match,
                                           // over_25_percentage_pre_match,
                                           // over_35_percentage_pre_match,
                                           // over_45_percentage_pre_match,
                                           //51-60
                                           // over_15_HT_FHG_percentage_pre_match,
                                           // over_05_HT_FHG_percentage_pre_match,
                                           // over_15_2HG_percentage_pre_match,
                                           // over_05_2HG_percentage_pre_match,
                                           // average_corners_per_match_pre_match,
                                           // average_cards_per_match_pre_match,
                                           // odds_ft_home_team_win,
                                           // odds_ft_draw,
                                           // odds_ft_away_team_win,
                                           // odds_ft_over15,
                                           //61-70
                                           // odds_ft_over25,
                                           // odds_ft_over35,
                                           // odds_ft_over45,
                                           // odds_btts_yes,
                                           // odds_btts_no,
        public string stadium_name { get; set; }//66
        public clsPartido(int timestamp, string dategmt, string status, int attendance, string hometeamname, string awayteamname, string referee,
                          int gameweek, double prematchhome, double prematchaway, double homeppg, double awayppg, int hometeamgoalcount, int awayteamgoalcount,
                          int totalgoalcount/*,,,,,,,*/, string stadium_name) 
        {
            //1-15
            this.timestamp = timestamp;
            this.date_GMT = dategmt;
            this.status = status;
            this.attendance = attendance;
            this.hometeamname = hometeamname;
            this.awayteamname = awayteamname;
            this.referee = referee;
            this.GameWeek = gameweek;
            this.PreMatchPPGHome = prematchhome;
            this.PreMatchPPGAway = prematchaway;
            this.home_ppg = homeppg;
            this.away_ppg = awayppg;
            this.home_team_goal_count = hometeamgoalcount;
            this.away_team_goal_count = awayteamgoalcount;
            this.total_goal_count = totalgoalcount;
            this.stadium_name = stadium_name;
        }

        public bool igualQue(object codigo)
        {
            clsPartido lMiEstudiante = (clsPartido)codigo;
            if (hometeamname.CompareTo(lMiEstudiante.hometeamname) == 0 )//&& hometeamname.CompareTo(lMiEstudiante.hometeamname)==0 && referee.CompareTo(lMiEstudiante.referee) == 0)
                return true;
            else
                return false;
        }

        public bool menorQue(object codigo)
        {
            clsPartido lMiEstudiante = (clsPartido)codigo;
            if (hometeamname.CompareTo(lMiEstudiante.hometeamname) < 0 )//&& hometeamname.CompareTo(lMiEstudiante.hometeamname) < 0 && referee.CompareTo(lMiEstudiante.referee) < 0)
                return true;
            else
                return false;
        }

        public bool menorIgualQue(object codigo)
        {
            clsPartido lMiEstudiante = (clsPartido)codigo;
            if (hometeamname.CompareTo(lMiEstudiante.hometeamname) <= 0 )//&& hometeamname.CompareTo(lMiEstudiante.hometeamname) <= 0 && referee.CompareTo(lMiEstudiante.referee) <= 0)
                return true;
            else
                return false;
        }

        public bool mayorQue(object codigo)
        {
            clsPartido lMiEstudiante = (clsPartido)codigo;
            if (hometeamname.CompareTo(lMiEstudiante.hometeamname) > 0 )//&& hometeamname.CompareTo(lMiEstudiante.hometeamname) > 0 && referee.CompareTo(lMiEstudiante.referee) > 0)
                return true;
            else
                return false;
        }

        public bool mayorIgualQue(object codigo)
        {
            clsPartido lMiEstudiante = (clsPartido)codigo;
            if (hometeamname.CompareTo(lMiEstudiante.hometeamname) >= 0)// && hometeamname.CompareTo(lMiEstudiante.hometeamname) >= 0 && referee.CompareTo(lMiEstudiante.referee) >= 0)
                return true;
            else
                return false;
        }



        public override string ToString()
        {
            return "(hometeamname: " + hometeamname + " awayteamname: " + awayteamname + " date_GMT: " + date_GMT + ")";
        }
        /*
        public override string ToString()
        {
            return "(Nombre: " + full_name + " Nombre: " + age + "  Zona: " + league + " Total: " + season + ")";
        }*/
    }
}
