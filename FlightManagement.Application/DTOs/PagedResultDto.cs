using System;
using System.Collections.Generic;
using System.Text;

namespace FlightManagement.Application.DTOs
{
    public class PagedResultDto<T>
    {
        public IEnumerable<T> Data { get; set; } = Enumerable.Empty<T>();

        public int TotalRecords { get; set; }

        public int? PageNumber { get; set; }
        public int? PageSize { get; set; }
        //public int? TotalPages => (int)Math.Ceiling((double)TotalRecords / PageSize);

        /*public int TotalPages =>
            PageSize == 0 ? 0 : (int)Math.Ceiling((double)TotalRecords / PageSize);*/
    }
}
