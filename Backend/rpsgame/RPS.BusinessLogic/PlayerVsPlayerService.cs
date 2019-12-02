namespace RPS.BusinessLogic
{
    using System;
    using Domain.Enums;
    using Abstractions.IPlayerVsPlayerService;
    using System.Linq;
    using System.Collections.Generic;
    public class PlayerVsPlayerService : IPlayerVsPlayerService
    { 
        public const int NUMPLAYERS = 2;
        public const string ROCK = "0";
        public const string PAPER = "1";
        public const string SCISSORS = "2";

        public Task<PlayerDTO> rps_game_winner(PlayerRequest req)
        {
            Rules rules;
            Errors errors;
            PlayerDTO playerOne, playerTwo;
    
            if ( req.list.Count != NUMPLAYERS)
                return (new PlayerDTO( errors.wrongNumberOfPlyersError.ToDescriptionString() , errors.wrongNumberOfPlyersError));
            
            else 
            {
                playerOne = req.list.ElementAtOrDefault(0);
                playerTwo = req.list.ElementAtOrDefault(1);
                string move1 = getStrategy(playerOne.move);
                string move2 = getStrategy(playerTwo.move);

                if ( (!move1.Contains(rules.rock) && !move1.Contains(rules.paper) && !move1.Contains(rules.scissors)) 
                    || (!move2.Contains(rules.rock) && !move2.Contains(rules.paper) && !move2.Contains(rules.scissors)) )
                    return (new PlayerDTO( errors.noSuchStrategyError.ToDescriptionString() , errors.noSuchStrategyError));
            
                else
                    return getWinner();
            }

            // Local Function, help method
            string getStrategy(String move)
            {
                switch(move.ToUpper())
                {
                    case rules.rock.ToDescriptionString():
                        return ROCK;
                    case rules.paper.ToDescriptionString():
                        return PAPER;
                    case rules.scissors.ToDescription():
                        return SCISSORS;
                    case default:
                        return string.Empty();
                }
            }

            PlayerDTO getWinner()
            {
                if ( move1.Contains(move2) )
                    return playerOne;

                if ( move1.Contains(rules.rock) )
                    if ( move2.Contains(rules.scissors) )
                        return playerOne;
                    else
                        return playerTwo;
                else if( move1.Contains(rules.paper) )
                    if( move2.Contains(rules.rock) )
                        return playerOne;
                    else
                        return playerTwo;
                else if ( move2.Contains(rules.paper) )
                    return playerOne;
                else
                    return playerTwo;
            }
        } 
    }
}