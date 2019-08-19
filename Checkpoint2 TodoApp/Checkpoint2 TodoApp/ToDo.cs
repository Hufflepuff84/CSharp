using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkpoint2_TodoApp
{
    public class ToDo
    {
        public string Description;
        public string DueDate;
        public int Id;
        public ToDo(string Desc, string Due)
        {
            this.Description = Desc;
            this.DueDate = Due;
        }
        public ToDo()
        {

        }

        public override string ToString()
        {
            return $"{Id} | {Description} | {DueDate}";
        }

    }

}
