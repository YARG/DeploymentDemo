using System;
using Microsoft.EntityFrameworkCore;

namespace DVDeploymentDemo.Models
{
   
    public class ToDoDbContext : DbContext
    {
        #region ctors

        public ToDoDbContext(DbContextOptions<ToDoDbContext> options)
            : base(options)
        {
        }

        #endregion

        #region public properties

        public DbSet<ToDoItem> TodoItems { get; set; }

        #endregion
    }
}
