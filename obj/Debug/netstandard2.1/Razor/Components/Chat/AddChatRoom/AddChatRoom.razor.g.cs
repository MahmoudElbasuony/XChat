#pragma checksum "C:\Users\melbasuony\Desktop\XChat\Components\Chat\AddChatRoom\AddChatRoom.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "535fe3f8cf5425b11cea6281220372a4ae860e59"
// <auto-generated/>
#pragma warning disable 1591
namespace XChat.Components.Chat.AddChatRoom
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
    public partial class AddChatRoom : Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "card-body");
            __builder.AddMarkupContent(5, "\r\n\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(6);
            __builder.AddAttribute(7, "EditContext", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Forms.EditContext>(
#nullable restore
#line 5 "C:\Users\melbasuony\Desktop\XChat\Components\Chat\AddChatRoom\AddChatRoom.razor"
                              _editContext

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "class", "form-inline  d-flex align-items-start");
            __builder.AddAttribute(9, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 5 "C:\Users\melbasuony\Desktop\XChat\Components\Chat\AddChatRoom\AddChatRoom.razor"
                                                                                                         _OnChatRoomCreate

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(11, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(12);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(13, "\r\n            ");
                __builder2.OpenElement(14, "div");
                __builder2.AddAttribute(15, "class", "form-group col-9");
                __builder2.AddMarkupContent(16, "\r\n                ");
                __builder2.AddMarkupContent(17, "<label for=\"chat-room-name\" class=\"sr-only\">Room Name</label>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(18);
                __builder2.AddAttribute(19, "id", "chat-room-name");
                __builder2.AddAttribute(20, "class", "form-control col-12");
                __builder2.AddAttribute(21, "placeholder", "Chat Room Name");
                __builder2.AddAttribute(22, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 9 "C:\Users\melbasuony\Desktop\XChat\Components\Chat\AddChatRoom\AddChatRoom.razor"
                                                            _addChatRoomDto.RoomName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(23, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _addChatRoomDto.RoomName = __value, _addChatRoomDto.RoomName))));
                __builder2.AddAttribute(24, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _addChatRoomDto.RoomName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(25, "\r\n                ");
                __Blazor.XChat.Components.Chat.AddChatRoom.AddChatRoom.TypeInference.CreateValidationMessage_0(__builder2, 26, 27, 
#nullable restore
#line 10 "C:\Users\melbasuony\Desktop\XChat\Components\Chat\AddChatRoom\AddChatRoom.razor"
                                           ()=> _addChatRoomDto.RoomName

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(28, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(29, "\r\n            ");
                __builder2.OpenElement(30, "div");
                __builder2.AddAttribute(31, "class", "col-3");
                __builder2.AddMarkupContent(32, "\r\n                ");
                __builder2.OpenElement(33, "button");
                __builder2.AddAttribute(34, "type", "submit");
                __builder2.AddAttribute(35, "disabled", 
#nullable restore
#line 13 "C:\Users\melbasuony\Desktop\XChat\Components\Chat\AddChatRoom\AddChatRoom.razor"
                                                _isFormInvalid

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(36, "class", "btn btn-primary mb-2 float-right");
                __builder2.AddContent(37, "Create Room");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(39, "\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(40, "\r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.XChat.Components.Chat.AddChatRoom.AddChatRoom
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
