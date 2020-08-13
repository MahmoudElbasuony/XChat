using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Components.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using XChat.Extentions;
using XChat.Models.Chat;

namespace XChat.Pages
{
    public partial class Chat
    {
        private const string Page_Title = "Chat";

        [Inject]
        private NavigationManager _navigator { get; set; }
        [Inject]
        private HttpClient _http { get; set; }

        private List<ChatRoomDto> _chatRooms { get; set; }

        public Chat()
        {
            _chatRooms = new List<ChatRoomDto>();
        }

        protected override void OnInitialized()
        {
            base.OnInitialized();
            _jsRuntime.SetPageTitle(Page_Title);
        }
        protected override async Task OnInitializedAsync()
        {
            _chatRooms = (await _http.GetFromJsonAsync<ChatRoomDto[]>("api/chatroom")).ToList();
        }

        private void _OnChatRoomCreate(AddChatRoomDto addChatRoomDto)
        {
            ChatRoomDto chatRoomDto = new ChatRoomDto
            {
                Id = Guid.NewGuid().ToString("D"),
                Name = addChatRoomDto.RoomName,
                StyleClass = addChatRoomDto.StyleClass
            };
            _chatRooms.Add(chatRoomDto);
        }

        private void _OnBackToHomeClicked(MouseEventArgs args)
        {
            _navigator?.NavigateTo("/");
        }

         
    }
}
