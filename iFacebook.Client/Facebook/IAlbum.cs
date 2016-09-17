using System;

namespace iFacebook.Client.Facebook
{
    public interface IAlbum : IFacebookResponse
    {
        string getId();
        ICategory getFrom();
        string getName();
        string getDescription();
        string getLocation();
        string getLink();
        string getCoverPhoto();
        PrivacyType getPrivacy();
        int getCount();
        string getType();
        DateTime getCreatedTime();
        DateTime getUpdatedTime();
        bool canUpload();
        IPlace getPlace();
        IPagableList<ILike> getLikes();
        IPagableList<IComment> getComments();
        IPagableList<IReaction> getReactions();
    }
}
