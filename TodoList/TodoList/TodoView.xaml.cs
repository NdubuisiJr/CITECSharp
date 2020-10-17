using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TodoList {
    /// <summary>
    /// Interaction logic for TodoView.xaml
    /// </summary>
    public partial class TodoView : UserControl {
        private Action<Todo> _deleteCallBack;
        private Action<Todo> _markAsCompletedCallBack;
        private Todo _todo;

        public TodoView(Todo todo, Action<Todo> deleteCallBack, Action<Todo> markAsCompletedCallBack) {
            InitializeComponent();
            dateLabel.Text = todo.CompletionTime.ToString();
            label.Text = todo.TodoText;
            _todo = todo;
            _deleteCallBack = deleteCallBack;
            _markAsCompletedCallBack = markAsCompletedCallBack;
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            _deleteCallBack.Invoke(_todo);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e) {
            _markAsCompletedCallBack.Invoke(_todo);
        }
    }
}
