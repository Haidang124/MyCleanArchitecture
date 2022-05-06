using MyCleanArchitecture.DomainShare.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCleanArchitecture.DomainShare
{
    public class Pagination
    {

        public SortOrder SortOrder { get; set; }
        public string? Sorter { get; set; }
        public int Limit { get; set; }
        public int Skip { get; set; }
    }
}
