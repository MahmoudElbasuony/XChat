#pragma checksum "C:\Users\melbasuony\Desktop\XChat\Pages\Chat.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1e4a18ad21767ff03157dbc6c317effe771bc6e6"
// <auto-generated/>
#pragma warning disable 1591
namespace XChat.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Chat")]
    public partial class Chat : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card mt-4");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "card-body");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.AddMarkupContent(6, "<h5 class=\"card-title\">Open Chat</h5>\r\n        ");
            __builder.OpenComponent<XChat.Components.Chat.AddChatRoom.AddChatRoom>(7);
            __builder.AddAttribute(8, "OnChatRoomCreate", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<XChat.Models.Chat.AddChatRoomDto>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<XChat.Models.Chat.AddChatRoomDto>(this, 
#nullable restore
#line 7 "C:\Users\melbasuony\Desktop\XChat\Pages\Chat.razor"
                                       _OnChatRoomCreate

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(9, "\r\n        ");
            __builder.OpenElement(10, "button");
            __builder.AddAttribute(11, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "C:\Users\melbasuony\Desktop\XChat\Pages\Chat.razor"
                          _OnBackToHomeClicked

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "class", "btn btn-primary mt-3");
            __builder.AddContent(13, "Back To Home");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n<br>\r\n");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "card mt-4");
            __builder.AddMarkupContent(19, "\r\n    ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "card-body");
            __builder.AddMarkupContent(22, "\r\n        ");
            __builder.AddMarkupContent(23, "<h5 class=\"card-title\">Rooms</h5>\r\n        ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "col-12 d-flex flex-sm-column flex-md-row flex-wrap-reverse");
            __builder.AddMarkupContent(26, "\r\n");
#nullable restore
#line 16 "C:\Users\melbasuony\Desktop\XChat\Pages\Chat.razor"
             foreach (var room in _chatRooms)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(27, "                ");
            __builder.OpenComponent<XChat.Components.Chat.ChatRoom.ChatRoom>(28);
            __builder.AddAttribute(29, "Room", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<XChat.Models.Chat.ChatRoomDto>(
#nullable restore
#line 18 "C:\Users\melbasuony\Desktop\XChat\Pages\Chat.razor"
                                            room

#line default
#line hidden
#nullable disable
            ));
            __builder.SetKey(
#nullable restore
#line 18 "C:\Users\melbasuony\Desktop\XChat\Pages\Chat.razor"
                                room

#line default
#line hidden
#nullable disable
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(30, "\r\n");
#nullable restore
#line 19 "C:\Users\melbasuony\Desktop\XChat\Pages\Chat.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(31, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime _jsRuntime { get; set; }
    }
}
#pragma warning restore 1591
