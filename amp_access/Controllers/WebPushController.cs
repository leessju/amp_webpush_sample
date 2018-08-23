using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebPush;

namespace amp_access.Controllers
{
    public class WebPushController : Controller
    {
        // https://github.com/web-push-libs/web-push-csharp
        // https://github.com/web-push-libs/web-push
        // https://glitch.com/edit/#!/web-push-codelab
        // https://web-push-codelab.glitch.me/
        public ActionResult Index()
        {
            var pushEndpoint    = @"https://fcm.googleapis.com/fcm/send/dhpapmn14tg:APA91bEFV6kKTb3KKaXoCv1AX6GlW9wVEnfkRTSTqP4mLr9nsJDE3lj_06TD5bNyl-JFVQf9A9xh2C9idXo3ATur-E1L7d10nCDdvanHKMOO--EnRl8P1Tlwu2xT-lBCubPd9XmSzRlU";
            var p256dh          = @"BE-ceh5xFFS_JP6Tho2hUOyYkDQMjgeW254khLbKILZphaUio5FlONgEoXSwZ3T_s1KeiIhc78YDoTS2v8ziI_g";
            var auth            = @"59NQn-N3yvkQOMASjECxiQ";

            var subject         = @"mailto:nicejames@gmail.com";
            var publicKey       = @"BCJqUeH5liwbNa-a9SxbHdGIUhqxACWIPoOUQHoixXU4DZjmRgN_7dJYIVmGhRyzvSpKQCdKwmSVsft6gfxqhpE";
            var privateKey      = @"8Nm10_AZI1TwJP1KKwa3gBYrLl2P0SXU-UUnoYPF538";

            var subscription = new PushSubscription(pushEndpoint, p256dh, auth);
            var vapidDetails = new VapidDetails(subject, publicKey, privateKey);

            var webPushClient = new WebPushClient();
            try
            {
	            webPushClient.SendNotification(subscription, "Hello~~~", vapidDetails);
                return Content("{\"status\":\"success\"}", "application/json", System.Text.Encoding.UTF8);
            }
            catch (WebPushException exception)
            {
	            Console.WriteLine("Http STATUS code" + exception.StatusCode);
                return Content("{\"status\":\"error\"}", "application/json", System.Text.Encoding.UTF8);
            }
            
            
        }
    }
}