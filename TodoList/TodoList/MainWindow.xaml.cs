using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Media;
using System.Data;
using System.Data.OleDb;

namespace TodoList {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        OleDbCommand _command;
        OleDbConnection _connection;
        int maxId;
        List<Todo> _todos = new List<Todo>();

        public MainWindow() {
            InitializeComponent();

            //create a connection
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\user\\Desktop\\TodoDb.accdb";
            _connection = new OleDbConnection(connectionString);
            //Command
            string commandString = "SELECT * From Todos";
            _command = new OleDbCommand(commandString, _connection);
            //Adapter
            OleDbDataAdapter adapter = new OleDbDataAdapter(_command);
            //dataTable
            DataTable table = new DataTable();
            _connection.Open();
            adapter.Fill(table);
            _connection.Close();

            _todos = new List<Todo>(table.Rows.OfType<DataRow>().Select(x => new Todo {
                Id = int.Parse(x["ID"].ToString()),
                CompletionTime = DateTime.Parse(x["CompletionTime"].ToString()),
                IsCompleted = bool.Parse(x["IsCompleted"].ToString()),
                TodoText = x["TodoText"].ToString()
            }));

            //Get max Id
            maxId = _todos.Select(x => x.Id).Count() > 1 ? _todos.Select(x => x.Id).Max() : 15;

            // This adds TodoView into the ListView 
            listview.ItemsSource = _todos.Select(x => {
                if (x.IsCompleted) {
                    var view = new TodoView(x, DeleteCallBack, MarkAsCompletedCallBack);
                    view.Background = Brushes.Green;
                    return view;
                }
                else if (x.CompletionTime < DateTime.Now) {
                    var view = new TodoView(x, DeleteCallBack, MarkAsCompletedCallBack);
                    view.Background = Brushes.Red;
                    return view;
                }
                return new TodoView(x, DeleteCallBack, MarkAsCompletedCallBack);
            });
        }
     
        private void Button_Click(object sender, RoutedEventArgs e) {
            if (date.SelectedDate == null) {
                MessageBox.Show("Please Select a completion Date");
                return;
            }
            var todo = new Todo();
            todo.Id = maxId + 1;
            todo.TodoText = textbox.Text;
            todo.CompletionTime = date.SelectedDate.Value;
            todo.IsCompleted = false;
            _todos.Add(todo);
            listview.ItemsSource = _todos.Select(x => {
                if (x.IsCompleted) {
                    var view = new TodoView(x, DeleteCallBack, MarkAsCompletedCallBack);
                    view.Background = Brushes.Green;
                    return view;
                }
                else if (x.CompletionTime < DateTime.Now) {
                    var view = new TodoView(x, DeleteCallBack, MarkAsCompletedCallBack);
                    view.Background = Brushes.Red;
                    return view;
                }
                return new TodoView(x, DeleteCallBack, MarkAsCompletedCallBack);
            });
            // Insert into the database
            string commandString = $"INSERT INTO Todos (ID,TodoText,IsCompleted,CompletionTime) VALUES ({todo.Id},\'{todo.TodoText}\',{todo.IsCompleted},{todo.CompletionTime.ToShortDateString()});";
            _command = new OleDbCommand(commandString, _connection);
            _connection.Open();
            _command.ExecuteNonQuery();
            _connection.Close();
        }

        public void DeleteCallBack(Todo todo) {
            _todos.Remove(todo);
            listview.ItemsSource = _todos.Select(x => {
                if (x.IsCompleted) {
                    var view = new TodoView(x, DeleteCallBack, MarkAsCompletedCallBack);
                    view.Background = Brushes.Green;
                    return view;
                }
                else if (x.CompletionTime < DateTime.Now) {
                    var view = new TodoView(x, DeleteCallBack, MarkAsCompletedCallBack);
                    view.Background = Brushes.Red;
                    return view;
                }
                return new TodoView(x, DeleteCallBack, MarkAsCompletedCallBack);
            });
            //Delete from the database
            string commandString = $"DELETE FROM Todos WHERE ID={todo.Id};";
            _command = new OleDbCommand(commandString, _connection);
            _connection.Open();
            _command.ExecuteNonQuery();
            _connection.Close();
        }

        private void MarkAsCompletedCallBack(Todo todo) {
            _todos.Remove(todo);
            todo.IsCompleted = true;
            _todos.Add(todo);
            listview.ItemsSource = _todos.Select(x => {
                if (x.IsCompleted) {
                    var view = new TodoView(x, DeleteCallBack, MarkAsCompletedCallBack);
                    view.Background = Brushes.Green;
                    return view;
                }
                else if (x.CompletionTime < DateTime.Now) {
                    var view = new TodoView(x, DeleteCallBack, MarkAsCompletedCallBack);
                    view.Background = Brushes.Red;
                    return view;
                }
                return new TodoView(x, DeleteCallBack, MarkAsCompletedCallBack);
            });
            //Update the database
            string commandString = $"UPDATE Todos SET IsCompleted={todo.IsCompleted} WHERE ID={todo.Id};";
            _command = new OleDbCommand(commandString, _connection);
            _connection.Open();
            _command.ExecuteNonQuery();
            _connection.Close();
        }
    }
}
