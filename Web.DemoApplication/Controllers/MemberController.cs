using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Services.Description;
using Web.DemoApplication.DemoWcfService;
using Web.DemoApplication.Helper;
using MemberEntity = Web.DemoApplication.Models.MemberEntity;

namespace Web.DemoApplication.Controllers
{
    public class MemberController : Controller
    {
        private IMemberServices _memberServices;
        private DataConverter _dataConverter;
        public MemberController()
        {
            _memberServices = new MemberServicesClient();
            _dataConverter = new DataConverter();
        }

        public ActionResult AllMembers(string message = "", int messageType = 0)
        {
            try
            {
                var returnResult = _memberServices.GetAllMember();
                if (returnResult == null) return View(new List<MemberEntity>());
                List<MemberEntity> memberEntities = _dataConverter.ConvertArrayToList(returnResult);
                if (!String.IsNullOrEmpty(message))
                    if (messageType == 1) ViewBag.successMessage = message;
                    else ViewBag.errorMessage = message;

                return View(memberEntities);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet]
        public ActionResult AddMember()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddMember(DemoWcfService.MemberEntity memberEntity)
        {
            try
            {
                _memberServices.Insert(memberEntity);
                return RedirectToAction("AllMembers", new { message = "data saved successfully", messageType = 1 });
            }
            catch (Exception ex)
            {
                return RedirectToAction("AllMembers", new { message = "operation failed", messageType = 0 });
            }
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            return View(_memberServices.LoadById(id));
        }

        [HttpPost]
        public ActionResult Edit(DemoWcfService.MemberEntity memberEntity)
        {
            try
            {
                _memberServices.Update(memberEntity);
                return RedirectToAction("AllMembers", new { message = "data updated successfully", messageType = 1 });
            }
            catch (Exception)
            {
                return RedirectToAction("AllMembers", new { message = "operation failed", messageType = 0 });
            }
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            return View(_memberServices.LoadById(id));
        }

        [HttpPost]
        public ActionResult Delete(DemoWcfService.MemberEntity memberEntity)
        {
            try
            {
                _memberServices.Delete(memberEntity);
                return RedirectToAction("AllMembers", new { message = "data deleted successfully", messageType = 1 });
            }
            catch (Exception)
            {
                return RedirectToAction("AllMembers", new { message = "operation failed", messageType = 0 });
            }
        }

    }
}