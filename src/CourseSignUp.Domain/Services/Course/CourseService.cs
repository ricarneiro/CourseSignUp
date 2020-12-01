using CourseSignUp.Api.Courses;
using CourseSignUp.Domain.Contracts;
using CourseSignUp.Domain.Contracts.Repositories;
using CourseSignUp.Domain.Contracts.Services;
using CourseSignUp.Domain.Entities;
using CourseSignUp.Domain.Events.Course;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseSignUp.Domain.Services
{
    public class CourseService : ICourseService
    {
        private readonly IRepositoryCourse repCourse;
        private readonly IEventBus eventBus;

        public CourseService(IRepositoryCourse repCourse, IEventBus eventBus)
        {
            this.repCourse = repCourse;
            this.eventBus = eventBus;
        }
        public void Create(CreateCourseDto course)
        {
            throw new NotImplementedException();
        }

        public CourseLecture Get(string courseId)
        {
            throw new NotImplementedException();
        }

        public void Signup(SignUpToCourseDto courseSignUp)
        {
            //Criar o respositorio Student e gravar o aluno quando não existir
            //Obter a agenda do curso para pegar a ultima data
            var student = new Student(); // <- Esse seria o estudante criado/existente
            var dataCurso = new DateTime();
            eventBus.Publish(new SignUpEvent(student.Id, courseSignUp.CourseId, dataCurso));
        }
    }
}
