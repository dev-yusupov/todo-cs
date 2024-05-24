## Technical Task: Todo App

---

### Project Overview

This project is a simple Todo web application built using ASP.NET Core with MVC architecture. It utilizes SQLite for database management and Entity Framework as the Object Relational Mapping (ORM) tool.

### Project Structure

- **Models**
- **Controllers**
- **Views**
- **Database Configuration**

### Models

#### Category Model

The Category model should include the following properties:
- **Id**: Primary Key, auto-incremented.
- **Title**: The name of the category.

#### Todo Model

The Todo model should include the following properties:
- **Id**: Primary Key, auto-incremented.
- **Title**: The title of the task.
- **Description**: A detailed description of the task.
- **DueDate**: The date by which the task should be completed.
- **CategoryId**: Foreign Key to the Category model.

---

### Controllers

#### CategoryController

The CategoryController manages operations related to categories.

**Responsibilities:**
- **Create**: Add a new category.
- **Read**: Retrieve a list of all categories or a single category by id.
- **Update**: Modify an existing category.
- **Delete**: Remove a category.

**Endpoints:**
- `GET /Category`: List all categories.
- `GET /Category/Details/{id}`: View details of a specific category.
- `GET /Category/Create`: Display form to create a new category.
- `POST /Category/Create`: Handle the creation of a new category.
- `GET /Category/Edit/{id}`: Display form to edit an existing category.
- `POST /Category/Edit/{id}`: Handle the update of an existing category.
- `GET /Category/Delete/{id}`: Display confirmation for deleting a category.
- `POST /Category/Delete/{id}`: Handle the deletion of a category.

#### TodoController

The TodoController manages operations related to tasks.

**Responsibilities:**
- **Create**: Add a new task.
- **Read**: Retrieve a list of all tasks or a single task by id.
- **Update**: Modify an existing task.
- **Delete**: Remove a task.

**Endpoints:**
- `GET /Todo`: List all tasks.
- `GET /Todo/Details/{id}`: View details of a specific task.
- `GET /Todo/Create`: Display form to create a new task.
- `POST /Todo/Create`: Handle the creation of a new task.
- `GET /Todo/Edit/{id}`: Display form to edit an existing task.
- `POST /Todo/Edit/{id}`: Handle the update of an existing task.
- `GET /Todo/Delete/{id}`: Display confirmation for deleting a task.
- `POST /Todo/Delete/{id}`: Handle the deletion of a task.

### Views

Create Razor views for each action in the controllers. The views should include:
- **Category Views**: Index, Details, Create, Edit, Delete
- **Todo Views**: Index, Details, Create, Edit, Delete

### Database Configuration

- Configure Entity Framework to use SQLite as the database.
- Ensure proper connection string settings in the configuration files.
- Implement database migrations to create the necessary database schema.

### Validations

- Implement necessary validations in the models using data annotations.
- Ensure that required fields are properly validated.
- Provide appropriate user feedback for validation errors.

### Testing

- Create unit tests for controllers to ensure all actions behave as expected.
- Include tests for create, read, update, and delete operations.

### Additional Considerations

- **Error Handling**: Implement error handling and user-friendly error pages.
- **Styling**: Apply CSS for a clean and responsive user interface.
- **Authentication/Authorization**: (Optional) Secure parts of the application using ASP.NET Core Identity.

### Deliverables

- Source code of the Todo app.
- Documentation including setup instructions and any dependencies.
- Unit tests demonstrating controller action coverage.

---

# You can enjoy
You can clone the repository using following command:
```
git clone https://github.com/dev-yusupov/todo-cs.git
```

There are two main folders:
- Docs - contains the documents
- TodoCS - contains the project