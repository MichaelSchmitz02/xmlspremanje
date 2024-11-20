using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak
{
    internal class Vozila
    {
        string Marka, Model;
        int Godina, Kilometraza;

        public Vozila() { }

        public Vozila(string marka, string model, int godina, int kilometraza)
        {
            this.Marka = marka;
            this.Model = model;
            this.Godina = godina;
            this.Kilometraza =kilometraza;
        }

        public string marka { get => marka; set => marka = value; }
        public string model { get => model; set => model = value; }
        public int godina { get => godina; set => godina = value; }
        public int kilometraza { get => kilometraza; set => kilometraza = value; }
        public override string ToString()
        {

            {
                string ispis = this.marka + "," + this.model + "," + this.godina + "," + this.kilometraza; ;


                return ispis;
            }
                ;
        }
    }
}
