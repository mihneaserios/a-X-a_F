﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a_X_a_F
{
    public class Car
    {
        public string color;
        public string name;
        public int maxSpeed;
        public int year;
        public void FullThrottle()
        {
            Console.WriteLine(name + " is going at the speed of " + maxSpeed);
        }

        public Car(string nameName)
        {
            name = nameName;
        }
        public Car(string nameName, string colorName, int yearValue, int maxSpeedValue)
        {
            name = nameName;
            color = colorName;
            year = yearValue;
            maxSpeed = maxSpeedValue;
        }

        public Car()
        {
        }
    }
}
