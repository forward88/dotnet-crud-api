﻿using Core.DataAccess.EntityFramework;
using Shop.DataAccess.Abstract;
using Shop.DataAccess.Concrete.EntityFramework.Configuration;
using Shop.Entities.Concrete;

namespace Shop.DataAccess.Concrete.EntityFramework
{
    public class EfUserRepository : EfRepository<User, ApplicationDbContext, int>, IUserRepository
    {
    }
}