namespace BlazorEcommerce.Server.Services.Category_Service
{
    public interface ICategoryService
    {

        Task<ServiceResponse<List<Category>>> GetCategories();
    }
}
