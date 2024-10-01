using SE310.P11.WebsiteQuanLySanPham.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SE310.P11.WebsiteQuanLySanPham.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            string connect = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=QuanLySanPham;User ID=master;Password=111111;TrustServerCertificate=True";
            QuanLySanPhamDataContext context = new QuanLySanPhamDataContext(connect);
            List<Product> dsProduct = context.Products.ToList();
            return View(dsProduct);
        }
    }
}