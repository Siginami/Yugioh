using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yugioh
{
    
    class Kocki
    {
        public string strana1 { get; set; }
        public string strana2 { get; set; }
        public string strana3 { get; set; }
        public string strana4 { get; set; }
        public string strana5 { get; set; }
        public string strana6 { get; set; }
        public Kocki(string strana1, string strana2, string strana3, string strana4, string strana5, string strana6)
        {
            this.strana1 = strana1;
            this.strana2 = strana2;
            this.strana3 = strana3;
            this.strana4 = strana4;
            this.strana5 = strana5;
            this.strana6 = strana6;
        }
    }
}
