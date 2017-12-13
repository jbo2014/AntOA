using System;
using System.Collections.Generic;
using System.Linq;
using Data;

namespace Ant.Service
{
    public abstract class BaseManager
    {
        private IRepository _repository;
        public IRepository Repository
        {
            get
            {
                if (_repository == null)
                {
                    _repository = new Repository();
                }
                return _repository;
            }
        }
    }
}
