using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AnimalSimulator
{
    public partial class Form1 : Form
    {
        Continent northAmerica;
        Continent australia;
        Random rGen;
        Graphics canvas;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rGen = new Random();
            canvas = CreateGraphics();
            northAmerica = new NorthAmerica(animalNamesLB, rGen, 3, canvas);
            australia = new Australia(animalNamesLB, rGen, 3, canvas);
        }

        private void northAmericaBTN_Click(object sender, EventArgs e)
        {
            animalNamesLB.Items.Clear();
            northAmerica.runSimulation();
        }

        private void australiaBTN_Click(object sender, EventArgs e)
        {
            animalNamesLB.Items.Clear();
            australia.runSimulation();
        }
    }
}
