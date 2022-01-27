using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExModelBinding.Models
{
    public class UserCustomModelBinder : IModelBinder
    {
        public Task BindModelAsync(ModelBindingContext bindingContext)
        {
            if (bindingContext ==null)
            {
                throw new NullReferenceException(nameof(bindingContext));
            }

            var Values = bindingContext.ValueProvider.GetValue("UserInfo");
            if (Values.Length == 0)
            {
                return Task.CompletedTask;
            }

            var splite = Values.FirstValue.Split(new char[] {'|'});
            if (splite.Length>=2)
            {
                UserInfo user = new UserInfo()
                {
                    Name = splite[0],
                    Age = int.Parse(splite[1])
                };
                bindingContext.Result = ModelBindingResult.Success(user);
            }

            return Task.CompletedTask;
        }
    }
}
