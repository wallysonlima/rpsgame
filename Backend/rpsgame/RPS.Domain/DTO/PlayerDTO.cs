using System;

namespace RPS.Domain.DTO
{
    [Serializable]
    public class PlayerDTO
    {
        public string name{get; set;}
        public string move{get; set;}

        public PlayerDTO() {}

        public PlayerDTO(string name, string move) {
            this.name = name;
            this.move = move;
        }
    }
}