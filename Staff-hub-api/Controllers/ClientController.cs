using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using StaffHubApi.Models.Entities;
using StaffHubApi.Models.Return;
using StaffHubApi.Repositories.Contract;
using StaffHubApi.Utils;

namespace StaffHubApi.Controllers
{
    [Route("api/client")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly ICommonService<Client> _clientService;

        public ClientController(ICommonService<Client> clientService)
        {
            _clientService = clientService;
        }

        // GET: api/client
        [Route("")]
        [HttpGet]
        public IEnumerable<Client> Get()
        {
            return _clientService.Get();
        }

        // POST : api/client
        [Route("")]
        [HttpPost]
        public ResultBase<Client> Update([FromBody]Client item)
        {
            ResultBase<Client> res = new ResultBase<Client>();

            if (!ModelState.IsValid)
            {
                res.IsSuccess = false;
                res.Error = new Error() { Message = Resources.ModelInvalid };
            }
            else
            {
                try
                {
                    res.Item = _clientService.Update(item);
                }
                catch (Exception ex)
                {
                    res.IsSuccess = false;
                    res.Error = new Error() { Message = Resources.ServerError + " : " + ex.Message, Stack = ex.StackTrace };
                }
            }
            return res;
        }

        // DELETE : api/client
        [Route("")]
        [HttpDelete]
        public ResultBase<Client> Delete([FromBody]Client item)
        {
            ResultBase<Client> res = new ResultBase<Client>();

            if (!ModelState.IsValid)
            {
                res.IsSuccess = false;
                res.Error = new Error() { Message = Resources.ModelInvalid };
            }
            else
            {
                try
                {
                    if (_clientService.Delete(item))
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
