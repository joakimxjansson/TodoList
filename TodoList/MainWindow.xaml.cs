using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TodoList;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>

public partial class MainWindow : Window 
{
    private ClasslistTodo _classlistTodo;
    
    public MainWindow() {
        InitializeComponent();
        _classlistTodo = new ClasslistTodo();
    }
    
/// <summary>
/// Eventhandler för att lägga till todo-items
/// </summary>

    private void AddButton_OnClick(object sender, RoutedEventArgs e) {
        string task = TaskTextBox.Text;
        if (!string.IsNullOrEmpty(task)) {

            _classlistTodo.AddTask(task);
            UpdateTaskList();
            TaskTextBox.Clear();
        } else 
        {
            MessageBox.Show("Skriv något för att lägga till");
        }

    }
/// <summary>
/// Metod för att uppdatera Listbox
/// </summary>
    private void UpdateTaskList() 
    {
        TasksListBox.Items.Clear();
        foreach (var task in _classlistTodo.GetAllTasks()) {
            TasksListBox.Items.Add(task);
        }
        
    }
/// <summary>
/// Eventhandler för ta bort från todo-items
/// </summary>

    private void RemoveButton_OnClick(object sender, RoutedEventArgs e) 
    
    {
        if (TasksListBox.SelectedIndex >=0) {
            _classlistTodo.RemoveTask(TasksListBox.SelectedIndex);
            UpdateTaskList();
        } else {
            MessageBox.Show("Markera önskat item för att ta bort från listan");
        }
    }

    private void ClearlistButton_OnClick(object sender, RoutedEventArgs e) {
        
        _classlistTodo.ClearTasks();
        UpdateTaskList();
        MessageBox.Show("Lista rensad!");
    }
}