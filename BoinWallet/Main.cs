using UIKit;
using Microsoft.WindowsAzure.MobileServices;

namespace BoinWallet
{
    public class Application
    {

        public static MobileServiceClient MobileService = new MobileServiceClient("https://boinwallet.azurewebsites.net");

        // This is the main entry point of the application.
        static void Main(string[] args)
        {
            // if you want to use a different Application Delegate class from "AppDelegate"
            // you can specify it here.
            UIApplication.Main(args, null, "AppDelegate");
        }
    }
}
