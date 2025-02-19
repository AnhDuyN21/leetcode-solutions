

namespace Leetcode.Interview.NashTech
{
    public class Solution_NashTech_Problem_2
    {
        #region Đề bài
        //A high school starts to evaluate the quality of learning by leveraging the Medium Grade(MG) of each class. The school currently has n classes, each class has m students and will learn k subjects.

        //Your task is to calculate the MG: MG = Sum(Everage score of each Student) / Number of students in the class.

        //Input
        //The 1st line will indicate the number of classes n need to calculate the MG.
        //The n next lines will contain the score list of the students in each class.
        //Each line will contain the score of m students in k subjects.
        //For example, in example 1, the class 1 has 5 students and 4 subjects:

        //[[10,9,8,7],[10,8,7,6],[8,9,10,8],[10,9,10,8],[6,8,7,9]]

        //Student 1: [10,9,8,7]

        //Student 2: [10,8,7,6]

        //Student 3: [8,9,10,8]

        //Student 4: [10,9,10,8]

        //Student 5: [6,8,7,9]

        //Output
        //For the example 1, the class 1 has the everage grages of each student:

        //Student 1: [10,9,8,7] => A1 = (10 + 9 + 8 + 7) / 4 = 8.5

        //Student 2: [10,8,7,6] => A2 = (10 + 8 + 7 + 6) / 4 = 7.75

        //Student 3: [8,9,10,8] => A3 = (8 + 9 + 10 + 8) / 4 = 8.75

        //Student 4: [10,9,10,8] => A4 = (10 + 9 + 10 + 8) / 4 = 9.25

        //Student 5: [6,8,7,9] => A5 = (6 + 8 + 7 + 9) / 4 = 7.5

        //MG = (8.5 + 7.75 + 8.75 + 9.25 + 7.5) / 5 = 8.35

        //Output: Case 1: 8.35

        //Notes
        //In case the MG contains infinite precission(E.g. 7.766666666...), the just round up the result up to 2 digit precission.

        //For example:

        //MG = 7.766666666666666 => 7.77

        //MG = 7.72442351 => 7.72
        #endregion
        public string MediumGrade(List<int[]> scores)
        {
            // TODO: Let's rock n roll here
            double result = 0.00;
            foreach (int[] score in scores)
            {
                double sum = 0;
                double subjectCount = 0;
                foreach( int miniScore in score)
                {
                    sum += miniScore;
                    subjectCount++;
                }
                result += sum / subjectCount;
            }
            double count = scores.Count;
            result = result / count;
            return string.Format("{0:N2}", result);
        }
    }
    public class Problem2
    {
        public static void Test()
        {
            Solution_NashTech_Problem_2 solution = new Solution_NashTech_Problem_2();

            string input;
            Console.Write("Number of classes n need to calculate the MG: ");

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write($"Enter student for class {i} :");
                input = Console.ReadLine();

                var line = input.Split(new string[] { "],[", "[", "]" }, System.StringSplitOptions.RemoveEmptyEntries);

                var scores = new List<int[]>();
                foreach (string str in line)
                {
                    scores.Add(str.Split(',').Select(int.Parse).ToArray());
                }

                var output = solution.MediumGrade(scores);
                Console.WriteLine("Result : ");
                Console.WriteLine($"Case {i}: {output}");
            }

        }
    }
}
