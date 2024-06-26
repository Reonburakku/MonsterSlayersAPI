﻿using MonsterSlayersAPI.BLL.Interfaces.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterSlayersAPI.BLL.Entities.Base
{
    public class BaseEntity : IBaseEntity
    {
        public DateTime? CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? ModifiedBy { get; set;}
        public DateTime? DeletedOn { get; set; }
        public string? DeletedBy { get; set; }
    }
}
