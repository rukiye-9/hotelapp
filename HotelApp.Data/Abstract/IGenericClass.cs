﻿namespace HotelApp.Data.Abstract
{
    public interface IGenericClass<T> where T : class
    {
        void Insert(T t);
        void Update(T t);
        void Delete(T t);
        List<T> GetList();
        T GetByID(int id);

    }
}
