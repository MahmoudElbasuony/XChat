using Microsoft.Extensions.Configuration.Json;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace XChat.Extentions
{
    public static class DOMUtilities
    {
        public static void SetPageTitle(this IJSRuntime jSRuntime, string title)
        {
            if (string.IsNullOrWhiteSpace(title))
                return;
            jSRuntime.InvokeVoidAsync("setPageTitle", title);
        }

    }
}
