using Laborator_5.Entities;
using System.Collections.Generic;

namespace Laborator_5.Data
{
    public interface ITodoRepository
    {
        void Create(Todo task);
        IEnumerable<Todo> GetAll();
        Todo GetById(int id);
        void Remove(int id);
        void Update(Todo task);
    }
}