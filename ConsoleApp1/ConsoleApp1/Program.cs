using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Задание 1-------------------------------------------------------------------------
            ////Часть а-----------------------------------------------
            //bool boolValue;
            //Console.WriteLine("Введите переменную типа bool:");
            //boolValue = Convert.ToBoolean(Console.ReadLine());
            //Console.WriteLine("bool: {0}",boolValue);

            //byte byteValue;
            //Console.WriteLine("Введите переменную типа byte:");
            //byteValue = Convert.ToByte(Console.ReadLine());
            //Console.WriteLine("byte: {0}", byteValue);

            //sbyte sbyteValue;
            //Console.WriteLine("Введите переменную типа sbyte:");
            //sbyteValue = Convert.ToSByte(Console.ReadLine());
            //Console.WriteLine("sbyte: {0}", sbyteValue);

            //short shortValue;
            //Console.WriteLine("Введите переменную типа short:");
            //shortValue = Convert.ToInt16(Console.ReadLine());
            //Console.WriteLine("short: {0}", shortValue);

            //ushort ushortValue;
            //Console.WriteLine("Введите переменную типа ushort:");
            //ushortValue = Convert.ToUInt16(Console.ReadLine());
            //Console.WriteLine("ushort: {0}", ushortValue);

            //int intValue;
            //Console.WriteLine("Введите переменную типа int:");
            //intValue = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("int: {0}", intValue);

            //uint uintValue;
            //Console.WriteLine("Введите переменную типа uint:");
            //uintValue = Convert.ToUInt32(Console.ReadLine());
            //Console.WriteLine("uint: {0}", uintValue);

            //long longValue;
            //Console.WriteLine("Введите переменную типа long:");
            //longValue = Convert.ToInt64(Console.ReadLine());
            //Console.WriteLine("long: {0}", longValue);

            //ulong ulongValue;
            //Console.WriteLine("Введите переменную типа ulong:");
            //ulongValue = Convert.ToUInt64(Console.ReadLine());
            //Console.WriteLine("ulong: {0}", ulongValue);

            //char charValue;
            //Console.WriteLine("Введите переменную типа char:");
            //charValue = Convert.ToChar(Console.ReadLine());
            //Console.WriteLine("char: {0}", charValue);

            //float floatValue;
            //Console.WriteLine("Введите переменную типа float:");
            //floatValue = Convert.ToSingle(Console.ReadLine());
            //Console.WriteLine("float: {0}", floatValue);

            //double doubleValue;
            //Console.WriteLine("Введите переменную типа double:");
            //doubleValue = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("double: {0}", doubleValue);

            //decimal decimalValue;
            //Console.WriteLine("Введите переменную типа decimal:");
            //decimalValue = Convert.ToDecimal(Console.ReadLine());
            //Console.WriteLine("decimal: {0}", decimalValue);
            ////-----------------------------------------------------

            ////Часть b----------------------------------------------
            //int valueInt = 21;
            //short valueShort = 34;

            //long valueLong = valueInt;
            //float valueFloat = valueLong;
            //double valueDouble = valueInt;
            //decimal valueDecimal = valueInt;
            //long valueLong2 = valueShort;

            //ulong valueUlong = (ulong)valueInt;
            //valueDecimal = (decimal)valueDouble;
            //valueFloat = (float)valueShort;
            //valueInt = (int)valueShort;
            //valueDouble = (double)valueDecimal;
            ////-----------------------------------------------------

            ////Часть c----------------------------------------------
            //int valueInt2 = 50;
            //Object valueObject = valueInt2;
            //int valueInt3 = (int)valueObject;
            ////-----------------------------------------------------

            ////Часть d----------------------------------------------
            //var valueVar1 = 23;
            //Console.WriteLine(valueVar1.GetType());
            //var valueVar2 = 23.23;
            //Console.WriteLine(valueVar2.GetType());

            //var valueVar3 = new[] { false, true, true };
            //Console.WriteLine(valueVar3.GetType());
            ////-----------------------------------------------------

            ////Часть e----------------------------------------------
            //short? valueNullable1 = 34;
            //short? valueNullable2 = null;
            //Console.WriteLine(valueNullable1 ?? valueNullable2);

            //short? valueNullable3 = null;
            //short? valueNullable4 = 354;
            //Console.WriteLine(valueNullable3 ?? valueNullable4);
            ////-----------------------------------------------------

            ////Часть f----------------------------------------------
            //var valueVar4 = 673.4;
            //valueVar4 = "hello";
            ////Ошибка
            ////-----------------------------------------------------
            //////----------------------------------------------------------------------------------

            ////Задание 2---------------------------------------------------------------------------
            ////Часть a------------------------------------------------
            //string valueString1 = "Hello";
            //string valueString2 = "Hi";
            //Console.WriteLine((valueString1 == valueString2) ? "Good. They are equal" : "Bad. They are not equal");
            ////-------------------------------------------------------

            ////Часть b------------------------------------------------
            //string valueString3 = "Good";
            //string valueString4 = "Morning";
            //string valueString5 = "!";

            //valueString3 = String.Concat(valueString3, " ", valueString4, valueString5);   //конкатенация  Good Morning!
            //valueString3 = String.Copy(valueString4);                                       //копирование   Morning
            //valueString5 = valueString4.Substring(0, 3);                                    //Выделение подстроки   Mor


            //valueString3 = String.Concat(valueString3, " ", valueString4, valueString5);    //Morning MorningMor
            //char[] param = { ' ' };
            //string[] arrayStrings = valueString3.Split(param);                              //Разбиение на слова Morning и MorningMor                      

            //valueString3 = valueString3.Insert(0, "Human");                                 //Вставка подстроки HumanMorning MorningMor
            //valueString3 = valueString3.Remove(0, 5);                                       //Удаление подстроки Morning MorningMor

            //Console.WriteLine($"Result: {valueString3}");
            ////-------------------------------------------------------

            ////Часть c------------------------------------------------
            //string valueString6 = "";
            //string valueString7 = null;
            //if(string.IsNullOrEmpty(valueString6))
            //{
            //    if(string.IsNullOrEmpty(valueString7))
            //    {
            //        Console.WriteLine("Good");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Bad");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Bad");
            //}

            //if(valueString6 == valueString7)
            //{
            //    Console.WriteLine("Good");
            //}
            //else
            //{
            //    Console.WriteLine("Bad");
            //}

            //string valueString8;
            //valueString8 = String.Concat(valueString7, valueString6);
            //Console.WriteLine(valueString8);
            ////-------------------------------------------------------

            ////Часть d------------------------------------------------
            //StringBuilder valueStringBuilder = new StringBuilder("Good bye");
            //valueStringBuilder.Remove(6, 1);                                     //Good be
            //valueStringBuilder.Remove(6, 1);                                     //Good b
            //valueStringBuilder.Append("us");                                     //Good bus
            //valueStringBuilder.Insert(0, "no");                                  //noGood bus
            ////-------------------------------------------------------
            //////----------------------------------------------------------------------------------

            ////Задание 3---------------------------------------------------------------------------
            ////Часть a------------------------------------------------

            //int[,] a = { { 1, 2 }, { 2, 3 } };

            ////-------------------------------------------------------

            ////Часть b------------------------------------------------
            //string[] arrayString = new[] { "Windows", "Linux", "macOS" };

            //foreach(string valueString9 in arrayString)
            //{
            //    Console.WriteLine(valueString9);
            //}
            //Console.WriteLine($"Length of array: {arrayString.Length}");

            //Console.WriteLine();
            //Console.WriteLine("Введите позицию: ");
            //int position = Convert.ToInt32(Console.ReadLine());

            //if(position<3)
            //{
            //    Console.WriteLine("Введите строку: ");
            //    string valueString10 = Console.ReadLine();
            //    Console.WriteLine();

            //    arrayString[position] = valueString10;
            //    foreach (string valueString9 in arrayString)
            //    {
            //        Console.WriteLine(valueString9);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("Too big value");
            //}
            ////-------------------------------------------------------

            ////Часть c------------------------------------------------
            //double[][] arrayDouble = new double[3][] { new double [2], new double[3], new double [4]};

            //for(int index1 = 0; index1<3; index1++)
            //{
            //    for(int index2 = 0; index2<arrayDouble[index1].Length; index2++)
            //    {
            //        Console.Write("Введите знначение: ");
            //        arrayDouble[index1][index2] = Convert.ToDouble(Console.ReadLine());
            //    }
            //}

            //foreach(double[] miniArrayDouble in arrayDouble)
            //{
            //    foreach (double valueDouble in miniArrayDouble)
            //    {
            //        Console.Write("\t" + valueDouble);
            //    }
            //    Console.WriteLine();
            //}
            ////-------------------------------------------------------

            ////Часть d------------------------------------------------
            //var arrayFloat = new float[] { 1, 2, 3, 4 };
            //var valueString11 = "Var is a good idea";
            ////-------------------------------------------------------
            //////----------------------------------------------------------------------------------

            ////Задание 4---------------------------------------------------------------------------
            ////Часть a------------------------------------------------
            //ValueTuple<int, string, char, string, ulong> student1 = (19, "Oleg", 'F', "ISiT", 2);
            ////-------------------------------------------------------

            ////Часть b------------------------------------------------
            //Console.WriteLine(student1);
            //Console.WriteLine(student1.Item1);
            //Console.WriteLine(student1.Item3);
            //Console.WriteLine(student1.Item4);
            ////-------------------------------------------------------

            ////Часть c------------------------------------------------
            //var (one, two, three, four, five) = student1;
            //Console.WriteLine($"{one }, {two}, {three}, {four}, {five}");
            ////-------------------------------------------------------

            ////Часть d------------------------------------------------
            //ValueTuple<int, string, char, string, ulong> student2 = (20, "Alex", 'F', "POIT", 2);
            //Console.WriteLine(student1 == student2);
            ////-------------------------------------------------------
            //////----------------------------------------------------------------------------------

            ////Задание 5---------------------------------------------------------------------------
            ////Часть a------------------------------------------------
            //int[] arrayInt = new[] { 1, 2, 3, 4 };
            //string valueString12 = "Weather";

            //var someTuple = CreateTuple(arrayInt, valueString12);

            //(int, int, int, char) CreateTuple(int [] arrayInt2, string valueString13)
            //{
            //    int minValue = arrayInt2.Min();
            //    int maxValue = arrayInt2.Max();
            //    int sumOfElememt = arrayInt2.Sum();
            //    char symbolString = valueString13[0];
            //    return (minValue, maxValue, sumOfElememt, symbolString);
            //}
            //Console.WriteLine(someTuple);
            ////-------------------------------------------------------
            //////----------------------------------------------------------------------------------

            ////Задание 6---------------------------------------------------------------------------
            //int OneFunc()
            //{
            //    checked
            //    {
            //        int valueInt = 2147483647;
            //        return valueInt;
            //    }
                
            //}
            //int TwoFunc()
            //{
            //    unchecked
            //    {
            //        int valueInt = 2147483647;
            //        return valueInt;
            //    }

            //}
            //Console.WriteLine(OneFunc());
            //Console.WriteLine(TwoFunc());
            //////----------------------------------------------------------------------------------
        }
    }
}
