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
using System.Configuration;

namespace LinqToSQL
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        LinqToSqlDataClassesDataContext dataContext;
        public MainWindow()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["LinqToSQL.Properties.Settings.PatrickDBConnectionString"].ConnectionString;
            dataContext = new LinqToSqlDataClassesDataContext(connectionString);

            //InsertUniversities();
            InsertStudents();
            //InsertLectures();
            //InsertStudentLectureAssociations();
            //GetUniversityofPatrick();
            //GetLecturesFromPatrick();
            //GetAllStudentsFromYale();
            //GetAllUniversitiesWithFemales();
            //GetAllLecturesFromHarvard();
            //UpdatePatrick();
            //DeleteCarla();
        }


        public void InsertUniversities()
        {
            dataContext.ExecuteCommand("delete from University");

            University yale = new University();
            yale.Name = "Yale";
            dataContext.Universities.InsertOnSubmit(yale);

            University harvard = new University();
            harvard.Name = "Harvard";
            dataContext.Universities.InsertOnSubmit(harvard);

            dataContext.SubmitChanges();

            MainDataGrid.ItemsSource = dataContext.Universities;
        }

        public void InsertStudents()
        {
            dataContext.ExecuteCommand("delete from Student");
            // ^ "from university in dataContext.University where university == "Yale" select university'
            University yale = dataContext.Universities.First(un => un.Name.Equals("Yale"));
            University harvard = dataContext.Universities.First(un => un.Name.Equals("Harvard"));

            List<Student> students = new List<Student>();

            students.Add(new Student { Name = "Carla", Gender = "Female", UniversityId = yale.Id });
            students.Add(new Student { Name = "Patrick", Gender = "Male", University = yale });
            students.Add(new Student { Name = "Tiffany", Gender = "Female", University = harvard });
            students.Add(new Student { Name = "George", Gender = "Male", University = harvard });


            dataContext.Students.InsertAllOnSubmit(students);
            dataContext.SubmitChanges();

            MainDataGrid.ItemsSource = dataContext.Students;

        }

        public void InsertLectures()
        {
            dataContext.Lectures.InsertOnSubmit(new Lecture { Name = "Math" });
            dataContext.Lectures.InsertOnSubmit(new Lecture { Name = "History" });

            dataContext.SubmitChanges();

            MainDataGrid.ItemsSource = dataContext.Lectures;
        }


        public void InsertStudentLectureAssociations()
        {
            Student Carla = dataContext.Students.First(st => st.Name.Equals("Carla"));
            Student Patrick = dataContext.Students.First(st => st.Name.Equals("Patrick"));
            Student Tiffany = dataContext.Students.First(st => st.Name.Equals("Tiffany"));
            Student George = dataContext.Students.First(st => st.Name.Equals("George"));

            Lecture Math = dataContext.Lectures.First(lc => lc.Name.Equals("Math"));
            Lecture History = dataContext.Lectures.First(lc => lc.Name.Equals("History"));

            dataContext.StudentLectures.InsertOnSubmit(new StudentLecture { Student = Carla, Lecture = Math });
            dataContext.StudentLectures.InsertOnSubmit(new StudentLecture { Student = Patrick, Lecture = Math });

            StudentLecture slTiffany = new StudentLecture();
            slTiffany.Student = Tiffany;
            slTiffany.LectureId = History.Id;
            dataContext.StudentLectures.InsertOnSubmit(slTiffany);

            dataContext.StudentLectures.InsertOnSubmit(new StudentLecture { Student = George, Lecture = History });

            dataContext.SubmitChanges();

            MainDataGrid.ItemsSource = dataContext.StudentLectures;

        }

        public void GetUniversityofPatrick()
        {
            Student Patrick = dataContext.Students.First(st => st.Name.Equals("Patrick"));

            University PatricksUniversity = Patrick.University;

            List<University> universities = new List<University>();
            universities.Add(PatricksUniversity);

            MainDataGrid.ItemsSource = universities;


        }

        public void GetLecturesFromPatrick()
        {
            Student Patrick = dataContext.Students.First(st => st.Name.Equals("Patrick"));

            var patricksLectures = from sl in Patrick.StudentLectures select sl.Lecture;
            MainDataGrid.ItemsSource = patricksLectures;

        }

        public void GetAllStudentsFromYale()
        {
            var studentsFromYale = from student in dataContext.Students
                                   where student.University.Name == "Yale"
                                   select student;

            MainDataGrid.ItemsSource = studentsFromYale;
        }

        public void GetAllUniversitiesWithFemales()
        {
            var femaleUniversities = from student in dataContext.Students
                                     join university in dataContext.Universities
                                     on student.University equals university
                                     where student.Gender == "female"
                                     select university;

            MainDataGrid.ItemsSource = femaleUniversities;
        }

        public void GetAllLecturesFromHarvard()
        {
            var lecturesFromHarvard = from sl in dataContext.StudentLectures
                                      join student in dataContext.Students on sl.StudentId equals student.Id
                                      where student.University.Name == "Harvard"
                                      select sl.Lecture;

            MainDataGrid.ItemsSource = lecturesFromHarvard;
        }


        public void UpdatePatrick()
        {
            Student Patrick = dataContext.Students.FirstOrDefault(st => st.Name == "Patrick");
            Patrick.Name = "MasterGreaterester";
            dataContext.SubmitChanges();
            MainDataGrid.ItemsSource = dataContext.Students;
        }


        public void DeleteCarla()
        {
            Student Carla = dataContext.Students.FirstOrDefault(st => st.Name == "MasterGreaterester");
            dataContext.Students.DeleteOnSubmit(Carla);
            dataContext.SubmitChanges();
            MainDataGrid.ItemsSource = dataContext.Students;
        }

    }
}
