using EstructurasDatosPG3CS.ArbolesBinarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WfmEstadisticasFutbolPG3
{
    public class clsJugador : clsComparador
    {
        //1-10
        public string full_name { get; set; }
        public int age { get; set; }
        public string birthday { get; set; }
        public string birthday_GMT { get; set; }
        public string league { get; set; }
        public string season { get; set; }
        public string position { get; set; }
        public string current_club { get; set; }
        public int minutes_played_overall { get; set; }
        public int minutes_played_home { get; set; }
        //11-20
        
        public int minutes_played_away { get; set; }
        /**
        public string nationality { get; set; }
        public int appearances_overall { get; set; }
        public int appearances_home { get; set; }
        public int appearances_away { get; set; }
        */
        public int goals_overall { get; set; }//16
        /*
        public int goals_home { get; set; }
        public int goals_away { get; set; }
        */
        public int assists_overall { get; set; }//19
        /*
        public int assists_home { get; set; }
        //21-30
        public int assists_away { get; set; }
        */
        public int penalty_goals { get; set; }//22
        /*
        public int penalty_misses { get; set; }
        public int clean_sheets_overall { get; set; }
        public int clean_sheets_home { get; set; }
        public int clean_sheets_away { get; set; }
        public int conceded_overall { get; set; }
        public int conceded_home { get; set; }
        public int conceded_away { get; set; }
        */
        public int yellow_cards_overall { get; set; }//30
        //31-40
        public int red_cards_overall { get; set; }//31
        /*
        public float goals_involved_per_90_overall { get; set; }
        public float assists_per_90_overall { get; set; }
        public float goals_per_90_overall { get; set; }
        public float goals_per_90_home { get; set; }
        public float goals_per_90_away { get; set; }
        public float min_per_goal_overall { get; set; }
        public float conceded_per_90_overall { get; set; }
        public float min_per_conceded_overall { get; set; }
        public float min_per_match { get; set; }

        //41-50
        public float min_per_card_overall { get; set; }
        public float min_per_assist_overall { get; set; }
        public float cards_per_90_overall { get; set; }
        public int rank_in_league_top_attackers { get; set; }
        public int rank_in_league_top_midfielders { get; set; }
        public int rank_in_league_top_defenders { get; set; }
        public int rank_in_club_top_scorer { get; set; }
        public float average_rating_overall { get; set; }
        public float assists_per_game_overall { get; set; }
        public int sm_assists_total_overall { get; set; }
        //51-60
        public float assists_per90_percentile_overall { get; set; }
        public float passes_per_90_overall { get; set; }
        public float passes_per_game_overall { get; set; }
        public float passes_per90_percentile_overall { get; set; }
        public int passes_total_overall { get; set; }
        public float passes_completed_per_game_overall { get; set; }
        public int passes_completed_total_overall { get; set; }
        public float pass_completion_rate_percentile_overall { get; set; }
        public float passes_completed_per_90_overall { get; set; }
        public float passes_completed_per90_percentile_overall { get; set; }
        //61-70
        public float short_passes_per_game_overall { get; set; }
        public float long_passes_per_game_overall { get; set; }
        public float key_passes_per_game_overall { get; set; }
        public int key_passes_total_overall { get; set; }
        public float through_passes_per_game_overall { get; set; }
        public float crosses_per_game_overall { get; set; }
        public float tackles_per_90_overall { get; set; }
        public float tackles_per_game_overall { get; set; }
        public int tackles_total_overall { get; set; }
        public float tackles_successful_per_game_overall { get; set; }

        //71-80
        public float dispossesed_per_game_overall { get; set; }
        public float possession_regained_per_game_overall { get; set; }
        public float pressures_per_game_overall { get; set; }
        public float saves_per_game_overall { get; set; }
        public float interceptions_per_game_overall { get; set; }
        public float dribbles_successful_per_game_overall { get; set; }
        public float shots_faced_per_game_overall { get; set; }
        public float shots_per_goal_scored_overall { get; set; }
        public float shots_per_90_overall { get; set; }
        public float shots_off_target_per_game_overall { get; set; }
        //81-90
        public float dribbles_per_game_overall { get; set; }
        public float distance_travelled_per_game_overall { get; set; }
        public float shots_on_target_per_game_overall { get; set; }
        public float xg_per_game_overall { get; set; }
        public float chances_created_per_game_overall { get; set; }
        public float aerial_duels_won_per_game_overall { get; set; }
        public float aerial_duels_per_game_overall { get; set; }
        public float possession_regained_per_90_overall { get; set; }
        public int possession_regained_total_overall { get; set; }
        public float possession_regained_per90_percentile_overall { get; set; }
        //91-100
        public string additional_info { get; set; }
        */
        public int shots_total_overall { get; set; }//92
        /*
        public float shots_per_game_overall { get; set; }
        public float shots_per90_percentile_overall { get; set; }
        public int shots_on_target_total_overall { get; set; }
        public float shots_on_target_per_90_overall { get; set; }
        public float shots_on_target_per90_percentile_overall { get; set; }
        public int shots_off_target_total_overall { get; set; }
        public float shots_off_target_per_90_overall { get; set; }
        public float shots_off_target_per90_percentile_overall { get; set; }
        //101-110
        public int games_subbed_out { get; set; }
        public int games_subbed_in { get; set; }
        public int games_started { get; set; }
        public float tackles_per90_percentile_overall { get; set; }
        public float tackles_successful_per_90_overall { get; set; }
        public float tackles_successful_per90_percentile_overall { get; set; }
        public int tackles_successful_total_overall { get; set; }
        public int interceptions_total_overall { get; set; }
        public float interceptions_per_90_overall { get; set; }
        public float interceptions_per90_percentile_overall { get; set; }

        //111-120
        public int crosses_total_overall { get; set; }
        public float cross_completion_rate_percentile_overall { get; set; }
        public float crosses_per_90_overall { get; set; }
        public float crosses_per90_percentile_overall { get; set; }
        public int through_passes_total_overall { get; set; }
        public float through_passes_per_90_overall { get; set; }
        public float through_passes_per90_percentile_overall { get; set; }
        public int long_passes_total_overall { get; set; }
        public float long_passes_per_90_overall { get; set; }
        public float long_passes_per90_percentile_overall { get; set; }
        */
        //121-130
        public int short_passes_total_overall { get; set; }//121
        /*
        public float short_passes_per_90_overall { get; set; }
        public float short_passes_per90_percentile_overall { get; set; }
        public float key_passes_per_90_overall { get; set; }
        public float key_passes_per90_percentile_overall { get; set; }
        public int dribbles_total_overall { get; set; }
        public float dribbles_per_90_overall { get; set; }
        public float dribbles_per90_percentile_overall { get; set; }
        */
        public int dribbles_successful_total_overall { get; set; }//129
        /*
        public float dribbles_successful_per_90_overall { get; set; }

        //131-140
        public float dribbles_successful_percentage_overall { get; set; }
        public int chances_created_total_overall { get; set; }
        public float chances_created_per_90_overall { get; set; }
        public float chances_created_per90_percentile_overall { get; set; }
        public int saves_total_overall { get; set; }
        public float save_percentage_percentile_overall { get; set; }
        public float saves_per_90_overall { get; set; }
        public float saves_per90_percentile_overall { get; set; }
        public int shots_faced_total_overall { get; set; }
        public float shots_per_goal_conceded_overall { get; set; }

        //141-150
        public int sm_goals_conceded_total_overall { get; set; }
        public float conceded_per90_percentile_overall { get; set; }
        public float shots_faced_per_90_overall { get; set; }
        public float shots_faced_per90_percentile_overall { get; set; }
        public float xg_faced_per_90_overall { get; set; }
        public float xg_faced_per90_percentile_overall { get; set; }
        public float xg_faced_per_game_overall { get; set; }
        public float xg_faced_total_overall { get; set; }
        public float save_percentage_overall { get; set; }
        public int pressures_total_overall { get; set; }

        //151-160
        public float pressures_per_90_overall { get; set; }
        public float pressures_per90_percentile_overall { get; set; }
        public float xg_total_overall { get; set; }
        public float market_value { get; set; }
        public float market_value_percentile { get; set; }
        */
        public float pass_completion_rate_overall { get; set; }//156
        /*
        public float shot_accuraccy_percentage_overall { get; set; }
        public float shot_accuraccy_percentage_percentile_overall { get; set; }
        public int sm_goals_scored_total_overall { get; set; }
        public float dribbled_past_per90_percentile_overall { get; set; }
        //161-170
        public float dribbled_past_per_game_overall { get; set; }
        public float dribbled_past_per_90_overall { get; set; }
        public int dribbled_past_total_overall { get; set; }
        public float dribbles_successful_per90_percentile_overall { get; set; }
        public float dribbles_successful_percentage_percentile_overall { get; set; }
        public int pen_scored_total_overall { get; set; }
        public int pen_missed_total_overall { get; set; }
        public int inside_box_saves_total_overall { get; set; }
        public float blocks_per_game_overall { get; set; }
        public float blocks_per_90_overall { get; set; }

        //171-180
        public int blocks_total_overall { get; set; }
        public float blocks_per90_percentile_overall { get; set; }
        public int ratings_total_overall { get; set; }
        public float clearances_per_game_overall { get; set; }
        public float clearances_per_90_overall { get; set; }
        public int clearances_total_overall { get; set; }
        public int pen_committed_total_overall { get; set; }
        public float pen_save_percentage_overall { get; set; }
        public float pen_committed_per_90_overall { get; set; }
        public float pen_committed_per90_percentile_overall { get; set; }
        //181-190
        public float pen_committed_per_game_overall { get; set; }
        public int pens_saved_total_overall { get; set; }
        public int pens_taken_total_overall { get; set; }
        public int hit_woodwork_total_overall { get; set; }
        public float hit_woodwork_per_game_overall { get; set; }
        public float hit_woodwork_per_90_overall { get; set; }
        public int punches_total_overall { get; set; }
        public float punches_per_game_overall { get; set; }
        public float punches_per_90_overall { get; set; }
        public float offsides_per_90_overall { get; set; }

        //191-200
        public float offsides_per_game_overall { get; set; }
        public int offsides_total_overall { get; set; }
        public int penalties_won_total_overall { get; set; }
        public float shot_conversion_rate_overall { get; set; }
        public float shot_conversion_rate_percentile_overall { get; set; }
        public float sm_minutes_played_per90_percentile_overall { get; set; }
        public int sm_minutes_played_recorded_overall { get; set; }
        public float minutes_played_percentile_overall { get; set; }
        public float matches_played_percentile_overall { get; set; }
        public float min_per_goal_percentile_overall { get; set; }
        //201-210
        public float min_per_conceded_percentile_overall { get; set; }
        public float xa_total_overall { get; set; }
        public float xa_per90_percentile_overall { get; set; }
        public float xa_per_game_overall { get; set; }
        public float xa_per_90_overall { get; set; }
        public float npxg_total_overall { get; set; }
        public float npxg_per90_percentile_overall { get; set; }
        public float npxg_per_game_overall { get; set; }
        public float npxg_per_90_overall { get; set; }
        public float fouls_drawn_per90_percentile_overall { get; set; }

        //211-220
        public int fouls_drawn_total_overall { get; set; }
        public float fouls_drawn_per_game_overall { get; set; }
        public float fouls_drawn_per_90_overall { get; set; }
        public float fouls_committed_per_90_overall { get; set; }
        public float fouls_committed_per_game_overall { get; set; }
        public float fouls_committed_per90_percentile_overall { get; set; }
        public int fouls_committed_total_overall { get; set; }
        public float xg_per_90_overall { get; set; }
        public float xg_per90_percentile_overall { get; set; }
        public float average_rating_percentile_overall { get; set; }
        //221-230
        public float clearances_per90_percentile_overall { get; set; }
        public float hit_woodwork_per90_percentile_overall { get; set; }
        public float punches_per90_percentile_overall { get; set; }
        public float offsides_per90_percentile_overall { get; set; }
        public float aerial_duels_won_per90_percentile_overall { get; set; }
        public int aerial_duels_total_overall { get; set; }
        public float aerial_duels_per_90_overall { get; set; }
        public float aerial_duels_per90_percentile_overall { get; set; }
        public int aerial_duels_won_total_overall { get; set; }
        public float aerial_duels_won_percentage_overall { get; set; }

        //231-240
        public float aerial_duels_won_per_90_overall { get; set; }
        public float duels_per_90_overall { get; set; }
        public float duels_per_game_overall { get; set; }
        public int duels_total_overall { get; set; }
        public int duels_won_total_overall { get; set; }
        public float duels_won_per90_percentile_overall { get; set; }
        public float duels_per90_percentile_overall { get; set; }
        public float duels_won_per_90_overall { get; set; }
        public float duels_won_per_game_overall { get; set; }
        public float duels_won_percentage_overall { get; set; }
        //241-250
        public int dispossesed_total_overall { get; set; }
        public float dispossesed_per_90_overall { get; set; }
        public float dispossesed_per90_percentile_overall { get; set; }
        public int progressive_passes_total_overall { get; set; }
        public float cross_completion_rate_overall { get; set; }
        public float distance_travelled_total_overall { get; set; }
        public float distance_travelled_per_90_overall { get; set; }
        public float distance_travelled_per90_percentile_overall { get; set; }
        public int accurate_crosses_total_overall { get; set; }
        public float accurate_crosses_per_game_overall { get; set; }

        //251-260
        public float accurate_crosses_per_90_overall { get; set; }
        public float accurate_crosses_per90_percentile_overall { get; set; }
        public int sm_matches_recorded_total_overall { get; set; }
        public float games_started_percentile_overall { get; set; }
        public float games_subbed_in_percentile_overall { get; set; }
        public float games_subbed_out_percentile_overall { get; set; }
        public int hattricks_total_overall { get; set; }
        public int two_goals_in_a_game_total_overall { get; set; }
        public int three_goals_in_a_game_total_overall { get; set; }
        public float two_goals_in_a_game_percentage_overall { get; set; }
        //261-270
        public float three_goals_in_a_game_percentage_overall { get; set; }
        public float goals_involved_per90_percentile_overall { get; set; }
        public float goals_per90_percentile_overall { get; set; }
        public float goals_per90_percentile_away { get; set; }
        public float goals_per90_percentile_home { get; set; }
        public int man_of_the_match_total_overall { get; set; }
        public float annual_salary_eur { get; set; }
        public float annual_salary_eur_percentile { get; set; }
        public float clean_sheets_percentage_percentile_overall { get; set; }
        public float min_per_card_percentile_overall { get; set; }

        //271-287
        public float cards_per90_percentile_overall { get; set; }
        public int booked_over05_overall { get; set; }
        public float booked_over05_percentage_overall { get; set; }
        public float booked_over05_percentage_percentile_overall { get; set; }
        public int shirt_number { get; set; }
        public float annual_salary_gbp { get; set; }
        public float annual_salary_usd { get; set; }
        */

        //Constructor
        public clsJugador(string fullName, int age, string birthday, string birthdayGMT, string league, string season, string position, string currentClub, int minutesPlayedOverall, int minutesPlayedHome,
                          int minutesPlayedAway/**, string nationality, int appearancesOverall, int appearancesHome, int appearancesAway*/, int goalsOverall/*, int goalsHome, int goalsAway*/, int assistsOverall/*, int assistsHome,
                          int assistsAway*/, int penaltyGoals/*, int penaltyMisses, int cleanSheetsOverall, int cleanSheetsHome, int cleanSheetsAway, int concededOverall, int concededHome, int concededAway*/, int yellowCardsOverall,
                          int redCardsOverall/*, float goalsInvolvedPer90Overall, float assistsPer90Overall, float goalsPer90Overall, float goalsPer90Home, float goalsPer90Away, float minPerGoalOverall, float concededPer90Overall, float minPerConcededOverall, float minPerMatch,
                          float minPerCardOverall, float minPerAssistOverall, float cardsPer90Overall, int rankInLeagueTopAttackers, int rankInLeagueTopMidfielders, int rankInLeagueTopDefenders, int rankInClubTopScorer, float averageRatingOverall, float assistsPerGameOverall, int smAssistsTotalOverall,
                          float assistsPer90PercentileOverall, float passesPer90Overall, float passesPerGameOverall, float passesPer90PercentileOverall, int passesTotalOverall, float passesCompletedPerGameOverall, int passesCompletedTotalOverall, float passCompletionRatePercentileOverall, float passesCompletedPer90Overall, float passesCompletedPer90PercentileOverall,
                          float shortPassesPerGameOverall, float longPassesPerGameOverall, float keyPassesPerGameOverall, int keyPassesTotalOverall, float throughPassesPerGameOverall, float crossesPerGameOverall, float tacklesPer90Overall, float tacklesPerGameOverall, int tacklesTotalOverall, float tacklesSuccessfulPerGameOverall,
                          float dispossesedPerGameOverall, float possessionRegainedPerGameOverall, float pressuresPerGameOverall, float savesPerGameOverall, float interceptionsPerGameOverall, float dribblesSuccessfulPerGameOverall, float shotsFacedPerGameOverall, float shotsPerGoalScoredOverall, float shotsPer90Overall, float shotsOffTargetPerGameOverall,
                          float dribblesPerGameOverall, float distanceTravelledPerGameOverall, float shotsOnTargetPerGameOverall, float xgPerGameOverall, float chancesCreatedPerGameOverall, float aerialDuelsWonPerGameOverall, float aerialDuelsPerGameOverall, float possessionRegainedPer90Overall, int possessionRegainedTotalOverall, float possessionRegainedPer90PercentileOverall,
                          string additionalInfo*/, int shotsTotalOverall/*, float shotsPerGameOverall, float shotsPer90PercentileOverall, int shotsOnTargetTotalOverall, float shotsOnTargetPer90Overall, float shotsOnTargetPer90PercentileOverall, int shotsOffTargetTotalOverall, float shotsOffTargetPer90Overall, float shotsOffTargetPer90PercentileOverall,
                          int gamesSubbedOut, int gamesSubbedIn, int gamesStarted, float tacklesPer90PercentileOverall, float tacklesSuccessfulPer90Overall, float tacklesSuccessfulPer90PercentileOverall, int tacklesSuccessfulTotalOverall, int interceptionsTotalOverall, float interceptionsPer90Overall, float interceptionsPer90PercentileOverall,
                          int crossesTotalOverall, float crossCompletionRatePercentileOverall, float crossesPer90Overall, float crossesPer90PercentileOverall, int throughPassesTotalOverall, float throughPassesPer90Overall, float throughPassesPer90PercentileOverall, int longPassesTotalOverall, float longPassesPer90Overall, float longPassesPer90PercentileOverall*/,
                          int shortPassesTotalOverall/*, float shortPassesPer90Overall, float shortPassesPer90PercentileOverall, float keyPassesPer90Overall, float keyPassesPer90PercentileOverall, int dribblesTotalOverall, float dribblesPer90Overall, float dribblesPer90PercentileOverall*/, int dribblesSuccessfulTotalOverall/*, float dribblesSuccessfulPer90Overall,
                          float dribblesSuccessfulPercentageOverall, int chancesCreatedTotalOverall, float chancesCreatedPer90Overall, float chancesCreatedPer90PercentileOverall, int savesTotalOverall, float savePercentagePercentileOverall, float savesPer90Overall, float savesPer90PercentileOverall, int shotsFacedTotalOverall, float shotsPerGoalConcededOverall,
                          int smGoalsConcededTotalOverall, float concededPer90PercentileOverall, float shotsFacedPer90Overall, float shotsFacedPer90PercentileOverall, float xgFacedPer90Overall, float xgFacedPer90PercentileOverall, float xgFacedPerGameOverall, float xgFacedTotalOverall, float savePercentageOverall, int pressuresTotalOverall,
                          float pressuresPer90Overall, float pressuresPer90PercentileOverall, float xgTotalOverall, float marketValue, float marketValuePercentile*/, float passCompletionRateOverall/*, float shotAccuracyPercentageOverall, float shotAccuracyPercentagePercentileOverall, int smGoalsScoredTotalOverall, float dribbledPastPer90PercentileOverall,
                          float dribbledPastPerGameOverall, float dribbledPastPer90Overall, int dribbledPastTotalOverall, float dribblesSuccessfulPer90PercentileOverall, float dribblesSuccessfulPercentagePercentileOverall, int penScoredTotalOverall, int penMissedTotalOverall, int insideBoxSavesTotalOverall, float blocksPerGameOverall, float blocksPer90Overall, 
                          int blocksTotalOverall, float blocksPer90PercentileOverall, int ratingsTotalOverall, float clearancesPerGameOverall, float clearancesPer90Overall, int clearancesTotalOverall, int penCommittedTotalOverall, float penSavePercentageOverall, float penCommittedPer90Overall, float penCommittedPer90PercentileOverall,
                          float penCommittedPerGameOverall, int pensSavedTotalOverall, int pensTakenTotalOverall, int hitWoodworkTotalOverall, float hitWoodworkPerGameOverall, float hitWoodworkPer90Overall, int punchesTotalOverall, float punchesPerGameOverall, float punchesPer90Overall, float offsidesPer90Overall,
                          float offsidesPerGameOverall, int offsidesTotalOverall, int penaltiesWonTotalOverall, float shotConversionRateOverall, float shotConversionRatePercentileOverall, float smMinutesPlayedPer90PercentileOverall, int smMinutesPlayedRecordedOverall, float minutesPlayedPercentileOverall, float matchesPlayedPercentileOverall, float minPerGoalPercentileOverall,
                          float minPerConcededPercentileOverall, float xaTotalOverall, float xaPer90PercentileOverall, float xaPerGameOverall, float xaPer90Overall, float npxgTotalOverall, float npxgPer90PercentileOverall, float npxgPerGameOverall, float npxgPer90Overall, float foulsDrawnPer90PercentileOverall,
                          int foulsDrawnTotalOverall, float foulsDrawnPerGameOverall, float foulsDrawnPer90Overall, float foulsCommittedPer90Overall, float foulsCommittedPerGameOverall, float foulsCommittedPer90PercentileOverall, int foulsCommittedTotalOverall, float xgPer90Overall, float xgPer90PercentileOverall, float averageRatingPercentileOverall,
                          float clearancesPer90PercentileOverall, float hitWoodworkPer90PercentileOverall, float punchesPer90PercentileOverall, float offsidesPer90PercentileOverall, float aerialDuelsWonPer90PercentileOverall, int aerialDuelsTotalOverall, float aerialDuelsPer90Overall, float aerialDuelsPer90PercentileOverall, int aerialDuelsWonTotalOverall, float aerialDuelsWonPercentageOverall,
                          float aerialDuelsWonPer90Overall, float duelsPer90Overall, float duelsPerGameOverall, int duelsTotalOverall, int duelsWonTotalOverall, float duelsWonPer90PercentileOverall, float duelsPer90PercentileOverall, float duelsWonPer90Overall, float duelsWonPerGameOverall, float duelsWonPercentageOverall,
                          int dispossesedTotalOverall, float dispossesedPer90Overall, float dispossesedPer90PercentileOverall, int progressivePassesTotalOverall, float crossCompletionRateOverall, float distanceTravelledTotalOverall, float distanceTravelledPer90Overall, float distanceTravelledPer90PercentileOverall, int accurateCrossesTotalOverall, float accurateCrossesPerGameOverall,
                          float accurateCrossesPer90Overall, float accurateCrossesPer90PercentileOverall, int smMatchesRecordedTotalOverall, float gamesStartedPercentileOverall, float gamesSubbedInPercentileOverall, float gamesSubbedOutPercentileOverall, int hattricksTotalOverall, int twoGoalsInAGameTotalOverall, int threeGoalsInAGameTotalOverall, float twoGoalsInAGamePercentageOverall,
                          float threeGoalsInAGamePercentageOverall, float goalsInvolvedPer90PercentileOverall, float goalsPer90PercentileOverall, float goalsPer90PercentileAway, float goalsPer90PercentileHome, int manOfTheMatchTotalOverall, float annualSalaryEur, float annualSalaryEurPercentile, float cleanSheetsPercentagePercentileOverall, float minPerCardPercentileOverall, 
                          float cardsPer90PercentileOverall, int bookedOver05Overall, float bookedOver05PercentageOverall, float bookedOver05PercentagePercentileOverall, int shirtNumber, float annualSalaryGbp, float annualSalaryUsd **/)
        {
            //1-10
            this.full_name = fullName;
            this.age = age;
            this.birthday = birthday;
            this.birthday_GMT = birthdayGMT;
            this.league = league;
            this.season = season;
            this.position = position;
            this.current_club = currentClub;
            this.minutes_played_overall = minutesPlayedOverall;
            this.minutes_played_home = minutesPlayedHome;
            //11-20
            
            this.minutes_played_away = minutesPlayedAway;
            /**
            this.nationality = nationality;
            this.appearances_overall = appearancesOverall;
            this.appearances_home = appearancesHome;
            this.appearances_away = appearancesAway;
            */
            this.goals_overall = goalsOverall;//16
            /*
            this.goals_home = goalsHome;
            this.goals_away = goalsAway;
            */
            this.assists_overall = assistsOverall;//19
            /*
            this.assists_home = assistsHome;
            //21-30
            this.assists_away = assistsAway;
            */
            this.penalty_goals = penaltyGoals;//22
            /*
            this.penalty_misses = penaltyMisses;
            this.clean_sheets_overall = cleanSheetsOverall;
            this.clean_sheets_home = cleanSheetsHome;
            this.clean_sheets_away = cleanSheetsAway;
            this.conceded_overall = concededOverall;
            this.conceded_home = concededHome;
            this.conceded_away = concededAway;
            */
            this.yellow_cards_overall = yellowCardsOverall;//30
            //31-40
            this.red_cards_overall = redCardsOverall;//31
            /*
            this.goals_involved_per_90_overall = goalsInvolvedPer90Overall;
            this.assists_per_90_overall = assistsPer90Overall;
            this.goals_per_90_overall = goalsPer90Overall;
            this.goals_per_90_home = goalsPer90Home;
            this.goals_per_90_away = goalsPer90Away;
            this.min_per_goal_overall = minPerGoalOverall;
            this.conceded_per_90_overall = concededPer90Overall;
            this.min_per_conceded_overall = minPerConcededOverall;
            this.min_per_match = minPerMatch;
            //41-50
            this.min_per_card_overall = minPerCardOverall;
            this.min_per_assist_overall = minPerAssistOverall;
            this.cards_per_90_overall = cardsPer90Overall;
            this.rank_in_league_top_attackers = rankInLeagueTopAttackers;
            this.rank_in_league_top_midfielders = rankInLeagueTopMidfielders;
            this.rank_in_league_top_defenders = rankInLeagueTopDefenders;
            this.rank_in_club_top_scorer = rankInClubTopScorer;
            this.average_rating_overall = averageRatingOverall;
            this.assists_per_game_overall = assistsPerGameOverall;
            this.sm_assists_total_overall = smAssistsTotalOverall;
            //51-60
            this.assists_per90_percentile_overall = assistsPer90PercentileOverall;
            this.passes_per_90_overall = passesPer90Overall;
            this.passes_per_game_overall = passesPerGameOverall;
            this.passes_per90_percentile_overall = passesPer90PercentileOverall;
            this.passes_total_overall = passesTotalOverall;
            this.passes_completed_per_game_overall = passesCompletedPerGameOverall;
            this.passes_completed_total_overall = passesCompletedTotalOverall;
            this.pass_completion_rate_percentile_overall = passCompletionRatePercentileOverall;
            this.passes_completed_per_90_overall = passesCompletedPer90Overall;
            this.passes_completed_per90_percentile_overall = passesCompletedPer90PercentileOverall;
            //61-70
            this.short_passes_per_game_overall = shortPassesPerGameOverall;
            this.long_passes_per_game_overall = longPassesPerGameOverall;
            this.key_passes_per_game_overall = keyPassesPerGameOverall;
            this.key_passes_total_overall = keyPassesTotalOverall;
            this.through_passes_per_game_overall = throughPassesPerGameOverall;
            this.crosses_per_game_overall = crossesPerGameOverall;
            this.tackles_per_90_overall = tacklesPer90Overall;
            this.tackles_per_game_overall = tacklesPerGameOverall;
            this.tackles_total_overall = tacklesTotalOverall;
            this.tackles_successful_per_game_overall = tacklesSuccessfulPerGameOverall;
            //71-80
            this.dispossesed_per_game_overall = dispossesedPerGameOverall;
            this.possession_regained_per_game_overall = possessionRegainedPerGameOverall;
            this.pressures_per_game_overall = pressuresPerGameOverall;
            this.saves_per_game_overall = savesPerGameOverall;
            this.interceptions_per_game_overall = interceptionsPerGameOverall;
            this.dribbles_successful_per_game_overall = dribblesSuccessfulPerGameOverall;
            this.shots_faced_per_game_overall = shotsFacedPerGameOverall;
            this.shots_per_goal_scored_overall = shotsPerGoalScoredOverall;
            this.shots_per_90_overall = shotsPer90Overall;
            this.shots_off_target_per_game_overall = shotsOffTargetPerGameOverall;
            //81-90
            this.dribbles_per_game_overall = dribblesPerGameOverall;
            this.distance_travelled_per_game_overall = distanceTravelledPerGameOverall;
            this.shots_on_target_per_game_overall = shotsOnTargetPerGameOverall;
            this.xg_per_game_overall = xgPerGameOverall;
            this.chances_created_per_game_overall = chancesCreatedPerGameOverall;
            this.aerial_duels_won_per_game_overall = aerialDuelsWonPerGameOverall;
            this.aerial_duels_per_game_overall = aerialDuelsPerGameOverall;
            this.possession_regained_per_90_overall = possessionRegainedPer90Overall;
            this.possession_regained_total_overall = possessionRegainedTotalOverall;
            this.possession_regained_per90_percentile_overall = possessionRegainedPer90PercentileOverall;
            //91-100
            this.additional_info = additionalInfo;
            */
            this.shots_total_overall = shotsTotalOverall;//92
            /*
            this.shots_per_game_overall = shotsPerGameOverall;
            this.shots_per90_percentile_overall = shotsPer90PercentileOverall;
            this.shots_on_target_total_overall = shotsOnTargetTotalOverall;
            this.shots_on_target_per_90_overall = shotsOnTargetPer90Overall;
            this.shots_on_target_per90_percentile_overall = shotsOnTargetPer90PercentileOverall;
            this.shots_off_target_total_overall = shotsOffTargetTotalOverall;
            this.shots_off_target_per_90_overall = shotsOffTargetPer90Overall;
            this.shots_off_target_per90_percentile_overall = shotsOffTargetPer90PercentileOverall;
            //101-110
            this.games_subbed_out = gamesSubbedOut;
            this.games_subbed_in = gamesSubbedIn;
            this.games_started = gamesStarted;
            this.tackles_per90_percentile_overall = tacklesPer90PercentileOverall;
            this.tackles_successful_per_90_overall = tacklesSuccessfulPer90Overall;
            this.tackles_successful_per90_percentile_overall = tacklesSuccessfulPer90PercentileOverall;
            this.tackles_successful_total_overall = tacklesSuccessfulTotalOverall;
            this.interceptions_total_overall = interceptionsTotalOverall;
            this.interceptions_per_90_overall = interceptionsPer90Overall;
            this.interceptions_per90_percentile_overall = interceptionsPer90PercentileOverall;
            //111-120
            this.crosses_total_overall = crossesTotalOverall;
            this.cross_completion_rate_percentile_overall = crossCompletionRatePercentileOverall;
            this.crosses_per_90_overall = crossesPer90Overall;
            this.crosses_per90_percentile_overall = crossesPer90PercentileOverall;
            this.through_passes_total_overall = throughPassesTotalOverall;
            this.through_passes_per_90_overall = throughPassesPer90Overall;
            this.through_passes_per90_percentile_overall = throughPassesPer90PercentileOverall;
            this.long_passes_total_overall = longPassesTotalOverall;
            this.long_passes_per_90_overall = longPassesPer90Overall;
            this.long_passes_per90_percentile_overall = longPassesPer90PercentileOverall;
            //121-130
            */
            this.short_passes_total_overall = shortPassesTotalOverall;//121
            /*
            this.short_passes_per_90_overall = shortPassesPer90Overall;
            this.short_passes_per90_percentile_overall = shortPassesPer90PercentileOverall;
            this.key_passes_per_90_overall = keyPassesPer90Overall;
            this.key_passes_per90_percentile_overall = keyPassesPer90PercentileOverall;
            this.dribbles_total_overall = dribblesTotalOverall;
            this.dribbles_per_90_overall = dribblesPer90Overall;
            this.dribbles_per90_percentile_overall = dribblesPer90PercentileOverall;
            */
            this.dribbles_successful_total_overall = dribblesSuccessfulTotalOverall;//129
            /*
            this.dribbles_successful_per_90_overall = dribblesSuccessfulPer90Overall;
            //131-140
            this.dribbles_successful_percentage_overall = dribblesSuccessfulPercentageOverall;
            this.chances_created_total_overall = chancesCreatedTotalOverall;
            this.chances_created_per_90_overall = chancesCreatedPer90Overall;
            this.chances_created_per90_percentile_overall = chancesCreatedPer90PercentileOverall;
            this.saves_total_overall = savesTotalOverall;
            this.save_percentage_percentile_overall = savePercentagePercentileOverall;
            this.saves_per_90_overall = savesPer90Overall;
            this.saves_per90_percentile_overall = savesPer90PercentileOverall;
            this.shots_faced_total_overall = shotsFacedTotalOverall;
            this.shots_per_goal_conceded_overall = shotsPerGoalConcededOverall;
            //141-150
            this.sm_goals_conceded_total_overall = smGoalsConcededTotalOverall;
            this.conceded_per90_percentile_overall = concededPer90PercentileOverall;
            this.shots_faced_per_90_overall = shotsFacedPer90Overall;
            this.shots_faced_per90_percentile_overall = shotsFacedPer90PercentileOverall;
            this.xg_faced_per_90_overall = xgFacedPer90Overall;
            this.xg_faced_per90_percentile_overall = xgFacedPer90PercentileOverall;
            this.xg_faced_per_game_overall = xgFacedPerGameOverall;
            this.xg_faced_total_overall = xgFacedTotalOverall;
            this.save_percentage_overall = savePercentageOverall;
            this.pressures_total_overall = pressuresTotalOverall;
            //151-160
            this.pressures_per_90_overall = pressuresPer90Overall;
            this.pressures_per90_percentile_overall = pressuresPer90PercentileOverall;
            this.xg_total_overall = xgTotalOverall;
            this.market_value = marketValue;
            this.market_value_percentile = marketValuePercentile;
            */
            this.pass_completion_rate_overall = passCompletionRateOverall;//156
            /*
            this.shot_accuraccy_percentage_overall = shotAccuracyPercentageOverall;
            this.shot_accuraccy_percentage_percentile_overall = shotAccuracyPercentagePercentileOverall;
            this.sm_goals_scored_total_overall = smGoalsScoredTotalOverall;
            this.dribbled_past_per90_percentile_overall = dribbledPastPer90PercentileOverall;
            //161-170
            this.dribbled_past_per_game_overall = dribbledPastPerGameOverall;
            this.dribbled_past_per_90_overall = dribbledPastPer90Overall;
            this.dribbled_past_total_overall = dribbledPastTotalOverall;
            this.dribbles_successful_per90_percentile_overall = dribblesSuccessfulPer90PercentileOverall;
            this.dribbles_successful_percentage_percentile_overall = dribblesSuccessfulPercentagePercentileOverall;
            this.pen_scored_total_overall = penScoredTotalOverall;
            this.pen_missed_total_overall = penMissedTotalOverall;
            this.inside_box_saves_total_overall = insideBoxSavesTotalOverall;
            this.blocks_per_game_overall = blocksPerGameOverall;
            this.blocks_per_90_overall = blocksPer90Overall;
            //171-180
            this.blocks_total_overall = blocksTotalOverall;
            this.blocks_per90_percentile_overall = blocksPer90PercentileOverall;
            this.ratings_total_overall = ratingsTotalOverall;
            this.clearances_per_game_overall = clearancesPerGameOverall;
            this.clearances_per_90_overall = clearancesPer90Overall;
            this.clearances_total_overall = clearancesTotalOverall;
            this.pen_committed_total_overall = penCommittedTotalOverall;
            this.pen_save_percentage_overall = penSavePercentageOverall;
            this.pen_committed_per_90_overall = penCommittedPer90Overall;
            this.pen_committed_per90_percentile_overall = penCommittedPer90PercentileOverall;
            //181-190
            this.pen_committed_per_game_overall = penCommittedPerGameOverall;
            this.pens_saved_total_overall = pensSavedTotalOverall;
            this.pens_taken_total_overall = pensTakenTotalOverall;
            this.hit_woodwork_total_overall = hitWoodworkTotalOverall;
            this.hit_woodwork_per_game_overall = hitWoodworkPerGameOverall;
            this.hit_woodwork_per_90_overall = hitWoodworkPer90Overall;
            this.punches_total_overall = punchesTotalOverall;
            this.punches_per_game_overall = punchesPerGameOverall;
            this.punches_per_90_overall = punchesPer90Overall;
            this.offsides_per_90_overall = offsidesPer90Overall;
            //191-200
            this.offsides_per_game_overall = offsidesPerGameOverall;
            this.offsides_total_overall = offsidesTotalOverall;
            this.penalties_won_total_overall = penaltiesWonTotalOverall;
            this.shot_conversion_rate_overall = shotConversionRateOverall;
            this.shot_conversion_rate_percentile_overall = shotConversionRatePercentileOverall;
            this.sm_minutes_played_per90_percentile_overall = smMinutesPlayedPer90PercentileOverall;
            this.sm_minutes_played_recorded_overall = smMinutesPlayedRecordedOverall;
            this.minutes_played_percentile_overall = minutesPlayedPercentileOverall;
            this.matches_played_percentile_overall = matchesPlayedPercentileOverall;
            this.min_per_goal_percentile_overall = minPerGoalPercentileOverall;
            //201-210
            this.min_per_conceded_percentile_overall = minPerConcededPercentileOverall;
            this.xa_total_overall = xaTotalOverall;
            this.xa_per90_percentile_overall = xaPer90PercentileOverall;
            this.xa_per_game_overall = xaPerGameOverall;
            this.xa_per_90_overall = xaPer90Overall;
            this.npxg_total_overall = npxgTotalOverall;
            this.npxg_per90_percentile_overall = npxgPer90PercentileOverall;
            this.npxg_per_game_overall = npxgPerGameOverall;
            this.npxg_per_90_overall = npxgPer90Overall;
            this.fouls_drawn_per90_percentile_overall = foulsDrawnPer90PercentileOverall;
            //211-220
            this.fouls_drawn_total_overall = foulsDrawnTotalOverall;
            this.fouls_drawn_per_game_overall = foulsDrawnPerGameOverall;
            this.fouls_drawn_per_90_overall = foulsDrawnPer90Overall;
            this.fouls_committed_per_90_overall = foulsCommittedPer90Overall;
            this.fouls_committed_per_game_overall = foulsCommittedPerGameOverall;
            this.fouls_committed_per90_percentile_overall = foulsCommittedPer90PercentileOverall;
            this.fouls_committed_total_overall = foulsCommittedTotalOverall;
            this.xg_per_90_overall = xgPer90Overall;
            this.xg_per90_percentile_overall = xgPer90PercentileOverall;
            this.average_rating_percentile_overall = averageRatingPercentileOverall;
            //221-230
            this.clearances_per90_percentile_overall = clearancesPer90PercentileOverall;
            this.hit_woodwork_per90_percentile_overall = hitWoodworkPer90PercentileOverall;
            this.punches_per90_percentile_overall = punchesPer90PercentileOverall;
            this.offsides_per90_percentile_overall = offsidesPer90PercentileOverall;
            this.aerial_duels_won_per90_percentile_overall = aerialDuelsWonPer90PercentileOverall;
            this.aerial_duels_total_overall = aerialDuelsTotalOverall;
            this.aerial_duels_per_90_overall = aerialDuelsPer90Overall;
            this.aerial_duels_per90_percentile_overall = aerialDuelsPer90PercentileOverall;
            this.aerial_duels_won_total_overall = aerialDuelsWonTotalOverall;
            this.aerial_duels_won_percentage_overall = aerialDuelsWonPercentageOverall;
            //231-240
            this.aerial_duels_won_per_90_overall = aerialDuelsWonPer90Overall;
            this.duels_per_90_overall = duelsPer90Overall;
            this.duels_per_game_overall = duelsPerGameOverall;
            this.duels_total_overall = duelsTotalOverall;
            this.duels_won_total_overall = duelsWonTotalOverall;
            this.duels_won_per90_percentile_overall = duelsWonPer90PercentileOverall;
            this.duels_per90_percentile_overall = duelsPer90PercentileOverall;
            this.duels_won_per_90_overall = duelsWonPer90Overall;
            this.duels_won_per_game_overall = duelsWonPerGameOverall;
            this.duels_won_percentage_overall = duelsWonPercentageOverall;
            //241-250
            this.dispossesed_total_overall = dispossesedTotalOverall;
            this.dispossesed_per_90_overall = dispossesedPer90Overall;
            this.dispossesed_per90_percentile_overall = dispossesedPer90PercentileOverall;
            this.progressive_passes_total_overall = progressivePassesTotalOverall;
            this.cross_completion_rate_overall = crossCompletionRateOverall;
            this.distance_travelled_total_overall = distanceTravelledTotalOverall;
            this.distance_travelled_per_90_overall = distanceTravelledPer90Overall;
            this.distance_travelled_per90_percentile_overall = distanceTravelledPer90PercentileOverall;
            this.accurate_crosses_total_overall = accurateCrossesTotalOverall;
            this.accurate_crosses_per_game_overall = accurateCrossesPerGameOverall;
            //251-260
            this.accurate_crosses_per_90_overall = accurateCrossesPer90Overall;
            this.accurate_crosses_per90_percentile_overall = accurateCrossesPer90PercentileOverall;
            this.sm_matches_recorded_total_overall = smMatchesRecordedTotalOverall;
            this.games_started_percentile_overall = gamesStartedPercentileOverall;
            this.games_subbed_in_percentile_overall = gamesSubbedInPercentileOverall;
            this.games_subbed_out_percentile_overall = gamesSubbedOutPercentileOverall;
            this.hattricks_total_overall = hattricksTotalOverall;
            this.two_goals_in_a_game_total_overall = twoGoalsInAGameTotalOverall;
            this.three_goals_in_a_game_total_overall = threeGoalsInAGameTotalOverall;
            this.two_goals_in_a_game_percentage_overall = twoGoalsInAGamePercentageOverall;
            //261-267
            this.three_goals_in_a_game_percentage_overall = threeGoalsInAGamePercentageOverall;
            this.goals_involved_per90_percentile_overall = goalsInvolvedPer90PercentileOverall;
            this.goals_per90_percentile_overall = goalsPer90PercentileOverall;
            this.goals_per90_percentile_away = goalsPer90PercentileAway;
            this.goals_per90_percentile_home = goalsPer90PercentileHome;
            this.man_of_the_match_total_overall = manOfTheMatchTotalOverall;
            this.annual_salary_eur = annualSalaryEur;
            this.annual_salary_eur_percentile = annualSalaryEurPercentile;
            this.clean_sheets_percentage_percentile_overall = cleanSheetsPercentagePercentileOverall;
            this.min_per_card_percentile_overall = minPerCardPercentileOverall;
            //271-280
            this.cards_per90_percentile_overall = cardsPer90PercentileOverall;
            this.booked_over05_overall = bookedOver05Overall;
            this.booked_over05_percentage_overall = bookedOver05PercentageOverall;
            this.booked_over05_percentage_percentile_overall = bookedOver05PercentagePercentileOverall;
            this.shirt_number = shirtNumber;
            this.annual_salary_gbp = annualSalaryGbp;
            this.annual_salary_usd = annualSalaryUsd;
            */
        }

        public bool igualQue(object nombre)
        {
            clsJugador lMiEstudiante = (clsJugador)nombre;
            if (full_name.CompareTo(lMiEstudiante.full_name) == 0)// && birthday.CompareTo(lMiEstudiante.birthday) == 0)
                return true;
            else
                return false;
        }

        public bool menorQue(object nombre)
        {
            clsJugador lMiEstudiante = (clsJugador)nombre;
            if (full_name.CompareTo(lMiEstudiante.full_name) < 0)// && birthday.CompareTo(lMiEstudiante.birthday) < 0)
                return true;
            else
                return false;
        }

        public bool menorIgualQue(object nombre)
        {
            clsJugador lMiEstudiante = (clsJugador)nombre;
            if (full_name.CompareTo(lMiEstudiante.full_name) <= 0)// && birthday.CompareTo(lMiEstudiante.birthday) <= 0)
                return true;
            else
                return false;
        }

        public bool mayorQue(object nombre)
        {
            clsJugador lMiEstudiante = (clsJugador)nombre;
            if (full_name.CompareTo(lMiEstudiante.full_name) > 0)//&& birthday.CompareTo(lMiEstudiante.birthday) > 0)
                return true;
            else
                return false;
        }

        public bool mayorIgualQue(object nombre)
        {
            clsJugador lMiEstudiante = (clsJugador)nombre;
            if (full_name.CompareTo(lMiEstudiante.full_name) >= 0)//&& birthday.CompareTo(lMiEstudiante.birthday) >= 0)
                return true;
            else
                return false;
        }

        public override string ToString()
        {
            return "(full_name: " + full_name +")";
        }
        /*
        public override string ToString()
        {
            return "(Nombre: " + full_name + " Nombre: " + age + "  Zona: " + league + " Total: " + season + ")";
        }*/
    }
}
