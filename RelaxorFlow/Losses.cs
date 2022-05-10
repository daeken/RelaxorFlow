using System.Linq.Expressions;
using Loss = System.Linq.Expressions.Expression<System.Func<RelaxorFlow.Tensor<float>, RelaxorFlow.Tensor<float>, RelaxorFlow.Tensor<float>>>;

namespace RelaxorFlow; 

public static class Losses {
	public static readonly Loss CategoricalCrossEntropy = (predicted, correct) => -(correct * predicted.Log).Sum;
	public static readonly Loss MeanAbsoluteError = (predicted, correct) => (predicted - correct).Sum.Mean;
	public static readonly Loss MeanSquaredError = (predicted, correct) => (predicted - correct).Squared.Sum.Mean;
}