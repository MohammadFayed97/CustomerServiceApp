﻿namespace AppSquare.Shared;

public class BaseValidator<TViewModel> : AbstractValidator<TViewModel>
    where TViewModel : BaseViewModel
{
    public BaseValidator()
    {
    }
}
