using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service.DataAccess.EntityModel;
namespace Service.DataAccess.GenericRepository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {

        private GanttChartEntityContainer dbContext;
        public GenericRepository(IDbFactory dbFactory)
        {
            DbFactory = dbFactory;
            dbContext = DbFactory.Init();
        }

        protected IDbFactory DbFactory
        {
            get;
            private set;
        }

        public IQueryable<T> GetAll()
        {
            return dbContext.Set<T>();
        }
    }
}
