﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HotelReservationSystem.Controllers
{
    public class OrdersController : Controller
    {
        public ActionResult New()
        {
            return View();
        }
    }
}