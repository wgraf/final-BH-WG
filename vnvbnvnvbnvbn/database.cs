using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vnvbnvnvbnvbn
{
    class database : DbContext
    {
        public DbSet<senddata> jtttdata { get; set; }
    }
}
