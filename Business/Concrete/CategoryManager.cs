﻿using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstarct;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CategoryManager:ICategoryService
    {
        ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            ICategoryDal _categoryDal = categoryDal;
        }
        public List<Category> GetAll()
        {
            //İş kodları

            return _categoryDal.GetAll();

        }
        //Select * from Categories where CategoryId = 3
        public Category GetById(int categoryId)
        {
            return _categoryDal.Get(c => c.CategoryId == categoryId);


        }
    }
}
