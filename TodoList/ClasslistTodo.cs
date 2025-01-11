using System.Windows.Controls;

namespace TodoList;
/// <summary>
/// Hanterar logiken för att lägga till, ta bort och visa todo-items
/// </summary>
public class ClasslistTodo {
    private List<string> tasks = new List<string>();
/// <summary>
/// Logik för att lägga till todo-items
/// </summary>

    public void AddTask(string task) 
    {
        tasks.Add(task);
    }
/// <summary>
/// Hanterar borttagning av todo-items
/// </summary>

    public void RemoveTask(int index) 
    {
        if (index >= 0 && index < tasks.Count) {

            tasks.RemoveAt(index);
        }
    }
/// <summary>
/// Returnerar fullständig lista av tasks
/// </summary>

    public List<string> GetAllTasks() {
        return tasks;
    }

    public void ClearTasks() {
        tasks.Clear();
    }
}