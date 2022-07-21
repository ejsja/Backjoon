using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjoon.Problem
{
    public class Bronze4
    {
        // 별 찍기 2
        public void Solve_2439()
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            {
                string str = sr.ReadLine();
                int num = 0;
                bool isSuccess = int.TryParse(str, out num);

                if (isSuccess)
                {
                    if (num > 0 && num < 101)
                    {
                        StringBuilder sb = new StringBuilder();

                        for (int i = 0; i < num; i++)
                        {
                            for (int j = num; j > i + 1; j--)
                            {
                                sb.Append(" ");
                            }

                            for (int j = 0; j < i + 1; j++)
                            {
                                sb.Append("*");
                            }
                            sb.AppendLine();
                        }

                        using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput()))
                        {
                            sw.WriteLine(sb);
                        }
                    }
                }
            }
        }

        // 주사위 세개
        public void Solve_2480()
        {
            string firstStr = Console.ReadLine();
            string[] arr = firstStr.Split(' ');
            int[] diceArr = new int[arr.Length];
            bool isOk = true;

            for (int i = 0; i < diceArr.Length; i++)
            {
                diceArr[i] = Convert.ToInt32(arr[i]);
                isOk &= (diceArr[i] > 0 && diceArr[i] < 7);
            }

            int equalCount = 0;

            if (isOk)
            {
                int selectedIndex = 0;
                int endIndex = arr.Length - 1;
                int number = 0;
                int checkCount = ((arr.Length) * (arr.Length - 1)) / 2;

                for (int i = selectedIndex + 1; i < endIndex + 1; i++)
                {
                    if (diceArr[selectedIndex] == diceArr[i])
                    {
                        equalCount++;
                        number = diceArr[selectedIndex];
                    }

                    if (i == endIndex && i != selectedIndex)
                    {
                        selectedIndex++;

                        if (selectedIndex == endIndex)
                        {
                            break;
                        }
                        else
                        {
                            i = selectedIndex;
                        }
                    }
                }

                int prize = 0;

                if (equalCount == checkCount)
                {
                    prize = number * 1000 + 10000;
                }
                else if (equalCount > 0)
                {
                    prize = number * 100 + 1000;
                }
                else if (equalCount == 0)
                {
                    prize = diceArr.Max() * 100;
                }
                else
                {
                    // Not Defined
                }

                Console.WriteLine(prize);
            }
        }

        // 기찍 N
        public void Solve_2742()
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            {
                string str = sr.ReadLine();
                int num = 0;
                bool isSuccess = int.TryParse(str, out num);

                if (isSuccess)
                {
                    if (num > 0 && num < 100_001)
                    {
                        StringBuilder sb = new StringBuilder();

                        for (int i = num; i > 0; i--)
                        {
                            sb.AppendLine(i.ToString());
                        }

                        using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput()))
                        {
                            sw.WriteLine(sb);
                        }
                    }
                }
            }
        }

        // 숫자의 합
        public void Solve_11720()
        {
            string firstStr = Console.ReadLine();
            string secondStr = Console.ReadLine();

            bool isSuccess = false;
            int numLength = 0;
            isSuccess = int.TryParse(firstStr, out numLength);

            if (isSuccess)
            {
                if (numLength == secondStr.Length)
                {
                    ulong sum = 0;
                    ulong temp = 0;

                    for (int i = 0; i < numLength; i++)
                    {
                        isSuccess = ulong.TryParse(secondStr.Substring(i, 1), out temp);
                        if (isSuccess)
                        {
                            sum += temp;
                        }
                    }

                    Console.WriteLine(sum);
                }
            }
        }

        // 빠른 A+B
        public void Solve_15552()
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            {
                string str = sr.ReadLine();
                int num = 0;
                bool r = int.TryParse(str, out num);

                if (r)
                {
                    if (num > 0 && num < 1_000_001)
                    {
                        string[] arr = new string[2];
                        int firstTemp = 0, secondTemp = 0;
                        StringBuilder res = new StringBuilder();

                        for (int i = 0; i < num; i++)
                        {
                            arr = sr.ReadLine().Split();

                            if (arr.Length == 2)
                            {
                                bool r1 = int.TryParse(arr[0], out firstTemp);
                                bool r2 = int.TryParse(arr[1], out secondTemp);

                                if (r1 && r2)
                                {
                                    if ((firstTemp > 0 && firstTemp < 1001) &&
                                        (secondTemp > 0 && secondTemp < 1001))
                                    {
                                        res.Append(string.Format("{0}\n", firstTemp + secondTemp));
                                    }
                                }
                            }
                        }

                        if (res.Length > 0)
                        {
                            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput()))
                            {
                                sw.WriteLine(res);
                            }
                        }
                    }
                }
            }
        }
    }
}
