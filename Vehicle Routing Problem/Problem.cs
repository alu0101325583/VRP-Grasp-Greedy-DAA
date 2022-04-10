﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle_Routing_Problem
{
    public class Problem
    {
        public int nbVehicles;
        public int nbCustomers;
        public List<List<int>> distanceMatrix = new List<List<int>>();

        public Problem(string fileName)
        {
            string[] lines = System.IO.File.ReadAllLines(fileName);
            string[] firstLine = lines[0].Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
            string[] secondLine = lines[1].Split(new char[0], StringSplitOptions.RemoveEmptyEntries);

            nbCustomers = int.Parse(firstLine[1]);
            nbVehicles = int.Parse(secondLine[1]);
            
            for (int i = 3; i < lines.Length; i++)
            {
                string[] line = lines[i].Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
                List<int> row = new List<int>();
                for (int j = 0; j < line.Length; j++)
                {
                    row.Add(int.Parse(line[j]));
                }
                distanceMatrix.Add(row);
            }
        }
    }
}
