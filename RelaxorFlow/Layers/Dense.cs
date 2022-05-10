namespace RelaxorFlow.Layers; 

public class Dense : ILayer {
	public readonly int Width;

	public Dense(int width, Func<int, float> initializer = null) {
		Width = width;
	}
}