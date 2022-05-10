using System.Collections;
using System.Linq.Expressions;
using RelaxorFlow.Layers;

namespace RelaxorFlow; 

public class Graph : IEnumerable {
	public void Add(ILayer layer) {
	}

	public void Add(Expression<Func<Tensor<float>, Tensor<float>>> activation) {
	}

	public void Add(Graph graph) {
	}
	
	public IEnumerator GetEnumerator() => throw new NotImplementedException();

	public static extern implicit operator Tensor<float>(Graph graph);
}