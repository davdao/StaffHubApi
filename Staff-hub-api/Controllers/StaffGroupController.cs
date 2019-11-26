using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StaffHubApi.Models;
using StaffHubApi.Models.Entities;
using StaffHubApi.Repositories.Contract;

namespace StaffHubApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffGroupController : ControllerBase
    {
        private readonly IActivityService _activityService;

        public StaffGroupController(IActivityService activityService)
        {
            _activityService = activityService;
        }

        // GET: api/StaffGroup
        [HttpGet]
        public async Task<Activity> GetAsync()
        {
            return null;
        //    return await _activityService.GetActivityById(1);
        }

        // GET: api/StaffGroup/5
        [HttpGet("{id}")]
        public StaffGroup Get(int id)
        {
            return Services.StaffGroupService.getStaffGroupById(id);
        }

        // GET: api/StaffGroup/5/shift/12
        [HttpGet("{id}/shifts/{month}")]
        public StaffGroup Get(int id, int month)
        {
            return Services.StaffGroupService.getStaffGroupMonthShift(id, month);
        }

        // POST: api/StaffGroup
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/StaffGroup/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

    }
}
