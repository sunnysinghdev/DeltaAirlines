using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DataController : ControllerBase
    {
        private StudentResponse _data;
        private readonly ILogger<WeatherForecastController> _logger;

        public DataController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
            _data = new StudentResponse();
            _data.Students = new List<Student>();
            _data.Students.Add(new Student
            {
                Id = 1,
                Name = "Alice",
                Age = 20,
                Hobbies = new List<string> { "reading", "swimming", "coding" }
            });
            _data.Students.Add(new Student
            {
                Id = 2,
                Name = "Bob",
                Age = 22,
                Hobbies = new List<string> { "painting", "dancing", "singing" }
            });

        }

        [HttpGet]
        public StudentResponse Get()
        {
            return _data;
        }
    }
}
