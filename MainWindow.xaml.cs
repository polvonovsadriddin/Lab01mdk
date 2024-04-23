using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace lab1_MDK
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
   

    public partial class MainWindow : Window
    {
        private Student student;
        private Employee employee;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void get_Click(object sender, RoutedEventArgs e)
        {
            student = new Student(Surname.Text, Name.Text, Patronymic.Text, decimal.Parse(Size.Text));
            employee = new Employee(Surname.Text, Name.Text, Patronymic.Text, decimal.Parse(Size.Text));


            if (Student.IsChecked == true)
            {
                
                    Income.Text = "";
                    balence.Text = "";
                    balence.Text += Name.Text;
                    balence.Text += "\n";
                    balence.Text += Surname.Text;
                    balence.Text += "\n";
                    balence.Text += Patronymic.Text;
                    balence.Text += "\n";
                    Income.Text = $"Годовой доход: {student.InCome().ToString()}";
                balence.Text += $"Годовой налог: {student.Balance().ToString()}";
                Size.Text = "";
                    Name.Text = "";
                    Surname.Text = "";
                    Patronymic.Text = "";
                
               


            }
            else if (Employee.IsChecked == true)
            {
                Income.Text = "";
                balence.Text = "";
                balence.Text += Name.Text;
                balence.Text += "\n";
                balence.Text += Surname.Text;
                balence.Text += "\n";
                balence.Text += Patronymic.Text;
                balence.Text += "\n";
                balence.Text += $"Годовой налог: {employee.Balance().ToString()}";
                Income.Text =  $"Годовой доход: {employee.InCome().ToString()}";
                Size.Text = "";
                Name.Text = "";
                Surname.Text = "";
                Patronymic.Text = "";
            }
        }
    }
}

