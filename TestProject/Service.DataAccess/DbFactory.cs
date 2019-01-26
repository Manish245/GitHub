using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service.DataAccess.EntityModel;
namespace Service.DataAccess
{
 public  class DbFactory:IDbFactory
    {
        GanttChartEntityContainer dbContext;

        public GanttChartEntityContainer Init()
        {
            return dbContext ?? (dbContext = new GanttChartEntityContainer());
        }
    }
}
