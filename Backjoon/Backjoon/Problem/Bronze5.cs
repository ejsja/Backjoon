using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backjoon.Problem
{
    public class Bronze5
    {
        // A+B
        public void Solve_1000()
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
                    if ((numArr[0] > 0 && numArr[0] < 10) &&
                        (numArr[1] > 0 && numArr[1] < 10))
                    {
                        Console.WriteLine(numArr[0] + numArr[1]);
                    }
                }
            }
        }

        // A-B
        public void Solve_1001()
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
                    if ((numArr[0] > 0 && numArr[0] < 10) &&
                        (numArr[1] > 0 && numArr[1] < 10))
                    {
                        Console.WriteLine(numArr[0] - numArr[1]);
                    }
                }
            }
        }

        // A/B
        public void Solve_1008()
        {
            string str = Console.ReadLine();
            string[] strArr = str.Split(' ');

            if (strArr.Length == 2)
            {
                double[] numArr = new double[strArr.Length];
                bool isSuccess = false;

                isSuccess = double.TryParse(strArr[0], out numArr[0]);
                isSuccess &= double.TryParse(strArr[1], out numArr[1]);

                if (isSuccess)
                {
                    if ((numArr[0] > 0 && numArr[0] < 10) &&
                        (numArr[1] > 0 && numArr[1] < 10))
                    {
                        Console.WriteLine(numArr[0] / numArr[1]);
                    }
                }
            }
        }

        // 두 수 비교하기
        public void Solve_1330()
        {
            string str = Console.ReadLine();
            string[] arr = str.Split(' ');

            if (arr.Length == 2)
            {
                int firstNum = Convert.ToInt32(arr[0]);
                int secondNum = Convert.ToInt32(arr[1]);

                if ((firstNum > -10001 && firstNum < 10001) &&
                    (secondNum > -10001 && secondNum < 10001))
                {
                    if (firstNum > secondNum)
                    {
                        Console.WriteLine(">");
                    }
                    else if (firstNum < secondNum)
                    {
                        Console.WriteLine("<");
                    }
                    else
                    {
                        Console.WriteLine("==");
                    }
                }
            }
        }

        // 별 찍기 - 1
        public void Solve_2438()
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            {
                string str = sr.ReadLine();
                int num = 0;
                bool isSuccess = int.TryParse(str, out num);

                if (isSuccess)
                {
                    StringBuilder sb = new StringBuilder();

                    for (int i = 0; i < num; i++)
                    {
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

        // Hello World
        public void Solve_2557()
        {
            Console.WriteLine("Hello World!");
        }

        // 구구단
        public void Solve_2739()
        {
            string str = Console.ReadLine();
            int dan = Convert.ToInt32(str);

            if (dan > 0 && dan < 10)
            {
                string res = "";

                for (int i = 1; i < 10; i++)
                {
                    res += string.Format($"{dan} * {i} = {dan * i}\n");
                }

                Console.WriteLine(res);
            }
        }

        // N 찍기
        public void Solve_2741()
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

                        for (int i = 0; i < num; i++)
                        {
                            sb.AppendLine((i + 1).ToString());
                        }

                        using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput()))
                        {
                            sw.WriteLine(sb);
                        }
                    }
                }
            }
        }

        // 윤년
        public void Solve_2753()
        {
            string str = Console.ReadLine();
            int year = Convert.ToInt32(str);
            int isTrue = 0;

            if (year > 0 && year < 4001)
            {
                if ((year % 4 == 0 && year % 100 != 0))
                {
                    isTrue = 1;
                }
                else if (year % 400 == 0)
                {
                    isTrue = 1;
                }
                else
                {
                    // Not Defined
                }

                Console.WriteLine(isTrue);
            }
        }

        // 킹, 퀸, 룩, 비숍, 나이트, 폰
        public void Solve_3003()
        {
            string str = Console.ReadLine();
            string[] arr = str.Split(' ');

            if (arr.Length == 6)
            {
                int[] c = new int[] { 1, 1, 2, 2, 2, 8 };
                int[] input = new int[6];

                for (int i = 0; i < input.Length; i++)
                {
                    input[i] = Convert.ToInt32(arr[i]);
                    if (i < input.Length - 1)
                    {
                        Console.Write($"{c[i] - input[i]} ");
                    }
                    else
                    {
                        Console.WriteLine($"{c[i] - input[i]}");
                    }
                }
            }
        }

        // 과제 안 내신 분..?
        public void Solve_5597()
        {
            bool[] result = new bool[30];
            for (int i = 0; i < 28; i++)
            {
                string temp = Console.ReadLine();
                int convert = int.MinValue;
                bool ret = int.TryParse(temp, out convert);
                
                if (ret && convert is (> 0 and < 31))
                {
                    result[convert - 1] = true;
                }
            }

            int count = Array.FindAll(result, x => x == false).Count();

            if (count == 2)
            {
                int firstIndex = Array.FindIndex(result, x => x == false);
                int lastIndex = Array.FindLastIndex(result, x => x == false);

                Console.WriteLine($"{firstIndex + 1}\n{lastIndex + 1}");
            }
        }

        // 합
        public void Solve_8393()
        {
            string str = Console.ReadLine();
            int num = Convert.ToInt32(str);

            if (num > 0 && num < 10001)
            {
                Console.WriteLine(num * (num + 1) / 2);
            }
        }

        // 시험 성적
        public void Solve_9498()
        {
            string str = Console.ReadLine();
            int score = Convert.ToInt32(str);
            string grade = "";

            if (score > -1 && score < 101)
            {
                switch (score / 10)
                {
                    case 10:
                    case 9:
                        grade = "A";
                        break;
                    case 8:
                        grade = "B";
                        break;
                    case 7:
                        grade = "C";
                        break;
                    case 6:
                        grade = "D";
                        break;
                    default:
                        grade = "F";
                        break;
                }

                Console.WriteLine(grade);
            }
        }

        // 고양이
        public void Solve_10171()
        {
            string cat = "\\    /\\\n )  ( \')\n(  /  )\n \\(__)|";
            Console.WriteLine(cat);
        }

        // 개
        public void Solve_10172()
        {
            string dog = "|\\_/|\n|q p|   /}\n( 0 )\"\"\"\\\n|\"^\"`    |\n||_/=\\\\__|";
            Console.WriteLine(dog);
        }

        // 나머지
        public void Solve_10430()
        {
            string str = Console.ReadLine();
            string[] strArr = str.Split(' ');

            if (strArr.Length == 3)
            {
                int[] numArr = new int[strArr.Length];
                bool isSuccess = false;

                isSuccess = int.TryParse(strArr[0], out numArr[0]);
                isSuccess &= int.TryParse(strArr[1], out numArr[1]);
                isSuccess &= int.TryParse(strArr[2], out numArr[2]);

                if (isSuccess)
                {
                    if ((numArr[0] > 1 && numArr[0] < 10_000) &&
                        (numArr[1] > 1 && numArr[1] < 10_000) &&
                        (numArr[2] > 1 && numArr[2] < 10_000))
                    {
                        Console.WriteLine((numArr[0] + numArr[1]) % numArr[2]);
                        Console.WriteLine((numArr[0] % numArr[1] + (numArr[1] % numArr[2])) % numArr[2]);
                        Console.WriteLine((numArr[0] * numArr[1]) % numArr[2]);
                        Console.WriteLine((numArr[0] % numArr[1] * (numArr[1] % numArr[2])) % numArr[2]);
                    }
                }
            }
        }

        // We love kriii
        public void Solve_10718()
        {
            Console.WriteLine("강한친구 대한육군");
            Console.WriteLine("강한친구 대한육군");
        }

        // 개수 세기
        public void Solve_10807()
        {
            string str = Console.ReadLine();
            string input = Console.ReadLine();
            string findNumStr = Console.ReadLine();
            string[] numStrArr = input.Split(' ');

            if (numStrArr.Length == Convert.ToInt32(str))
            {
                Console.WriteLine(Array.FindAll(numStrArr, x => x == findNumStr).Length);
            }
        }

        // 알파벳 찾기
        public void Solve_10809()
        {
            int alphabetCount = 26;
            string str = Console.ReadLine();
            int[] alphaArr = new int[alphabetCount];
            string output = "";

            for (int i = 0; i < alphaArr.Length; i++)
            {
                alphaArr[i] = -1;
                alphaArr[i] = str.ToList().FindIndex(c => c == 'a' + i);

                if (i == alphaArr.Length - 1)
                {
                    output += string.Format($"{alphaArr[i]}");
                }
                else
                {
                    output += string.Format($"{alphaArr[i]} ");
                }
            }

            Console.WriteLine(output);
        }

        // 사칙연산
        public void Solve_10869()
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
                    if ((numArr[0] > 0 && numArr[0] < 10) &&
                        (numArr[1] > 0 && numArr[1] < 10))
                    {
                        Console.WriteLine(numArr[0] + numArr[1]);
                        Console.WriteLine(numArr[0] - numArr[1]);
                        Console.WriteLine(numArr[0] * numArr[1]);
                        Console.WriteLine(numArr[0] / numArr[1]);
                        Console.WriteLine(numArr[0] % numArr[1]);
                    }
                }
            }
        }

        // X보다 작은 수
        public void Solve_10871()
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            {
                string str = sr.ReadLine();
                string[] strArr = str.Split();
                int numCnt = 0;
                int selectNum = 0;

                if (strArr.Length == 2)
                {
                    bool isSuccess = int.TryParse(strArr[0], out numCnt);
                    isSuccess &= int.TryParse(strArr[1], out selectNum);

                    if (isSuccess)
                    {
                        str = sr.ReadLine();
                        strArr = str.Split();

                        if (strArr.Length == numCnt)
                        {
                            int[] numArr = new int[numCnt];
                            StringBuilder sb = new StringBuilder();

                            for (int i = 0; i < numCnt; i++)
                            {
                                isSuccess = int.TryParse(strArr[i], out numArr[i]);

                                if (isSuccess && numArr[i] < selectNum)
                                {
                                    sb.Append(string.Format("{0}", numArr[i]));
                                    if (i < numCnt - 1)
                                    {
                                        sb.Append(" ");
                                    }
                                }
                            }

                            sb.AppendLine();

                            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput()))
                            {
                                sw.WriteLine(sb);
                            }
                        }
                    }
                }
            }
        }

        // ??!
        public void Solve_10926()
        {
            string temp = "";
            StringBuilder sb = new StringBuilder();

            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            {
                temp = sr.ReadLine();

                if (temp.Length < 51)
                {
                    sb.AppendLine(temp + "??!");

                    using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput()))
                    {
                        sw.WriteLine(sb);
                    }
                }
            }
        }

        // A+B - 3
        public void Solve_10950()
        {
            string str = Console.ReadLine();
            int num = Convert.ToInt32(str);

            if (num > 0)
            {
                string[] arr = new string[num];
                int[] sumArr = new int[num];
                int firstTemp = 0, secondTemp = 0;
                string[] splitTemp = null;
                string res = "";

                for (int i = 0; i < num; i++)
                {
                    arr[i] = Console.ReadLine();
                    splitTemp = arr[i].Split(' ');
                    firstTemp = Convert.ToInt32(splitTemp[0]);
                    secondTemp = Convert.ToInt32(splitTemp[1]);

                    if ((firstTemp > 0 && firstTemp < 10) &&
                        (secondTemp > 0 && secondTemp < 10))
                    {
                        sumArr[i] = firstTemp + secondTemp;
                        res += string.Format("{0}\n", sumArr[i]);
                    }
                }

                Console.WriteLine(res);
            }
        }

        // A+B - 4
        public void Solve_10951()
        {
            bool isContinue = true;
            bool isSuccess = false;
            int firstNum = 0;
            int secondNum = 0;
            string temp = "";
            string[] tempArr = null;
            StringBuilder sb = new StringBuilder();

            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            {
                while (isContinue)
                {
                    temp = sr.ReadLine();

                    if (string.IsNullOrEmpty(temp))
                    {
                        break;
                    }

                    tempArr = temp.Split();

                    if (tempArr.Length == 2)
                    {
                        isSuccess = int.TryParse(tempArr[0], out firstNum);
                        isSuccess &= int.TryParse(tempArr[1], out secondNum);

                        if (isSuccess)
                        {
                            if ((firstNum > 0 && firstNum < 10) &&
                                (secondNum > 0 && secondNum < 10))
                            {
                                sb.AppendLine((firstNum + secondNum).ToString());
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                }

                using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput()))
                {
                    sw.WriteLine(sb);
                }
            }
        }

        // A+B - 5
        public void Solve_10952()
        {
            bool isContinue = true;
            bool isSuccess = false;
            int firstNum = 0;
            int secondNum = 0;
            string temp = "";
            string[] tempArr = null;
            StringBuilder sb = new StringBuilder();

            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            {
                while (isContinue)
                {
                    temp = sr.ReadLine();
                    tempArr = temp.Split();

                    if (tempArr.Length == 2)
                    {
                        isSuccess = int.TryParse(tempArr[0], out firstNum);
                        isSuccess &= int.TryParse(tempArr[1], out secondNum);

                        if (isSuccess)
                        {
                            if (firstNum == 0 && secondNum == 0)
                            {
                                break;
                            }
                            else
                            {
                                sb.AppendLine((firstNum + secondNum).ToString());
                            }
                        }
                    }
                }

                using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput()))
                {
                    sw.WriteLine(sb);
                }
            }
        }

        // A×B
        public void Solve_10998()
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
                    if ((numArr[0] > 0 && numArr[0] < 10) &&
                        (numArr[1] > 0 && numArr[1] < 10))
                    {
                        Console.WriteLine(numArr[0] * numArr[1]);
                    }
                }
            }
        }

        // A+B - 7
        public void Solve_11021()
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
                                    if ((firstTemp > 0 && firstTemp < 11) &&
                                        (secondTemp > 0 && secondTemp < 11))
                                    {
                                        res.Append(string.Format("Case #{0}: {1}\n", (i + 1), firstTemp + secondTemp));
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

        // A+B - 8
        public void Solve_11022()
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
                                    if ((firstTemp > 0 && firstTemp < 11) &&
                                        (secondTemp > 0 && secondTemp < 11))
                                    {
                                        res.Append(string.Format("Case #{0}: {1} + {2} = {3}\n", (i + 1), firstTemp, secondTemp, firstTemp + secondTemp));
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

        // 아스키 코드
        public void Solve_11654()
        {
            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            {
                int num = sr.Read();
                Console.WriteLine(num);
            }
        }

        // 사분면 고르기
        public void Solve_14681()
        {
            string firstStr = Console.ReadLine();
            string secondStr = Console.ReadLine();

            int firstPoint = Convert.ToInt32(firstStr);
            int secondPoint = Convert.ToInt32(secondStr);
            int quadrant = 0;

            if ((firstPoint > -1001 && firstPoint < 1001) &&
                (secondPoint > -1001 && secondPoint < 1001))
            {
                if (firstPoint > 0)
                {
                    if (secondPoint > 0)
                    {
                        quadrant = 1;
                    }
                    else
                    {
                        quadrant = 4;
                    }
                }
                else
                {
                    if (secondPoint > 0)
                    {
                        quadrant = 2;
                    }
                    else
                    {
                        quadrant = 3;
                    }
                }

                Console.WriteLine(quadrant);
            }
        }

        // 1998년생인 내가 태국에서는 2541년생?!
        public void Solve_18108()
        {
            bool isSuccess = false;
            int buddaYear = 0;
            int different = 543;
            string temp = "";

            using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
            {
                temp = sr.ReadLine();
                isSuccess = int.TryParse(temp, out buddaYear);

                if (isSuccess)
                {
                    if (buddaYear > 999 && buddaYear < 3001)
                    {
                        int res = buddaYear - different;
                        using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput()))
                        {
                            sw.WriteLine(res);
                        }
                    }
                }
            }
        }

        // 새싹
        public void Solve_25083()
        {
            string saessack = "         ,r'\"7\nr`-_   ,'  ,/\n \\. \". L_r'\n   `~\\/\n      |\n      |";
            Console.WriteLine(saessack);
        }

        // 영수증
        public void Solve_25304()
        {
            string totalStr = Console.ReadLine();
            string numStr = Console.ReadLine();
            int loopCnt = Convert.ToInt32(numStr);

            int sum = 0;

            for (int i = 0; i < loopCnt; i++)
            {
                string temp = Console.ReadLine();
                string[] split = temp.Split(' ');
                sum += (Convert.ToInt32(split[0]) * Convert.ToInt32(split[1]));
            }
            
            if (sum == Convert.ToInt32(totalStr))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
