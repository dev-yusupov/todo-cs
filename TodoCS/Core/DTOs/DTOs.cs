namespace TodoApp.Core.DTOs
{
    public class CategoryDTO
    {
        public int Id { get; set; }
        public required string Name { get; set; }
    }

    public class TodoDTO
    {
        public int Id { get; set;}
        public required string Title { get; set;}
        public string? Description { get; set;}
        public DateTime DueDate { get; set;}
        public int CategoryId { get; set;}
        public string? CategoryTitle { get; set;}
    }
}