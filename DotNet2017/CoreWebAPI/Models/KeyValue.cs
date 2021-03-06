﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreWebAPI.Models
{
    public class KeyValue
    {
        [Key]
        public string Key { get; set; }
        public string Value { get; set; }
    }

    public class KeyValueContext : DbContext
    {
        public KeyValueContext(DbContextOptions<KeyValueContext> options)
            : base(options)
        {
        }

        public DbSet<KeyValue> KeyValue { get; set; }
    }
}
