using client.Models;
using Microsoft.AspNetCore.Mvc;

namespace client.ViewComponents
{
    public class CalloutViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(string message)
        {
            var viewModel = new CalloutViewModel();
            viewModel.Message = message;

            if (message == null)
            {
                viewModel.Message = "Teste msg default";
            }

            return View(viewModel);
        }
    }
}
