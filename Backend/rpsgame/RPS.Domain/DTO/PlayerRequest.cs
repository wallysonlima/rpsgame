namespace RPS.Domain.DTO
{
    using System.Collections.Generic;
    public class PlayerRequest{
        public PlayerRequest() {}
        public List<PlayerDTO> list {get; set;}
    }
}