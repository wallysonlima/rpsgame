namespace RPS.BusinessLogic
{
    using System;
    using Domain.DTO;
    using Abstractions;
    using System.Linq;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Domain.Enums;
    public class PlayerVsPlayerService : IPlayerVsPlayerService
    { 
        public const int NUMPLAYERS = 2;

        public PlayerVsPlayerService() {}
        
        public PlayerDTO rps_game_winner(List<PlayerDTO> playerList)
        {
            PlayerDTO playerOne, playerTwo;
            String wrongNumber = Enum.GetName(typeof(Errors), Errors.wrongNumberOfPlayersError);
            String noStrategy = Enum.GetName(typeof(Errors), Errors.noSuchStrategyError);
            int move1, move2;

            if ( playerList.Count != NUMPLAYERS)
                return (new PlayerDTO( wrongNumber, ""));
            
            else 
            {
                //playerOne = req.list.ElementAtOrDefault(0);
                //playerTwo = req.list.ElementAtOrDefault(1);
                playerOne = playerList[0];
                playerTwo = playerList[1];

                move1 = getStrategy(playerOne.move);
                move2 = getStrategy(playerTwo.move);

                if ( ((move1 != (int) Rules.R) && (move1 != (int) Rules.P) && (move1 != (int) Rules.S)) 
                    || ((move2 != (int) Rules.R) && (move2 != (int) Rules.P) && (move2 != (int) Rules.S)) )
                    return (new PlayerDTO( noStrategy , ""));
            
                else
                    return getWinner();
            }

            // Local Functions, help method
            int getStrategy(String move)
            {
                switch(move.ToUpper())
                {
                    case "R":
                        return (int) Rules.R;
                    case "P":
                        return (int) Rules.P;
                    case "S":
                        return (int) Rules.S;
                    default:
                        return -1;
                }
            }

            PlayerDTO getWinner()
            {
                if ( move1 == move2 )
                    return playerOne;

                if ( move1 == (int) Rules.R )
                    if ( move2 == (int) Rules.S )
                        return playerOne;
                    else
                        return playerTwo;
                else if( move1 == (int) Rules.P )
                    if( move2 == (int) Rules.R )
                        return playerOne;
                    else
                        return playerTwo;
                else if ( move2 == (int) Rules.P )
                    return playerOne;
                else
                    return playerTwo;
            }
        } 
    }
}