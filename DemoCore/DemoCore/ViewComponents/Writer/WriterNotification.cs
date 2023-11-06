﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace DemoCore.ViewComponents.Writer
{
    public class WriterNotification:ViewComponent
    {
        NotificationManager nm = new NotificationManager(new EFNotificationRepository());
        public IViewComponentResult Invoke()
        {
            var values = nm.GetList();
            return View(values);
        }
    }
}
