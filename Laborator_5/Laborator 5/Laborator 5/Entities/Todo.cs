using System;


namespace Laborator_5.Entities
{
    public class Todo
    {

        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }

        public bool IsDone = false;
    }
}
