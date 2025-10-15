namespace ToDoListApp.Models
{
    public class ToDoTask
    {
        public int Id { get; set; }
        public string Title { get; set; }      
        public bool IsCompleted { get; set; }
        public DateOnly CompletedDate { get; set; }
    }
}
