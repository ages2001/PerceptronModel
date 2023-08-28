using System;

namespace PerceptronModel
{
    public class Neuron
    {
        private const int ARRAY_LIMIT = 2;

        private double[] inputs;
        private double[] weights;

        private Random random;

        public double[] Inputs { get => inputs; set => inputs = value; }
        public double[] Weights { get => weights; set => weights = value; }

        public Neuron()
        {
            Inputs = new double[ARRAY_LIMIT];
            Weights = new double[ARRAY_LIMIT];

            random = new Random();

            for (int i = 0; i < Weights.Length; i++)
                Weights[i] = random.NextDouble() * 2.0 - 1.0;
        }

        public void insertInputs(double input1, double input2)
        {
            Inputs[0] = input1 / 10.0;
            Inputs[1] = input2 / 10.0;
        }

        public double getOutput()
        {
            double output = 0.0;

            for (int i = 0; i < ARRAY_LIMIT; i++)
                output += Inputs[i] * Weights[i];

            return output >= 0.5 ? 1 : -1;
        }

        public void changeWeights(double lambda, double target, double output)
        {
            for (int i = 0; i < ARRAY_LIMIT; i++)
                Weights[i] += lambda * (target - output) * Inputs[i];
        }
    }
}
