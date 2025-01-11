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

        [Fact]
        public void IsListShowingCorrectly() {
            var task1 = "Test task1"; //Skapar task 
            var task2 = "Test task2"; //Skapar task 
            var task3 = "Test task3"; //Skapar task 
            _classlistTodo.AddTask(task1); // Lägger task1 på index 0
            _classlistTodo.AddTask(task2); // Lägger task2 på index 1
            _classlistTodo.AddTask(task3); // Lägger task3 på index 2
            var tasks = _classlistTodo.GetAllTasks(); //hämtar listan på alla tasks
            Assert.Equal(task1, tasks[0]); 
            Assert.Equal(task2, tasks[1]);
            Assert.Equal(task3, tasks[2]);


        }
        

    }
}