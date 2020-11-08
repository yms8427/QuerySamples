using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BilgeAdam.EF.Samples.Extensions
{
    public static class QueryableExtensions
    {
        public static IQueryable<T> Paginate<T, P>(this IQueryable<T> query, Expression<Func<T, P>> orderBy, int index)
        {
            var limit = 10;
            return query.OrderBy(orderBy).Skip(index * limit).Take(limit);
        }
    }
}
