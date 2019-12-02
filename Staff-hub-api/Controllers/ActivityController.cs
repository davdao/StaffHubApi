using System;
using Microsoft.AspNetCore.Mvc;
using StaffHubApi.Models.Entities;
using StaffHubApi.Models.Return;
using StaffHubApi.Repositories.Contract;
using StaffHubApi.Utils;
using Microsoft.AspNetCore.Cors;

namespace StaffHubApi.Controllers
{
    [EnableCors("StaffHub")]
    [Route("api/activity")]
    [ApiController]
    public class ActivityController : ControllerBase
    {
        private readonly ICommonService<Activity> _activityService;

        public ActivityController(ICommonService<Activity> activityService)
        {
            _activityService = activityService;
        }

        // GET : api/activity
        [Route("")]
        [HttpGet]
        public ResultBase<Activity> Get(int id)
        {
            ResultBase<Activity> res = new ResultBase<Activity>();

            try
            {
                res.Item = _activityService.GetById(id);
            }
            catch (Exception ex)
            {
                res.IsSuccess = false;
                res.Error = new Error() { Message = Resources.ServerError + " : " + ex.InnerException, Stack = ex.StackTrace };
            }

            return res;
        }

        // POST : api/activity
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
                    res.Error = new Error() { Message = Resources.ServerError + " : " + ex.InnerException, Stack = ex.StackTrace };
                }
            }
            return res;
        }

        // DELETE : api/activity
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
                    res.Error = new Error() { Message = Resources.ServerError + " : " + ex.InnerException, Stack = ex.StackTrace };
                }
            }
            return res;
        }
    }
}