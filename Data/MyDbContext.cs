using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Assessment_Riwi.Data
{
    public class MyDbContext : DbContext
    {

        
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }
    }
}