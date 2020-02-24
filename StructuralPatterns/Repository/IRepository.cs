using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DesignPatternCheatSheet.Repository
{
    public interface IRepository<T>
    {
        public void add(T obj);
        public void addRange(IEnumerable<T> range);
        public void remove(T obj);
        public void removeRange(IEnumerable<T> range);
        public T get(int id);
        public IEnumerable<T> getAll();
        public IEnumerable<T> find(Expression<Func<T>> predicate);
    }
}
