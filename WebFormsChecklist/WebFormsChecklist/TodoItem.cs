using System;

namespace WebFormsChecklist
{
    [Serializable]
    public class TodoItem
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public DateTime? CompletedTime { get; set; }
    }
}