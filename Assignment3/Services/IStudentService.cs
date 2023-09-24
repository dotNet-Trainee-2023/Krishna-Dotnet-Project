using Assignment3.Models;

namespace Assignment3.Services
{
    public interface IStudentService
    {
        List<Student> GetStudent();
        void CreateStudent(Student s);
        void DeleteStudent(int id);
        Student GetStudent(int index);
        void UpdateStudent(Student model);



    }
}


