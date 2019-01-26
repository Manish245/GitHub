using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
//using System.Web.Mvc;
using Service.Business;
using Service.Model;

namespace WebService.Controllers
{
    public class GanttChartController : ApiController
    {
        // GET: GanttChart
        private IGanttChattBusiness _ganttChartBusiness;
        public GanttChartController(IGanttChattBusiness ganttChartBusiness) {
            _ganttChartBusiness = ganttChartBusiness;
        }
        [HttpGet]
        public IQueryable<GanttChartModel> Get()
        {
            return _ganttChartBusiness.GetGanttCharts();
        }
    }
}