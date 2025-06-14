namespace Interpreter
{
    public class TerminalExpression : IExpression
    {
        // Храним ключевое слово
        private readonly string _data;

        // Передаем искомое значение
        public TerminalExpression(string data)
        {
            _data = data;
        }

        // Проверяем наличие ключевого слова
        public bool Interpret(string context)
        {
            return context.Contains(_data);
        }
    }
}
