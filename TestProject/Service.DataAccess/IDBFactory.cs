using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service.DataAccess.EntityModel;
namespace Service.DataAccess
{
    public interface IDbFactory
    {
        GanttChartEntityContainer Init();
    }
}
