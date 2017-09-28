using System;
using System.Text;

namespace SoftUniJudgeSolutions
{
    /// <summary>
    /// Easily copy-paste this class in new project and use it as entry point.
    /// </summary>
    internal class ExerciseSolution
    {
        /// <summary>
        /// Collect output here instead of directly writing to Console.
        /// This noticeably improves the execution times.
        /// </summary>
        private static StringBuilder result = new StringBuilder();

        /// <summary>
        /// Simple 3-steps approach to any exercise
        /// </summary>
        private static void Main(string[] args)
        {
            ReadInput();
            Solve();
            PrintResult();
        }

        /// <summary>
        /// Prints the collected output when solving has completed.
        /// </summary>
        private static void PrintResult()
        {
            Console.WriteLine(result.ToString());
        }

        /// <summary>
        /// Read console input here.
        /// Assign to static variables,
        /// in order do be accessible across the other static methods
        /// </summary>
        private static void ReadInput()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Solve the exercise using this method:
        /// 1. Define the necessary steps as method calls,
        /// even though the methods are not currently existing.
        /// 2. When all the steps are defined ,
        /// use Alt+Enter to auto-generate the missing static methods.
        /// 3. When something needs to be printed to the console,
        /// use result.Append/AppendFormat/AppendLine instead.
        /// 4. Thats all folks!
        /// </summary>
        private static void Solve()
        {
            throw new NotImplementedException();
        }
    }
}