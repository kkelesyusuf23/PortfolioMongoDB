using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using PortfolioMongoDB.DAL.Entities;
using PortfolioMongoDB.DAL.Settings;

namespace PortfolioMongoDB.Controllers
{
    public class FeatureController : Controller
    {
        private readonly IMongoCollection<Feature> _featureCollection;
        public FeatureController(IDatabaseSettings _databaseSettings)
        {
            var client = new MongoClient(_databaseSettings.ConnectionString);
            var database = client.GetDatabase(_databaseSettings.DatabaseName);
            _featureCollection = database.GetCollection<Feature>(_databaseSettings.FeatureCollectionName);
        }
        public async Task<IActionResult> Index()
        {
            var values =await  _featureCollection.Find(x => true).ToListAsync();
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateFeature()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateFeature(Feature feature)
        {
            await _featureCollection.InsertOneAsync(feature);
            return RedirectToAction("Index");
        }
    }
}