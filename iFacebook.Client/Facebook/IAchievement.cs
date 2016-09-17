using System;

namespace iFacebook.Client.Facebook
{
    public interface IAchievement : IFacebookResponse
    {
        string getId();
        IIdNameEntity getFrom();
        DateTime getStartTime();
        DateTime getEndTime();
        DateTime getPublishTime();
        IApplication getApplication();
        int getImportance();
        IAchievedObject getAchievement();
        IPagableList<ILike> getLikes();
        IPagableList<IComment> getComments();
    }
}
