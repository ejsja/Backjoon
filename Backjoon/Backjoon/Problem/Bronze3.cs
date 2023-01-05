using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjoon.Problem
{
    public class Bronze3
    {
        // 오븐 시계
        public void Solve_2525()
        {
            string firstStr = Console.ReadLine();
            string secondStr = Console.ReadLine();
            string[] arr = firstStr.Split(' ');

            int hour = Convert.ToInt32(arr[0]);
            int min = Convert.ToInt32(arr[1]);
            int time = Convert.ToInt32(secondStr);

            if ((hour > -1 && hour < 24) &&
                (min > -1 && min < 60) &&
                (time > -1 && time < 1001))
            {
                int hourTemp = time / 60;
                int minTemp = time % 60;

                int minRes = min + minTemp;
                int hourRes = hour + hourTemp;

                if (minRes > 59)
                {
                    minRes -= 60;
                    hourRes++;
                }

                if (hourRes > 23)
                {
                    hourRes -= 24;
                }

                Console.WriteLine(string.Format("{0} {1}", hourRes, minRes));
            }
        }

        // 최댓값
        public void Solve_2562()
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            {
                string tempStr = "";
                int tempNum = 0;
                List<int> numList = new List<int>();
                bool isSuccess = false;

                for (int i = 0; i < 9; i++)
                {
                    tempStr = sr.ReadLine();
                    isSuccess = int.TryParse(tempStr, out tempNum);

                    if (isSuccess)
                    {
                        numList.Add(tempNum);
                    }
                    else
                    {
                        break;
                    }
                }

                if (numList.Count == 9)
                {
                    Console.WriteLine("{0}\n{1}", numList.Max(), numList.IndexOf(numList.Max()) + 1);
                }
            }
        }

        // 곱셈
        public void Solve_2588()
        {
            string str = Console.ReadLine();
            string[] strArr = str.Split(' ');

            if (strArr.Length == 2)
            {
                int[] numArr = new int[strArr.Length];
                bool isSuccess = false;

                isSuccess = int.TryParse(strArr[0], out numArr[0]);
                isSuccess &= int.TryParse(strArr[1], out numArr[1]);

                if (isSuccess)
                {
                    if ((numArr[0] / 100 > 0) && (numArr[1] / 100 > 0))
                    {
                        int[] temp = new int[3];
                        temp[0] = numArr[1] / 100;
                        temp[1] = (numArr[1] % 100) / 10;
                        temp[2] = numArr[1] % 10;

                        Console.WriteLine(numArr[0] * temp[2]);
                        Console.WriteLine(numArr[0] * temp[1]);
                        Console.WriteLine(numArr[0] * temp[0]);
                        Console.WriteLine(numArr[0] * numArr[1]);
                    }
                }
            }
        }

        // 알람 시계
        public void Solve_2884()
        {
            string timeStr = Console.ReadLine();
            string[] arr = timeStr.Split(' ');

            int hour = Convert.ToInt32(arr[0]);
            int min = Convert.ToInt32(arr[1]);

            if ((hour > -1 && hour < 24) &&
                (min > -1 && min < 60))
            {
                min -= 45;

                if (min < 0)
                {
                    min += 60;

                    if (hour > 0)
                    {
                        hour--;
                    }
                    else
                    {
                        hour = 23;
                    }
                }

                Console.WriteLine(string.Format("{0} {1}", hour, min));
            }
        }

        public void Solve_10250()
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            {
                string loopStr = sr.ReadLine();
                int loopCnt = int.Parse(loopStr);
                StringBuilder sb = new StringBuilder();

                for (int i = 0; i < loopCnt; i++)
                {
                    string caseStr = sr.ReadLine();
                    string[] split = caseStr.Split(' ');
                    int h = int.Parse(split[0]);
                    int w = int.Parse(split[1]);
                    int n = int.Parse(split[2]);

                    int divide = n / h;
                    int mod = n % h;

                    if (mod == 0)
                    {
                        sb.AppendLine($"{h}{(divide):D2}");
                    }
                    else
                    {
                        sb.AppendLine($"{mod}{(divide + 1):D2}");
                    }
                }

                Console.WriteLine(sb);
            }
        }

        // 최소, 최대
        public void Solve_10818()
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            {
                bool isSuccess = false;
                string temp = sr.ReadLine();
                int num = 0;
                isSuccess = int.TryParse(temp, out num);

                if (isSuccess && (num > 0 && num < 1_000_001))
                {
                    string[] arr = sr.ReadLine().Split();

                    if (arr.Length == num)
                    {
                        int t = 0;
                        List<int> arrIntList = new List<int>();

                        for (int i = 0; i < arr.Length; i++)
                        {
                            isSuccess &= int.TryParse(arr[i], out t);
                            if (isSuccess)
                            {
                                if (t < -1_000_000 || t > 1_000_000)
                                {
                                    break;
                                }

                                arrIntList.Add(t);
                            }
                        }

                        if (isSuccess && arrIntList.Count == num)
                        {
                            Console.WriteLine("{0} {1}", arrIntList.Min(), arrIntList.Max());
                        }
                    }
                }
            }
        }
    }
}
