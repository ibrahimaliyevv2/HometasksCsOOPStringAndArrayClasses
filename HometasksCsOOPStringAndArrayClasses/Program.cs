using System;
using System.Text;

namespace HometasksCsOOPStringAndArrayClasses
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Hometask1-Addition
            //ReplaceMultipleIntoSingle("salam,     dunya!");
            #endregion

            #region Hometask2-Addition
            //Console.WriteLine(CheckString("Asif123"));
            #endregion

            #region Hometask3-Addition
            //string word = "Hello, hello";
            //string first = FirstOfString(ref word);
            //Console.WriteLine(first);
            #endregion

            #region Hometask4-Addition
            //string str = "Hello World";
            //Console.WriteLine(TwoPascalWords(str));
            #endregion

            #region Hometask5-Addition
            //int[] array = { 3, 4, 5 };
            //int num = 6;
            //foreach (var item in AddInteger(ref array, num))
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Optimal solutions-Addition
            //string word = "  hello,  world    salam    ";

            //MakeSentence(ref word);
            //Console.WriteLine(word);

            //string sentence = "  Hello  world  ";

            //Console.WriteLine("Fullname daxil edin:");
            //string fullname = Console.ReadLine();

            //Console.WriteLine(CheckFullName(fullname));

            //Console.WriteLine(FindFirstWord(sentence));

            //int[] nums = { 1, 2, 3, 4 };

            //AddInt(ref nums, 55);

            //Console.WriteLine("Nums:");
            //foreach (var item in nums)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion
        }


        //Hometask1: Butun bosluqlari tek bosluqla evez et
        static void ReplaceMultipleIntoSingle(string str)
        {
            int length = 0;


            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                {
                    length++;
                }
            }

            string[] strArr = new string[length + 1];
            string temp = "";
            int j = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                {
                    strArr[j] = temp;
                    j++;
                    temp = "";
                }
                else
                {
                    temp += str[i];
                }
                strArr[j] = temp;
            }


            foreach (var item in strArr)
            {
                if (item != "")
                {
                    str += item + " ";
                }
            }

            Console.WriteLine(str);
        }

        //Hometask2: Stringin sertleri odemesini yoxlamaq
        static bool CheckString(string str)
        {
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsDigit(str[i]))
                {
                    count++;
                    break;
                }
            }

            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsUpper(str[i]))
                {
                    count++;
                    break;
                }
            }

            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsLower(str[i]))
                {
                    count++;
                    break;
                }
            }

            if (count == 3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Hometask3: Stringdeki ilk sozu qaytaran metod
        static string FirstOfString(ref string str)
        {
            string newStr = "";
            str = str.Trim();
            for (int i = 0; i < str.Length - 1; i++)
            {
                if (char.IsLetter(str[i]))
                {
                    newStr += str[i];
                }
                else
                {
                    break;
                }
            }
            str = newStr;
            return str;
        }

        //Hometask4: Verilmis string deyerinin icerisinde 2 soz olmasini ve her bir sozun boyuk herfle baslamasini yoxlayan metod
        static bool TwoPascalWords(string str)
        {
            int count = 0;
            string newStr = "";
            string[] arrStr;
            str = str.Trim();
            for (int i = 0; i < str.Length - 1; i++)
            {
                if (str[i] != ' ')
                {
                    newStr += str[i];
                }
                else if (str[i] == ' ' && str[i + 1] == ' ')
                {
                    continue;
                }
                else
                {
                    count++;
                    newStr += " ";
                }
                if (count == 2)
                {
                    break;
                }
            }
            if (count != 2)
            {
                return false;
            }
            arrStr = newStr.Split(" ");
            return char.IsUpper(arrStr[0][0]) && char.IsUpper(arrStr[1][0]);
        }

        //Hometask5: Integer value-nu integer massive yeni element kimi daxil eden metod
        static int[] AddInteger(ref int[] numbers, int number)
        {
            Array.Resize(ref numbers, numbers.Length + 1);
            numbers[numbers.Length - 1] = number;
            return numbers;
        }



        //Burada ise muellim terefinden yazilmis daha optimal heller yer almaqdadir:


        static bool CheckFullName(string str)
        {
            MakeSentence(ref str);
            var arr = str.Split(' ');

            if (arr.Length == 2 && char.IsUpper(arr[0][0]) && char.IsUpper(arr[1][0]))
                return true;

            return false;
        }
        static void AddInt(ref int[] arr, int num)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = num;
        }
        static void MakeSentence(ref string str)
        {
            StringBuilder strBuilder = new StringBuilder();

            str = str.Trim();
            bool lastIsSpace = true;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ' ')
                {
                    strBuilder.Append(str[i]);
                    lastIsSpace = false;
                }
                else if (!lastIsSpace)
                {
                    strBuilder.Append(str[i]);
                    lastIsSpace = true;
                }
            }

            str = strBuilder.ToString();
        }

        static bool CheckStr(string str)
        {
            bool hasDigit = false;
            bool hasUpper = false;
            bool hasLower = false;

            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsDigit(str[i]))
                    hasDigit = true;
                else if (char.IsUpper(str[i]))
                    hasUpper = true;
                else if (char.IsLower(str[i]))
                    hasLower = true;

                if (hasLower && hasUpper && hasDigit)
                    return true;
            }


            return false;
        }
        static string FindFirstWord(string str)
        {
            str = str.Trim();

            //var arr = str.Split(' ');
            //if (arr.Length > 0)
            //    return arr[0];


            int firstSpaceIndex = str.IndexOf(' ');

            if (firstSpaceIndex != -1)
                return str.Substring(0, str.IndexOf(' '));

            return str;

        }

    }
}