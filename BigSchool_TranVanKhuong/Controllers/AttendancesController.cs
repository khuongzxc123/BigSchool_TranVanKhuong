using BigSchool_TranVanKhuong.DTOs;
using BigSchool_TranVanKhuong.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BigSchool_TranVanKhuong.Controllers
{
    public class AttendancesController : ApiController
    {
        private ApplicationDbContext _dbContext;
        public AttendancesController()
        {
            _dbContext = new ApplicationDbContext();
        }
        [HttpPost]
        public IHttpActionResult Attend(AttendanceDto attendanceDto)
        {
            var UserId = User.Identity.GetUserId();
            if (_dbContext.Attendances.Any(a=>a.AttendeeId == UserId && a.CourseID == attendanceDto.CourseId))
            {
                return BadRequest("The Attendance already exists!!!");
            }
            var attendance = new Attendance
            {
                CourseID = attendanceDto.CourseId,
                AttendeeId = UserId
            };
            _dbContext.Attendances.Add(attendance);
            _dbContext.SaveChanges();
            return Ok();
        }
    }
}
