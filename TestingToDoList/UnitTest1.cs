using TestingToDoList;
using TodoList;
using Xunit;

namespace TestingToDoList
{
    public class ToDoListTests
    {
        private ClasslistTodo _classlistTodo;
        public ToDoListTests() 
        {
            _classlistTodo = new ClasslistTodo();
        }

        [Fact]
        public void AddTask_ShouldAddTaskToList()
        {
            var task = "Test task"; // Skapar task
            _classlistTodo.AddTask(task); // Lägger till task på index 0
            var tasks = _classlistTodo.GetAllTasks(); // visar listan på alla tasks.
            Assert.Contains(task, tasks);
        }

        [Fact]
        public void RemoveTask_ShouldRemoveTaskToList() 
        {
            var task = "Task to remove"; //Skapar task
            _classlistTodo.AddTask(task); // Lägger till task på index 0
            _classlistTodo.RemoveTask(0); //Tar bort task på index 0
            var tasks = _classlistTodo.GetAllTasks(); // visar listan på alla tasks.
            Assert.DoesNotContain(task, tasks);
        }

        [Fact]
        public void RemoveTask_InvalidIndex_ShouldNotThrowException()
        {
            var task = "valid task"; //Skapar task 
            _classlistTodo.AddTask(task); //Lägger valid task på index 0
            _classlistTodo.RemoveTask(1); // tar bort task på index 1 som ej finns.
            var tasks = _classlistTodo.GetAllTasks(); // visar listan på alla tasks.
            Assert.Single(tasks); 
        }
        
        
        [Fact]
        public void ClearTasks_ShouldClearTasks()
        {
            var task = "Test task"; //Skapar task 
            _classlistTodo.AddTask(task); //Lägger Test Task på index 0
            _classlistTodo.ClearTasks(); // Rensar Listan
            var tasks = _classlistTodo.GetAllTasks(); //Visar listan på alla tasks
            Assert.DoesNotContain(task, tasks);
        }
        [Fact]
        public void ClearTasks_EmptyList_ShouldNotThrowException() {
            _classlistTodo.ClearTasks(); //Rensar listan utan att listan har tilldelats något item innan
            var tasks = _classlistTodo.GetAllTasks(); //Visar listan
            Assert.Empty(tasks);
            
        }




    }
}