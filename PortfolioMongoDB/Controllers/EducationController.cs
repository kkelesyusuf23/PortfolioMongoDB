﻿using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using PortfolioMongoDB.DAL.Entities;
using PortfolioMongoDB.DAL.Settings;

namespace PortfolioMongoDB.Controllers
{
    public class EducationController : Controller
    {
        private readonly IMongoCollection<Education> _educationCollection;
        public EducationController(IDatabaseSettings _databaseSettings) 
        {
            var client = new MongoClient(_databaseSettings.ConnectionString);
            var database = client.GetDatabase(_databaseSettings.DatabaseName);
            _educationCollection = database.GetCollection<Education>(_databaseSettings.EducationCollectionName);
        }
        public async Task<IActionResult> Index()
        {
            var values = await _educationCollection.Find(x => true).ToListAsync();
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateEducation()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateEducation(Education education)
        {
            await _educationCollection.InsertOneAsync(education);
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> DeleteEducation(string id)
        {
            await _educationCollection.DeleteOneAsync(x => x.EducationID == id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public async Task<IActionResult> UpdateEducation(string id)
        {
            var value = await _educationCollection.Find(x => x.EducationID == id).FirstOrDefaultAsync();
            return View(value);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateEducation(Education education)
        {
            await _educationCollection.FindOneAndReplaceAsync(x => x.EducationID == education.EducationID, education);
            return RedirectToAction("Index");
        }
    }
}
