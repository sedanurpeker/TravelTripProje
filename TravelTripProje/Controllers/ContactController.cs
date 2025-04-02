using System.Web.Mvc;
using TravelTripProje.Models.Siniflar;

namespace TravelTripProje.Controllers
{
    public class ContactController : Controller
    {
        private readonly Context _context = new Context();

        // GET: İletişim formunu gösterir
        [HttpGet]
        public ActionResult Index()
        {
            return View(new Iletisim()); // Boş bir Iletisim nesnesi ile formu aç
        }

        // POST: Kullanıcıdan gelen mesajı kaydeder
        [HttpPost]
        public ActionResult SendMessage(Iletisim iletisim)
        {
            _context.Iletisims.Add(iletisim);
            _context.SaveChanges();
            return View("Index", new Iletisim()); // Formu sıfırlanmış şekilde geri döndür
        }
    }
}