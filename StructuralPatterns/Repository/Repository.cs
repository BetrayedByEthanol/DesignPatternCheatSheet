using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DesignPatternCheatSheet.Repository
{
    public abstract class Repository<T> : IRepository<T>
    {
        private string db { get; set; }
        public Repository(string DB)
        {
            db = DB;
        }
        public void add(T obj){}

        public void addRange(IEnumerable<T> range){}

        public IEnumerable<T> find(Expression<Func<T>> predicate) => new List<T>();

        public T get(int id) => default(T);

        public IEnumerable<T> getAll() => new List<T>();
        public void remove(T obj) { }
        
        public void removeRange(IEnumerable<T> range) {}
    }
}
