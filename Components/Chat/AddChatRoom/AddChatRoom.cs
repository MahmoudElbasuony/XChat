using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XChat.Models.Chat;

namespace XChat.Components.Chat.AddChatRoom
{
    public partial class AddChatRoom
    {

        private readonly List<string> _roomStyleClasses = new List<string>
        {
            "bg-primary",
            "bg-secondary",
            "bg-success",
            "bg-danger",
            "bg-warning",
            "bg-info",
            "bg-dark"
        };

        private AddChatRoomDto _addChatRoomDto { get; set; } = new AddChatRoomDto();
        private bool _isFormInvalid { get; set; } = true;
        private EditContext _editContext { get; set; }

        [Parameter]
        public EventCallback<AddChatRoomDto> OnChatRoomCreate { get; set; }

        protected override void OnInitialized()
        {
            _editContext = new EditContext(_addChatRoomDto);
            _editContext.OnFieldChanged += _OnAddRoomFormFieldChanged;
        }

        private void _OnChatRoomCreate()
        {
            _addChatRoomDto.StyleClass = _GetRandomChatRoomStyleClass();
            OnChatRoomCreate.InvokeAsync(_addChatRoomDto);
        }
        private void _OnAddRoomFormFieldChanged(object sender, FieldChangedEventArgs e)
        {
            Console.WriteLine("Changed");
            _isFormInvalid = !_editContext.Validate();
            StateHasChanged();
        }
        private string _GetRandomChatRoomStyleClass() => _roomStyleClasses[new Random().Next(_roomStyleClasses.Count)];

        public void Dispose()
        {
            _editContext.OnFieldChanged -= _OnAddRoomFormFieldChanged;
        }
    }
}
