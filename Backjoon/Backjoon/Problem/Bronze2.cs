using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Backjoon.Problem
{
    public class Bronze2
    {
        // 단어의 개수
        public void Solve_1152()
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            {
                string str = sr.ReadLine();
                char[] seperateChar = { ' ', '\t' };

                if (str.Length < 1_000_001)
                {
                    Console.WriteLine(str.Split(seperateChar, StringSplitOptions.RemoveEmptyEntries).Length);
                }
            }
        }

        // 숫자의 개수
        public void Solve_2577()
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            {
                string tempStr = "";
                int tempNum = 0;
                int numCnt = 0;
                int[] numArr = new int[3];
                bool isSuccess = false;

                for (int i = 0; i < 3; i++)
                {
                    tempStr = sr.ReadLine();
                    isSuccess = int.TryParse(tempStr, out tempNum);

                    if (isSuccess && (tempNum > 99 && tempNum < 1000))
                    {
                        numArr[numCnt++] = tempNum;
                    }
                    else
                    {
                        break;
                    }
                }

                if (numCnt == 3)
                {
                    int multiNum = numArr[0] * numArr[1] * numArr[2];
                    List<char> numToStrList = multiNum.ToString().ToList<char>();
                    StringBuilder sb = new StringBuilder();
                    for (int i = 0; i < 10; i++)
                    {
                        var temp = numToStrList.FindAll(x => x == i.ToString().ToCharArray()[0]);
                        sb.AppendLine(temp.Count.ToString());
                    }

                    Console.WriteLine(sb);
                }
            }
        }

        // 문자열 반복
        public void Solve_2675()
        {
            string totalStr = Console.ReadLine();
            int totalCount = 0;
            bool isSuccess = int.TryParse(totalStr, out totalCount);

            if (isSuccess && (totalCount > 0 && totalCount < 1001))
            {
                string[] input = new string[totalCount];
                string[] output = new string[totalCount];
                int[] loopCount = new int[totalCount];

                for (int i = 0; i < totalCount; i++)
                {
                    input[i] = Console.ReadLine();
                    string[] temp = input[i].Split(' ');

                    if (temp.Length == 2)
                    {
                        isSuccess = int.TryParse(temp[0], out loopCount[i]);
                        if (isSuccess && (loopCount[i] > 0 && loopCount[i] < 9) && temp[1].Length < 21)
                        {
                            for (int j = 0; j < loopCount[i] * temp[1].Length; j++)
                            {
                                output[i] += temp[1].ElementAt(j / loopCount[i]);
                            }
                        }
                    }
                }

                for (int i = 0; i < totalCount; i++)
                {
                    Console.WriteLine(output[i]);
                }
            }
        }

        // 상수
        public void Solve_2908()
        {
            string str = Console.ReadLine();
            string[] strArr = str.Split(' ');

            if (strArr.Length == 2 && strArr[0].Length == 3 && strArr[1].Length == 3)
            {
                var first = strArr[0].Reverse();
                string firstStr = "";
                var second = strArr[1].Reverse();
                string secondStr = "";

                for (int i = 0; i < strArr[0].Length; i++)
                {
                    firstStr += first.ElementAt(i);
                    secondStr += second.ElementAt(i);
                }

                Console.WriteLine(int.Parse(firstStr) > int.Parse(secondStr) ? firstStr : secondStr);
            }
        }

        // 나머지
        public void Solve_3052()
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            {
                string tempStr = "";
                int tempNum = 0;
                int numCnt = 0;
                int[] numArr = new int[10];
                bool isSuccess = false;

                for (int i = 0; i < 10; i++)
                {
                    tempStr = sr.ReadLine();
                    isSuccess = int.TryParse(tempStr, out tempNum);

                    if (isSuccess && (tempNum > -1 && tempNum < 1001))
                    {
                        numArr[numCnt++] = tempNum;
                    }
                    else
                    {
                        break;
                    }
                }

                if (numCnt == 10)
                {
                    List<int> numList = new List<int>();

                    for (int i = 0; i < 10; i++)
                    {
                        int temp = numArr[i] % 42;
                        if (!numList.Contains(temp))
                        {
                            numList.Add(temp);
                        }
                    }

                    Console.WriteLine(numList.Count);
                }
            }
        }

        // 다이얼
        public void Solve_5622()
        {
            string str = Console.ReadLine();

            if (str.Length > 1 && str.Length < 16)
            {
                Dictionary<string, int> dialDict = new Dictionary<string, int>();
                dialDict.Add("ABC", 3);
                dialDict.Add("DEF", 4);
                dialDict.Add("GHI", 5);
                dialDict.Add("JKL", 6);
                dialDict.Add("MNO", 7);
                dialDict.Add("PQRS", 8);
                dialDict.Add("TUV", 9);
                dialDict.Add("WXYZ", 10);

                int sum = 0;

                for (int i = 0; i < str.Length; i++)
                {
                    var temp = dialDict.Select(x => x.Key.Contains(str.Substring(i, 1)));
                    var index = temp.ToList().IndexOf(true);
                    sum += dialDict.ElementAt(index).Value;
                }

                Console.WriteLine(sum);
            }
        }

        // OX퀴즈
        public void Solve_8958()
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            {
                string tempStr = "";
                int num = 0;
                bool isSuccess = false;
                bool isContainOX = true;

                tempStr = sr.ReadLine();
                isSuccess = int.TryParse(tempStr, out num);

                if (isSuccess && num > 0)
                {
                    string[] oxArr = new string[num];
                    int[] sumArr = new int[num];

                    for (int i = 0; i < oxArr.Length; i++)
                    {
                        oxArr[i] = sr.ReadLine();
                        if (!(oxArr[i].Contains("O") || oxArr[i].Contains("X")))
                        {
                            isContainOX = false;
                            break;
                        }
                    }

                    if (isContainOX)
                    {
                        int score = 0;
                        StringBuilder sb = new StringBuilder();

                        for (int i = 0; i < oxArr.Length; i++)
                        {
                            score = 0;

                            for (int j = 0; j < oxArr[i].Length; j++)
                            {
                                if (oxArr[i].ElementAt(j) == 'O')
                                {
                                    score++;
                                    sumArr[i] += score;
                                }
                                else
                                {
                                    score = 0;
                                }
                            }

                            sb.AppendLine(sumArr[i].ToString());
                        }

                        Console.WriteLine(sb);
                    }
                }
            }
        }
    }
}
