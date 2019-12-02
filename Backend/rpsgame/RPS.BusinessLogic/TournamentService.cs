namespace RPS.BusinessLogic
{
    using System;
    using Domain.DTO;
    using Abstractions;
    using System.Linq;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Domain.Enums;

    public class TournamentService : ITournamentService
    {
        public PlayerDTO rps_tournament_winner(TournamentRequest req)
        {
            PlayerVsPlayerService pvp = new PlayerVsPlayerService();
            int level = 0;
            String temp;
            List<string> tempList = new List<string>();
            List<PlayerDTO> playerList = new List<PlayerDTO>();
            List<PlayerDTO> winnerList = new List<PlayerDTO>();
            List<PlayerDTO> tournamentList = new List<PlayerDTO>();

            string[] lines = System.IO.File.ReadAllLines(req.localPath);
            
            foreach(string line in lines)
            {
                if ( line[0] == '[' && line.Length == 1 )
                    level++;
                else if ( line[1] == ']' && line.Length == 2 && level > 0 )
                    level--;
                else
                {
                    for(int i = 0; i < line.Length; i++)
                    {
                        temp = "";

                        if ( line[i] == '"' )
                            while( line[++i] != '"' )
                                temp += line[i];

                        tempList.Add(temp);

                        if ( tempList.Count == 4 )
                        {
                            playerList.Add( new PlayerDTO(tempList[0], tempList[1]) );
                            playerList.Add( new PlayerDTO(tempList[1], tempList[2]) );
                            tournamentList.Add( pvp.rps_game_winner(playerList) );
                            tempList = new List<string>();
                            playerList = new List<PlayerDTO>();
                        }
                    }

                    if ( tournamentList.Count == 2 )
                    {
                        winnerList.Add( pvp.rps_game_winner(tournamentList) );
                        tournamentList = new List<PlayerDTO>();
                    }

                    if ( winnerList.Count == 2 )
                        return pvp.rps_game_winner(winnerList);

                    
                }
            }

            return null;
        }
    }
}