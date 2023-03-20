using CommunityToolkit.Mvvm.Messaging.Messages;

namespace Example3.Messages;

public class DeleteItemMessage : ValueChangedMessage<string>
{
    public DeleteItemMessage(string value) : base(value)
    {

    }
}