using SMS.Model;
using SMS.Service.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Repository.Repositories
{
    public class CoursRepository
        : RepositoryBase, ICoursRepository
    {
        public CoursRepository(SMSDatabaseEntities dc)
            : base(dc)
        {

        }
        public void Add(Cours entity)
        {
            DataContext.Courses.Add(entity);
        }

        public int CountAll()
        {
            return DataContext.Courses.Count();
        }

        public int CountBy(global::XMen.Query.Query query)
        {
            string s = query.BuildQuery();
            return DataContext.Courses.SqlQuery(s).Count();
        }

        public Cours CreateObject()
        {
            return new Cours();
        }

        public IEnumerable<Cours> FindAll()
        {
            return DataContext.Courses;
        }

        public IEnumerable<Cours> FindAll(int index, int count)
        {
            return DataContext.Courses.Skip(index).Take(count);
        }

        public Cours FindBy(Guid id)
        {
            return DataContext.Courses.FirstOrDefault(t => t.Id == id);
        }

        public IEnumerable<Cours> FindBy(global::XMen.Query.Query query)
        {
            return DataContext.Courses.SqlQuery(query.BuildQuery());
        }

        public IEnumerable<Cours> FindBy(global::XMen.Query.Query query, int index, int count)
        {
            return DataContext.Courses.SqlQuery(query.BuildQuery()).Skip(index).Take(count);
        }

        public void Remove(Cours entity)
        {
            DataContext.Courses.Remove(entity);
        }

        public void Update(Cours entity)
        {
            DataContext.SaveChanges();
        }
    }
}
