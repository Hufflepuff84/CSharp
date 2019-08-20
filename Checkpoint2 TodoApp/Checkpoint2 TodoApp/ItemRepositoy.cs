using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkpoint2_TodoApp
{
    class ItemRepositoy
    {
        public ItemContext context = new ItemContext();
        public ItemRepositoy()
        {
            
        }
        public void Add (ToDo Item)
        {
            context.Database.EnsureCreated();
            context.Add(Item);
            context.SaveChanges();
        }
        public void Delete(int ID)
        {
            ToDo Item = Get(ID);
            context.Remove(Item);
            context.SaveChanges();
        }
        public void MarkAsDone(int ID)
        {
            ToDo Item = Get(ID);
            Item.Status = "Done";
            context.Update(Item);
            context.SaveChanges();
        }
        public IEnumerable<ToDo> GetAll()
        {
            return context.ToDos;
        }
        public IEnumerable<ToDo> GetDone()
        {
            return context.ToDos.Where(x => x.Status == "Done").ToList();
        }
        public IEnumerable<ToDo> GetPending()
        {
            return context.ToDos.Where(x => x.Status == "Pending").ToList();
        }
        public ToDo Get(int Id)
        {
            return context.ToDos.FirstOrDefault(x => x.Id == Id);
        }
        

    }
}
