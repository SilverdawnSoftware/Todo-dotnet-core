// ALLOWOVERWRITE-8D338F84B23A3685A4F69AF40819D4C2
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;


namespace ToDo
{
    public partial class ToDoDbContext : DbContext
    {
    
        public DbSet<User> Users { get; set; } 
        public DbSet<Task> Tasks { get; set; } 
     

	


     }
 }