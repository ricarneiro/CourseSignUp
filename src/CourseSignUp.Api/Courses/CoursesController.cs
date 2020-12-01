using CourseSignUp.Domain.Contracts.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace CourseSignUp.Api.Courses
{
    [ApiController, Route("[controller]")]
    public class CoursesController : ControllerBase
    {
        private readonly ICourseService courseService;

        public CoursesController(ICourseService courseService)
        {
            this.courseService = courseService;
        }

        [HttpGet, Route("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            try
            {
                var course = courseService.Get(id);

                return Ok(new CourseDto
                {
                    Id = course.Id,
                    Capacity = course.Capacity,
                    NumberOfStudents = course.NumberOfStudents
                });
            }
            catch(Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost, Route("create")]
        public async Task<IActionResult> Post([FromBody]CreateCourseDto createCourseDto)
        {
            try
            {
                courseService.Create(createCourseDto);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost, Route("sign-up")]
        public async Task<IActionResult> Post([FromBody] SignUpToCourseDto signUpToCourseDto)
        {
            try
            {
                courseService.Signup(signUpToCourseDto);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
