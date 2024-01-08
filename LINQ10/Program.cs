using System;
namespace LINQ10.Shared
{
    internal class Program
    {
        public static void Main(String[] args)
        {
            RepeatOperation();
        }
        public static void GenerationEmptyList()
        {

            var empty01 = new List<int>();
            foreach (var x in empty01)
            {
                Console.WriteLine(x);
            }

            var empty02 = Enumerable.Empty<Question>();
            foreach (var x in empty02)
            {
                Console.WriteLine(x);
            }
        }
        public static void DefualtEmpty()
        {
            Console.WriteLine(default(int));
            Console.WriteLine(default(DateTime));
            Console.WriteLine(default(Object) is null ? "Null" : default(Object) is null);

            var questions = Enumerable.Empty<Question>();

            var question02 = questions.DefaultIfEmpty();

            question02 = questions.DefaultIfEmpty();


            var question03 = questions.DefaultIfEmpty(Question.Default);
            Console.WriteLine(question02);


            Console.ReadKey();
        }

        public static void RangeOperation()
        {
            var range = Enumerable.Range(1, 10);
            var questions = QuestionBank.GetQuestionRange(range);
            questions.ToQuiz();
            Console.ReadKey();
        }
        public static void RepeatOperation()
        {
            var q = QuestionBank.PickOne();
            
            var questionRegularWay = new List<Question>();
            for(int i = 0; i < 10; i++)
            {
                questionRegularWay.Add(new Question());
            }
            Console.WriteLine(ReferenceEquals(questionRegularWay[0], questionRegularWay[1]));
            
            var LINQquestionsway = Enumerable.Repeat(q,20).ToList();
            Console.WriteLine(ReferenceEquals(LINQquestionsway[0], LINQquestionsway[1]));
            LINQquestionsway.ToQuiz(); 
            Console.ReadKey();   
        }

    }

}