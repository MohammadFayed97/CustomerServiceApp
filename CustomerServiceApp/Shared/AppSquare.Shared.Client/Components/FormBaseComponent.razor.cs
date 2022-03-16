namespace AppSquare.Shared.Client.Components;

public partial class FormBaseComponent<TViewModel>
    where TViewModel : BaseViewModel
{
    [Parameter]
    public TViewModel ViewModel { get; set; }
    [Parameter]
    public string FormTitle { get; set; }
    [Parameter]
    public EventCallback<TViewModel> HandleValidSubmit { get; set; }
    [Parameter]
    public EventCallback OnCancel { get; set; }
    [Parameter]
    public RenderFragment ChildContent { get; set; }
    [Parameter]
    public RenderFragment FooterContent { get; set; }
    [Parameter]
    public SystemFeatureType SystemFeature { get; set; }

    public override Task SetParametersAsync(ParameterView parameters)
    {
        if(ViewModel is null) 
            ViewModel = Activator.CreateInstance<TViewModel>();

        return base.SetParametersAsync(parameters);
    }
}
