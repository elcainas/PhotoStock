using PhotoStock.BusinessLogic;
using PhotoStock.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PhotoStock.Web.Controllers
{
    public class AlbumController : Controller
    {
        private AlbumBL _albumBL;
        private AlbumBL AlbumBL
        {
            get
            {
                _albumBL = _albumBL == null ? new AlbumBL() : _albumBL;
                return _albumBL;
            }
        }

        private PhotoBL _photoBL;
        private PhotoBL PhotoBL
        {
            get
            {
                _photoBL = _photoBL == null ? new PhotoBL() : _photoBL;
                return _photoBL;
            }
        }
        // GET: Album
        public ActionResult Index()
        {
            var list = AlbumBL.Get();
            return View(list);
        }

        // GET: Album/Details/5
        public ActionResult Details(int id)
        {
            var album = AlbumBL.Get(id);
            var photos = PhotoBL.GetPhotoByAlbumId(id);
            var vm = new AlbumViewModel();
            vm.Album = album.FirstOrDefault();
            vm.Photos = photos;
            return View(vm);
        }

        // GET: Album/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Album/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Album/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Album/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Album/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Album/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
