using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace XChat.Shared
{
    public partial class AppNavbar
    {
        [Parameter]
        public string Title { get; set; }
    }
}
