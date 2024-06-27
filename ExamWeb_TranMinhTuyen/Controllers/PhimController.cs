using ExamWeb_TranMinhTuyen.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamWeb_TranMinhTuyen.Controllers
{
    public class PhimController : Controller
    {
        private readonly ApplicationDbContext _db;
        public PhimController(ApplicationDbContext db)
        {
            _db = db;
        }
        //Hiển thị danh sách chủng loại
        public IActionResult Index()
        {
            var listPhim = _db.Phim.ToList();
            return View(listPhim);
        }
        //Hiển thị form thêm mới chủng loại
        public IActionResult Add()
        {
            return View();
        }
        // Xử lý thêm chủng loại mới
        [HttpPost]
        public IActionResult Add(Phim phim)
        {
            if (ModelState.IsValid) //kiem tra hop le
            {
                //thêm category vào table Categories
                _db.Phim.Add(phim);
                _db.SaveChanges();
                TempData["success"] = "Phim inserted success";
                return RedirectToAction("Index");
            }
            return View();
        }
        //Hiển thị form cập nhật chủng loại
        public IActionResult Update(int id)
        {
            var phim = _db.Phim.Find(id);
            if (phim == null)
            {
                return NotFound();
            }
            return View(phim);
        }
        // Xử lý cập nhật chủng loại
        [HttpPost]
        public IActionResult Update(Phim phim)
        {
            if (ModelState.IsValid) //kiem tra hop le
            {
                //cập nhật category vào table Categories
                _db.Phim.Update(phim);
                _db.SaveChanges();
                TempData["success"] = "Phim updated success";
                return RedirectToAction("Index");
            }
            return View(phim);
        }
        //Hiển thị form xác nhận xóa chủng loại
        public IActionResult Delete(int id)
        {
            var phim = _db.Phim.FirstOrDefault(x => x.Id == id);
            if (phim == null)
            {
                return NotFound();
            }
            return View(phim);
        }
        // Xử lý xóa chủng loại
        public IActionResult DeleteConfirmed(int id)
        {
            var phim = _db.Phim.Find(id);
            if (phim == null)
            {
                return NotFound();
            }
            _db.Phim.Remove(phim);
            _db.SaveChanges();
            TempData["success"] = "Phim deleted success";
            return RedirectToAction("Index");
        }
    }
}
