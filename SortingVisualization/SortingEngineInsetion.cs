using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingVisualization
{
    internal class SortingEngineInsetion:sortingEngine
    {
        private int[] array;
        private Graphics g;
        private int maxValue;
        Brush whiteBrush = new SolidBrush(Color.White);
        Brush blackBrush = new SolidBrush(Color.Black);
        private double totalTime;
        public double sortInterface(int[] array_in, Graphics g_in, int maxValue_in)
        {
            array = array_in;
            g = g_in;
            maxValue = maxValue_in;

            int width = 3;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 1; i < array.Length; i++)
            {
                int m = array[i];
                int j = i - 1;
                while (j >= 0 && array[j] >= m)
                {
                    DrawBar(j + 1, array[j]);
                    array[j + 1] = array[j];
                    j--;
                }
                DrawBar(j + 1, m);
                array[j + 1] = m;
            }
            stopwatch.Stop();
            totalTime = stopwatch.Elapsed.TotalSeconds;
            return totalTime;
        }

        private void DrawBar(int index, int height)
        {
            int width = 3;
            int x = index * width;

            // Clear the bar at the current position (set to black)
            g.FillRectangle(new SolidBrush(Color.Red), x, 0, width, maxValue);
            g.FillRectangle(blackBrush, x, 0, width, maxValue);

            // Draw the bar with the specified color
            Random rand = new Random();
            int r = rand.Next(0, 255);
            int gr = rand.Next(0, 255);
            int bl = rand.Next(0, 255);
            //Brush barBrush = new SolidBrush(Color.FromArgb(r, gr, bl));
            g.FillRectangle(whiteBrush, x, maxValue - height, width, height);
            //System.Threading.Thread.Sleep(1); // 1ms delay 
        }
    }
}
