//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PredictiveAnalysis.Domain
{
    using System;
    using System.Collections.Generic;
    
    public partial class StockData
    {
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<double> Open { get; set; }
        public Nullable<double> High { get; set; }
        public Nullable<double> Low { get; set; }
        public Nullable<double> Close { get; set; }
        public Nullable<double> Adj_Close { get; set; }
        public Nullable<double> Volume { get; set; }
        public string Year { get; set; }
        public string Month { get; set; }
        public int StockDataId { get; set; }
    }
}