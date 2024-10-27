using Palindrom.Classes1;
namespace vscode
{
    class Program
    {
        static void Main(string[] args)
        {//1

            palindrom check = new palindrom();
            check.CheckTextPalindrom(); 
            //2
            Temperator Temp = new Temperator();
            Temp.CalculateTemperator();
            //3
            Sort sort = new Sort();
            sort.Switch();
            //4
            Letter c = new Letter();
            c.Claculate();
            //5
            student f = new student();
            f.findResult();

        }
    }
    class student
    {
        public void findResult()
        {

            //1
            /*  var studentsResult = new List<KeyValuePair<string, int>>();
        studentsResult.Add(new KeyValuePair<string, int>("Ali", 5));
        studentsResult.Add(new KeyValuePair<string, int>("Vali", 4));*/
            //2
            List<int> result = new List<int>();
            result.Add(5);
            result.Add(4);
            IterationThrought(result);


        }
        public void IterationThrought(List<int> listToBeIterated)//iteratsiya qilinayotgan list
        {
            Console.WriteLine("Find result:");
            int outresult = Convert.ToInt32(Console.ReadLine());
            foreach (var elementIndex in listToBeIterated)
            {
                if (outresult == elementIndex)
                {
                    Console.WriteLine(elementIndex);
                }

            }
        }

    }
}