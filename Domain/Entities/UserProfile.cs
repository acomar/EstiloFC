﻿using Domain.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain.Entities
{
    public class UserProfile : BaseEntity
    {
        public string Key { get; set; }
        public string Name { get; set; }
    }
}
