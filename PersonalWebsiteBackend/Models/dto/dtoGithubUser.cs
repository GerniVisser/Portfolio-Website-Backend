﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProtfolioBackend.Models.dto
{
    public class dtoGithubUser
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Url { get; set; }
    }
}
