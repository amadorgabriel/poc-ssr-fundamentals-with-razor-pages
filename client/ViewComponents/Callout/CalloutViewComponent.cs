using client.Models;
using Microsoft.AspNetCore.Mvc;

namespace client.ViewComponents.Callout
{
    public class CalloutViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(string message)
        {
            CalloutViewModel viewModel = new CalloutViewModel{Message = message};
         
            if(message == null)
            {
                viewModel.Message = "Teste msg default";  
            }


            return View(viewModel);
        }
    }
}
