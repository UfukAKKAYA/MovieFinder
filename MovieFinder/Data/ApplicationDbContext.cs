using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MovieFinder.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieFinder.Data
{
    public class ApplicationDbContext : IdentityDbContext<UserDetail>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
