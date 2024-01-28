using gRPC.TaskManagement.BL.DTOs.CategoryDTOs;
using gRPC.TaskManagement.BL.Managers.Abstracts;
using gRPC.TaskManagement.DAL.Enums;
using Grpc.Core;

namespace gRPC.TaskManagement.Presentation.Services;

public class CategoryService(ICategoryManager categoryManager)
    : CategoryItem.CategoryItemBase
{
    private readonly ICategoryManager _categoryManager = categoryManager;

    public override async Task<GetCategoryResponse> GetCategory(GetCategoryRequest request, ServerCallContext context)
    {
        var category = await _categoryManager.GetCategory(request.Id);
        if (category is null)
            throw new RpcException(new Grpc.Core.Status(StatusCode.NotFound, "Category not found"));
        return new GetCategoryResponse
        {
            Id = category.Id,
            Name = category.Name,
            Description = category.Description,
            Color = category.Color
        };
    }

    public override async Task<CreateCategoryResponse> CreateCategory(CreateCategoryRequest request, ServerCallContext context)
    {
        var category = new CreateCategoryDTO(request.Name, request.Description, TaskColor.Green);
        await _categoryManager.CreateAsync(category);
        return new CreateCategoryResponse
        {
            Id = category.Id,
            Name = category.Name,
            Description = category.Description,
            Color = category.Color.ToString()
        };
    }

    public override async Task GetAllCategories(GetAllCategoriesRequest request, IServerStreamWriter<GetAllCategoriesResponse> responseStream, ServerCallContext context)
    {
        var categories = await _categoryManager.GetAllCategoriesAsync();
        foreach (var category in categories)
        {
            await responseStream.WriteAsync(new GetAllCategoriesResponse
            {
                Id = category.Id,
                Name = category.Name,
                Description = category.Description,
                Color = category.Color
            });
        }
    }

    public override async Task<DeleteCategoryResponse> DeleteCategory(DeleteCategoryRequest request, ServerCallContext context)
    {
        if (request.Id <= 0)
            throw new RpcException(new Grpc.Core.Status(StatusCode.InvalidArgument, "Id must be greater than 0"));

        var categoryIsExist = await _categoryManager.GetCategory(request.Id);
        if (categoryIsExist is null)
            throw new RpcException(new Grpc.Core.Status(StatusCode.NotFound, "Category not found"));

        await _categoryManager.DeleteAsync(request.Id);
        return new DeleteCategoryResponse
        {
            Status = 200
        };
    }

    public override async Task<UpdateCategoryResponse> UpdateCategory(UpdateCategoryRequest request, ServerCallContext context)
    {
        if (request.Id <= 0)
            throw new RpcException(new Grpc.Core.Status(StatusCode.InvalidArgument, "Id must be greater than 0"));

        var updateDTO = new CategoryUpdateDTO(request.Id, request.Name, request.Description, TaskColor.Green);

        await _categoryManager.UpdateAsync(request.Id, updateDTO);

        return new UpdateCategoryResponse
        {
            Id = updateDTO.Id,
            Name = updateDTO.Name,
            Description = updateDTO.Description,
            Color = updateDTO.Color.ToString()
        };
    }

    public override async Task FindCategoryByName(FindCategoryByNameRequest request, IServerStreamWriter<GetAllCategoriesResponse> responseStream, ServerCallContext context)
    {
        var categories = await _categoryManager.FindByName(request.Name);

        foreach (var category in categories)
        {
            await responseStream.WriteAsync(new GetAllCategoriesResponse
            {
                Id = category.Id,
                Name = category.Name,
                Description = category.Description,
                Color = category.Color.ToString()
            });
        }
    }

    public override async Task GetAllCategoriesPaging(GetAllCategoriesPagingRequest request, IServerStreamWriter<GetAllCategoriesResponse> responseStream, ServerCallContext context)
    {
        var categories = await _categoryManager.GetAllWithPaging(request.Page, request.Limit);

        foreach (var category in categories)
        {
            await responseStream.WriteAsync(new GetAllCategoriesResponse
            {
                Id = category.Id,
                Name = category.Name,
                Description = category.Description,
                Color = category.Color.ToString()
            });
        }
    }
}