using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace XChat.Models.Chat
{
    public class AddChatRoomDto
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Room name is required!")]
        [StringLength(30, MinimumLength = 5, ErrorMessage = "Room name length should be between 5-30 characters")]
        public string RoomName { get; set; }
        public string StyleClass { get; set; }
    }
}
