using System;
using ADSApi.DataStructures.Methods;
using System.Linq;
using ADSApi.DataStructures.Item;

namespace ADSApi.List
{
    public static class PosFixedConverter
    {
        private static Stack<string> OperatorsStack { set; get; }
        private static Queue<string> Result { set; get; }

        private static string[] Operators = { "+", "-", "*", "/", "(", ")"};

        private static bool IsOperator(string c)
        {
            return Operators.Contains(c);
        }

        private static void PushOperator(string op)
        {
            Item<string> currentOp = (Item<string>)OperatorsStack.Peek();
            while (OperatorsStack.Peek() != null && GetOperatorPriority(op) <
                GetOperatorPriority(currentOp.Value))
            {
                Item<string> opToInsert = (Item<string>)OperatorsStack.Pop();
                Result.Insert(opToInsert.Value);
            }
                
            OperatorsStack.Push(op);
        }

        private static int GetOperatorPriority(string op)
        {
            switch (op)
            {
                case ")":
                    return 0;
                case "+":
                case "-":
                    return 1;
                case "*":
                case "/":
                    return 2;
                case "(":
                    return 3;
                default:
                    throw new Exception("Invalid operator " + op.ToString());
            }
        }

        public static Queue<string> Convert(string Expression)
        {
            Result = new Queue<string>();
            OperatorsStack = new Stack<string>();

            string aux, number = "";

            for(int i = 0; i < Expression.Length; i++)
            {
                aux = Expression.ElementAt(i).ToString();
                if (IsOperator(aux))
                {
                    if (number != "")
                    {
                        Result.Insert(number);
                        number = "";
                    }
                    PushOperator(aux);
                }
                else
                    number += aux;      
            }

            if (number != "")
            {
                Result.Insert(number);
                number = "";
            }

            while ((aux = (string)OperatorsStack.Pop()) != null)
                Result.Insert(aux);

            return Result;
                
        }
    }
}
