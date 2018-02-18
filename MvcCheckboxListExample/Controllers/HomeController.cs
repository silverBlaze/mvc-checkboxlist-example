using System.Collections.Generic;
using System.Web.Mvc;
using MvcCheckboxListExample.Models;

namespace MvcCheckboxListExample.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            var model = new FormStuff();

            //Dynamically add the "checkboxlist" items before returning the view
            model.Options = new List<FormOption> {
                new FormOption { Id = "abc", Label = "A.B.C." },
                new FormOption { Id = "bcd", Label = "BCD", Checked = true }, //this one will appear checked
                new FormOption { Id = "cde", Label = "C D E" },
                new FormOption { Id = "def",  Label = "Def." }
            };

            return View(model);
        }

        [HttpPost]
        public ActionResult Index(FormStuff model) {

            foreach(var item in model.Options) {
                if(item.Id == "abc" && item.Checked) {
                    //abc was checked, do something...
                }
                else if (item.Id == "bcd") {
                    var myBool = item.Checked;
                    //do something with the value of myBool, which is true if bcd was checked...
                }
                //... and so on.
            }

            return View(model);
        }
    }
}