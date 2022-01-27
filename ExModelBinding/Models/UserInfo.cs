using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExModelBinding.Models
{
    public class UserInfo
    {
        [BindNever]
        //az samte user send nashe
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

    }
}
