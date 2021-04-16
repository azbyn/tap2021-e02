using System;

namespace NAIKE.EntityFramework
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}
