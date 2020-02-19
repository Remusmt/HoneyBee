using HoneyBee.ApplicationCore.Entities;
using HoneyBee.ApplicationCore.Interfaces;
using HoneyBee.ApplicationCore.Services;
using HoneyBee.ApplicationCore.Services.TreeStructure;
using HoneyBee.Infrastructure.Data;
using HoneyBee.Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnitTestProject.ApplicationCore.Entities
{
    [TestClass]
    public class CustomerTypeTest
    {
        readonly Guid companyId = new Guid("af6ef9be-fcde-4b4f-beac-1b9e310cafa8");
        readonly ICategoryRepository<CustomerType> repository;
        readonly ICategoryRepository<SupplierType> repositoryCat;
        public CustomerTypeTest()
        {
            DbContextOptions<HoneyBeeContext> _options = new DbContextOptionsBuilder<HoneyBeeContext>()
                .UseSqlServer("Server=DESKTOP-LPOGMEO\\SQLEXPRESS;Database=HoneyBeeContextDB;Trusted_Connection=True;MultipleActiveResultSets=true").Options;

            HoneyBeeContext honeyBeeContext = new HoneyBeeContext(_options);
            repository = new CategoryRepository<CustomerType>(honeyBeeContext);
            repositoryCat = new CategoryRepository<SupplierType>(honeyBeeContext);
        }

        [TestMethod]
        public void Add()
        {
            CustomerType customerType = new CustomerType
            {
                CompanyId = companyId,
                Code = "02",
                Description = "Father",
                InActive = true,
                ParentCategoryId = 1
            };

            CustomerType dType = new CustomerType
            {
                CompanyId = companyId,
                Code = "03",
                Description = "Mother",
                InActive = true,
                ParentCategoryId = 1
            };

            dType.ChildCategories.Add(
                new CustomerType
                {
                    CompanyId = companyId,
                    Code = "04",
                    Description = "Child one"
                }
             );

            dType.ChildCategories.Add(
                new CustomerType
                {
                    CompanyId = companyId,
                    Code = "05",
                    Description = "Child two"
                }
             );

            customerType.ChildCategories.Add(
                new CustomerType
                {
                    CompanyId = companyId,
                    Code = "06",
                    Description = "Child three"
                }
             );

            customerType.ChildCategories.Add(
                new CustomerType
                {
                    CompanyId = companyId,
                    Code = "07",
                    Description = "Child four"
                }
             );


            repository.Add(customerType);
            repository.Add(dType);
            Assert.IsTrue(repository.SaveChanges() > 0);
        }

        [TestMethod]
        public void Update()
        {
            CustomerType customerTy = Task.Run(async () => await repository.GetByIdAsync(1)).GetAwaiter().GetResult();
            customerTy.Description = "Grand parents";
            CategoryService<CustomerType> categoryService = new CategoryService<CustomerType>(repository);
            Assert.IsTrue(Task.Run(async () => await categoryService.Update(customerTy)).GetAwaiter().GetResult());
        }

        [TestMethod]
        public void CheckCodeDuplicate()
        {
            CustomerType customerTy = Task.Run(async () => await repository.GetByIdAsync(1)).GetAwaiter().GetResult();
            customerTy.Code = "02";
            CategoryService<CustomerType> categoryService = new CategoryService<CustomerType>(repository);
            Assert.ThrowsExceptionAsync<Exception>(async () => await categoryService.Update(customerTy));
        }

        [TestMethod]
        public void CheckDescriptionDuplicate()
        {
            CustomerType customerTy = Task.Run(async () => await repository.GetByIdAsync(1)).GetAwaiter().GetResult();
            customerTy.Description = "Father";
            CategoryService<CustomerType> categoryService = new CategoryService<CustomerType>(repository);
            Assert.ThrowsExceptionAsync<Exception>(async () => await categoryService.Update(customerTy));
        }

        [TestMethod]
        public void CheckGet()
        {
            IReadOnlyList<CustomerType> custTypeList = Task.Run(async () => await repository.ListAllAsync()).GetAwaiter().GetResult();
            IReadOnlyList<SupplierType> supTypeList = Task.Run(async () => await repositoryCat.ListAllAsync()).GetAwaiter().GetResult();

            //custTypeList.ToList().RemoveAll(e => e.ParentCategory != null);
            List<CustomerType> customerTypes = custTypeList.ToList();

            customerTypes.RemoveAll(e => e.ParentCategory != null);

            Assert.IsTrue(customerTypes.Count == 2);
            Assert.AreEqual(supTypeList.Count, 0);
        }

    }
}
