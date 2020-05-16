using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab2.Domain.Model
{
    public class Expenses
    {
        public long Id { get; set; }

        public string Description { get; set; }

        public double Sum { get; set; }

        public string Location { get; set; }

        public DateTime Date { get; set; }

        public string Currency { get; set; }

        public string Type { get; set; }

        public enum Importance { low, medium, high }

        public enum Status { always, necessary, optional }
    }
}
