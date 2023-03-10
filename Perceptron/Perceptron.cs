using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perceptron
{
    public class Perceptron
    {
        private double[] weights;
        private double bias;
        private double learningRate;

        public Perceptron(int numInputs)
        {
            weights = new double[2];
            Random rand = new Random();
            for (int i = 0; i < numInputs; i++)
            {
                weights[i] = rand.Next(-1,1); 
            }
            bias = 1;
            learningRate = 1;
        }
        //computational model
        public int Activate(double[] inputs)
        {
            double activation = 0;
            for (int i = 0; i < inputs.Length; i++)
            {
                activation += inputs[i] * weights[i];
            }
            activation += bias;
            return Hard_Limiting(activation);
        }
        //limiting function
        public int Hard_Limiting(double activation) 
        {
            
            if (activation >= 0)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }
     
        //update weights and bias
        public void Train(double[][] inputs, int[] targets, double numEpochs)
        {
            
            for (int epoch = 0; epoch < numEpochs; epoch++)
            {
        
                for (int i = 0; i < inputs.Length; i++)
                {
                    int output = Activate(inputs[i]);
                    int error = targets[i] - output;
                    for (int j = 0; j < weights.Length; j++)
                    {
                        weights[j] += learningRate * error * inputs[i][j];
                    }
                    bias += learningRate * error;
                }
            }
            
          
            
           
        }
    }
}
