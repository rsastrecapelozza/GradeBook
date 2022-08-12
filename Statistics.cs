﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook
{
    public class Statistics
    {
        public double Average
        {
            get
            {
                return Sum / Count;
            }
        }
        public double High;
        public double Low;
        public char Letter
        {
            get
            {
                /*switch (Average)
                {
                    case var d when d >= 90.0:
                    {
                        return 'A';
                    }

                    case var d when d >= 80.0:
                    {
                        return 'B';
                    }

                    case var d when d >= 70.0:
                    {
                        return 'C';
                    }

                    case var d when d >= 60.0:
                    {
                        return 'D';
                    }

                    default:
                    {
                        return 'F';
                    }
                }*/

                var Letra = Average switch
                {
                    >= 90 => 'A',
                    >= 80 => 'B',
                    >= 70 => 'C',
                    >= 60 => 'D',
                    _ => 'F'
                };
                return (Letra);
            }
        }
        public double Sum;
        public int Count;

        public Statistics()
        {
            Count = 0;
            Sum = 0.0;
            High = double.MinValue;
            Low = double.MaxValue;
        }

        public void Add(double number)
        {
            Sum += number;
            Count += 1;
            Low = Math.Min(Low, number);
            High = Math.Max(High, number);
        }

    }
}
