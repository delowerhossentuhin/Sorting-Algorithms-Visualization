using SortingAlgorithmVisualize;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SortingVisualization
{
    public partial class SortingFrontEnd : Form
    {
        int[] array;
        Graphics g;

        public SortingFrontEnd()
        {
            InitializeComponent();
        }

        private void SortingFrontEnd_Load(object sender, EventArgs e)
        {
            generateRandomLine();   
        }
        void generateRandomLine()
        {
            g = backPanel.CreateGraphics();
            int barwidth = 3;
            int numOfBars = backPanel.Width / barwidth;
            int maxHeight = backPanel.Height;
            array = new int[numOfBars];
            g.FillRectangle(new SolidBrush(Color.Black), 0, 0, backPanel.Width, maxHeight);
            Random rand = new Random();
            for (int i = 0; i < numOfBars; i++)
            {
                array[i] = rand.Next(0, maxHeight);

            }
            for (int i = 0; i < numOfBars; i++)
            {
                int x = i * barwidth;
                int r=rand.Next(0, 255);
                int gr=rand.Next(0, 255);
                int bl=rand.Next(0, 255);
                g.FillRectangle(new SolidBrush(Color.White), x, maxHeight - array[i], barwidth, array[i]);
            }
            Time.Text = "00:00";
            Time.ForeColor = Color.Black;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            AllSortAlgoDD.Text = "";
            generateRandomLine();
        }

        private void AllSortAlgoDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(AllSortAlgoDD.SelectedIndex == 0)
            {
                sortingEngine sortingEngine = new SortingEngineBubble();
                Time.Text = sortingEngine.sortInterface(array, g, backPanel.Height).ToString() + " Second";
                Time.ForeColor = Color.Red;
            }
            else if (AllSortAlgoDD.SelectedIndex == 1)
            {
                sortingEngine sortingEngine = new SortingEngineInsetion();
                Time.Text = sortingEngine.sortInterface(array, g, backPanel.Height).ToString() + " Second";
                Time.ForeColor = Color.Red;
            }
            else if (AllSortAlgoDD.SelectedIndex == 2)
            {
                sortingEngine sortingEngine = new SortingEngineSelection();
                Time.Text = sortingEngine.sortInterface(array, g, backPanel.Height).ToString() + " Second";
                Time.ForeColor = Color.Red;
            }
        }
    }
}
