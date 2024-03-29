﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProtfolioBackend.Models.Data.Entities
{
    [Table("Repos")]
    public class GithubRepo
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int GithubId { get; set;}
        public string Name { get; set; }
        public string Url { get; set; }
        public string Content { get; set; }
        public DateTime Created_at { get; set; }
        public DateTime Updated_at { get; set; }
        public GithubUser Owner { get; set; }
        public int OwnerId { get; set; }
    }
}
