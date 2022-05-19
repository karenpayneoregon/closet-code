using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using RecursivePatterns.Classes;


namespace RecursivePatterns
{
    public partial class MainForm : Form
    {
        private readonly List<Person> _peopleList;
        private StringBuilder _stringBuilder;
        public MainForm()
        {
            InitializeComponent();

            // populate list of Employee and Manager
            _peopleList = Mocked.PeopleList();
        }
        /// <summary>
        /// Get only managers in people list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Example1Button_Click(object sender, EventArgs e)
        {
            var people = _peopleList;
            _stringBuilder = new StringBuilder();

            ResultsTextBox.Text = "";
            _stringBuilder.AppendLine("Managers");
            _stringBuilder.AppendLine("");

            foreach (Person person1 in people)
            {
                if (person1 is Manager person)
                {
                    _stringBuilder.AppendLine(person.FullName);
                }
            }

            ResultsTextBox.Text = _stringBuilder.ToString();

        }
        /// <summary>
        /// Get Managers in people list, show employees under them
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Example2Button_Click(object sender, EventArgs e)
        {
            var people = _peopleList;
            _stringBuilder = new StringBuilder();

            _stringBuilder.AppendLine("Managers/Employees");
            _stringBuilder.AppendLine("");

            foreach (var person in people)
            {
                if (person is Manager manager)
                {
                    _stringBuilder.AppendLine(manager.ToString());
                    foreach (var employee in manager.Employees)
                    {
                        _stringBuilder.AppendLine($"  {employee}");
                    }
                }
            }

            ResultsTextBox.Text = _stringBuilder.ToString();
        }
        /// <summary>
        /// Recursive pattern with condition that when iterating the people list use pattern matching to
        /// get managers then the next condition is the manager has been a manager for three years.
        /// get employees under them, present each employee name
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Example3Button_Click(object sender, EventArgs e)
        {

            _stringBuilder = new StringBuilder();

            _stringBuilder.AppendLine("Recursive pattern with static condition");
            _stringBuilder.AppendLine("");


            foreach (var employeeList in Helpers.GetEmployeesWhereManagerHasThreeYearsAsManager(_peopleList))
            {
                var names = employeeList.Select(employee => employee.FullName).ToList().Select(fullName => fullName);

                foreach (var name in names)
                {
                    _stringBuilder.AppendLine(name);
                }
                
            }

            ResultsTextBox.Text = _stringBuilder.ToString();
        }
        /// <summary>
        /// Recursive pattern with condition that when iterating the people list use pattern matching to
        /// get managers then the next condition is the manager for YearsAsManager for 3 years or 4 or more years
        /// using C# 9 pattern matching using a switch.
        /// get employees under them, present each employee name
        ///
        /// If the years as manager is not 3, 4 or more null is returned
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Example4Button_Click(object sender, EventArgs e)
        {
            var people = _peopleList;

            _stringBuilder = new StringBuilder();

            _stringBuilder.AppendLine("Conditional YearsAsManager");
            _stringBuilder.AppendLine("");


            foreach (var person in people)
            {
                if (person is Manager manager)
                {
                    
                    var employees = manager.GetEmployeesWhereManagerHasYearsAsManager();
                    
                    if (employees == null) continue;
                    
                    foreach (var employee in employees)
                    {
                        _stringBuilder.AppendLine($"{employee.Id,3} {employee.FullName}");
                    }

                }
            }

            ResultsTextBox.Text = _stringBuilder.ToString();
        }

        private void ValidBirthYearButton_Click(object sender, EventArgs e)
        {
            List<string> yearList = new() {"1900", "1956", "2000", DateAndTime.Now.Year.ToString()};
            
            foreach (var currentYear in yearList)
            {
                Debug.WriteLine(Validates.ValidateBirthYear(currentYear) ? 
                    $"{currentYear} is valid" : 
                    $"{currentYear} is not valid");
            }


        }
        private void button1_Click(object sender, EventArgs e)
        {
            var value = "Accounting Manager";
            Debug.WriteLine($"Conventional = {Conventional(value)}");
            Debug.WriteLine($"PattenMatching = {PattenMatching(value)}");
            Debug.WriteLine("");
            
            value = "Sales Manager";
            Debug.WriteLine($"Conventional = {Conventional(value)}");
            Debug.WriteLine($"PattenMatching = {PattenMatching(value)}");
            Debug.WriteLine("");

            value = "Sales associate";
            Debug.WriteLine($"Conventional = {Conventional(value)}");
            Debug.WriteLine($"PattenMatching = {PattenMatching(value)}");

        }

        private static bool Conventional(string value) 
            => value == "Accounting Manager" || value == "Sales Associate";

        private static bool PattenMatching(string value) 
            => value is "Accounting Manager" or "Sales Associate";

        static bool IsConferenceDay(DateTime date) 
            => date is { Year: 2020, Month: 5, Day: 19 or 20 or 21 };
    }
}
