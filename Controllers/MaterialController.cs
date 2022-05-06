using System;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using System.Linq;
using System.Net;
using System.Net.Http;
using DevExtremeAsp.Models;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace DevExtremeAsp.Controllers {

    //[Route("api/[controller]")]
    public class MaterialController : Controller {
        private readonly DevExtremeAspDBContext _dbContext;
        public MaterialController(DevExtremeAspDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult MatDelete(int id) {
            var mode = _dbContext.TMaterials
                .SingleOrDefault(u => u.MatId.Equals(id));
            try{
            _dbContext.TMaterials.Remove(mode);
            _dbContext.SaveChanges();
            }  
            catch{}          
            //CreateViewBags(0,0);                
            //ViewData["panel"]=4;
            return RedirectToAction("Index","Home");
        }


        [HttpGet]
        public IActionResult MatCreate() {
            //CreateViewBags(0,0);
            return View();      
        }

        [HttpPost]
        public IActionResult MatCreate(TMaterial material,string actionType) {
            if(actionType=="Add"){
             if (ModelState.IsValid){
                    try{
                        _dbContext.TMaterials.Add(material); 
                        _dbContext.SaveChanges();
                   }
                 catch{return View("Error");}
                 } 
            else {
                //CreateViewBags(0,0);    
                return View(material);
                }
            }
            //CreateViewBags(0,0);    

            return RedirectToAction("Index","Home");
        }



        [HttpGet]
        public IActionResult MatEdit(int id) {
            try{
            if (id==0){return View();}
            else{
            var model = _dbContext.TMaterials
                .SingleOrDefault(u => u.MatId.Equals(id));
            //CreateViewBags(0,0,model.MatClass);  
            return View(model);
            }
            }
            catch{return View("Error");}            
        }

        [HttpPost]
        public IActionResult MatEdit(int id , TMaterial material,string actionType) {
            if (actionType=="Update"){
            if (ModelState.IsValid){
                try{
                    _dbContext.TMaterials.Update(material);
                    _dbContext.SaveChanges();
                }
                catch{}
                }
                else {
                    //CreateViewBags(0,0,material.MatClass);    
                    //ViewData["panel"]=3;
                    //return View(material);
                }
            }
            //CreateViewBags(0,0,material.MatClass);    
            //ViewData["panel"]=4;

            return RedirectToAction("Index","Home");//,new{panel=4,Code=material.MatClass});
        } 


        [HttpGet]
        public object Get(DataSourceLoadOptions loadOptions) {
            var queryc = from p in _dbContext.TMaterials
                         select p;
            var qList = queryc.ToList();
            var model = qList;
            return DataSourceLoader.Load(model, loadOptions);
        }

    }
}