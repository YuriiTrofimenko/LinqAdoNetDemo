﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAdoNetDemo.DAO
{
    public class AuthorDAO : AbstractDAO<Author>
    {
        public AuthorDAO(DiseaseEntities1 _db) : base(_db)
        {

        }
        
    }
}
