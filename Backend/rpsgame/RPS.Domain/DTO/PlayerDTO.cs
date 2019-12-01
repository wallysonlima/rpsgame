namespace class RPS.Domain.DTO
{
    public class PlayerDTO
    {
        public string name{get; set;}
        public string move{get; set;}

        public void PlayerDTO() {}

        public void PlayerDTO(string name, string move) {
            this.name = name;
            this.move = move;
        }
    }
}