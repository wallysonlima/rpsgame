using System.Collections.Generic;
using System.Threading.Tasks;

namespace RPS.Abstractions
{
    using System;
    using System.IO;
    using Microsoft.AspNetCore.Http;
    using RPS.Domain.DTO;
    public interface ITournamentService
    {
        public PlayerDTO rps_tournament_winner(TournamentRequest req);
    }
}