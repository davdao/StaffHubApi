using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StaffHubApi.Models.Entities;
using StaffHubApi.Models.Return;
using StaffHubApi.Repositories.Contract;
using StaffHubApi.Utils;

namespace StaffHubApi.Controllers
{
    [Route("api/activity")]
    [ApiController]
    public class ActivityController : ControllerBase
    {
        private readonly IActivityService _activityService;

        public ActivityController(IActivityService activityService)
        {
            _activityService = activityService;
        }

        // GET: api/activity
        [Route("")]
        [HttpGet]
        public async Task<IEnumerable<Activity>> Get()
        {
            IEnumerable<Activity> listActivities = _activityService.Get();
            return listActivities;
        }

        // POST: api/activity
        [Route("")]
        [HttpPost]
        public ResultBase<Activity> Update([FromBody]Activity item)
        {
            ResultBase<Activity> res = new ResultBase<Activity>() ;

            if (!ModelState.IsValid)
            {
                res.IsSuccess = false;
                res.Error = new Error() { Message = Resources.ModelInvalid };
            }
            else
            {
                try
                {
                    res.Item = _activityService.Update(item);
                }
                catch (Exception ex)
                {
                    res.IsSuccess = false;
                    res.Error = new Error() { Message = Resources.ServerError + " : " + ex.Message};
                }
            }
            return res;
        }

        // POST: api/activity
        [Route("")]
        [HttpDelete]
        public ResultBase<Activity> Delete([FromBody]Activity item)
        {
            ResultBase<Activity> res = new ResultBase<Activity>();

            if (!ModelState.IsValid)
            {
                res.IsSuccess = false;
                res.Error = new Error() { Message = Resources.ModelInvalid };
            }
            else
            {
                try
                {
                    if (_activityService.Delete(item))
                        res.Message = string.Format(Resources.ItemDeleted, item.Name);
                }
                catch (Exception ex)
                {
                    res.IsSuccess = false;
                    res.Error = new Error() { Message = Resources.ServerError + " : " + ex.Message };
                }
            }
            return res;
        }
    }
}