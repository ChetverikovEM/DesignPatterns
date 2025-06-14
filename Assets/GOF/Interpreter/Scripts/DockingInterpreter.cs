using System.Collections.Generic;
using UnityEngine;

/*
 * Паттерн: Интерпретатор
 * Применение: описание грамматики языка команд стыковки и интерпретация
 * выражений этого языка. Позволяет просто расширять набор правил.
 * Плюсы: удобен для часто меняющихся или простых языков команд.
 */

namespace Interpreter
{
    public class DockingInterpreter : MonoBehaviour
    {
        // Создаем и применяем интерпретатор команд
        private void Start()
        {
            IExpression alpha = new TerminalExpression("ALPHA");
            IExpression beta = new TerminalExpression("BETA");
            IExpression command = new OrExpression(alpha, beta);
            Debug.Log(command.Interpret("DOCK ALPHA"));
        }
    }
}
