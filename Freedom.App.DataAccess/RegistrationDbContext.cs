using Freedom.App.DataAccess.DTO;
using Microsoft.EntityFrameworkCore;
using System;

namespace Freedom.App.DataAccess
{
    public class RegistrationDbContext: DbContext
    {
        public RegistrationDbContext(DbContextOptions<RegistrationDbContext> options)
            : base(options) {
        
        }

        public virtual DbSet<RegistrationFormDto> RegistrationFormMap { get; set; }

    }
}
