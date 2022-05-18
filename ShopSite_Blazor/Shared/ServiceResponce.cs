using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopSite_Blazor.Shared
{
    public class ServiceResponce<T>
    {
        public T? Data { get; set; }
        public bool Success { get; set; } = true;
        public string Massege { get; set; } = string.Empty;
    }
}
