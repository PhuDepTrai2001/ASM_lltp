using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class Service : IService
{
    private MyDbContext _dbContext;
    public Service()
    {
        this._dbContext = new MyDbContext();
    }
    public bool CreateStudent(Student student)
    {
        _dbContext.Students.Add(student);
        _dbContext.SaveChanges();

        return true;
        
    }

    public bool DeleteStudent(int id)
    {

        var toDelStd = GetStudentById(id);
        if (toDelStd == null)
        {
            return false;
        }
        _dbContext.Students.Remove(toDelStd);
        _dbContext.SaveChanges();
        return true;
    }

    public IEnumerable<Student> GetListStudents()
    {
        var listStudent = from s in _dbContext.Students select s;
        return listStudent;
    }

    public Student GetStudentById(int id)
    {
        var student = from s in _dbContext.Students where s.Id == id select s;
        return student.FirstOrDefault();
    }

    public bool UpdateStudent(int id, Student newStudent)
    {
        var existStudent = _dbContext.Students.First(student => student.Id == id);
        if (existStudent == null)
        {
            return false;
        }
       
        existStudent.Rollnumber = newStudent.Rollnumber;
        existStudent.Introduction = newStudent.Introduction;
        existStudent.Genre = newStudent.Genre;
        existStudent.Email = newStudent.Email;
        existStudent.Name = newStudent.Name;
        existStudent.Birthday = newStudent.Birthday;
        _dbContext.SaveChanges();
        return true;
    }
}
