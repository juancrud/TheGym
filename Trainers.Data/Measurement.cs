using System;

namespace Trainers.Data
{
    public class Measurement
    {
        public int MeasurementId { get; set; }
        public DateTime Date { get; set; }
        public string Comments { get; set; }

        //Todas las medidas posibles

        public Customer Customer { get; set; }

    }
}
