﻿using System;

namespace _07_Classes
{
    public enum VehicleType { Car, Truck, SUV, Motorcycle, MiniVan, Coupe}
    public class Vehicle
    {
        //Access Modifier -> Type -> prpertyName -> {get;set;}
        public string Make { get; set; }
        public int Year { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public double Mileage { get; set; }
        public VehicleType Type { get; set; }

        public Vehicle()
        {

        }

        public Vehicle(string make, string model, int year, double mileage, string color, VehicleType type)
        {
            Make = make;
            Year = year;
            Model = model;
            Color = color;
            Mileage = mileage;
            Type = type;
        }
    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName
        {
            get { return $"{FirstName} {LastName}"; }
        }

        public DateTime DateOfBirth { get; set; }

        public int AgeInYears
        {
            get
            {
                TimeSpan ageSpan = DateTime.Now - DateOfBirth;
                double totalAgeInYears = ageSpan.TotalDays / 365.25;
                return Convert.ToInt32(Math.Floor(totalAgeInYears));
            }
        }

        public Vehicle Transport { get; set; }

        public Person()
        {

        }

        public Person(string firstName, string lastName, DateTime dateOfBirth, Vehicle transport)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            Transport = transport;
        }
    }
}