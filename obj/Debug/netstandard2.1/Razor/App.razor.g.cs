#pragma checksum "C:\Users\melbasuony\Desktop\XChat\App.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ee24878127a4150b5a0eafc3109996d96ac01e0e"
// <auto-generated/>
#pragma warning disable 1591
namespace XChat
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\melbasuony\Desktop\XChat\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\melbasuony\Desktop\XChat\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\melbasuony\Desktop\XChat\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\melbasuony\Desktop\XChat\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\melbasuony\Desktop\XChat\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\melbasuony\Desktop\XChat\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\melbasuony\Desktop\XChat\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\melbasuony\Desktop\XChat\_Imports.razor"
using XChat;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\melbasuony\Desktop\XChat\_Imports.razor"
using XChat.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\melbasuony\Desktop\XChat\_Imports.razor"
using XChat.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\melbasuony\Desktop\XChat\_Imports.razor"
using XChat.Components.Chat.AddChatRoom;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\melbasuony\Desktop\XChat\_Imports.razor"
using XChat.Components.Chat.ChatRoom;

#line default
#line hidden
#nullable disable
    public partial class App : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.Router>(0);
            __builder.AddAttribute(1, "AppAssembly", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Reflection.Assembly>(
#nullable restore
#line 1 "C:\Users\melbasuony\Desktop\XChat\App.razor"
                      typeof(Program).Assembly

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "Found", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.RouteData>)((routeData) => (__builder2) => {
                __builder2.AddMarkupContent(3, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.RouteView>(4);
                __builder2.AddAttribute(5, "RouteData", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.RouteData>(
#nullable restore
#line 3 "C:\Users\melbasuony\Desktop\XChat\App.razor"
                               routeData

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(6, "DefaultLayout", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Type>(
#nullable restore
#line 3 "C:\Users\melbasuony\Desktop\XChat\App.razor"
                                                          typeof(AppLayout)

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\r\n    ");
            }
            ));
            __builder.AddAttribute(8, "NotFound", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(9, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.LayoutView>(10);
                __builder2.AddAttribute(11, "Layout", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Type>(
#nullable restore
#line 7 "C:\Users\melbasuony\Desktop\XChat\App.razor"
                             typeof(AppLayout)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(12, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(13, "\r\n            ");
                    __builder3.AddMarkupContent(14, "<p>Sorry, there\'s nothing at this address.</p>\r\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(15, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
