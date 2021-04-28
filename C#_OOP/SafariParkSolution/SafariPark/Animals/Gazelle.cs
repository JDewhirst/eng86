

namespace SafariPark.Animals
{
    public class Gazelle : Animal
    {
        public override string Move()
        {
            return "Gazelle is moving along.";
        }

        public override string Move(int times)
        {
            return $"Gazelle is moving along {times} times.";
        }
    }
}
