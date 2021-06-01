﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProtfolioBackend.Models.dto
{
    public class dtoGithubRepoContent
    {
        public int GithubId { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string Content { get; set; }
        public int Size { get; set; }
        public string Encoding { get; set; }
        public int OwnerId { get; set; }
    }
}