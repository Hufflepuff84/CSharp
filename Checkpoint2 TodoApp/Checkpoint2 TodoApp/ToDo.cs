using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkpoint2_TodoApp
{
    public class ToDo
    {
        public string Item { get; set; }
        public string Status { get; set; }
        public int Id { get; set; }
        public ToDo(string Desc, string Due)
        {
            this.Item = Desc;
            this.Status = Due;
        }
        public ToDo()
        {

        }

        public override string ToString()
        {
            return $"{Id} | {Item} | {Status}";
        }

    }

}
