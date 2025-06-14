namespace Interpreter
{
    public interface IExpression
    {
        // Проверка соответствия выражению
        bool Interpret(string context);
    }
}
