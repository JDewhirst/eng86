

namespace SafariPark
{
    public class Gazelle : Animal
    {
        public Gazelle() { }

        public Gazelle(int position, int speed = 18, int startle = 18, string name = "Gazelle") : base(position, speed, startle, name) {}

        public override string Move()
        {
            Position += Speed;
            return "Gazelle is moving along.";
        }

        public override string Move(int times)
        {
            Position += Speed * times;
            return $"Gazelle is moving along {times} times.";
        }


    }
}
