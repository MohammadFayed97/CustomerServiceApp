namespace Cities.Client.Components
{
    using Cities.Shared.ViewModels;
    using Microsoft.AspNetCore.Components;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public partial class CityDetailsComponent
    {
        [Parameter]
        public Guid CityId { get; set; }

        private CityViewModel cityViewModel = new CityViewModel();

        protected override async Task OnInitializedAsync()
        {
            cityViewModel = await _cityHttpService.GetCityByIdAsync($"/api/cities/{CityId}");
        }
    }
}
