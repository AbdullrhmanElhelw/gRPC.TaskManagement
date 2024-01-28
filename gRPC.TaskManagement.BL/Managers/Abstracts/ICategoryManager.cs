using gRPC.TaskManagement.BL.DTOs.CategoryDTOs;

namespace gRPC.TaskManagement.BL.Managers.Abstracts;

public interface ICategoryManager
{
    Task CreateAsync(CreateCategoryDTO categoryDTO);

    Task<CategoryReadDTO> GetCategory(int id);

    Task<IQueryable<CategoryReadDTO>> GetAllCategoriesAsync();

    Task<IQueryable<CategoryReadDTO>> FindByName(string name);

    Task<IQueryable<CategoryReadDTO>> GetAllWithPaging(int page, int limit);

    Task DeleteAsync(int id);

    Task UpdateAsync(int id, CategoryUpdateDTO updateDTO);
}