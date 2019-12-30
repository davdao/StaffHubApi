using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using StaffHubApi.Models.Entities;
using StaffHubApi.Models.Return;
using StaffHubApi.Repositories.Contract;
using StaffHubApi.Utils;

namespace StaffHubApi.Controllers
{
    public class ShiftController : ControllerBase
    {
        private readonly ICommonService<Shift> _shiftService;

        public ShiftController(ICommonService<Shift> shiftService)
        {
            _shiftService = shiftService;
        }

        // GET: api/activity
        [Route("")]
        [HttpGet]
        public IEnumerable<Shift> Get()
        {
            return _shiftService.Get();
        }

        // POST : api/category
        [Route("add")]
        [HttpPost]
        public ResultBase<Shift> Add([FromBody]Shift item)
        {
            ResultBase<Shift> res = new ResultBase<Shift>();

            if (!ModelState.IsValid)
            {
                res.IsSuccess = false;
                res.Error = new Error() { Message = Resources.ModelInvalid };
            }
            else
            {
                try
                {
                    res.Item = _shiftService.Post(item);
                }
                catch (Exception ex)
                {
                    res.IsSuccess = false;
                    res.Error = new Error() { Message = Resources.ServerError + " : " + ex.InnerException, Stack = ex.StackTrace };
                }
            }
            return res;
        }

        // POST : api/category
        [Route("update")]
        [HttpPost]
        public ResultBase<Shift> Update([FromBody]Shift item)
        {
            ResultBase<Shift> res = new ResultBase<Shift>();

            if (!ModelState.IsValid)
            {
                res.IsSuccess = false;
                res.Error = new Error() { Message = Resources.ModelInvalid };
            }
            else
            {
                try
                {
                    res.Item = _shiftService.Update(item);
                }
                catch (Exception ex)
                {
                    res.IsSuccess = false;
                    res.Error = new Error() { Message = Resources.ServerError + " : " + ex.InnerException, Stack = ex.StackTrace };
                }
            }
            return res;
        }

        // DELETE : api/category
        [Route("")]
        [HttpDelete]
        public ResultBase<Shift> Delete([FromBody]Shift item)
        {
            ResultBase<Shift> res = new ResultBase<Shift>();

            if (!ModelState.IsValid)
            {
                res.IsSuccess = false;
                res.Error = new Error() { Message = Resources.ModelInvalid };
            }
            else
            {
                try
                {
                    if (_shiftService.Delete(item))
                        res.Message = string.Format(Resources.ItemDeleted, item.Title);
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
