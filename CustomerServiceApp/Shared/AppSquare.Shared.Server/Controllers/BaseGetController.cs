namespace AppSquare.Shared.Server;

public class BaseGetController<TEntity, TViewModel> : ControllerBase, IBaseGetController
    where TEntity : BaseEntity
    where TViewModel : BaseViewModel
{
    private readonly IBaseGetUnitOfWork<TEntity, TViewModel> _unitOfWork;

    public BaseGetController(IBaseGetUnitOfWork<TEntity, TViewModel> unitOfWork) => _unitOfWork = unitOfWork;

    [HttpGet]
    public async Task<IActionResult> GetAllAsync()
    {
        IEnumerable<TViewModel> viewModels = await _unitOfWork.ReadAllAsync();
        return Ok(viewModels);
    }
    [HttpGet("{id}")]
    public async Task<IActionResult> GetByIdAsync(Guid id)
    {
        TViewModel viewModel = await _unitOfWork.ReadByIdAsync(id);
        return Ok(viewModel);
    }
}
