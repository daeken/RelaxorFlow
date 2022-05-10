using Activation = System.Linq.Expressions.Expression<System.Func<RelaxorFlow.Tensor<float>, RelaxorFlow.Tensor<float>>>;
using static RelaxorFlow.Tensor<float>;

namespace RelaxorFlow; 

public class Activations {
	public static readonly Activation Linear = x => x;
	public static readonly Activation ReLU = x => Max(x, 0);
	public static Activation LeakyReLU(float alpha) => x => Select(x < 0, x * alpha, x);
	public static readonly Activation Softmax = x => x / x.Exp.Sum;
}