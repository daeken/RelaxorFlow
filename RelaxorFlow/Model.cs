using System.Linq.Expressions;

namespace RelaxorFlow; 

public class Model {
	public Model(
		Graph graph, 
		Expression<Func<Tensor<float>, Tensor<float>, Tensor<float>>> loss, 
		IOptimizer optimizer, 
		params (string Label, Expression<Func<Tensor<float>, Tensor<float>, Tensor<float>>>)[] metrics
	) {
	}
}