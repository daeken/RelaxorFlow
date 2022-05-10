using RelaxorFlow;
using RelaxorFlow.Layers;
using RelaxorFlow.Optimizers;

var relu = Activations.LeakyReLU(0.1f);

var first = new Graph {
	new Input(784),
	new Dense(64),
	relu
};

var graph = new Graph {
	first, 
	new Dense(64), 
	relu, 
	new Dense(64),
	relu,
	x => x + first, 
	new Dense(64), 
	relu, 
	new Dense(10),
	Activations.Softmax
};

var model = new Model(graph, Losses.CategoricalCrossEntropy, new SGD());
