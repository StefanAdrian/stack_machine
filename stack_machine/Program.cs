using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack_machine
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            result = Solution("");
            Console.WriteLine(result);
        }

        static int Solution(string S)
        {
            Stack<int> st = new Stack<int>();

            if (S.Length != 0)
            {
                for (int i = 0; i < S.Length; i++)
                {
                    int temp = 0;
                    if (Char.IsDigit(S[i]))
                    {
                        st.Push((int)Char.GetNumericValue(S[i]));
                    }
                    else
                    {
                        switch (S[i])
                        {
                            case '+':
                                try
                                {
                                    temp = st.Pop() + st.Pop();
                                    st.Push(temp);
                                }
                                catch(InvalidOperationException ex)
                                {
                                    Console.WriteLine(ex.Message);
                                }
                                catch (OverflowException ex)
                                {
                                    Console.WriteLine(ex.Message);
                                }
                                break;
                            case '-':
                                try
                                {
                                    temp = st.Pop() - st.Pop();
                                    st.Push(temp);
                                }
                                catch (InvalidOperationException ex)
                                {
                                    Console.WriteLine(ex.Message);
                                }
                                break;
                            case '*':
                                try
                                {
                                    temp = st.Pop() * st.Pop();
                                    st.Push(temp);
                                }
                                catch (InvalidOperationException ex)
                                {
                                    Console.WriteLine(ex.Message);
                                }
                                catch (OverflowException ex)
                                {
                                    Console.WriteLine(ex.Message);
                                }
                                break;
                            case '/':
                                try
                                {
                                    temp = st.Pop() / st.Pop();
                                    st.Push(temp);
                                }
                                catch (InvalidOperationException ex)
                                {
                                    Console.WriteLine(ex.Message);
                                }
                                break;
                            default:
                                break;
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("The string is empty");
            }

            if (st.Count > 0)
            {
                return st.Peek();
            }
            else
            {
                return -1;
            }
        }
    }
}
