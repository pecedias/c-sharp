﻿using System;
using System.Globalization;
using System.Collections.Generic;

namespace ConsoleApp6 {
    class Employee {

        public int Id { get; private set; }
        public string Name { get; private set; }
        public double Salary { get; private set; }

        public Employee(int id, string name, double salary) {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public void increaseSalary(double percentage) {
            Salary += Salary * percentage / 100.0;
        }

        public override string ToString() {
            return Id
                   + ", "
                   + Name
                   + ", "
                   + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
