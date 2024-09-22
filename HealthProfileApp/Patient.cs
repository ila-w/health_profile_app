﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HealthProfileApp
{
    public class Patient
    {
        private string name;
        private string gender;
        private int age;
        private int weight;
        private int height;
        private int max;
        private int lTarget;
        private int hTarget;
        private string target;
        private double bmi;

        public string Name { get { return name; } set { name = value; } }
        public string Gender { get { return gender; } set { gender = value; } }
        public int Age { get { return age; } set { age = 2023 - value; } }
        public int Weight { get { return weight; } set { weight = value; } }
        public int Height { get { return height; } set { height = value; } }
        public int Max { get { return max; } set { max = 200 - age; } }
        public string Target { get { return target; } set { lTarget = (int)(max * 0.5); hTarget = (int)(max * 0.85); target = lTarget + " to " + hTarget; } }
        public double BMI { get { return bmi; } set { bmi = ((double)weight / (height * height)) * 703; } }

        public Patient() { }

        public string getPatientInfo()
        {
            return "Patient: " + name + "<br/>" + "Gender: " + gender + "<br/>" + "Age: " + age + "<br/>" + "Height (in): " + height + "<br/>" + "Weight (lbs): " + weight + "<br/>" + "Max heart rate (bpm): " + max + "<br/>" + "Target heart rate (bpm): " + target + "<br/>" + "Body mass index (BMI): " + String.Format("{0:0.0}", bmi);
        }
    }
}
