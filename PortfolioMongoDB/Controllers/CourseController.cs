using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using PortfolioMongoDB.DAL.Entities;
using PortfolioMongoDB.DAL.Settings;
using System.Security.Cryptography.Pkcs;

namespace PortfolioMongoDB.Controllers
{
    public class CourseController : Controller
    {
        private readonly IMongoCollection<Courses> _courseCollection;
        public CourseController(IDatabaseSettings _databaseSettings)
        {
            var client = new MongoClient(_databaseSettings.ConnectionString);
            var database = client.GetDatabase(_databaseSettings.DatabaseName);
            _courseCollection = database.GetCollection<Courses>(_databaseSettings.CourseCollectionName);
        }
        public async Task<IActionResult> Index()
        {
            var values = await _courseCollection.Find(x => true).ToListAsync();
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateCourse()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateCourse(Courses courses)
        {
            await _courseCollection.InsertOneAsync(courses);
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> DeleteCourse(string id)
        {
            await _courseCollection.DeleteOneAsync(x => x.CourseID == id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public async Task<IActionResult> UpdateCourse(string id)
        {
            var value = await _courseCollection.Find(x => x.CourseID == id).FirstOrDefaultAsync();
            return View(value);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateCourse(Courses courses)
        {
            await _courseCollection.FindOneAndReplaceAsync(x => x.CourseID == courses.CourseID, courses);
            return RedirectToAction("Index");
        }
    }
}
