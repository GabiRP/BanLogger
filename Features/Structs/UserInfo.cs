using System.Text;

namespace BanLogger.Features.Structs
{
    public struct UserInfo
    {
        public UserInfo(string username, string userId, string userIP)
        {
            Username = username;
            UserId = userId;
            UserIP = userIP;
        }
        
        public string Username;
        public string UserId;
        public string UserIP;
        
        public string PublicInfo => string.IsNullOrEmpty(Username) ? "n/a" : Username;
        public string PrivateInfo => $"{(string.IsNullOrEmpty(Username) ? "n/a" : Username)} ({(string.IsNullOrEmpty(UserId) ? "n/a" : UserId)}) ||{(string.IsNullOrEmpty(UserIP) ? "n/a" : UserIP)}||";
    }
}