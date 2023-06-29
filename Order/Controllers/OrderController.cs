using Order.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Order.Controllers
{
    [Route("[controller]/[action]")]
    public class OrderController : Controller
    {
        /// <summary>
        /// 取得訂單
        /// </summary>
        [HttpGet]
        public JsonResult getOrder(string orderid){
            return Json(new{id=orderid,name="歡樂全家桶",price=2000});
        }

        /// <summary>
        /// 數字加總
        /// </summary>
        /// <param name="addnumbers">加總數字</param>
        [HttpPost]
        public JsonResult add([FromBody]addModel addnumbers){
            return Json(new{anser=addnumbers.num1+addnumbers.num2});
        }

        [HttpGet]
        public string getOrderExcel()
        {
            string excelurl = "https://goodexcel.blob.core.windows.net/excel/FlooringEstimates.xlsx";
            return excelurl;
        }
        public class addModel{
            public int num1{get;set;}
            public int num2{get;set;}
        }
    }
}
