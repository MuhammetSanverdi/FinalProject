﻿using System;
using System.Collections.Generic;
using System.Text;
using Entities.Abstract;

namespace Entities.Concrete
{
    public class Category:IEntity
    {
        //Çıplak class kalmasın
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}