using Fiorello.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Fiorello.ViewComponents
{


    public class HeaderVwComponent : ViewComponent
    {

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var datas = _layoutService.GetAllDatas();

            return await Task.FromResult(View(datas));
        }
    }
}
