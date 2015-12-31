using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCommon
{

    public partial class MockObjectSet<T> : IDbSet<T> where T : class
    {
        ObservableCollection<T> _data;
        IQueryable _query;

        public MockObjectSet()
        {
            _data = new ObservableCollection<T>();
            _query = _data.AsQueryable();
        }

        public virtual T Find(params object[] keyValues)
        {
            throw new NotImplementedException("Derive from MockIbjectSet<T> and override Find");
        }

        public T Add(T item)
        {
            _data.Add(item);
            return item;
        }

        public T Remove(T item)
        {
            _data.Remove(item);
            return item;
        }

        public T Attach(T item)
        {
            _data.Add(item);
            return item;
        }

        public T Detach(T item)
        {
            _data.Remove(item);
            return item;
        }

        public T Create()
        {
            return Activator.CreateInstance<T>();
        }

        public TDerivedEntity Create<TDerivedEntity>() where TDerivedEntity : class, T
        {
            return Activator.CreateInstance<TDerivedEntity>();
        }

        public ObservableCollection<T> Local
        {
            get { return _data; }
        }

        Type IQueryable.ElementType
        {
            get { return _query.ElementType; }
        }

        System.Linq.Expressions.Expression IQueryable.Expression
        {
            get { return _query.Expression; }
        }

        IQueryProvider IQueryable.Provider
        {
            get { return _query.Provider; }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _data.GetEnumerator();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return _data.GetEnumerator();
        }
    }
}

    //public partial class MockObjectSet<T> : IObjectSet<T> where T : class
    //{
    //    private readonly IList<T> collection = new List<T>();

    //    #region IObjectSet<T> Members

    //    public void AddObject(T entity)
    //    {
    //        collection.Add(entity);
    //    }

    //    public void Attach(T entity)
    //    {
    //        collection.Add(entity);
    //    }

    //    public void DeleteObject(T entity)
    //    {
    //        collection.Remove(entity);
    //    }

    //    public void Detach(T entity)
    //    {
    //        collection.Remove(entity);
    //    }

    //    #endregion

    //    #region IEnumerable<T> Members

    //    public IEnumerator<T> GetEnumerator()
    //    {
    //        return collection.GetEnumerator();
    //    }

    //    #endregion

    //    #region IEnumerable Members

    //    IEnumerator IEnumerable.GetEnumerator()
    //    {
    //        return collection.GetEnumerator();
    //    }

    //    #endregion

    //    #region IQueryable<T> Members

    //    public Type ElementType
    //    {
    //        get { return typeof(T); }
    //    }

    //    public System.Linq.Expressions.Expression Expression
    //    {
    //        get { return collection.AsQueryable<T>().Expression; }
    //    }

    //    public IQueryProvider Provider
    //    {
    //        get { return collection.AsQueryable<T>().Provider; }
    //    }

    //    #endregion
    //}

