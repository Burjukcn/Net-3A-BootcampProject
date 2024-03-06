﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class BootcampState : BaseEntity<int>
    {
        public string Name { get; set; }

        public ICollection<Bootcamp> Bootcamps { get; set; }

        public BootcampState()
        {
            Bootcamps = new HashSet<Bootcamp>();
        }
        public BootcampState(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public BootcampState(string name, ICollection<Bootcamp> bootcamps)
        {
            Name = name;
            Bootcamps = bootcamps;
        }
    }
}