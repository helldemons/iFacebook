namespace iFacebook.Client.Facebook
{
    public interface IReaction : IIdNameEntity
    {
        ReactionType getType();
    }
}
