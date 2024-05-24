using TodoApp.Core.DTOs;
using TodoApp.Core.Entities.Category;
using TodoApp.Core.Entities.Todo;

namespace TodoApp.Core.Interface
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetAll();
        Category GetCategory(int id);
        void Add(Category category);
        void Update(Category category);
        void Delete(int id);
    }

    public interface ITodoRepository
    {
        IEnumerable<Todo> GetAll();
        Todo GetTodo(int id);
        void Add(Todo todo);
        void Update(Todo todo);
        void Delete(int id);
    }

    public interface ICategoryService
    {
        IEnumerable<CategoryDTO> GetCategories();
        CategoryDTO GetCategoryById(int id);
        void CreateCategory(CategoryDTO category);
        void UpdateCategory(CategoryDTO category);
        void DeleteCategory(int id);
    }

    public interface ITodoService
    {
        IEnumerable<TodoDTO> GetTodos();
        TodoDTO GetTodoById(int id);
        void CreateCategory(TodoDTO todo);
        void UpdateCategory(TodoDTO todo);
        void DeleteCategory(int id);

    }
}