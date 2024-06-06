using EstructurasDatosPG3CS.ArbolesBinarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace WfmEstadisticasFutbolPG3
{
    public class clsEquipo : clsComparador
    {
        //1-10
        public string team_name { get; set; }
        public string common_name { get; set; }
        public string season { get; set; }
        public string country { get; set; }
        public int matches_played { get; set; }
        
        public int matches_played_home { get; set; }
        public int matches_played_away { get; set; }
        
        public int suspended_matches { get; set; }
        public int wins { get; set; }
       /** public int wins_home { get; set; }
        //11-20
        public int wins_away { get; set; }*/
        
        public int draws { get; set; }//*12
        /*
        public int draws_home { get; set; }
        public int draws_away { get; set; }
        */
        public int losses { get; set; }//*15
        /*
        public int losses_home { get; set; }
        public int losses_away { get; set; }
        public float points_per_game { get; set; }
        public float points_per_game_home { get; set; }
        public float points_per_game_away { get; set; }
        */
        //21-30
        public int league_position { get; set; }//*21
        /*
        public int league_position_home { get; set; }
        public int league_position_away { get; set; }
        public int performance_rank { get; set; }
        public int goals_scored { get; set; }
        public int goals_conceded { get; set; }
        public int goal_difference { get; set; }
        */
        public int total_goal_count { get; set; }//*28
        /*
        public int total_goal_count_home { get; set; }
        public int total_goal_count_away { get; set; }
        //31-40
        public int goals_scored_home { get; set; }
        public int goals_scored_away { get; set; }
        public int goals_conceded_home { get; set; }
        public int goals_conceded_away { get; set; }
        public int goal_difference_home { get; set; }
        public int goal_difference_away { get; set; }
        public float minutes_per_goal_scored { get; set; }
        public float minutes_per_goal_scored_home { get; set; }
        public float minutes_per_goal_scored_away { get; set; }
        public float minutes_per_goal_conceded { get; set; }
        //41-50
        public float minutes_per_goal_conceded_home { get; set; }
        public float minutes_per_goal_conceded_away { get; set; }
        public int clean_sheets { get; set; }
        public int clean_sheets_home { get; set; }
        public int clean_sheets_away { get; set; }
        public int btts_count { get; set; }
        public int btts_count_home { get; set; }
        public int btts_count_away { get; set; }
        public int fts_count { get; set; }
        public int fts_count_home { get; set; }
        //51-60
        public int fts_count_away { get; set; }
        public int first_team_to_score_count { get; set; }
        public int first_team_to_score_count_home { get; set; }
        public int first_team_to_score_count_away { get; set; }
        */
        public int corners_total { get; set; }//*55
        /*
        public int corners_total_home { get; set; }
        public int corners_total_away { get; set; }
        */
        public int cards_total { get; set; }//*58
        /*
        public int cards_total_home { get; set; }
        public int cards_total_away { get; set; }
        */
        //61-70
        public float average_possession { get; set; }//*61
        /*
        public float average_possession_home { get; set; }
        public float average_possession_away { get; set; }
        public int shots { get; set; }
        public int shots_home { get; set; }
        public int shots_away { get; set; }
        public int shots_on_target { get; set; }
        public int shots_on_target_home { get; set; }
        public int shots_on_target_away { get; set; }
        public int shots_off_target { get; set; }
        //71-80
        public int shots_off_target_home { get; set; }
        public int shots_off_target_away { get; set; }
        */
        public int fouls { get; set; }//*73
        /*
        public int fouls_home { get; set; }
        public int fouls_away { get; set; }
        public int goals_scored_half_time { get; set; }
        public int goals_scored_half_time_home { get; set; }
        public int goals_scored_half_time_away { get; set; }
        public int goals_conceded_half_time { get; set; }
        public int goals_conceded_half_time_home { get; set; }
        //81-90
        public int goals_conceded_half_time_away { get; set; }
        public int goal_difference_half_time { get; set; }
        public int goal_difference_half_time_home { get; set; }
        public int goal_difference_half_time_away { get; set; }
        public int leading_at_half_time { get; set; }
        public int leading_at_half_time_home { get; set; }
        public int leading_at_half_time_away { get; set; }
        public int draw_at_half_time { get; set; }
        public int draw_at_half_time_home { get; set; }
        public int draw_at_half_time_away { get; set; }
        //91-100
        public int losing_at_half_time { get; set; }
        public int losing_at_half_time_home { get; set; }
        public int losing_at_half_time_away { get; set; }
        public float points_per_game_half_time { get; set; }
        public float points_per_game_half_time_home { get; set; }
        public float points_per_game_half_time_away { get; set; }
        public float average_total_goals_per_match { get; set; }
        public float average_total_goals_per_match_home { get; set; }
        public float average_total_goals_per_match_away { get; set; }
        */
        public float goals_scored_per_match { get; set; }//*100
        //101-110
        /*
        public float goals_scored_per_match_home { get; set; }
        public float goals_scored_per_match_away { get; set; }
        public float goals_conceded_per_match { get; set; }
        public float goals_conceded_per_match_home { get; set; }
        public float goals_conceded_per_match_away { get; set; }
        public float total_goals_per_match_half_time { get; set; }
        public float total_goals_per_match_half_time_home { get; set; }
        public float total_goals_per_match_half_time_away { get; set; }
        public float goals_scored_per_match_half_time { get; set; }
        public float goals_scored_per_match_half_time_home { get; set; }
        //111-120
        public float goals_scored_per_match_half_time_away { get; set; }
        public float goals_conceded_per_match_half_time { get; set; }
        public float goals_conceded_per_match_half_time_home { get; set; }
        public float goals_conceded_per_match_half_time_away { get; set; }
        public int over05_count { get; set; }
        public int over15_count { get; set; }
        public int over25_count { get; set; }
        public int over35_count { get; set; }
        public int over45_count { get; set; }
        public int over55_count { get; set; }
        //121-130
        public int over05_count_home { get; set; }
        public int over15_count_home { get; set; }
        public int over25_count_home { get; set; }
        public int over35_count_home { get; set; }
        public int over45_count_home { get; set; }
        public int over55_count_home { get; set; }
        public int over05_count_away { get; set; }
        public int over15_count_away { get; set; }
        public int over25_count_away { get; set; }
        public int over35_count_away { get; set; }
        //131-140
        public int over45_count_away { get; set; }
        public int over55_count_away { get; set; }
        public int under05_count { get; set; }
        public int under15_count { get; set; }
        public int under25_count { get; set; }
        public int under35_count { get; set; }
        public int under45_count { get; set; }
        public int under55_count { get; set; }
        public int under05_count_home { get; set; }
        public int under15_count_home { get; set; }
        //141-150
        public int under25_count_home { get; set; }
        public int under35_count_home { get; set; }
        public int under45_count_home { get; set; }
        public int under55_count_home { get; set; }
        public int under05_count_away { get; set; }
        public int under15_count_away { get; set; }
        public int under25_count_away { get; set; }
        public int under35_count_away { get; set; }
        public int under45_count_away { get; set; }
        public int under55_count_away { get; set; }
        //151-160
        public float over05_percentage { get; set; }
        public float over15_percentage { get; set; }
        public float over25_percentage { get; set; }
        public float over35_percentage { get; set; }
        public float over45_percentage { get; set; }
        public float over55_percentage { get; set; }
        public float over05_percentage_home { get; set; }
        public float over15_percentage_home { get; set; }
        public float over25_percentage_home { get; set; }
        public float over35_percentage_home { get; set; }
        //161-170
        public float over45_percentage_home { get; set; }
        public float over55_percentage_home { get; set; }
        public float over05_percentage_away { get; set; }
        public float over15_percentage_away { get; set; }
        public float over25_percentage_away { get; set; }
        public float over35_percentage_away { get; set; }
        public float over45_percentage_away { get; set; }
        public float over55_percentage_away { get; set; }
        public float under05_percentage { get; set; }
        public float under15_percentage { get; set; }
        //171-180
        public float under25_percentage { get; set; }
        public float under35_percentage { get; set; }
        public float under45_percentage { get; set; }
        public float under55_percentage { get; set; }
        public float under05_percentage_home { get; set; }
        public float under15_percentage_home { get; set; }
        public float under25_percentage_home { get; set; }
        public float under35_percentage_home { get; set; }
        public float under45_percentage_home { get; set; }
        public float under55_percentage_home { get; set; }
        //181-190
        public float under05_percentage_away { get; set; }
        public float under15_percentage_away { get; set; }
        public float under25_percentage_away { get; set; }
        public float under35_percentage_away { get; set; }
        public float under45_percentage_away { get; set; }
        public float under55_percentage_away { get; set; }
        public int over05_count_half_time { get; set; }
        public int over15_count_half_time { get; set; }
        public int over25_count_half_time { get; set; }
        public int over05_count_half_time_home { get; set; }
        //191-200
        public int over15_count_half_time_home { get; set; }
        public int over25_count_half_time_home { get; set; }
        public int over05_count_half_time_away { get; set; }
        public int over15_count_half_time_away { get; set; }
        public int over25_count_half_time_away { get; set; }
        public float over05_half_time_percentage { get; set; }
        public float over15_half_time_percentage { get; set; }
        public float over25_half_time_percentage { get; set; }
        public float over05_half_time_percentage_home { get; set; }
        public float over15_half_time_percentage_home { get; set; }
        //201-210
        public float over25_half_time_percentage_home { get; set; }
        public float over05_half_time_percentage_away { get; set; }
        public float over15_half_time_percentage_away { get; set; }
        public float over25_half_time_percentage_away { get; set; }
        */
        public float win_percentage { get; set; }//*205
        /*
        public float win_percentage_home { get; set; }
        public float win_percentage_away { get; set; }
        public float home_advantage_percentage { get; set; }
        public float clean_sheet_percentage { get; set; }
        public float clean_sheet_percentage_home { get; set; }
        //211-220
        public float clean_sheet_percentage_away { get; set; }
        public float btts_percentage { get; set; }
        public float btts_percentage_home { get; set; }
        public float btts_percentage_away { get; set; }
        public float fts_percentage { get; set; }
        public float fts_percentage_home { get; set; }
        public float fts_percentage_away { get; set; }
        public float first_team_to_score_percentage { get; set; }
        public float first_team_to_score_percentage_home { get; set; }
        public float first_team_to_score_percentage_away { get; set; }
        public int clean_sheet_half_time { get; set; }
        //221-230
        public int clean_sheet_half_time_home { get; set; }
        public int clean_sheet_half_time_away { get; set; }
        public float clean_sheet_half_time_percentage { get; set; }
        public float clean_sheet_half_time_percentage_home { get; set; }
        public float clean_sheet_half_time_percentage_away { get; set; }
        public int fts_half_time { get; set; }
        public int fts_half_time_home { get; set; }
        public int fts_half_time_away { get; set; }
        public float fts_half_time_percentage { get; set; }
        public float fts_half_time_percentage_home { get; set; }
        //231-240
        public float fts_half_time_percentage_away { get; set; }
        public float btts_half_time { get; set; }
        public float btts_half_time_home { get; set; }
        public float btts_half_time_away { get; set; }
        public float btts_half_time_percentage { get; set; }
        public float btts_half_time_percentage_home { get; set; }
        public float btts_half_time_percentage_away { get; set; }
        public float leading_at_half_time_percentage { get; set; }
        public float leading_at_half_time_percentage_home { get; set; }
        public float leading_at_half_time_percentage_away { get; set; }
        //241-250
        public float draw_at_half_time_percentage { get; set; }
        public float draw_at_half_time_percentage_home { get; set; }
        public float draw_at_half_time_percentage_away { get; set; }
        public float losing_at_half_time_percentage { get; set; }
        public float losing_at_half_time_percentage_home { get; set; }
        public float losing_at_half_time_percentage_away { get; set; }
        public int corners_per_match { get; set; }
        public int corners_per_match_home { get; set; }
        public int corners_per_match_away { get; set; }
        public int cards_per_match { get; set; }
        //251-260
        public int cards_per_match_home { get; set; }
        public int cards_per_match_away { get; set; }
        public float over65_corners_percentage { get; set; }
        public float over75_corners_percentage { get; set; }
        public float over85_corners_percentage { get; set; }
        public float over95_corners_percentage { get; set; }
        public float over105_corners_percentage { get; set; }
        public float over115_corners_percentage { get; set; }
        public float over125_corners_percentage { get; set; }
        public float over135_corners_percentage { get; set; }
        //261-270
        public float xg_for_avg_overall { get; set; }
        public float xg_for_avg_home { get; set; }
        public float xg_for_avg_away { get; set; }
        public float xg_against_avg_overall { get; set; }
        public float xg_against_avg_home { get; set; }
        public float xg_against_avg_away { get; set; }
        public float prediction_risk { get; set; }
        public int goals_scored_min_0_to_10 { get; set; }
        public int goals_scored_min_11_to_20 { get; set; }
        public int goals_scored_min_21_to_30 { get; set; }
        //271-280
        public int goals_scored_min_31_to_40 { get; set; }
        public int goals_scored_min_41_to_50 { get; set; }
        public int goals_scored_min_51_to_60 { get; set; }
        public int goals_scored_min_61_to_70 { get; set; }
        public int goals_scored_min_71_to_80 { get; set; }
        public int goals_scored_min_81_to_90 { get; set; }
        public int goals_conceded_min_0_to_10 { get; set; }
        public int goals_conceded_min_11_to_20 { get; set; }
        public int goals_conceded_min_21_to_30 { get; set; }
        public int goals_conceded_min_31_to_40 { get; set; }

        //281-290
        public int goals_conceded_min_41_to_50 { get; set; }
        public int goals_conceded_min_51_to_60 { get; set; }
        public int goals_conceded_min_61_to_70 { get; set; }
        public int goals_conceded_min_71_to_80 { get; set; }
        public int goals_conceded_min_81_to_A2890 { get; set; } // This attribute name seems incorrect
        public int draw_percentage_overall { get; set; }*
        public int draw_percentage_home { get; set; }
        public int draw_percentage_away { get; set; }
        public int loss_percentage_overall { get; set; }*
        public int loss_percentage_home { get; set; }

        //291-300
        public int loss_percentage_away { get; set; }
        public float over145_corners_percentage { get; set; }
        **/
        //302 en total

        // Metodo Constructor
        public clsEquipo(string teamName, string commonName, string season, string country, int matchesPlayed, int matchesPlayedHome, int matchesPlayedAway, int suspendedMatches, int wins,/* int winsHome,
                         int winsAway,*/ int draws/*, int drawsHome, int drawsAway*/, int losses/*, int lossesHome, int lossesAway, float pointsPerGame, float pointsPerGameHome, float pointsPerGameAway*/,
                         int league_position/*, int league_position_home, int league_position_away, int performance_rank, int goals_scored, int goals_conceded, int goal_difference*/, int total_goal_count/*, int total_goal_count_home, int total_goal_count_away,
                         int goals_scored_home, int goals_scored_away, int goals_conceded_home, int goals_conceded_away, int goal_difference_home, int goal_difference_away, float minutes_per_goal_scored, float minutes_per_goal_scored_home, float minutes_per_goal_scored_away, float minutes_per_goal_conceded,
                         float minutesPerGoalConcededHome, float minutesPerGoalConcededAway, int cleanSheets, int cleanSheetsHome, int cleanSheetsAway, int bttsCount, int bttsCountHome, int bttsCountAway, int ftsCount, int ftsCountHome,
                         int ftsCountAway, int firstTeamToScoreCount, int firstTeamToScoreCountHome, int firstTeamToScoreCountAway*/, int cornersTotal/*, int cornersTotalHome, int cornersTotalAway*/, int cardsTotal/*, int cardsTotalHome, int cardsTotalAway*/,
                         float averagePossession/*, float averagePossessionHome, float averagePossessionAway, int shotsCount, int shotsHome, int shotsAway, int shotsOnTarget, int shotsOnTargetHome, int shotsOnTargetAway, int shotsOffTarget,
                         int shotsOffTargetHome, int shotsOffTargetAway*/, int foulsCount/*, int foulsHome, int foulsAway, int goalsScoredHalfTime, int goalsScoredHalfTimeHome, int goalsScoredHalfTimeAway, int goalsConcededHalfTime, int goalsConcededHalfTimeHome,
                         int goalsConcededHalfTimeAway, int goalDifferenceHalfTime, int goalDifferenceHalfTimeHome, int goalDifferenceHalfTimeAway, int leadingAtHalfTime, int leadingAtHalfTimeHome, int leadingAtHalfTimeAway, int drawAtHalfTime, int drawAtHalfTimeHome, int drawAtHalfTimeAway,
                         int losingAtHalfTime, int losingAtHalfTimeHome, int losingAtHalfTimeAway, float pointsPerGameHalfTime, float pointsPerGameHalfTimeHome, float pointsPerGameHalfTimeAway, float averageTotalGoalsPerMatch, float averageTotalGoalsPerMatchHome, float averageTotalGoalsPerMatchAway*/, float goalsScoredPerMatch/*,
                         float goalsScoredPerMatchHome, float goalsScoredPerMatchAway, float goalsConcededPerMatch, float goalsConcededPerMatchHome, float goalsConcededPerMatchAway, float totalGoalsPerMatchHalfTime, float totalGoalsPerMatchHalfTimeHome, float totalGoalsPerMatchHalfTimeAway, float goalsScoredPerMatchHalfTime, float goalsScoredPerMatchHalfTimeHome,
                         float goalsScoredPerMatchHalfTimeAway, float goalsConcededPerMatchHalfTime, float goalsConcededPerMatchHalfTimeHome, float goalsConcededPerMatchHalfTimeAway, int over05Count, int over15Count, int over25Count, int over35Count, int over45Count, int over55Count,
                         int over05CountHome, int over15CountHome, int over25CountHome, int over35CountHome, int over45CountHome, int over55CountHome, int over05CountAway, int over15CountAway, int over25CountAway, int over35CountAway,
                         int over45CountAway, int over55CountAway, int under05Count, int under15Count, int under25Count, int under35Count, int under45Count, int under55Count, int under05CountHome, int under15CountHome,
                         int under25CountHome, int under35CountHome, int under45CountHome, int under55CountHome, int under05CountAway, int under15CountAway, int under25CountAway, int under35CountAway, int under45CountAway, int under55CountAway,
                         float over05Percentage, float over15Percentage, float over25Percentage, float over35Percentage, float over45Percentage, float over55Percentage, float over05PercentageHome, float over15PercentageHome, float over25PercentageHome, float over35PercentageHome,
                         float over45PercentageHome, float over55PercentageHome, float over05PercentageAway, float over15PercentageAway, float over25PercentageAway, float over35PercentageAway, float over45PercentageAway, float over55PercentageAway, float under05Percentage, float under15Percentage,
                         float under25Percentage, float under35Percentage, float under45Percentage, float under55Percentage, float under05PercentageHome, float under15PercentageHome, float under25PercentageHome, float under35PercentageHome, float under45PercentageHome, float under55PercentageHome,
                         float under05PercentageAway, float under15PercentageAway, float under25PercentageAway, float under35PercentageAway, float under45PercentageAway, float under55PercentageAway, int over05CountHalfTime, int over15CountHalfTime, int over25CountHalfTime, int over05CountHalfTimeHome,
                         int over15CountHalfTimeHome, int over25CountHalfTimeHome, int over05CountHalfTimeAway, int over15CountHalfTimeAway, int over25CountHalfTimeAway, float over05HalfTimePercentage, float over15HalfTimePercentage, float over25HalfTimePercentage, float over05HalfTimePercentageHome, float over15HalfTimePercentageHome,
                         float over25HalfTimePercentageHome, float over05HalfTimePercentageAway, float over15HalfTimePercentageAway, float over25HalfTimePercentageAway*/, float winPercentage/*, float winPercentageHome, float winPercentageAway, float homeAdvantagePercentage, float cleanSheetPercentage, float cleanSheetPercentageHome,
                         float cleanSheetPercentageAway, float bttsPercentage, float bttsPercentageHome, float bttsPercentageAway, float ftsPercentage, float ftsPercentageHome, float ftsPercentageAway, float firstTeamToScorePercentage, float firstTeamToScorePercentageHome, float firstTeamToScorePercentageAway, int cleanSheetHalfTime,
                         int cleanSheetHalfTimeHome, int cleanSheetHalfTimeAway, float cleanSheetHalfTimePercentage, float cleanSheetHalfTimePercentageHome, float cleanSheetHalfTimePercentageAway, int ftsHalfTime, int ftsHalfTimeHome, int ftsHalfTimeAway, float ftsHalfTimePercentage, float ftsHalfTimePercentageHome,
                         float ftsHalfTimePercentageAway, float bttsHalfTime, float bttsHalfTimeHome, float bttsHalfTimeAway, float bttsHalfTimePercentage, float bttsHalfTimePercentageHome, float bttsHalfTimePercentageAway, float leadingAtHalfTimePercentage, float leadingAtHalfTimePercentageHome, float leadingAtHalfTimePercentageAway,
                         float drawAtHalfTimePercentage, float drawAtHalfTimePercentageHome, float drawAtHalfTimePercentageAway, float losingAtHalfTimePercentage, float losingAtHalfTimePercentageHome, float losingAtHalfTimePercentageAway, int cornersPerMatch, int cornersPerMatchHome, int cornersPerMatchAway, int cardsPerMatch,
                         int cardsPerMatchHome, int cardsPerMatchAway, float over65CornersPercentage, float over75CornersPercentage, float over85CornersPercentage, float over95CornersPercentage, float over105CornersPercentage, float over115CornersPercentage, float over125CornersPercentage, float over135CornersPercentage,
                         float xgForAvgOverall, float xgForAvgHome, float xgForAvgAway, float xgAgainstAvgOverall, float xgAgainstAvgHome, float xgAgainstAvgAway, float predictionRisk, int goalsScoredMin0To10, int goalsScoredMin11To20, int goalsScoredMin21To30,
                         int goalsScoredMin31To40, int goalsScoredMin41To50, int goalsScoredMin51To60, int goalsScoredMin61To70, int goalsScoredMin71To80, int goalsScoredMin81To90, int goalsConcededMin0To10, int goalsConcededMin11To20, int goalsConcededMin21To30, int goalsConcededMin31To40,
                         int goalsConcededMin41To50, int goalsConcededMin51To60, int goalsConcededMin61To70, int goalsConcededMin71To80, int goalsConcededMin81ToA2890, int drawPercentageOverall, int drawPercentageHome, int drawPercentageAway, int lossPercentageOverall, int lossPercentageHome,
                         int lossPercentageAway, float over145CornersPercentage*/)
        {
            //1-10
            this.team_name = teamName;
            this.common_name = commonName;
            this.season = season;
            this.country = country;
            this.matches_played = matchesPlayed;
            this.matches_played_home = matchesPlayedHome;
            this.matches_played_away = matchesPlayedAway;
            this.suspended_matches = suspendedMatches;
            this.wins = wins;
            //this.wins_home = winsHome;
            //11-20
            //this.wins_away = winsAway;
            this.draws = draws;//12
            /**
            this.draws_home = drawsHome;
            this.draws_away = drawsAway;
            */
            this.losses = losses;//15
            /*
            this.losses_home = lossesHome;
            this.losses_away = lossesAway;
            this.points_per_game = pointsPerGame;
            this.points_per_game_home = pointsPerGameHome;
            this.points_per_game_away = pointsPerGameAway;
            */
            //21-30
            this.league_position = league_position;//21
            /*
            this.league_position_home = league_position_home;
            this.league_position_away = league_position_away;
            this.performance_rank = performance_rank;
            this.goals_scored = goals_scored;
            this.goals_conceded = goals_conceded;
            this.goal_difference = goal_difference;
            */
            this.total_goal_count = total_goal_count;//28
            /*
            this.total_goal_count_home = total_goal_count_home;
            this.total_goal_count_away = total_goal_count_away;
            //31-40
            this.goals_scored_home = goals_scored_home;
            this.goals_scored_away = goals_scored_away;
            this.goals_conceded_home = goals_conceded_home;
            this.goals_conceded_away = goals_conceded_away;
            this.goal_difference_home = goal_difference_home;
            this.goal_difference_away = goal_difference_away;
            this.minutes_per_goal_scored = minutes_per_goal_scored;
            this.minutes_per_goal_scored_home = minutes_per_goal_scored_home;
            this.minutes_per_goal_scored_away = minutes_per_goal_scored_away;
            this.minutes_per_goal_conceded = minutes_per_goal_conceded;
            //41-50
            this.minutes_per_goal_conceded_home = minutesPerGoalConcededHome;
            this.minutes_per_goal_conceded_away = minutesPerGoalConcededAway;
            this.clean_sheets = cleanSheets;
            this.clean_sheets_home = cleanSheetsHome;
            this.clean_sheets_away = cleanSheetsAway;
            this.btts_count = bttsCount;
            this.btts_count_home = bttsCountHome;
            this.btts_count_away = bttsCountAway;
            this.fts_count = ftsCount;
            this.fts_count_home = ftsCountHome;
            //51-60
            fts_count_away = ftsCountAway;
            first_team_to_score_count = firstTeamToScoreCount;
            first_team_to_score_count_home = firstTeamToScoreCountHome;
            first_team_to_score_count_away = firstTeamToScoreCountAway;
            */
            this.corners_total = cornersTotal;//55
            /*
            corners_total_home = cornersTotalHome;
            corners_total_away = cornersTotalAway;
            */
            this.cards_total = cardsTotal;//58
            /*
            cards_total_home = cardsTotalHome;
            cards_total_away = cardsTotalAway;
            */
            //61-70
            this.average_possession = averagePossession;//61
            /*
            this.average_possession_home = averagePossessionHome;
            this.average_possession_away = averagePossessionAway;
            this.shots = shotsCount;
            this.shots_home = shotsHome;
            this.shots_away = shotsAway;
            this.shots_on_target = shotsOnTarget;
            this.shots_on_target_home = shotsOnTargetHome;
            this.shots_on_target_away = shotsOnTargetAway;
            this.shots_off_target = shotsOffTarget;
            //71-80
            this.shots_off_target_home = shotsOffTargetHome;
            this.shots_off_target_away = shotsOffTargetAway;
            */
            this.fouls = foulsCount;//73
            /*
            this.fouls_home = foulsHome;
            this.fouls_away = foulsAway;
            this.goals_scored_half_time = goalsScoredHalfTime;
            this.goals_scored_half_time_home = goalsScoredHalfTimeHome;
            this.goals_scored_half_time_away = goalsScoredHalfTimeAway;
            this.goals_conceded_half_time = goalsConcededHalfTime;
            this.goals_conceded_half_time_home = goalsConcededHalfTimeHome;
            //81-90
            this.goals_conceded_half_time_away = goalsConcededHalfTimeAway;
            this.goal_difference_half_time = goalDifferenceHalfTime;
            this.goal_difference_half_time_home = goalDifferenceHalfTimeHome;
            this.goal_difference_half_time_away = goalDifferenceHalfTimeAway;
            this.leading_at_half_time = leadingAtHalfTime;
            this.leading_at_half_time_home = leadingAtHalfTimeHome;
            this.leading_at_half_time_away = leadingAtHalfTimeAway;
            this.draw_at_half_time = drawAtHalfTime;
            this.draw_at_half_time_home = drawAtHalfTimeHome;
            this.draw_at_half_time_away = drawAtHalfTimeAway;
            //91-100
            this.losing_at_half_time = losingAtHalfTime;
            this.losing_at_half_time_home = losingAtHalfTimeHome;
            this.losing_at_half_time_away = losingAtHalfTimeAway;
            this.points_per_game_half_time = pointsPerGameHalfTime;
            this.points_per_game_half_time_home = pointsPerGameHalfTimeHome;
            this.points_per_game_half_time_away = pointsPerGameHalfTimeAway;
            this.average_total_goals_per_match = averageTotalGoalsPerMatch;
            this.average_total_goals_per_match_home = averageTotalGoalsPerMatchHome;
            this.average_total_goals_per_match_away = averageTotalGoalsPerMatchAway;
            */
            this.goals_scored_per_match = goalsScoredPerMatch;//100
            /*
            //101-110
            this.goals_scored_per_match_home = goalsScoredPerMatchHome;
            this.goals_scored_per_match_away = goalsScoredPerMatchAway;
            this.goals_conceded_per_match = goalsConcededPerMatch;
            this.goals_conceded_per_match_home = goalsConcededPerMatchHome;
            this.goals_conceded_per_match_away = goalsConcededPerMatchAway;
            this.total_goals_per_match_half_time = totalGoalsPerMatchHalfTime;
            this.total_goals_per_match_half_time_home = totalGoalsPerMatchHalfTimeHome;
            this.total_goals_per_match_half_time_away = totalGoalsPerMatchHalfTimeAway;
            this.goals_scored_per_match_half_time = goalsScoredPerMatchHalfTime;
            this.goals_scored_per_match_half_time_home = goalsScoredPerMatchHalfTimeHome;
            //111-120
            this.goals_scored_per_match_half_time_away = goalsScoredPerMatchHalfTimeAway;
            this.goals_conceded_per_match_half_time = goalsConcededPerMatchHalfTime;
            this.goals_conceded_per_match_half_time_home = goalsConcededPerMatchHalfTimeHome;
            this.goals_conceded_per_match_half_time_away = goalsConcededPerMatchHalfTimeAway;
            this.over05_count = over05Count;
            this.over15_count = over15Count;
            this.over25_count = over25Count;
            this.over35_count = over35Count;
            this.over45_count = over45Count;
            this.over55_count = over55Count;
            //121-130
            this.over05_count_home = over05CountHome;
            this.over15_count_home = over15CountHome;
            this.over25_count_home = over25CountHome;
            this.over35_count_home = over35CountHome;
            this.over45_count_home = over45CountHome;
            this.over55_count_home = over55CountHome;
            this.over05_count_away = over05CountAway;
            this.over15_count_away = over15CountAway;
            this.over25_count_away = over25CountAway;
            this.over35_count_away = over35CountAway;
            //131-140
            this.over45_count_away = over45CountAway;
            this.over55_count_away = over55CountAway;
            this.under05_count = under05Count;
            this.under15_count = under15Count;
            this.under25_count = under25Count;
            this.under35_count = under35Count;
            this.under45_count = under45Count;
            this.under55_count = under55Count;
            this.under05_count_home = under05CountHome;
            this.under15_count_home = under15CountHome;
            //141-150
            this.under25_count_home = under25CountHome;
            this.under35_count_home = under35CountHome;
            this.under45_count_home = under45CountHome;
            this.under55_count_home = under55CountHome;
            this.under05_count_away = under05CountAway;
            this.under15_count_away = under15CountAway;
            this.under25_count_away = under25CountAway;
            this.under35_count_away = under35CountAway;
            this.under45_count_away = under45CountAway;
            this.under55_count_away = under55CountAway;
            //151-160
            this.over05_percentage = over05Percentage;
            this.over15_percentage = over15Percentage;
            this.over25_percentage = over25Percentage;
            this.over35_percentage = over35Percentage;
            this.over45_percentage = over45Percentage;
            this.over55_percentage = over55Percentage;
            this.over05_percentage_home = over05PercentageHome;
            this.over15_percentage_home = over15PercentageHome;
            this.over25_percentage_home = over25PercentageHome;
            this.over35_percentage_home = over35PercentageHome;
            //161-170
            this.over45_percentage_home = over45PercentageHome;
            this.over55_percentage_home = over55PercentageHome;
            this.over05_percentage_away = over05PercentageAway;
            this.over15_percentage_away = over15PercentageAway;
            this.over25_percentage_away = over25PercentageAway;
            this.over35_percentage_away = over35PercentageAway;
            this.over45_percentage_away = over45PercentageAway;
            this.over55_percentage_away = over55PercentageAway;
            this.under05_percentage = under05Percentage;
            this.under15_percentage = under15Percentage;
            //171-180
            this.under25_percentage = under25Percentage;
            this.under35_percentage = under35Percentage;
            this.under45_percentage = under45Percentage;
            this.under55_percentage = under55Percentage;
            this.under05_percentage_home = under05PercentageHome;
            this.under15_percentage_home = under15PercentageHome;
            this.under25_percentage_home = under25PercentageHome;
            this.under35_percentage_home = under35PercentageHome;
            this.under45_percentage_home = under45PercentageHome;
            this.under55_percentage_home = under55PercentageHome;
            //181-190
            this.under05_percentage_away = under05PercentageAway;
            this.under15_percentage_away = under15PercentageAway;
            this.under25_percentage_away = under25PercentageAway;
            this.under35_percentage_away = under35PercentageAway;
            this.under45_percentage_away = under45PercentageAway;
            this.under55_percentage_away = under55PercentageAway;
            this.over05_count_half_time = over05CountHalfTime;
            this.over15_count_half_time = over15CountHalfTime;
            this.over25_count_half_time = over25CountHalfTime;
            this.over05_count_half_time_home = over05CountHalfTimeHome;
            //191-200
            this.over15_count_half_time_home = over15CountHalfTimeHome;
            this.over25_count_half_time_home = over25CountHalfTimeHome;
            this.over05_count_half_time_away = over05CountHalfTimeAway;
            this.over15_count_half_time_away = over15CountHalfTimeAway;
            this.over25_count_half_time_away = over25CountHalfTimeAway;
            this.over05_half_time_percentage = over05HalfTimePercentage;
            this.over15_half_time_percentage = over15HalfTimePercentage;
            this.over25_half_time_percentage = over25HalfTimePercentage;
            this.over05_half_time_percentage_home = over05HalfTimePercentageHome;
            this.over15_half_time_percentage_home = over15HalfTimePercentageHome;
            //201-210
            this.over25_half_time_percentage_home = over25HalfTimePercentageHome;
            this.over05_half_time_percentage_away = over05HalfTimePercentageAway;
            this.over15_half_time_percentage_away = over15HalfTimePercentageAway;
            this.over25_half_time_percentage_away = over25HalfTimePercentageAway;
            */
            this.win_percentage = winPercentage;//205
            /*
            this.win_percentage_home = winPercentageHome;
            this.win_percentage_away = winPercentageAway;
            this.home_advantage_percentage = homeAdvantagePercentage;
            this.clean_sheet_percentage = cleanSheetPercentage;
            this.clean_sheet_percentage_home = cleanSheetPercentageHome;
            //211-220
            this.clean_sheet_percentage_away = cleanSheetPercentageAway;
            this.btts_percentage = bttsPercentage;
            this.btts_percentage_home = bttsPercentageHome;
            this.btts_percentage_away = bttsPercentageAway;
            this.fts_percentage = ftsPercentage;
            this.fts_percentage_home = ftsPercentageHome;
            this.fts_percentage_away = ftsPercentageAway;
            this.first_team_to_score_percentage = firstTeamToScorePercentage;
            this.first_team_to_score_percentage_home = firstTeamToScorePercentageHome;
            this.first_team_to_score_percentage_away = firstTeamToScorePercentageAway;
            this.clean_sheet_half_time = cleanSheetHalfTime;
            //221-230
            this.clean_sheet_half_time_home = cleanSheetHalfTimeHome;
            this.clean_sheet_half_time_away = cleanSheetHalfTimeAway;
            this.clean_sheet_half_time_percentage = cleanSheetHalfTimePercentage;
            this.clean_sheet_half_time_percentage_home = cleanSheetHalfTimePercentageHome;
            this.clean_sheet_half_time_percentage_away = cleanSheetHalfTimePercentageAway;
            this.fts_half_time = ftsHalfTime;
            this.fts_half_time_home = ftsHalfTimeHome;
            this.fts_half_time_away = ftsHalfTimeAway;
            this.fts_half_time_percentage = ftsHalfTimePercentage;
            this.fts_half_time_percentage_home = ftsHalfTimePercentageHome;
            //231-240
            this.fts_half_time_percentage_away = ftsHalfTimePercentageAway;
            this.btts_half_time = bttsHalfTime;
            this.btts_half_time_home = bttsHalfTimeHome;
            this.btts_half_time_away = bttsHalfTimeAway;
            this.btts_half_time_percentage = bttsHalfTimePercentage;
            this.btts_half_time_percentage_home = bttsHalfTimePercentageHome;
            this.btts_half_time_percentage_away = bttsHalfTimePercentageAway;
            this.leading_at_half_time_percentage = leadingAtHalfTimePercentage;
            this.leading_at_half_time_percentage_home = leadingAtHalfTimePercentageHome;
            this.leading_at_half_time_percentage_away = leadingAtHalfTimePercentageAway;
            //241-250
            this.draw_at_half_time_percentage = drawAtHalfTimePercentage;
            this.draw_at_half_time_percentage_home = drawAtHalfTimePercentageHome;
            this.draw_at_half_time_percentage_away = drawAtHalfTimePercentageAway;
            this.losing_at_half_time_percentage = losingAtHalfTimePercentage;
            this.losing_at_half_time_percentage_home = losingAtHalfTimePercentageHome;
            this.losing_at_half_time_percentage_away = losingAtHalfTimePercentageAway;
            this.corners_per_match = cornersPerMatch;
            this.corners_per_match_home = cornersPerMatchHome;
            this.corners_per_match_away = cornersPerMatchAway;
            this.cards_per_match = cardsPerMatch;
            //251-260
            this.cards_per_match_home = cardsPerMatchHome;
            this.cards_per_match_away = cardsPerMatchAway;
            this.over65_corners_percentage = over65CornersPercentage;
            this.over75_corners_percentage = over75CornersPercentage;
            this.over85_corners_percentage = over85CornersPercentage;
            this.over95_corners_percentage = over95CornersPercentage;
            this.over105_corners_percentage = over105CornersPercentage;
            this.over115_corners_percentage = over115CornersPercentage;
            this.over125_corners_percentage = over125CornersPercentage;
            this.over135_corners_percentage = over135CornersPercentage;
            //261-270
            this.xg_for_avg_overall = xgForAvgOverall;
            this.xg_for_avg_home = xgForAvgHome;
            this.xg_for_avg_away = xgForAvgAway;
            this.xg_against_avg_overall = xgAgainstAvgOverall;
            this.xg_against_avg_home = xgAgainstAvgHome;
            this.xg_against_avg_away = xgAgainstAvgAway;
            this.prediction_risk = predictionRisk;
            this.goals_scored_min_0_to_10 = goalsScoredMin0To10;
            this.goals_scored_min_11_to_20 = goalsScoredMin11To20;
            this.goals_scored_min_21_to_30 = goalsScoredMin21To30;
            //271-280
            this.goals_scored_min_31_to_40 = goalsScoredMin31To40;
            this.goals_scored_min_41_to_50 = goalsScoredMin41To50;
            this.goals_scored_min_51_to_60 = goalsScoredMin51To60;
            this.goals_scored_min_61_to_70 = goalsScoredMin61To70;
            this.goals_scored_min_71_to_80 = goalsScoredMin71To80;
            this.goals_scored_min_81_to_90 = goalsScoredMin81To90;
            this.goals_conceded_min_0_to_10 = goalsConcededMin0To10;
            this.goals_conceded_min_11_to_20 = goalsConcededMin11To20;
            this.goals_conceded_min_21_to_30 = goalsConcededMin21To30;
            this.goals_conceded_min_31_to_40 = goalsConcededMin31To40;
            //281-290
            this.goals_conceded_min_41_to_50 = goalsConcededMin41To50;
            this.goals_conceded_min_51_to_60 = goalsConcededMin51To60;
            this.goals_conceded_min_61_to_70 = goalsConcededMin61To70;
            this.goals_conceded_min_71_to_80 = goalsConcededMin71To80;
            this.goals_conceded_min_81_to_A2890 = goalsConcededMin81ToA2890;
            this.draw_percentage_overall = drawPercentageOverall;
            this.draw_percentage_home = drawPercentageHome;
            this.draw_percentage_away = drawPercentageAway;
            this.loss_percentage_overall = lossPercentageOverall;
            this.loss_percentage_home = lossPercentageHome;
            //291-300
            this.loss_percentage_away = lossPercentageAway;
            this.over145_corners_percentage = over145CornersPercentage;

            **/
        }

        public bool igualQue(object equipo)
        {
            clsEquipo lMiEstudiante = (clsEquipo)equipo;
            if (team_name.CompareTo(lMiEstudiante.team_name) == 0)// && birthday.CompareTo(lMiEstudiante.birthday) == 0)
                return true;
            else
                return false;
        }

        public bool menorQue(object equipo)
        {
            clsEquipo lMiEstudiante = (clsEquipo)equipo;
            if (team_name.CompareTo(lMiEstudiante.team_name) < 0)// && birthday.CompareTo(lMiEstudiante.birthday) < 0)
                return true;
            else
                return false;
        }

        public bool menorIgualQue(object equipo)
        {
            clsEquipo lMiEstudiante = (clsEquipo)equipo;
            if (team_name.CompareTo(lMiEstudiante.team_name) <= 0)// && birthday.CompareTo(lMiEstudiante.birthday) <= 0)
                return true;
            else
                return false;
        }

        public bool mayorQue(object equipo)
        {
            clsEquipo lMiEstudiante = (clsEquipo)equipo;
            if (team_name.CompareTo(lMiEstudiante.team_name) > 0)//&& birthday.CompareTo(lMiEstudiante.birthday) > 0)
                return true;
            else
                return false;
        }

        public bool mayorIgualQue(object equipo)
        {
            clsEquipo lMiEstudiante = (clsEquipo)equipo;
            if (team_name.CompareTo(lMiEstudiante.team_name) >= 0)//&& birthday.CompareTo(lMiEstudiante.birthday) >= 0)
                return true;
            else
                return false;
        }

        public override string ToString()
        {
            return "(Nombre: " + team_name + " Club: " + common_name + ")";
        }
    }
}
