namespace Uaine.Objects.Primitives.Interface
{
    public interface IArithmetic<T>
    {
        T Add(T other);
        T Subtract(T other);
        T Multiply(T other);
        T Divide(T other);
    }

}
