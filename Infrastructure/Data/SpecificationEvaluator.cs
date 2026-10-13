using Core.Entities;
using Core.Interfaces;
using Core.Specification;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Data
{
    public class SpecificationEvaluator<T> where T : BaseEntity
    {

        public static IQueryable<T> GetQuery(IQueryable<T> query, ISpecification<T> spec)
        {
            if (spec.Criteria != null)
            {
                query = query.Where(spec.Criteria);//x=>x.brand==brand
            }
                
            if (spec.OrderBy != null)
            {
                query = query.OrderBy(spec.OrderBy);
            }
            if (spec.OrderByDesc != null)
            {
                query = query.OrderByDescending(spec.OrderByDesc);
            }
            return query;
        }
    }
}
