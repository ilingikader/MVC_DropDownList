﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;

namespace MVC_DropDownList.Models
{
    public class Ulke
    {
        public int UlkeId { get; set; }
        public string UlkeAdi { get; set; }

        public static List<Ulke> UlkeGetir()
        {
            return new List<Ulke>()
            {
                new Ulke() { UlkeId = 1, UlkeAdi = "Türkiye" },
                new Ulke() { UlkeId = 2, UlkeAdi = "İtalya" },
                new Ulke() { UlkeId = 3, UlkeAdi = "Fransa" },
            };
        }

    }
}