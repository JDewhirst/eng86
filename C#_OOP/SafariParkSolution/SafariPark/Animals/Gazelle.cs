

namespace SafariPark
{
    public class Gazelle : Animal
    {
        public Gazelle() { }

        public Gazelle(int position, int speed = 10, string name = "Gazelle") : base(position, speed, name) {}

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
