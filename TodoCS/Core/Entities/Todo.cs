namespace TodoApp.Core.Entities.Todo
{
    public class Todo
    {
        public int Id { get; set;}
        public required string Title { get; set;}
        public string? Description { get; set;}
        public DateTime DueDate { get; set;}
        public int CategoryId { get; set;}
        public Category.Category? Category { get; set;}
    }
}