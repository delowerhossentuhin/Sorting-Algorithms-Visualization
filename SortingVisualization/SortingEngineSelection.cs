using SortingVisualization;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithmVisualize
{
    internal class SortingEngineSelection : sortingEngine
    {
        private int[] array;
        private Graphics g;
        private int maxValue;
        private double totalTime;
        Brush blackBrush = new SolidBrush(Color.Black);
        Brush whiteBrush = new SolidBrush(Color.White);


        public double sortInterface(int[] array_in, Graphics g_in, int maxValue_in)
        {
            array = array_in;
            maxValue = maxValue_in;
            g = g_in;

            Stopwatch s = new Stopwatch();
            s.Start();

            for (int i = 0; i < array.Length - 1; i++)
            {
                int m = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[m] > array[j])
                    {
                        m = j;
                    }
                }

                if (m != i)
                {
                    int temp = array[m];

                    // Erase the old bar and draw the new one for the bar at index m
                    DrawBar(m, array[i], Color.White);  // First, erase m and redraw
                    array[m] = array[i];
                    DrawBar(m, array[m], Color.White);  // Update m with the new value

                    // Erase the old bar and draw the new one for the bar at index i
                    DrawBar(i, temp, Color.White);      // First, erase i and redraw
                    array[i] = temp;
                    DrawBar(i, array[i], Color.White);  // Update i with the new value
                }
            }

            s.Stop();
            totalTime = s.Elapsed.TotalSeconds;
            return totalTime;
        }

        private void DrawBar(int index, int height, Color color)
        {
            int width = 3;
            int x = width * index;

            // Erase the previous bar (draw in black).
            //g.FillRectangle(new SolidBrush(Color.Red), x, 0, width, maxValue);
            g.FillRectangle(blackBrush, x, 0, width, maxValue);
            

            // Draw the new bar (draw in the specified color).
            Random rand = new Random();
            //int r = rand.Next(0, 255);
            //int gr = rand.Next(0, 255);
            //int bl = rand.Next(0, 255);
            //Brush barBrush = new SolidBrush(Color.FromArgb(r, gr, bl));
            g.FillRectangle(whiteBrush, x, maxValue - height, width, height);
            //System.Threading.Thread.Sleep(500); // 1ms delay 
        }
    }
}
