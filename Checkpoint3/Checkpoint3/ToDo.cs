using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.IO;

namespace Checkpoint3
{
    class ToDo
    {
        public int Id { get; private set; }
        public String Item { get; set; }
        public String Status { get; set; }
        public ToDo(String Item)
        {
            this.Item = Item;
            this.Status = "Pending";
        }
    }
}