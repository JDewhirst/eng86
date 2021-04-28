

namespace SafariPark
{
    public abstract class Animal : IMoveable
    {
        public Animal() { }
        public abstract string Move();

        public abstract string Move(int times);
    }
}
