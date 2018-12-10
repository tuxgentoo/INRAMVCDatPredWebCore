using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace INRAMVCDatPredWebCore.Controllers
{
    public static class TempDataMessage
    {
        public static void AddMessage(this Controller controller, string identidier, string message)
        {
            if (controller.TempData.ContainsKey("messages"))
            {
                (controller.TempData["messages"] as Dictionary<string, string>).Add(identidier, message);
            }
            else
            {
                controller.TempData["messages"] = new Dictionary<string, string>
                {
                    [identidier] = message
                };
            }
        }

        public static void AddMessageFixed(this Controller controller, string identifier, string message)
        {
            if (controller.TempData.ContainsKey("messagesFixed"))
            {
                (controller.TempData["messagesFixed"] as Dictionary<string, string>).Add(identifier, message);
            }
            else
            {
                controller.TempData["messagesFixed"] = new Dictionary<string, string>
                {
                    [identifier] = message
                };
            }
        }
    }
}
