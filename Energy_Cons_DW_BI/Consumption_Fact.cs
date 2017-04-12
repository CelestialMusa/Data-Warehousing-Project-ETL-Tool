using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Energy_Cons_DW_BI
{
    class Consumption_Fact
    {
        private double actual_consumption, actual_emission_CO2, actual_emission_Nox, actual_emissions_Sox, actual_emissions_Particles, actual_emissions_Water, temperature;
        public Consumption_Fact(double actual_consumption, double actual_emission_CO2, double actual_emission_Nox, double actual_emissions_Sox, double actual_emissions_Particles, double actual_emissions_Water, double temperature)
        {
            this.actual_consumption = actual_consumption;
            this.actual_emission_CO2 = actual_emission_CO2;
            this.actual_emission_Nox = actual_emission_Nox;
            this.actual_emissions_Sox = actual_emissions_Sox;
            this.actual_emissions_Particles = actual_emissions_Particles;
            this.actual_emissions_Water = actual_emissions_Water;
            this.temperature = temperature;
        }

        public double ACTUAL_CONS
        {
            get { return actual_consumption; }
        }

        public double ACTUAL_EMISSION_CO2
        {
            get { return actual_emission_CO2; }
        }

        public double ACTUAL_EMISSION_NOX
        {
            get { return actual_emission_Nox; }
        }

        public double ACTUAL_EMISSION_SOX
        {
            get { return actual_emissions_Sox; }
        }

        public double ACTUAL_EMISSION_PARTICLES
        {
            get { return actual_emissions_Particles; }
        }

        public double ACTUAL_EMISSION_WATER
        {
            get { return actual_emissions_Water; }
        }

        public double TEMPERATURE
        {
            get { return temperature; }
        }
    }
}
