namespace UsableClasses
{
    using System;
    using System.IO;
    using System.Linq;

    //Create a static class PathStorage with static methods to save and load paths from a text file. 
    //Use a file format of your choice.

    static class PathStorage
    {
        public static void WriteToFile()
        {
            StreamWriter writer = new StreamWriter("../../../FileToWrite.txt");

            using (writer)
            {
                foreach (var item in Path.pointsSequence)
                {
                    writer.WriteLine(item);
                }
            }
        }

        public static void ReadFromFile()
        {
            StreamReader reader = new StreamReader("../../../FileToRead");

            using (reader)
            {
                reader.ReadLine();
            }
        }
    }
}