using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayPractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            Random randGen = new Random();

            // Create 2 arrays to hold 10 values each
            int[] array1 = new int[10];
            int[] array2 = new int[10];

            //1. Generate random values for BOTH pre-created arrays
            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = randGen.Next(0, 10);
                array2[i] = randGen.Next(0, 10);
            }

            //2. Display array 1
            array1Output.Text = "";
            for (int i = 0; i < array1.Length; i++)
            {
                array1Output.Text += array1[i] + " ";
            }

            //3. Display array 2
            array2Output.Text = "";
            for (int i = 0; i < array1.Length; i++)
            {
                array2Output.Text += array2[i] + " ";
            }

            //4. Display array 1 in reverse order
            reverseOutput.Text = "";
            for (int i = array1.Length - 1; i > 0; i--)
            {
                reverseOutput.Text += array1[i] + " ";
            }

            //5. Determine and display the largest value in array 1          
            int max = 0;

            for (int i = 0; i < array1.Length; i++)
            {
                if (max < array1[i])
                {
                    max = array1[i];
                }
            }
            maxOutput.Text = $"{max}";


            //6. Determine and display the average of all values in array 1
            double sum = 0;
            double average = 0;

            //add all numbers
            for (int i = 0; i < array1.Length; i++)
            {
                sum += array1[i];
            }
            //find average
            average = sum / array1.Length;
            averageOutput.Text = $"{average}";

            //7. Determine and display the sum of all even values in array 1
            int sumEven = 0;
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] % 2 == 0)
                {
                    sumEven += array1[i];
                }
            }
            evenOutput.Text = $"{sumEven}";

            //8. Determine and display the number of 3s in array 1
            int numThrees = 0;
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] == 3)
                {
                    numThrees++;
                }
            }
            threeOutput.Text = $"{numThrees}";

            //9. Determine and display how many matching numbers in matching positions between the 2 arrays there are
            int samePosition = 0;
            for (int i = 0; i < array1.Length; i++)
            {
                for (int ii = 0; ii < array2.Length; ii++)
                {
                    if (ii == i && array1[i] == array2[i])
                    {
                        samePosition++;
                    }
                }
            }
            matchOutput.Text = $"{samePosition}";



            // ----------------------
            // ##### ENRICHMENT #####
            // ----------------------


            //1. Determine and display at what index is the first 0 in array 1, (show "null" if no 0 exists)
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] == 0)
                {
                    zeroOutput.Text = $"{i}";
                    break;
                }
                else
                {
                    zeroOutput.Text = "null";
                }
            }


            //2. swap and display all values between array1 and array2

            //make another array that holds the copy


        }
    }
}
