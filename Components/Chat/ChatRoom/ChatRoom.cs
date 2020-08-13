using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XChat.Models.Chat;

namespace XChat.Components.Chat.ChatRoom
{
    public partial class ChatRoom
    {
        [Parameter]
        public ChatRoomDto Room { get; set; }= new ChatRoomDto();




    }
}
