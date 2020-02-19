using HoneyBee.ApplicationCore.Entities;
using HoneyBee.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HoneyBee.ApplicationCore.Services
{
    public class CategoryService<T> where T: Category
    {
        readonly ICategoryRepository<T> categoryRepository;
        public CategoryService(ICategoryRepository<T> _categoryRepository)
        {
            categoryRepository = _categoryRepository;
        }
        public async Task<int> Add(T category)
        {
            if (string.IsNullOrWhiteSpace(category.Description))
            {
                throw new Exception("Description requires a value");
            }
            if (!string.IsNullOrWhiteSpace(category.Code))
            {
                if (categoryRepository.IfCodeExists(category.Code, category.CompanyId))
                {
                    throw new Exception("A record with a similar code already exixst");
                }
            }
            if (categoryRepository.IfDescriptionExists(category.Description, category.CompanyId))
            {
                throw new Exception("A record with a similar description already exixst");
            }

            categoryRepository.Add(category);
            await categoryRepository.SaveChangesAsync();

            return category.Id;
        }

        public async Task<bool> Update(T category)
        {
            if (string.IsNullOrWhiteSpace(category.Description))
            {
                throw new Exception("Description requires a value");
            }
            if (!string.IsNullOrWhiteSpace(category.Code))
            {
                if (categoryRepository.IfDeplicateCode(category.Id, category.Code, category.CompanyId))
                {
                    throw new Exception("Updating record with the provided code would create a duplicate record");
                }
            }
           
            if (categoryRepository.IfDeplicateDescription(category.Id, category.Description, category.CompanyId))
            {
                throw new Exception("Updating record with the provided description would create a duplicate record");
            }
            
            categoryRepository.Update(category);
            await categoryRepository.SaveChangesAsync();

            return true;
        }
    }
}
