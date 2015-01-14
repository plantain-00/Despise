namespace Despise
{
    public interface IGenerator<out T>
    {
        T Generate();
        T[] GenerateMany(int number);
    }
}