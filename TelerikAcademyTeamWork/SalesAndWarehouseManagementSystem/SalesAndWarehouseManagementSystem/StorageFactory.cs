using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SalesAndWarehouseManagementSystem
{
    static class StorageFactory
    {
        static public Storage CreateStorage(string fileName)
        {
            using (StreamReader reader = new StreamReader(fileName))
            {
                uint itemCount = uint.Parse(reader.ReadLine());
                List<Merchandise> newStorageBody = new List<Merchandise>((int)itemCount);
                for (int i = 0; i < itemCount; i++)
                {
                    switch (int.Parse(reader.ReadLine()))
                    {
                        case 1: newStorageBody.Add(CreateDesktopComputer(reader));
                            break;
                        case 2: /*Add some other type of merchandice*/
                            break;
                        default: throw new NotImplementedException();
                    }
                }
                return new Storage(newStorageBody);
            }


        }

        //every class that derives from Merchandise and is not abstract should have a decoding function that creates it

        static private DesktopComputer CreateDesktopComputer(StreamReader reader)
        {
            StringBuilder description = new StringBuilder();
            int descriptionLines = int.Parse(reader.ReadLine());
            for (int i = 0; i <= descriptionLines; i++)
            {
                description.Append(reader.ReadLine());
                description.Append('\n');
            }
            return new DesktopComputer(reader.ReadLine(), description.ToString(), reader.ReadLine(),
                                       double.Parse(reader.ReadLine()), uint.Parse(reader.ReadLine()),
                                       uint.Parse(reader.ReadLine()), double.Parse(reader.ReadLine()),
                                       double.Parse(reader.ReadLine()), double.Parse(reader.ReadLine()));
        }
    }
}