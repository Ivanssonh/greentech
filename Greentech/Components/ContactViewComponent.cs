using Greentech.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Greentech.Components
{
    [ViewComponent(Name ="Contact")]
    public class ContactViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke (ContactViewModel model)
        {
            model ??= new ContactViewModel();
            return View(model);
        }
    }
}
