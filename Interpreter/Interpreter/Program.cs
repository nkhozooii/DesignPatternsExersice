﻿using System;
using System.Collections.Generic;

namespace Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context();
            List<AbstractExpression> list = new List<AbstractExpression>();

            list.Add(new TerminalExpression());
            list.Add(new NonterminalExpression());
            list.Add(new TerminalExpression());
            list.Add(new TerminalExpression());
            list.Add(new NonterminalExpression());

            foreach (var item in list)
            {
                item.Interpret(context);
            }
            Console.ReadKey();
        }
    }

    public class Context
    {
    }


    public abstract class AbstractExpression
    {
        public abstract void Interpret(Context context);
    }

    public class TerminalExpression : AbstractExpression
    {
        public override void Interpret(Context context)
        {
            Console.WriteLine("Called Terminal.Interpret()");
        }
    }

    public class NonterminalExpression : AbstractExpression
    {
        public override void Interpret(Context context)
        {
            Console.WriteLine("Called Nonterminal.Interpret()");
        }
    }

}
