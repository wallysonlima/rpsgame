namespace RPS.Abstractions
{
    public interface IPlayerVsPlayerService
    {
        Task<IEnumerable<PlayerDTO>> rps_game_winner(PlayerVsPlayerRequest req);
    }
}