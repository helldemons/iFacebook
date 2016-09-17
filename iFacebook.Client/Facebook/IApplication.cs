using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iFacebook.Client.Facebook
{
    public interface IApplication
    {
        string getId();
        string getName();
        string getDescription();
        string getCategory();
        string getCompany();
        string getIconUrl();
        string getSubcategory();
        string getLink();
        string getLogoUrl();
        string getDailyActiveUsers();
        string getWeeklyActiveUsers();
        string getMonthlyActiveUsers();
        Dictionary<string, bool> getMigrations();
        List<string> getAppDomains();
        string getAuthDialogDataHelpUrl();
        string getAuthDialogDescription();
        string getAuthDialogHeadline();
        string getAuthDialogPermsExplanation();
        List<string> getAuthReferralUserPerms();
        List<string> getAuthReferralFriendPerms();
        string getAuthReferralDefaultActivityPrivacy();
        bool authReferralEnabled();
        List<string> getAuthReferralExtendedPerms();
        string getAuthReferralResponseType();
        bool canvasFluidHeight();
        bool canvasFluidWidth();
        string getCanvasUrl();
        string getContactEmail();
        long getCreatedTime();
        long getCreatorUid();
        string getDeauthCallbackUrl();
        string getIphoneAppStoreId();
        string getHostingUrl();
        string getMobileWebUrl();
        string getPageTabDefaultName();
        string getPageTabUrl();
        string getPrivacyPolicyUrl();
        string getSecureCanvasUrl();
        string getSecurePageTabUrl();
        string getServerIpWhiteList();
        bool socialDiscovery();
        string getTermsOfServiceUrl();
        string getUserSupportEmail();
        string getUserSupportUrl();
        string getWebsiteUrl();
        string getCanvasName();
    }
}
