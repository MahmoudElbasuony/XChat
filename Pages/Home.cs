using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XChat.Extentions;

namespace XChat.Pages
{
    public partial class Home
    {
        private const string Page_Title = "Home";
        protected override void OnInitialized()
        {
            base.OnInitialized();
            _jSRuntime.SetPageTitle(Page_Title);
        }
    }
}
