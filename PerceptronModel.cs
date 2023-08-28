namespace PerceptronModel
{
    public class PerceptronModel
    {
        private Neuron neuron;
        private double[,] dataset;

        public Neuron Neuron { get => neuron; set => neuron = value; }
        public double[,] Dataset { get => dataset; set => dataset = value; }

        public PerceptronModel(Neuron neuron, double[,] dataset)
        {
            Neuron = neuron;
            Dataset = dataset;
        }

        public void train(double lambda, int epoch)
        {
            for (int i = 0; i < epoch; i++)
            {
                for (int j = 0; j < Dataset.GetLength(0); j++)
                {
                    Neuron.insertInputs(Dataset[j, 0], Dataset[j, 1]);
                    double output = Neuron.getOutput();

                    if (Dataset[j, 2] != output) Neuron.changeWeights(lambda, Dataset[j, 2], output);
                }
            }
        }

        public double accuracyValue()
        {
            int totalDataCount = Dataset.GetLength(0);
            int trueDataCount = 0;

            for (int j = 0; j < Dataset.GetLength(0); j++)
            {
                Neuron.insertInputs(Dataset[j, 0], Dataset[j, 1]);
                double output = Neuron.getOutput();

                if (Dataset[j, 2] == output) trueDataCount++;
            }

            return (double)trueDataCount * 100 / totalDataCount;
        }
    }
}
