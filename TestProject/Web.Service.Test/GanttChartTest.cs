using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Service.Business;
using Service.DataAccess;
using Service.DataAccess.GenericRepository;
using Service.Model;
using WebService.Controllers;

namespace Web.Service.Test
{
    [TestClass]
    public class GanttChartTest
    {
        [TestMethod]
        public void GanttChatt_Is_Not_EqualTo_Zero()
        {
            IDbFactory dbFactory = new DbFactory();
            IGenericRepository<GanttChartModel> genericRepository = new GenericRepository<GanttChartModel>(dbFactory);
            IGanttChattBusiness _ganttChartBusiness = new GanttChattBusiness(genericRepository);
            GanttChartController controller = new GanttChartController(_ganttChartBusiness);
            // var ss = controller.Get();
            // Assert.AreNotEqual(0, );
        }
    }
}
