using CommunityToolkit.Mvvm.Messaging.Messages;

namespace Example3.Messages;

public class AddItemMessage : ValueChangedMessage<string>
{
    public AddItemMessage(string value) : base(value)
    {

    }
}