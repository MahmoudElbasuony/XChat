using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
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
        public ChatRoomDto Room { get; set; } = new ChatRoomDto();
        private List<string> _roomMessages = new List<string>();
        private string _message { get; set; } = string.Empty;

        private void _OnSendMessage(KeyboardEventArgs args)
        {
            if (args.Key != "Enter")
                return;
            if (string.IsNullOrWhiteSpace(_message))
                return;
            _roomMessages.Add(_message);
            _message = string.Empty;
        }


    }
}
