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

        public MemberController(IMemberService memberService)
        {
            _memberService = memberService;
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
                    res.Error = new Error() { Message = Resources.ServerError + " : " + ex.Message, Stack = ex.StackTrace };
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
                    res.Error = new Error() { Message = Resources.ServerError + " : " + ex.Message, Stack = ex.StackTrace };
                }
            }
            return res;
        }

        // POST : api/member/event/add
        [Route("event/add")]
        [HttpPost]
        public ResultBase<Member> AddEvent([FromBody]Shift item, [FromQuery]string memberEmail, [FromQuery]int activityId)
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
                    bool result = _memberService.AddEventByMemberEmail(item, memberEmail, activityId);
                }
                catch (Exception ex)
                {
                    res.IsSuccess = false;
                    res.Error = new Error() { Message = Resources.ServerError + " : " + ex.Message, Stack = ex.StackTrace };
                }
            }
            return res;
        }

        // POST : api/member/event/update
        [Route("event/update")]
        [HttpPost]
        public ResultBase<Member> UpdateEvent([FromBody]Shift item, [FromQuery]int memberId)
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
                   // res.Item = _memberService.Update(item);
                }
                catch (Exception ex)
                {
                    res.IsSuccess = false;
                    res.Error = new Error() { Message = Resources.ServerError + " : " + ex.Message, Stack = ex.StackTrace };
                }
            }
            return res;
        }

        // POST : api/member/event/delete
        [Route("event/delete")]
        [HttpPost]
        public ResultBase<Member> DeleteEvent([FromBody]Member item)
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
                    res.Error = new Error() { Message = Resources.ServerError + " : " + ex.Message, Stack = ex.StackTrace };
                }
            }
            return res;
        }
    }
}
