using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service.DataAccess.GenericRepository;
using Service.Model;
namespace Service.Business
{
    public class GanttChattBusiness : IGanttChattBusiness
    {
        private IGenericRepository<GanttChartModel> _genericRepository;
        public GanttChattBusiness(IGenericRepository<GanttChartModel> genericRepository) {
            _genericRepository = genericRepository;

        }
        public IQueryable<GanttChartModel> GetGanttCharts() {

            List<GanttChartModel> item =new  List<GanttChartModel>();
            item.Add(new GanttChartModel() { Date=DateTime.Now.AddDays(1),Name="A"});
            item.Add(new GanttChartModel() { Date = DateTime.Now.AddDays(2), Name = "A" });
            item.Add(new GanttChartModel() { Date = DateTime.Now.AddDays(3), Name = "B" });
            item.Add(new GanttChartModel() { Date = DateTime.Now.AddDays(4), Name = "C" });
            item.Add(new GanttChartModel() { Date = DateTime.Now.AddDays(5), Name = "D" });
            item.Add(new GanttChartModel() { Date = DateTime.Now.AddDays(6), Name = "E" });
            item.Add(new GanttChartModel() { Date = DateTime.Now.AddDays(7), Name = "F" });
            item.Add(new GanttChartModel() { Date = DateTime.Now.AddDays(8), Name = "G" });
            item.Add(new GanttChartModel() { Date = DateTime.Now.AddDays(9), Name = "H" });
            item.Add(new GanttChartModel() { Date = DateTime.Now.AddDays(10), Name = "I" });
            item.Add(new GanttChartModel() { Date = DateTime.Now.AddDays(11), Name = "J" });

            return item.AsQueryable();

           // return _genericRepository.GetAll();
        }
    }
}
