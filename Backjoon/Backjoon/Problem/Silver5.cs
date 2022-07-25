using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Backjoon.Problem
{
    public class Silver5
    {
        // 그룹 단어 체커
        public void Solve_1316()
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            {
                string numStr = sr.ReadLine();
                int loopCount = 0;
                bool isSuccess = int.TryParse(numStr, out loopCount);

                if (isSuccess)
                {
                    string[] wordArray = new string[loopCount];
                    Dictionary<char, string>[] wordCheckDict = new Dictionary<char, string>[loopCount];
                    bool isGroupWord = true;
                    int groupWordCount = 0;

                    for (int i = 0; i < wordArray.Length; i++)
                    {
                        wordArray[i] = sr.ReadLine();
                        wordCheckDict[i] = new Dictionary<char, string>();

                        for (int j = 0; j < wordArray[i].Length; j++)
                        {
                            if (!wordCheckDict[i].ContainsKey(wordArray[i][j]))
                            {
                                wordCheckDict[i].Add(wordArray[i][j], j.ToString());
                            }
                            else
                            {
                                wordCheckDict[i][wordArray[i][j]] += string.Format($",{j}");
                            }
                        }

                        for (int j = 0; j < wordCheckDict[i].Count; j++)
                        {
                            string indexStr = wordCheckDict[i].ElementAt(j).Value.Clone() as string;
                            string[] splitIndex = indexStr.Split(',');
                            bool isContinue = true;

                            if (splitIndex.Length > 1)
                            {
                                int prev, next;

                                for (int k = 1; k < splitIndex.Length; k++)
                                {
                                    isSuccess &= int.TryParse(splitIndex[k - 1], out prev);
                                    isSuccess &= int.TryParse(splitIndex[k], out next);

                                    if (isSuccess)
                                    {
                                        if (prev + 1 != next)
                                        {
                                            isContinue = false;
                                            break;
                                        }
                                    }
                                }

                                isGroupWord &= isContinue;
                            }
                        }

                        if (isGroupWord)
                        {
                            groupWordCount++;
                        }

                        isGroupWord = true;
                    }

                    Console.WriteLine(groupWordCount);
                }
            }
        }

        // 달팽이는 올라가고 싶다
        public void Solve_2869()
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            {
                string str = sr.ReadLine();
                string[] strArr = str.Split(' ');
                
                if (strArr.Length == 3)
                {
                    int up = int.Parse(strArr[0]);
                    int down = int.Parse(strArr[1]);
                    int goal = int.Parse(strArr[2]);
                    int days = 0;
                    int distance = up - down;

                    int temp = goal - up;
                    temp = (int)Math.Ceiling((double)temp / (double)distance);
                    days = ++temp;


                    Console.WriteLine(days);
                }
            }
        }

        // 크로아티아 알파벳
        public void Solve_2941()
        {
            string[] croatiaAlphabet =
            {
                "dz=",
                "z=",
                "s=",
                "c=",
                "d-",
                "c-",
                "nj",
                "lj",           
            };

            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            {
                string str = sr.ReadLine();
                string temp = str.Clone() as string;
                int alphabetCount = 0;

                for (int i = temp.Length - 1; i > -1; i--)
                {
                    if (string.IsNullOrEmpty(temp))
                    {
                        break;
                    }
                    else
                    {
                        if (temp[i].Equals('j') && (temp.Length > 1))
                        {
                            switch (temp[i - 1])
                            {
                                case 'l':
                                case 'n':
                                    alphabetCount++;
                                    temp = temp.Remove(temp.Length - 2);
                                    break;
                                default:
                                    alphabetCount++;
                                    temp = temp.Remove(temp.Length - 1, 1);
                                    break;
                            }
                        }
                        else if (temp[i].Equals('=') || temp[i].Equals('-'))
                        {
                            for (int j = 0; j < croatiaAlphabet.Length; j++)
                            {
                                if (temp.EndsWith(croatiaAlphabet[j]))
                                {
                                    alphabetCount++;
                                    temp = temp.Remove(temp.Length - croatiaAlphabet[j].Length, croatiaAlphabet[j].Length);
                                    break;
                                }
                            }
                        }
                        else
                        {
                            alphabetCount++;
                            temp = temp.Remove(temp.Length - 1, 1);
                        }

                        i = temp.Length;
                    }
                }

                Console.WriteLine(alphabetCount);
            }
        }

        // 셀프 넘버
        public void  Solve_4673()
        {
            int count = 10000;
            int[] numArr = new int[count];
            bool[] checkArr = new bool[count];
            int temp = 0;

            for (int i = 0; i < numArr.Length; i++)
            {
                if (i > 0)
                {
                    if (i % 1000 == 0)
                    {
                        temp = numArr[i - 5] - 17;
                    }
                    else if (i % 100 == 0)
                    {
                        temp = numArr[i - 5] - 8;
                    }
                    else if (i % 10 == 0)
                    {
                        temp = numArr[(i / 10 - 1) * 10 + 5] + 1;
                    }
                    else
                    {
                        temp = numArr[i - 1] + 2;
                    }
                    numArr[i] = temp;
                }

                if (numArr[i] < count)
                {
                    checkArr[numArr[i]] = true;
                }
            }

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < checkArr.Length; i++)
            {
                if (!checkArr[i])
                {
                    sb.AppendLine(i.ToString());
                }
            }

            Console.WriteLine(sb);
        }
    }
}
