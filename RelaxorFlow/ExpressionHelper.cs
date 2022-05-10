using System.Linq.Expressions;

namespace RelaxorFlow; 

public static class ExpressionHelper {
	public static Expression<Func<Tensor<T>, Tensor<T>>> Pipeline<T>(params Expression<Func<Tensor<T>, Tensor<T>>>[] exprs) =>
		exprs.Reverse().Aggregate((a, x) => x.Compose(a));

	public static Expression<Func<T, U>> Compose<T, I, U>(this Expression<Func<I, U>> outer, Expression<Func<T, I>> inner) {
		var param = Expression.Parameter(typeof(T), inner.Parameters[0].Name);
		return Expression.Lambda<Func<T, U>>(Expression.Invoke(outer, Expression.Invoke(inner, param)), param);
	}
}