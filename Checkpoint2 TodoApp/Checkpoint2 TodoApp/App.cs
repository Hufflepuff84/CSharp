using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkpoint2_TodoApp
{
    class App
    {
        public ItemRepositoy Repo = new ItemRepositoy();
        public App()
        {
            
        }
        public void Add(string Description, string DueDate)
        {
            ToDo ToAdd = new ToDo(Description, DueDate);
            Repo.Add(ToAdd);
        }
        public void MarkAsDone(int ID)
        {
            Repo.MarkAsDone(ID);
        }
        public void Delete(int ID)
        {
            Repo.Delete(ID);
        }
        public IEnumerable<ToDo> GetAll()
        {
            return Repo.GetAll();
        }
        public IEnumerable<ToDo> GetDone()
        {
            return Repo.GetDone();
        }
        public IEnumerable<ToDo> GetPending()
        {
            return Repo.GetUnfinnished();
        }
    }

}
