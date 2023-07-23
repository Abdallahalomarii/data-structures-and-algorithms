namespace Challenge13_stack_queue_brackets
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(ValidateBrackets("()[[Extra Characters]]()"));
            Console.WriteLine(ValidateBrackets("{}")); // Output: True
            Console.WriteLine(ValidateBrackets("{}(){}")); // Output: True
            Console.WriteLine(ValidateBrackets("()[[Extra Characters]]")); // Output: True
            Console.WriteLine(ValidateBrackets("(){}[[]]")); // Output: True
            Console.WriteLine(ValidateBrackets("{}{Code}[Fellows](())")); // Output: True
            Console.WriteLine(ValidateBrackets("[({}]")); // Output: False
            Console.WriteLine(ValidateBrackets("(](")); // Output: False
            Console.WriteLine(ValidateBrackets("{(})")); // Output: False
            Console.WriteLine(ValidateBrackets(")")); // Output: False
            Console.WriteLine(ValidateBrackets("{")); // Output: False
            Console.WriteLine(ValidateBrackets("[}")); // Output: False
        }

        public static bool ValidateBrackets(string value)
        {
            Stack<char> stack = new Stack<char>();

            char[] bracketChar = value.ToCharArray();
            foreach (char item in bracketChar)
            {
                if (item == '[' || item == '{' || item == '(')
                {
                    stack.Push(item);
                }
                else if (item == ']' || item == '}' || item == ')')
                {
                    if (stack.Count == 0)
                    {
                        return false;
                    }

                    char open = stack.Pop();

                    if ((item == ')' && open != '(') || (item == ']' && open != '[') || (item == '}' && open != '{'))
                    {
                        return false;
                    }
                }
            }

            return stack.Count == 0;
        }
    }
}