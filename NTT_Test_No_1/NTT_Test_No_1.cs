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
        int[] numberEntered = new int[] { 4, 6, 15, 25, 45, 2, 8 };
        int referenceSummarizeNumber = 10;

        Console.Write("output A :");
        
        /*The answer format  will have a same result as expected */
        AnswerUsingStandardFormat(numberEntered, referenceSummarizeNumber);
                
        Console.WriteLine();

        Console.Write("output B :");
        numberEntered = new int[] { 4, 7, 12, 1, 4, 8, 8 };
        referenceSummarizeNumber = 12;

        /*The answer format will have a same result as expected, but it will containts a double quotes because the codes using JSON serialization */
        AnswerUsingJsonFormat(numberEntered, referenceSummarizeNumber);
    }

    public static string AnswerUsingJsonFormat(int[] numberEntered, int referenceSummarizeNumber)
    {
        try
        {
            List<string> numberEnteredResult = new List<string>();

            for (int start = 0; start <= numberEntered.Length; start++)
            {
                if (start < numberEntered.Length - 1)
                {
                    int summarizeNumberEntered = numberEntered[start] + numberEntered[start + 1];
                    if (summarizeNumberEntered == referenceSummarizeNumber)
                    {
                        numberEnteredResult.Add(numberEntered[start] + "," + numberEntered[start + 1]);
                    }
                }
            }

            var numberConverted = numberEnteredResult.ToArray();
            List<string[]> chunkedNumberConverted = numberConverted.Chunk(1).ToList();
            var resultJsonFormat = JsonSerializer.Serialize(chunkedNumberConverted);
            Console.WriteLine(resultJsonFormat);

            return resultJsonFormat.Replace(" ", "");
        }
        catch (Exception ex)
        {
            // Log Data Error disini
            Console.WriteLine("Error  : " + ex.Message);
            throw;

        }

    }

    public static string AnswerUsingStandardFormat(int[] numberEntered, int referenceSummarizeNumber)
    {
        try
        {
            List<string> numberEnteredResult = new List<string>();
            StringBuilder stringBuilderResult = new StringBuilder();

            stringBuilderResult.Append("[");

            for (int start = 0; start <= numberEntered.Length; start++)
            {
                if (start < numberEntered.Length - 1)
                {
                    int summarizeNumberEntered = numberEntered[start] + numberEntered[start + 1];
                    if (summarizeNumberEntered == referenceSummarizeNumber)
                    {
                        numberEnteredResult.Add("[" + numberEntered[start] + "," + numberEntered[start + 1] + "]");
                    }
                }
            }
            string resultsStandarFormat = string.Join(",", numberEnteredResult);
            stringBuilderResult.Append(resultsStandarFormat);
            stringBuilderResult.Append("]");

            Console.Write(stringBuilderResult);

            return stringBuilderResult.ToString();
        }
        catch (Exception ex)
        {
            // Log Data Error disini
            Console.WriteLine("Error  : " + ex.Message);
            throw;

        }

    }
}