using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using SQLitePCL;
namespace WpfApp1
{
    [Table("Contact")]
    public class Contact
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Number { get; set; }

        public string EmailAddress { get; set; }
    }
}
