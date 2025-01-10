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
            var task = "Test task";
            _classlistTodo.AddTask(task);
            var tasks = _classlistTodo.GetAllTasks();
            Assert.Contains(task, tasks);
        }

        [Fact]
        public void RemoveTask_ShouldRemoveTaskToList() 
        {
            var task = "Task to remove";
            _classlistTodo.AddTask(task);
            _classlistTodo.RemoveTask(0);
            var tasks = _classlistTodo.GetAllTasks();
            Assert.DoesNotContain(task, tasks);
        }

        [Fact]
        public void RemoveTask_InvalidIndex_ShouldNotThrowException()
        {
            var task = "valid task";
            _classlistTodo.AddTask(task);
            _classlistTodo.RemoveTask(8); // invalid index

            var tasks = _classlistTodo.GetAllTasks();
            Assert.Single(tasks); // den ursprungliga uppgiften ska fortfarande finnas kvar
        }
    }
}