using System;
using System.Diagnostics;
using System.Drawing;

namespace SortingVisualization
{
    internal class SortingEngineBubble : sortingEngine
    {
        private int[] array;
        private Graphics g;
        private int maxValue;
        private double totalTime;
        Brush whiteBrush = new SolidBrush(Color.White);
        Brush blackBrush = new SolidBrush(Color.Black);

        public double sortInterface(int[] array_in, Graphics g_in, int maxValue_in)
        {
            array = array_in;
            g = g_in;
            maxValue = maxValue_in;

            int width = 3;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        // Highlight the bars being swapped
                        DrawBar(j, array[j], Color.Red);
                        DrawBar(j + 1, array[j + 1], Color.Red);

                        // Swap the values in the array
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;

                        // Redraw the bars in white after swapping
                        DrawBar(j, array[j], Color.White);
                        DrawBar(j + 1, array[j + 1], Color.White);
                    }
                }
            }

            stopwatch.Stop();
            totalTime = stopwatch.Elapsed.TotalSeconds;
            return totalTime;
        }

        private void DrawBar(int index, int height, Color color)
        {
            int width = 3;
            int x = index * width;

            // Clear the old bar by drawing a black rectangle
            g.FillRectangle(new SolidBrush(Color.Red),x,0,width,maxValue);
            g.FillRectangle(blackBrush, x, 0, width, maxValue);

            // Draw the new bar with the specified color
            Random rand = new Random();
            int r=rand.Next(0,255);
            int gr=rand.Next(0,255);
            int bl=rand.Next(0,255);
            Brush barBrush = new SolidBrush(Color.FromArgb(r,gr,bl));
            g.FillRectangle(whiteBrush, x, maxValue - height, width, height);
            //System.Threading.Thread.Sleep(500); // 1ms delay 
        }
    }
}
