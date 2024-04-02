using System;

using System.IO;



class Program

{

    static void Main(string[] args)

    
    {

        // Read the file line by line

        string[] lines = File.ReadAllLines(@"C:\Users\skrll\Downloads\input.txt");



        // Create a StreamWriter for the output file

        using (StreamWriter sw = new StreamWriter(@"C:\Users\skrll\Downloads\output.txt"))

        {

            foreach (string line in lines)

            {

                // Check if the line contains "split"

                if (line.Contains("split"))

                {

                    // Split the line and get the element at index 4

                    string[] splitLine = line.Split(' ');

                    if (splitLine.Length > 4)

                    {

                        // Write the element to the output file

                        sw.Write(splitLine[4] + " ");

                    }

                }

            }

        }

    }

}