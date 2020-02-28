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
    [Route("api/category")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICommonService<Category> _categoryService;

        public CategoryController(ICommonService<Category> categoryService)
        {
            _categoryService = categoryService;
        }

        // GET: api/category
        [Route("")]
        [HttpGet]
        public ResultBase<Category> Get()
        {
            ResultBase<Category> res = new ResultBase<Category>();

            try
            {
                res.Data = _categoryService.Get();
            }
            catch (Exception ex)
            {
                res.IsSuccess = false;
                res.Error = new Error() { Message = Resources.ServerError + " : " + ex.InnerException, Stack = ex.StackTrace };
            }

            return res;
        }

        // POST : api/category/add
        [Route("add")]
        [HttpPost]
        public ResultBase<Category> Add([FromBody]Category item)
        {
            ResultBase<Category> res = new ResultBase<Category>();

            if (!ModelState.IsValid)
            {
                res.IsSuccess = false;
                res.Error = new Error() { Message = Resources.ModelInvalid };
            }
            else
            {
                try
                {
                    res.Item = _categoryService.Post(item);
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
        [Route("")]
        [HttpPost]
        public ResultBase<Category> Update([FromBody]Category item)
        {
            ResultBase<Category> res = new ResultBase<Category>();

            if (!ModelState.IsValid)
            {
                res.IsSuccess = false;
                res.Error = new Error() { Message = Resources.ModelInvalid };
            }
            else
            {
                try
                {
                    res.Item = _categoryService.Update(item);
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
        public ResultBase<Category> Delete([FromBody]Category item)
        {
            ResultBase<Category> res = new ResultBase<Category>();

            if (!ModelState.IsValid)
            {
                res.IsSuccess = false;
                res.Error = new Error() { Message = Resources.ModelInvalid };
            }
            else
            {
                try
                {
                    if (_categoryService.Delete(item))
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
