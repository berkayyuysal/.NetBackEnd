﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Core.DataAccess
{
    // Generic Constraint
    // class    : referans type
    // IEntity  : IEntity yada IEntity implemente eden bir nesne olmalı 
    // new      : newlenebilen bir nesne olmalı (interface newlenemediği için artık IEntity olamaz sadece IEntity impelementastonları olabilir.)
    public interface IEntityRepository<T> where T:class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
