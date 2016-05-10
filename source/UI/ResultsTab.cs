﻿using System.Linq;
using System.Windows.Forms;
using GAF;
using Modelo;

namespace UI
{
    public partial class ResultsTab : UserControl
    {
        public ResultsTab()
        {
            InitializeComponent();
        }

        public void AddPoint(double xValue, double yValue)
        {
            chart.Series[0].Points.AddXY(xValue, yValue);
        }

        public void ShowChart(GaEventArgs e)
        {
            chart.Show();
            var maxIndividualChromosome = e.Population.GetTop(1).First();
            var maxIndividual = Acertijo.Instance.CrearModelos(maxIndividualChromosome);
            resultsText.Text = "Generaciones: " + e.Generation + "\n" +
                "Población final: " + e.Population.PopulationSize + " individuos" + "\n" +
                "Mejor individuo Fitness: " + e.Population.MaximumFitness.ToString() + "\n";
            foreach (var persona in maxIndividual)
            {
                resultsText.Text += "Nombre: " + persona.Name + ", Nacionalidad: " + persona.Nationality + ", Botines: " + persona.Sneakers + "\n";
            }
        }
    }
}
