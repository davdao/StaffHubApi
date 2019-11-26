using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using StaffHubApi.Models.Entities;
using StaffHubApi.Models.Return;
using StaffHubApi.Repositories.Contract;
using StaffHubApi.Utils;

namespace StaffHubApi.Controllers
{
    [Route("api/member")]
    [ApiController]
    public class MemberController : ControllerBase
    {
        private readonly ICommonService<Member> _memberService;

        public MemberController(ICommonService<Member> memberService)
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
    }
}
