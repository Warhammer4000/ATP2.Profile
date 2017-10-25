﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Entity;

namespace ATP2.Profile.Models
{
    public enum FilterBy { Any,Name,Email,Status}
    public class UserSearchModel
    {

        public string SearchText { get; set; }
        public List<User> Users { get; set; }

        public UserSearchModel()
        {
            Users=new List<User>();
        }
    }
}