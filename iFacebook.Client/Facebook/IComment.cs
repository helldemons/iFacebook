using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iFacebook.Client.Facebook
{
    public interface IComment : IFacebookResponse
    {
        string getId();
        ICategory getFrom();
        string getMessage();
        List<ITag> getMessageTags();
        bool canComment();
        bool canRemove();
        bool canHide();
        bool canLike();
        DateTime getCreatedTime();
        int getLikeCount();
        int getCommentCount();
        bool isUserLikes();
        IAttachment getAttachment();
        IComment getParent();
    }
}
