namespace ToDoListApp.Models
{
    public class ToDoTask
    {
        public int Id { get; set; }
        public string Title { get; set; }
        private bool _isCompleted;

        public bool IsCompleted
        {
            get => _isCompleted;
            set
            {
                _isCompleted = value;
                if (_isCompleted && CompletedDate == default)
                {
                    CompletedDate = DateTime.Now;
                }                
            }
        }
        public DateTime CompletedDate { get; set; }
    }
}
