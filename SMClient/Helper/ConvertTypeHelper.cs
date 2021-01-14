using SMClient.Models;
using SMClient.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SMClient.Helper
{
    public class ConvertTypeHelper
    {
        public static StudentClient ConvertServiceStudentToViewStudent(Student serviceStudent)
        {
            var stdView = new StudentClient
            {
                Id = serviceStudent.Id,
                Rollnumber = serviceStudent.Rollnumber,
                Name = serviceStudent.Name,
                Birthday = serviceStudent.Birthday,
                Email = serviceStudent.Email,
                Genre = serviceStudent.Genre,
                Introduction = serviceStudent.Introduction
            };
            return stdView;
        }

        public static Student ConvertViewStudentToServiceStudent(StudentClient studentViewModel)
        {
            var student = new Student
            {

                Rollnumber = studentViewModel.Rollnumber,
                Birthday = studentViewModel.Birthday,
                Email = studentViewModel.Email,
                Genre = (int)studentViewModel.Genre,
                Introduction = studentViewModel.Introduction,
                Name = studentViewModel.Name
            };
            return student;
        }
    }
}