﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string ProductListed ="Ürünler listelendi";
        public static string ProductCountOfCategoryError = "Bir kategoride en fazla 15 ürün bulunabilir";
        public static string ProductNameAlreadyExists = "Bu isimde zaten başka bir ürün var";
    }
}
