using System;
using System.Collections.Generic;
using System.Linq;
//using Data;
using Model;

namespace Ant.Service
{
    public abstract class BaseService
    {
        //private IRepository _repository;
        //public IRepository Repository
        //{
        //    get
        //    {
        //        if (_repository == null)
        //        {
        //            _repository = new Repository();
        //        }
        //        return _repository;
        //    }
        //}

        public SQLDB db = new SQLDB();
    }
}
