namespace Task2.Models
{
    public interface ICreature
    {
        int Speed { get; }
        void Move();
        void Stand();
    }
}