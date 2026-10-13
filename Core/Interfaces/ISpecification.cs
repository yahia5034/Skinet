using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.Interfaces
{
    public interface ISpecification<T>
    {
        Expression<Func<T, bool>>? Criteria { get; }
        Expression<Func<T, object>>? OrderBy { get; }
        Expression<Func<T, object>>? OrderByDesc { get; }

    }
}
