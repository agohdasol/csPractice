using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch13.Models
{
    internal sealed class Configuration : DbMigrationsConfiguration<BooksDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            ContextKey = "Ch13.Models.BooksDbContext";
        }
    }
}
