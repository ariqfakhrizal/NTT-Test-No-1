using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text;
using Microsoft.Extensions.Logging;

namespace NTT;

public class NTT_Test_No_1
{
    public static void Main(string[] args)
    {
        int[] dataArray = new int[] { 4, 6, 15, 25, 45, 2, 8 };
        int sumArray = 10;

        Console.Write("output A :");
        
        /*The answer format  will have a same result as expected */
        AnswerUsingStandardFormat(dataArray, sumArray);
                
        Console.WriteLine();

        Console.Write("output B :");
        dataArray = new int[] { 4, 7, 12, 1, 4, 8, 8 };
        sumArray = 12;

        /*The answer format will have a same result as expected, but it will containts a double quotes because the codes using JSON serialization */
        AnswerUsingJSON(dataArray, sumArray);
    }

    public static string AnswerUsingJSON(int[] dataArray, int dataSum)
    {
        try
        {
            List<string> dataResult = new List<string>();

            for (int start = 0; start <= dataArray.Length; start++)
            {
                if (start < dataArray.Length - 1)
                {
                    int sumArray = dataArray[start] + dataArray[start + 1];
                    if (sumArray == dataSum)
                    {
                        dataResult.Add(dataArray[start] + "," + dataArray[start + 1]);
                    }
                }
            }

            var arrayDataResult = dataResult.ToArray();
            List<string[]> listArr = arrayDataResult.Chunk(1).ToList();
            var json = JsonSerializer.Serialize(listArr);
            Console.WriteLine(json);

            return json.Replace(" ", "");
        }
        catch (Exception ex)
        {
            // Log Data Error disini
            Console.WriteLine("Error  : " + ex.Message);
            throw;

        }

    }

    public static string AnswerUsingStandardFormat(int[] dataArray, int dataSum)
    {
        try
        {
            List<string> finalResult = new List<string>();
            StringBuilder sbResult = new StringBuilder();
            int totalResult = 0;

            sbResult.Append("[");
            for (int start = 0; start <= dataArray.Length; start++)
            {
                if (start < dataArray.Length - 1)
                {
                    int sumArray = dataArray[start] + dataArray[start + 1];
                    if (sumArray == dataSum)
                    {
                        finalResult.Add("[" + dataArray[start] + "," + dataArray[start + 1] + "]");
                        totalResult++;
                    }
                }
            }
            string results = string.Join(",", finalResult);
            sbResult.Append(results);
            sbResult.Append("]");

            Console.Write(sbResult);


            return sbResult.ToString();
        }
        catch (Exception ex)
        {
            // Log Data Error disini
            Console.WriteLine("Error  : " + ex.Message);
            throw;

        }

    }
}