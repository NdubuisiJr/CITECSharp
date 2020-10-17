using System;
namespace TodoList {
    public class Todo {
        public int Id { get; set; }
        public string TodoText { get; set; }
        public bool IsCompleted { get; set; }
        public DateTime CompletionTime { get; set; }
    }
}
