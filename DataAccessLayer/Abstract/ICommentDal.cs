﻿using EntityLayer.concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
public    interface ICommentDal:IGenericDal<Comment>//Comment bu entitylayer içindeki conrete klasörünün içinde olduğu için ekledik kütüphaneyi 
    {
    }
}