using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BeijingYouth.Pub.Models;
using BeijingYouth.Pub.Models.JSJL;
using BeijingYouth.Pub.Service.JSJL;

namespace BeijingYouth.Web.Areas.JSJL.Controllers
{
    public class MessagesController : Controller
    {
        private BeijingYouthContext db = new BeijingYouthContext();

        // GET: JSJL/Messages
        public ActionResult Index()
        {
            return View(db.Messages);
        }

        // GET: JSJL/Messages/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Message messages = db.Messages.Find(id);
            if (messages == null)
            {
                return HttpNotFound();
            }
            return View(messages);
        }

        // GET: JSJL/Messages/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: JSJL/Messages/Create
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Send,Receive,Content,SendDate,Type")] Message messages)
        {
            messages.Type = MessageType.Type.好友消息.ToString();
            var isSuccess = MessagesService.CreateMessage(messages);
            if (isSuccess)
            {
                return RedirectToAction("Index");
            }
            return View(messages);
        }

        /// <summary>
        /// 发送消息
        /// </summary>
        /// <param name="messages">消息模型</param>
        /// <returns>发送结果</returns>
        [HttpPost]
        public ActionResult Send(Message messages)
        {
            messages.Type = MessageType.Type.好友消息.ToString();
            var isSuccess = MessagesService.CreateMessage(messages);
            
            if (isSuccess)
            {
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
            //messages.Type = MessageType.Type.好友信息.ToString();
            //var isSuccess = MessagesService.CreateMessage(messages);
            //var result = new {IsSuccess = isSuccess};
            //return Json(result,JsonRequestBehavior.DenyGet);
        }

        // GET: JSJL/Messages/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Message messages = db.Messages.Find(id);
            if (messages == null)
            {
                return HttpNotFound();
            }
            return View(messages);
        }

        // POST: JSJL/Messages/Edit/5
        // 为了防止“过多发布”攻击，请启用要绑定到的特定属性，有关 
        // 详细信息，请参阅 http://go.microsoft.com/fwlink/?LinkId=317598。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Send,Receive,Content,SendDate,Type")] Message messages)
        {
            if (ModelState.IsValid)
            {
                db.Entry(messages).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(messages);
        }

        // GET: JSJL/Messages/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Message messages = db.Messages.Find(id);
            if (messages == null)
            {
                return HttpNotFound();
            }
            return View(messages);
        }

        // POST: JSJL/Messages/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Message messages = db.Messages.Find(id);
            db.Messages.Remove(messages);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
