using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammeringUppgift3
{
    class Bird
    {
        // Variables for height, weight & name
        private int height = 5;
        private int weight = 40;
        private string name = string.Empty;

        // Height get
        public int getHeight()
        {
            return this.height;
        }

        // Height set
        public void setHeight(int height)
        {
            this.height = height;
        }

        // Weight get
        public int getWeight()
        {
            return this.weight;
        }

        // Weight set
        public void setWeight(int weight)
        {
            this.weight = weight;
        }

        // Name get
        public string getName()
        {
            return this.name;
        }

        // Name set
        public void setName(string name)
        {
            this.name = name;
        }

        // Sing function
        public string sing()
        {
            return "Craw! Craw!";
        }
    }
}
