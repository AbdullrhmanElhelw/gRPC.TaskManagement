using gRPC.TaskManagement.BL.DTOs.CategoryDTOs;
using gRPC.TaskManagement.BL.Managers.Abstracts;
using gRPC.TaskManagement.DAL.Models;
using gRPC.TaskManagement.DAL.Repositories.Abstracts;
using gRPC.TaskManagement.DAL.UnitOfWork;

namespace gRPC.TaskManagement.BL.Managers.Implementations;

public class CategoryManager
    : ICategoryManager
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IBaseRepository<Category> _repository;

    public CategoryManager(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
        _repository = _unitOfWork.GetRepository<Category>();
    }

    public Task CreateAsync(CreateCategoryDTO categoryDTO)
    {
        _repository.CreateAsync(categoryDTO);
        return _unitOfWork.Commit();
    }

    public async Task DeleteAsync(int id)
    {
        var category = await _repository.GetAsync(id);
        await _repository.DeleteAsync(category!);
        await _unitOfWork.Commit();
    }

    public async Task<IQueryable<CategoryReadDTO>> FindByName(string name)
    {
        var categories = await _repository.FindAsync(x => x.Name.Equals(name, StringComparison.CurrentCultureIgnoreCase));
        return categories.ToCategoryReadDTO();
    }

    public async Task<IQueryable<CategoryReadDTO>> GetAllCategoriesAsync()
    {
        var categories = await _repository.GetAllAsync();
        return categories.ToCategoryReadDTO();
    }

    public async Task<IQueryable<CategoryReadDTO>> GetAllWithPaging(int page, int limit)
    {
        var categories = await _repository.GetAllWithPaging(page, limit);
        return categories.ToCategoryReadDTO();
    }

    public async Task<CategoryReadDTO> GetCategory(int id)
    {
        return await _repository.GetAsync(id);
    }

    public async Task UpdateAsync(int id, CategoryUpdateDTO updateDTO)
    {
        var findEntity = await _repository.GetAsync(id);

        if (findEntity is null)
            throw new NullReferenceException(nameof(findEntity));

        findEntity.Name = updateDTO.Name;
        findEntity.Description = updateDTO.Description;

        await _repository.UpdateAsync(findEntity);
        await _unitOfWork.Commit();
    }
}