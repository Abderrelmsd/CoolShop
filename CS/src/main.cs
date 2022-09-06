using System;
using System.IO;

class Program
{
    public static void Main(string[] args)
    {
        //Get the arguments entered through the command line
        String path = args[0];
        int column = Int32.Parse(args[1]);
        String key = args[2];

        //Create a stream to read the contents of the file
        using (var reader = new StreamReader(File.OpenRead(path)))
        {
            while (!reader.EndOfStream)
            {
                //Get line and compare the desired column data with the key provided and print it in case it is found
                var line = reader.ReadLine();
                var Record = line.Split(',');
                if (Record[column] == key)
                {
                    Console.WriteLine(line);
                    return;
                }
            }
        }
    }
}