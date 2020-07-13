using BlazingCoffee.Shared.Resources;
using System;
using System.Collections.Generic;
using System.Text;
using Telerik.Blazor.Resources;
using Telerik.Blazor.Services;

namespace BlazingCoffee.Shared.Localization
{
    public class TelerikLocalizer : ITelerikStringLocalizer
    {
        public string this[string name]
        {
            get
            {
                return GetStringFromResource(name);
            }
        }

        public string GetStringFromResource(string key)
        {
            return TelerikMessages.ResourceManager.GetString(key, TelerikMessages.Culture);
        }
    }
}
