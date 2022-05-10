using System.Linq.Expressions;

namespace RelaxorFlow.Layers; 

public class Input : ILayer {
	public readonly int Width;

	public Input(int width) => Width = width;
}