using Microsoft.AspNetCore.Mvc;

namespace CrmUygulamasi.UI.ViewComponents
{
    public class ModalViewComponent: ViewComponent
    {
        public IViewComponentResult Invoke(string modalId, string headerText, string formId, string buttonText, string buttonClass, string detailDivId)
        {
            ModalVCModel model = new ModalVCModel();
            model.ModalId = modalId;
            model.HeaderText = headerText;
            model.FormId = formId;
            model.ButtonText = buttonText;
            model.ButtonClass = buttonClass;
            model.DetailDivId = detailDivId;

            return View(model);
        }
    }
}


public class ModalVCModel
{
    public string ModalId { get; set; }
    public string HeaderText { get; set; }
    public string FormId { get; set; }
    public string ButtonText { get; set; }
    public string ButtonClass { get; set; }
    public string DetailDivId { get; set; }
}