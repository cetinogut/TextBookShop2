using System;
using System.Collections.Generic;
using System.Text;

namespace TextBookShop.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        ICategoryRepository Category { get; }
        ICourseTypeRepository CourseType { get; }
        IProductRepository Product { get; }
        ICompanyRepository Company { get; }
        //IApplicationUserRepository ApplicationUser { get; }
        ISP_Call SP_Call { get; }
        //IShoppingCartRepository ShoppingCart { get; }
        //IOrderHeaderRepository OrderHeader { get; }
        //IOrderDetailsRepository OrderDetails { get; }

        void Save();
    }
}
