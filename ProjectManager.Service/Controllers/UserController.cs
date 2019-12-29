﻿using CommonEntities;
using CommonEntities.Interfaces;
using ProjectManager.BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProjectManager.Service.Controllers
{
    [RoutePrefix("User")]
    public class UserController : ApiController
    {
        IUserBusiness p1;
        public UserController()
        {
            p1 = new User();
        }

        public UserController(IUserBusiness user)
        {
            p1 = user;
        }
        [Route("GetUsers/{soringParameter?}")]
        [HttpGet]
        public List<UsersModel> GetUsers(string soringParameter)
        {
            return p1.GetUsers(soringParameter);
        }

        [Route("AddUser")]
        [HttpPost]
        public bool AddUser(UsersModel user)
        {
            return p1.AddUser(user);
        }

        [Route("DeleteUser")]
        [HttpPost]
        public bool DeleteUser(UsersModel user)
        {
            return p1.DeleteUser(user);
        }
    }
}
