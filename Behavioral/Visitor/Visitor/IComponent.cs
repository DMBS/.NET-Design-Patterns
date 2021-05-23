namespace Visitor
{
    public interface IComponent
    {
        // Интерфейс Компонента объявляет метод accept, который в качестве аргумента
        // может получать любой объект, реализующий интерфейс посетителя.
        void Accept(IVisitor visitor);
    }
}
