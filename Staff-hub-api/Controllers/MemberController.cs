using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using StaffHubApi.Models.Entities;
using StaffHubApi.Models.Return;
using StaffHubApi.Repositories.Contract;
using StaffHubApi.Utils;

namespace StaffHubApi.Controllers
{
    [EnableCors("StaffHub")]
    [Route("api/member")]
    [ApiController]
    public class MemberController : ControllerBase
    {
        private readonly IMemberService _memberService;
        private readonly ICommonService<Shift> _shiftService;

        public MemberController(IMemberService memberService,
                                ICommonService<Shift> shiftService)
        {
            _memberService = memberService;
            _shiftService = shiftService;
        }

        // GET: api/member
        [Route("")]
        [HttpGet]
        public IEnumerable<Member> Get()
        {
            return _memberService.Get();
        }

        // POST : api/member
        [Route("")]
        [HttpPost]
        public ResultBase<Member> Update([FromBody]Member item)
        {
            ResultBase<Member> res = new ResultBase<Member>();

            if (!ModelState.IsValid)
            {
                res.IsSuccess = false;
                res.Error = new Error() { Message = Resources.ModelInvalid };
            }
            else
            {
                try
                {
                    res.Item = _memberService.Update(item);
                }
                catch (Exception ex)
                {
                    res.IsSuccess = false;
                    res.Error = new Error() { Message = Resources.ServerError + " : " + ex.InnerException, Stack = ex.StackTrace };
                }
            }
            return res;
        }

        // DELETE : api/member
        [Route("")]
        [HttpDelete]
        public ResultBase<Member> Delete([FromBody]Member item)
        {
            ResultBase<Member> res = new ResultBase<Member>();

            if (!ModelState.IsValid)
            {
                res.IsSuccess = false;
                res.Error = new Error() { Message = Resources.ModelInvalid };
            }
            else
            {
                try
                {
                    if (_memberService.Delete(item))
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

        // POST : api/member/event/add
        [Route("event/add")]
        [HttpPost]
        public ResultBase<Shift> AddEvent([FromBody]Shift item, [FromQuery]string memberEmail, [FromQuery]int activityId)
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
                    res.Item = _memberService.AddEventByMemberEmail(item, memberEmail, activityId);
                    res.IsSuccess = true;
                }
                catch (Exception ex)
                {
                    res.IsSuccess = false;
                    res.Error = new Error() { Message = Resources.ServerError + " : " + ex.InnerException, Stack = ex.StackTrace };
                }
            }
            return res;
        }

        // POST : api/member/event/update
        [Route("event/update")]
        [HttpPost]
        public ResultBase<Shift> UpdateEvent([FromBody]Shift item)
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

        // POST : api/member/event/delete
        [Route("event/delete")]
        [HttpDelete]
        public ResultBase<Shift> DeleteEvent([FromBody]Shift item)
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
                    res.IsSuccess = _shiftService.Delete(item);
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
