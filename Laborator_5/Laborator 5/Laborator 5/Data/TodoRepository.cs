using Laborator_5.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Laborator_5.Data
{
    public class TodoRepository : ITodoRepository
    {
        private readonly DataContext context;
        public TodoRepository(DataContext context)
        {
            this.context = context;
        }

        public void Create(Todo task)
        {
            this.context.Add(task);
            this.context.SaveChanges();
        }

        public void Update(Todo task)
        {
            this.context.Update(task);
            this.context.SaveChanges();
        }

        public IEnumerable<Todo> GetAll()
        {
            return this.context.Todos.ToList();
        }

        public Todo GetById(int id)
        {
            return this.context.Todos.Find(id);
        }

        public IEnumerable<Todo> GetActive()
        {
            return this.context.Todos.Where(td => td.IsDone == false);

        }

        public IEnumerable<Todo> GetDone()
        {
            return this.context.Todos.Where(td => td.IsDone == true);
        }

        public void Remove(int id)
        {
            Todo task = GetById(id);
            this.context.Remove(task);
            this.context.SaveChanges();
        }
    }
}
