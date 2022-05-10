using System.Linq.Expressions;

#pragma warning disable CS0626

namespace RelaxorFlow; 

public class Tensor<T> {
	public static extern Tensor<T> Select(Tensor<bool> cond, Tensor<T> a, Tensor<T> b);
	
	public extern Tensor<U> Map<U>(Expression<Func<T, U>> expr);
	public extern Tensor<T> Sum { get; }
	public extern Tensor<T> Mean { get; }
	public extern Tensor<T> Exp { get; }
	public extern Tensor<T> Log { get; }
	public extern Tensor<T> Squared { get; }
	public extern Tensor<T> Sqrt { get; }

	public extern Tensor<T> Pow(Tensor<T> exponent);

	public static extern Tensor<T> Max(params Tensor<T>[] args);
	
	public static extern Tensor<T> operator +(Tensor<T> a, Tensor<T> b);
	public static extern Tensor<T> operator -(Tensor<T> a, Tensor<T> b);
	public static extern Tensor<T> operator *(Tensor<T> a, Tensor<T> b);
	public static extern Tensor<T> operator /(Tensor<T> a, Tensor<T> b);
	public static extern Tensor<T> operator %(Tensor<T> a, Tensor<T> b);
	public static extern Tensor<T> operator ^(Tensor<T> a, Tensor<T> b);

	public static extern Tensor<T> operator -(Tensor<T> x);
	
	public static extern Tensor<bool> operator <(Tensor<T> a, Tensor<T> b);
	public static extern Tensor<bool> operator >(Tensor<T> a, Tensor<T> b);
	public static extern Tensor<bool> operator ==(Tensor<T> a, Tensor<T> b);
	public static extern Tensor<bool> operator !=(Tensor<T> a, Tensor<T> b);
	public static extern Tensor<bool> operator <=(Tensor<T> a, Tensor<T> b);
	public static extern Tensor<bool> operator >=(Tensor<T> a, Tensor<T> b);
	
	public static extern implicit operator Tensor<T>(T v);
}