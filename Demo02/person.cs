using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo02
{
    internal class person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int IQ { get; set; }

        public string GetAgeGroup()
        {
            return this switch
            {
                { Age: <= 10 } => $"{Name}, You're just a kid.",
                { Age: > 10 and <= 20 } => $"{Name}, You're just a bit older kid.",
                { Age: > 20 and <= 40 } => $"{Name}, You're now adult.😉",
                { Age: > 40 } => $"{Name}, You're still young.😎",
                _ => "Unknown age group" // Default case for unmatched values
            };
        }

        public string GetIQGroup()
        {
            return this switch
            {
                { IQ: <= 100 } => $"{Name}, You're IQ is Avarage",
                { IQ: > 100 and <= 120 } => $"{Name},  You're IQ is above Avarage.",
                { IQ: > 120 and <= 140 } => $"{Name}, You're Smart!.",
                { IQ: > 140 } => $"{Name}, You're intelligent",
                _ => "Unknown IQ group" // Default case for unmatched values
            };
        }
    }
}