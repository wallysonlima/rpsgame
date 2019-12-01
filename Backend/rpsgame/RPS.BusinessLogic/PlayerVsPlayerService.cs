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
        public Task<PlayerDTO> rps_game_winner(PlayerRequest req)
        {
            Rules rules;
            Errors errors;
            String move1, move2;
            
            move1 = move2 = "";
            move1 = req.list.ElementAtOrDefault(0).move.ToUpper();
            move2 = req.list.ElementAtOrDefault(1).move.ToUpper();

            if ( req.list.Count != NUMPLAYERS)
                return (new PlayerDTO( errors.wrongNumberOfPlyersError.ToDescriptionString() ,errors.wrongNumberOfPlyersError));
            
            else 
                if ( !move1.Contains(rules.rock) && !move1.Contains(rules.paper) && !move1.Contains(rules.scissors) 
                 || (!move2.Contains(rules.rock) && !move2.Contains(rules.paper) && !move2.Contains(rules.scissors)) )
                    return (new PlayerDTO( errors.noSuchStrategyError.ToDescriptionString(), errors.noSuchStrategyError));
            else
            {
 
            }
        } 

    }
}