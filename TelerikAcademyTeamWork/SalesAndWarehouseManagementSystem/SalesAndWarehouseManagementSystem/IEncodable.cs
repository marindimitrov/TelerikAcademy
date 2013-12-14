using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SalesAndWarehouseManagementSystem
{
    interface IEncodable
    {
        void Encode(StreamWriter writer);
    }
}