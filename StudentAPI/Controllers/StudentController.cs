using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ZH2_BUU7FQ.Models;

namespace StudentAPI.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        [Route("get/all")]
        [HttpGet]
        public IActionResult getAllInstructors()
        {
            StudentContext context = new StudentContext();
            var instructors = from x in context.Instructors
                              select x.Name;
            return Ok(instructors.ToList());
        }

        [Route("get/instructorById")]
        [HttpGet]
        public IActionResult getInstructorById(int id) 
        {
            StudentContext context = new StudentContext();
            var instructorsById = from x in context.Instructors
                                  where x.InstructorSk == id
                                  select x.Name;
            return Ok(instructorsById.ToList());
        }

        [Route("get/lessonsByInstructor")]
        [HttpGet]
        public IActionResult getLessonsByInstructor(string name)
        {
            StudentContext context = new StudentContext();
            var lessonsByName = from x in context.Lessons
                                where x.InstructorFkNavigation.Name.Contains(name)
                                select new
                                {
                                    Instructor = x.InstructorFkNavigation.Name,
                                    CourseName = x.CourseFkNavigation.Name,
                                    Day = x.DayFkNavigation.Name,
                                    Time = x.TimeFkNavigation.Name,
                                    Room = x.RoomFkNavigation.Name
                                };
            return Ok(lessonsByName.ToList());
        }

        [Route("post/addCourse")]
        [HttpPost]
        public void Post([FromBody] Course course)
        {
            StudentContext context = new StudentContext();
            context.Courses.Add(course);
            context.SaveChanges();
        }
    }
}
