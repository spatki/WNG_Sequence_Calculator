using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WNG_Sequences.Service;
using WNG_Sequences.WebUI.Models;
using WNG_Sequences.Core.Model;

namespace WNG_Sequences.WebUI.Controllers
{
    public class HomeController : Controller
    {
        protected readonly ISequenceService _service;

        public HomeController(ISequenceService service)
        {
            this._service = service;
        }

        public ActionResult Index()
        {
            return View("Index");
        }

        public ActionResult Help()
        {
            return View("Help");
        }

        public ActionResult GenerateSequences(UserInput input)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    Response.StatusCode = 403;
                    input.CustomValidation = true;
                    input.CustomValidationMessage = "";
                    foreach (var err in ModelState["InputNumber"].Errors)
                    {
                        // Add errors 
                        input.CustomValidationMessage = input.CustomValidationMessage + ((input.CustomValidationMessage != null && input.CustomValidationMessage != "") ? ", " : "") + err.ErrorMessage;
                    }
                    return Json(input, JsonRequestBehavior.AllowGet);
                }
                return Json(_service.GenerateSequence(input.InputNumber), JsonRequestBehavior.AllowGet);
            }
            catch (IndexOutOfRangeException e)
            {
                Response.StatusCode = 400;
                input.CustomValidation = true;
                input.CustomValidationMessage = e.Message;
                return Json(input, JsonRequestBehavior.AllowGet);
            }
            catch (FormatException e)
            {
                Response.StatusCode = 400;
                input.CustomValidation = true;
                input.CustomValidationMessage = e.Message;
                return Json(input, JsonRequestBehavior.AllowGet);
            }
            catch (Exception e)
            {
                Response.StatusCode = 500;
                input.CustomValidation = true;
                input.CustomValidationMessage = "Application Error: Pl. try again";
                return Json(input, JsonRequestBehavior.AllowGet);
            }
        }

    }
}
