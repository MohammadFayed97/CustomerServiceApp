namespace AppSquare.Shared.Server;

public interface IBaseController<TViewModel> 
    where TViewModel : BaseViewModel
{
    Task<IActionResult> Delete(Guid id);
    Task<IActionResult> Post([FromBody] TViewModel viewModel);
    Task<IActionResult> Put([FromBody] TViewModel viewModel);
}
