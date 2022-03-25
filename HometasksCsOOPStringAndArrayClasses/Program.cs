using System;

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
            string newStr = "";
            int count = 0;
            int count2 = 0;
            str = str.Trim();
            for (int i = 0; i < str.Length - 1; i++)
            {
                if (char.IsLetter(str[i]))
                {
                    newStr += str[i];

                }

                else if (!char.IsLetter(str[i]) && !char.IsLetter(str[i + 1]))
                {
                    continue;
                }
                else
                {
                    count++;
                    newStr += " ";
                }
 
            }

            string[] arrStr = newStr.Split(" ");

            for (int i = 0; i < arrStr.Length; i++)
            {
                if (char.IsUpper(arrStr[i][0]))
                {
                    count2++;
                }


            }
            if (count == 2 && count2 == 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Hometask5: Integer value-nu integer massive yeni element kimi daxil eden metod
        static int[] AddInteger(ref int[] numbers, int number)
        {
            Array.Resize(ref numbers, numbers.Length + 1);
            numbers[numbers.Length - 1] = number;
            return numbers;
        }

    }
}