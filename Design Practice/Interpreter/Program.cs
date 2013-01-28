using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Interpreter.Contexts;
using Interpreter.Expressions;
using Interpreter.TerminalExpressions;

namespace Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {

            string roman = "MMCMXXVIII";
            Context context = new Context(roman);

            //Build the 'parse tree'
            List<Expression> tree = new List<Expression>();
            tree.Add(new ThousandExpression());
            tree.Add(new HundredExpression());
            tree.Add(new TenExpression());
            tree.Add(new OneExpression());

            //Interpret

            foreach (Expression expression in tree)
            {
                expression.Interpret(context);
            }

            Console.WriteLine("{0} = {1}",roman, context.Output);

            //wait for user input
            Console.ReadKey(true);
        }
    }
}
