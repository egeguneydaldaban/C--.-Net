using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EgeGuneyDaldaban.Components
{
    public class NavigationMenuViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedItem = 1;
            List<string> menuItems = new List<string>() { "Create" };
            return View(menuItems);

        }
           
    }
}
