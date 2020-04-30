﻿using System;
using System.Collections.Generic;
using System.Text;
using GASF.ApplicationLogic.Data;

namespace GASF.ApplicationLogic.Abstractions
{
    public interface IStudentRepository : IRepository<Student>
    {
        Student GetStudentById(Guid Id);
        Student GetByUserId(Guid Id);
        Student GetStudentByFirstName(string FirstName);

        Student GetStudentByCNP(string CNP);

        SchoolFee GetSchoolFee(Guid id);

        IEnumerable<Course> GetStudentCourses(Guid id);

        IEnumerable<Grade> GetStudentGrades(Guid id);
    }
}