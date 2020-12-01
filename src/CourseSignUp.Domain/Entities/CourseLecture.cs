using CourseSignUp.Api.Courses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CourseSignUp.Domain.Entities
{
    public class CourseLecture : AEntity
    {
        public CourseLecture()
        {
        }

        public CourseLecture(CourseDto dto)
        {
            this.Id = dto.Id;
            this.Capacity = dto.Capacity;
            this.NumberOfStudents = dto.NumberOfStudents;
        }

        public int Capacity { get; set; }
        public int NumberOfStudents { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public Teacher Creator { get; set; }
        public DateTime CreatedAt { get; set; }

        public List<ContentClass> Contents { get; private set; }

        public void AddContent(ContentClass contentClass)
        {
            if (Contents.Any(c => c.Number <= contentClass.Number))
            {
                //Here it was better if we create a Notify class to return messages to caller
                throw new Exception("You aready have a class with this number. Move it or change it, please.");
            }
            this.Contents.Add(contentClass);
        }
    }
}
