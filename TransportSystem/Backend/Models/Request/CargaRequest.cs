﻿namespace Backend.Models.Request
{
    public class CargaRequest
    {
        public double DistanciaEmKm { get; set; }
        public double PesoEmKg { get; set; }
        public double Largura { get; set; }
        public double Altura { get; set; }
        public double Comprimento { get; set; }
        public double CustoFrete { get; set; }
    }
}
