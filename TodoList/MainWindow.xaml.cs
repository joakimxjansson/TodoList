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
    

    private void AddButton_OnClick(object sender, RoutedEventArgs e) {
        string task = TaskTextBox.Text;
        if (!string.IsNullOrEmpty(task)) {
            
            _classlistTodo.AddTask(task);
        UpdateTaskList();
        TaskTextBox.Clear();
        }
    }

    private void UpdateTaskList() 
    {
        TasksListBox.Items.Clear();
        foreach (var task in _classlistTodo.GetAllTasks()) {
            TasksListBox.Items.Add(task);
        }
        
    }

    private void RemoveButton_OnClick(object sender, RoutedEventArgs e) 
    {
        if (TasksListBox.SelectedIndex >=0) {
            _classlistTodo.RemoveTask(TasksListBox.SelectedIndex);
            UpdateTaskList();
        }
    }
    
}