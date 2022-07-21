using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjoon.Problem
{
    public class Silver4
    {
        // 한수
        public void Solve_1065()
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            {
                string temp = sr.ReadLine();
                int num = 0;
                bool isSuccess = int.TryParse(temp, out num);

                if (isSuccess && (num > 0 && num < 1001))
                {
                    int hanCount = 0;
                    string numStr = "";
                    int[] numArr = new int[4];
                    int[] numDiffArr = new int[3];

                    for (int i = 1; i < num + 1; i++)
                    {
                        if (i < 100)
                        {
                            hanCount++;
                        }
                        else
                        {
                            numStr = i.ToString();

                            for (int j = 0; j < numStr.Length; j++)
                            {
                                isSuccess = int.TryParse(numStr.ElementAt(j).ToString(), out numArr[j]);
                                if (!isSuccess)
                                {
                                    break;
                                }
                            }

                            if (isSuccess)
                            {
                                bool isSameDiff = true;

                                for (int j = 0; j < numStr.Length - 1; j++)
                                {
                                    numDiffArr[j] = numArr[j] - numArr[j + 1];
                                    if (j > 0)
                                    {
                                        if (numDiffArr[j] != numDiffArr[j - 1])
                                        {
                                            isSameDiff = false;
                                            break;
                                        }
                                    }
                                }

                                if (isSameDiff)
                                {
                                    hanCount++;
                                }
                            }
                        }
                    }

                    Console.WriteLine(hanCount);
                }
            }
        }
    }
}
