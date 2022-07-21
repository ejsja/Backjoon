using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjoon.Problem
{
    public class Bronze1
    {
        // 더하기 사이클
        public void Solve_1110()
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            {
                string originNumStr = sr.ReadLine();
                int originNum = 0;
                int cycleCnt = 0;
                bool isSuccess = int.TryParse(originNumStr, out originNum);
                bool isContinue = true;

                if (isSuccess)
                {
                    if (originNum > -1 && originNum < 100)
                    {
                        if (originNumStr.Length == 1)
                        {
                            originNumStr = originNumStr.Insert(0, "0");
                        }

                        string temp = originNumStr;
                        int firstNum = 0;
                        int secondNum = 0;

                        isSuccess = int.TryParse(temp.Substring(0, 1), out firstNum);
                        isSuccess &= int.TryParse(temp.Substring(1, 1), out secondNum);

                        if (isSuccess)
                        {
                            while (isContinue)
                            {
                                temp = string.Format("{0}{1}", secondNum, (firstNum + secondNum).ToString().Substring((firstNum + secondNum).ToString().Length - 1, 1));
                                cycleCnt++;

                                if (temp.Equals(originNumStr))
                                {
                                    break;
                                }
                                else
                                {
                                    if (temp.Length == 1)
                                    {
                                        temp = temp.Insert(0, "0");
                                    }

                                    isSuccess = int.TryParse(temp.Substring(0, 1), out firstNum);
                                    isSuccess &= int.TryParse(temp.Substring(1, 1), out secondNum);

                                    if (!isSuccess)
                                    {
                                        break;
                                    }
                                }
                            }

                            Console.WriteLine(cycleCnt);
                        }
                    }
                }
            }
        }

        // 단어 공부
        public void Solve_1157()
        {
            string str = Console.ReadLine();
            int alphabetCount = 26;

            if (str.Length > 0 && str.Length < 1_000_001)
            {
                str = str.ToUpper();
                List<char> listStr = str.ToList();
                listStr.Sort();
                int maxValue = int.MinValue;
                bool isEqualMaxValue = false;
                char maxChar = ' ';

                for (int i = 0; i < alphabetCount; i++)
                {
                    List<char> listTemp = listStr.FindAll(c => c == 'A' + i);
                    int countTemp = listTemp.Count;

                    if (countTemp > maxValue && countTemp > 0)
                    {
                        maxValue = countTemp;
                        maxChar = listTemp[0];
                        isEqualMaxValue = false;
                    }
                    else if (maxValue == countTemp)
                    {
                        isEqualMaxValue = true;
                    }
                    else
                    {
                        // Not Defined
                    }
                }

                if (isEqualMaxValue)
                {
                    Console.WriteLine("?");
                }
                else
                {
                    Console.WriteLine(maxChar);
                }
            }
        }

        // 평균
        public void Solve_1546()
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            {
                string tempStr = "";
                int num = 0;
                int numCount = 0;
                bool isSuccess = false;

                tempStr = sr.ReadLine();
                isSuccess = int.TryParse(tempStr, out num);

                if (isSuccess && (num > 0 && num < 1001))
                {
                    string[] scoreStrArr = sr.ReadLine().Split();

                    if (scoreStrArr.Length == num)
                    {
                        double tempNum = 0;
                        double[] scoreArr = new double[num];
                        for (int i = 0; i < scoreArr.Length; i++)
                        {
                            isSuccess = double.TryParse(scoreStrArr[i], out tempNum);
                            if (isSuccess && (tempNum > -1 && tempNum < 101))
                            {
                                scoreArr[numCount++] = tempNum;
                            }
                        }

                        if (numCount == num)
                        {
                            double max = scoreArr.Max();
                            for (int i = 0; i < scoreArr.Length; i++)
                            {
                                scoreArr[i] = (scoreArr[i] / max) * 100;
                            }

                            Console.WriteLine(string.Format("{0:F6}", scoreArr.Average()));
                        }
                    }
                }
            }
        }

        // 평균은 넘겠지
        public void Solve_4344()
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            {
                string tempStr = "";
                int num = 0;
                bool isSuccess = false;

                tempStr = sr.ReadLine();
                isSuccess = int.TryParse(tempStr, out num);

                if (isSuccess && num > 0)
                {
                    string[] caseScoreArr = new string[num];
                    string[] tempArr = null;
                    int[][] studentArr = new int[num][];
                    int tempNum = 0;
                    int numCount = 0;

                    for (int i = 0; i < caseScoreArr.Length; i++)
                    {
                        caseScoreArr[i] = sr.ReadLine();
                        tempArr = caseScoreArr[i].Split();
                        isSuccess = int.TryParse(tempArr[0], out tempNum);

                        if (isSuccess && (tempNum > 0 && tempNum < 1001))
                        {
                            studentArr[numCount] = new int[tempNum];

                            for (int j = 1; j < tempArr.Length; j++)
                            {
                                isSuccess = int.TryParse(tempArr[j], out studentArr[numCount][j - 1]);
                                if (!isSuccess)
                                {
                                    break;
                                }
                            }

                            numCount++;
                        }
                        else
                        {
                            break;
                        }
                    }

                    if (numCount == num)
                    {
                        StringBuilder sb = new StringBuilder();
                        int upperThanAvgCnt = 0;

                        for (int i = 0; i < studentArr.Length; i++)
                        {
                            for (int j = 0; j < studentArr[i].Length; j++)
                            {
                                if (studentArr[i][j] > studentArr[i].Average())
                                {
                                    upperThanAvgCnt++;
                                }
                            }

                            sb.AppendLine(string.Format("{0:F3}%", ((float)upperThanAvgCnt / (float)studentArr[i].Length) * 100.0f));
                            upperThanAvgCnt = 0;
                        }

                        Console.WriteLine(sb);
                    }
                }
            }
        }
    }
}
