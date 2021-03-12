using PublicApi.Interfaces.Specification;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace PublicApi.Specifications
{
    public class SpecificationBase<T> : ISpecification<T>
    {
        public SpecificationBase()
        {

        }

        public SpecificationBase(Expression<Func<T, bool>> criteria)
        {
            Criteria = criteria;
        }

        public Expression<Func<T, bool>> Criteria { get; protected set;}

        public List<Expression<Func<T, object>>> Includes { get; } =
            new List<Expression<Func<T, object>>>();

        protected void AddInclude(Expression<Func<T, object>> includeExpression)
        {
            Includes.Add(includeExpression);
        }
    }
}
