using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _2021_06_17_Experimentente_Partial_Views.Models
{
    public class Document
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public Document(int id, string name)
        {
            id = this.ID;
            name = this.Name;
        }
    }
}
