﻿using HelpdeskMVC.Controllers;
using HelpdeskMVC.Models;
using log4net;
using PasswordSecurity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelpdeskMVC.Repository
{
    public class UserRepository
    {
        ILog log = log4net.LogManager.GetLogger(typeof(HomeController));
        ApplContext dbContext = new ApplContext();
        public bool SaveUserDetails(UserDetails user)
        {
            log.Info(">>>>> Save data called");
            dbContext.Configuration.ValidateOnSaveEnabled = false;
            dbContext.Users.Add(user);
            dbContext.SaveChanges();
            log.Info(">>>> Data has been saved");
            return true;
        }
    }
}