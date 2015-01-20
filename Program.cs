using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gradebook {
  class Program {
    static void Main(string[] args) {
      GradeBook book = new GradeBook();
      book.AddGrade(91);
      book.AddGrade(89.1f);
      book.AddGrade(75);

      GradeStatistics stats = book.ComputeStatistics();
      Console.WriteLine("Average: " + stats.AverageGrade);
      Console.WriteLine("Lowest: " + stats.LowestGrade);
      Console.WriteLine("Highest: " + stats.HighestGrade);
    }
  }
}
