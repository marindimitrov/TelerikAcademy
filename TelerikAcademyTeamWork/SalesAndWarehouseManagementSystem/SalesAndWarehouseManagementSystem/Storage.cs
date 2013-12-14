using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SalesAndWarehouseManagementSystem
{
    public class Storage : IEncodable
    {
        private List<Merchandise> merchandiseList;

        public Storage ShallowClone()
        {
            List<Merchandise> cloneBody = new List<Merchandise>(merchandiseList.Count);
            foreach (var item in merchandiseList)
            {
                cloneBody.Add(item);
            }
            return new Storage(cloneBody);
        }

        public Storage(List<Merchandise> merchandise)
        {
            merchandiseList = merchandise;
        }

        internal List<Merchandise> MerchandiseList
        {
            get { return merchandiseList; }
        }

        void Display()
        {
            throw new NotImplementedException();
        }

        public bool RemoveMerchandiese(Merchandise itemToBeRemoved)
        {
            return this.merchandiseList.Remove(itemToBeRemoved);
        }

        public bool CheckForModel(string model)
        {
            foreach (Merchandise item in MerchandiseList)
            {
                if (model == item.Model)
                {
                    return true;
                }
            }
            return false;
        }

        public void AddElementInStorage(Merchandise itemToBeAdded)
        {
            if (!CheckForModel(itemToBeAdded.Model))
            {
                merchandiseList.Add(itemToBeAdded);
            }
        }

        public Merchandise GetMerchandiseModel(string model)
        {
            for (int i = 0; i < merchandiseList.Count; i++)
            {
                if (merchandiseList[i].Model == model)
                    return MerchandiseList[i];
            }
            return null;
        }

        public void RestockModel(string model, uint amount)
        {
            for (int i = 0; i < merchandiseList.Count; i++)
            {
                if (merchandiseList[i].Model == model)
                {
                    merchandiseList[i].Quantity += amount;
                    return;
                }
            }
        }

        public void Encode(StreamWriter writer)
        {
            writer.WriteLine(merchandiseList.Count);
            for (int i = 0; i < merchandiseList.Count; i++)
            {
                switch (merchandiseList[i].GetType().Name)
                {
                    case "DesktopComputer": writer.WriteLine("1");
                        break;
                    default:
                        break;
                }
                merchandiseList[i].Encode(writer);
            }
        }
    }
}