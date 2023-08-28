namespace PerceptronModel
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double[,] dataset1 = new double[,] {
            { 6, 5, 1 },
            { 2, 4, 1 },
            { -3, -5, -1 },
            { -1, -1, -1 },
            { 1, 1, 1 },
            { -2, 7, 1 },
            { -4, -2, -1 },
            { -6, 3, -1 }
            };

            Neuron neuron1 = new Neuron();
            PerceptronModel perceptronModel1 = new PerceptronModel(neuron1, dataset1);

            perceptronModel1.train(0.05, 10);
            Console.WriteLine("Lambda 0.05 and 10 epoch, accuracy value is {0:0.00} %\n", perceptronModel1.accuracyValue());

            Neuron neuron2 = new Neuron();
            PerceptronModel perceptronModel2 = new PerceptronModel(neuron2, dataset1);

            perceptronModel2.train(0.05, 100);
            Console.WriteLine("Lambda 0.05 and 100 epoch, accuracy value is {0:0.00} %\n", perceptronModel2.accuracyValue());

            Console.WriteLine("-----------------------------------------------------\n");

            double[,] dataset2 = new double[,] {
            { 2, 3, 1 },
            { 1, 2, 1 },
            { -2, -3, -1 },
            { -1, -1, -1 },
            { 0, 1, 1 },
            { -1, 4, 1 },
            { -3, -2, -1 },
            { -4, 3, -1 }
            };

            Neuron neuron3 = new Neuron();
            PerceptronModel perceptronModel3 = new PerceptronModel(neuron3, dataset2);

            perceptronModel3.train(0.05, 10);
            Console.WriteLine("Lambda 0.05 and 10 epoch, accuracy value is {0:0.00} %\n", perceptronModel3.accuracyValue());

            Neuron neuron4 = new Neuron();
            PerceptronModel perceptronModel4 = new PerceptronModel(neuron4, dataset2);

            perceptronModel4.train(0.05, 100);
            Console.WriteLine("Lambda 0.05 and 100 epoch, accuracy value is {0:0.00} %\n", perceptronModel4.accuracyValue());

            Console.WriteLine("-----------------------------------------------------\n");

            double[,] dataset3 = new double[,] {
            { 6, 5, 1 },
            { 2, 4, 1 },
            { -3, -5, -1 },
            { -1, 0, -1 },
            { 1, 2, 1 },
            { -2, 7, 1 },
            { -4, -2, -1 },
            { -6, 3, -1 }
            };

            Neuron neuron5 = new Neuron();
            PerceptronModel perceptronModel5 = new PerceptronModel(neuron5, dataset3);

            perceptronModel5.train(0.05, 10);
            Console.WriteLine("Lambda 0.05 and 10 epoch, accuracy value is {0:0.00} %\n", perceptronModel5.accuracyValue());

            Neuron neuron6 = new Neuron();
            PerceptronModel perceptronModel6 = new PerceptronModel(neuron6, dataset3);

            perceptronModel6.train(0.05, 100);
            Console.WriteLine("Lambda 0.05 and 100 epoch, accuracy value is {0:0.00} %\n", perceptronModel6.accuracyValue());
        }
    }
}
