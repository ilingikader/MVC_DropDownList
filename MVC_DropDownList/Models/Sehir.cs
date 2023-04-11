﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Mvc;

namespace MVC_DropDownList
{
    public class Sehir
    {
        public int SehirId { get; set; }
        public string SehirAdi { get; set; }
        public int UlkeId { get; set; }


        public static List<Sehir> SehirGetir()
        {
            return new List<Sehir>()
            {
                new Sehir() { SehirId = 1, SehirAdi = "İstanbul", UlkeId = 1 },
                new Sehir() { SehirId = 2, SehirAdi = "Ankara", UlkeId = 1 },
                new Sehir() { SehirId = 3, SehirAdi = "Floransa", UlkeId = 2 },
                new Sehir() { SehirId = 4, SehirAdi = "Roma", UlkeId = 2 },
                new Sehir() { SehirId = 5, SehirAdi = "Paris", UlkeId = 3 },
                new Sehir() { SehirId = 6, SehirAdi = "Nice", UlkeId = 3 }
                
            };
        }

       
    }
}