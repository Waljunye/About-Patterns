using System;

namespace AboutPatterns
{
    class Program
    {
        private const char QUIT_BUTTON = 'q'; 
        static void Main(string[] args)
        {
            Console.WriteLine("Здравствуйте вас приветствует математическая программа");
            Console.WriteLine("пажалуйста введите число: ");
            // У меня есть скепсис к этим 2-м строкам, но почему-то мне не хочется их рефакторить в функцию, сомневаюсь, что это надо

            String inputString = Console.ReadLine(); //Интуитивно не понятно, что обозначает эта переменная, лучше давать мнемонические имена

            if (inputString == QUIT_BUTTON.ToString().ToLower()) // Магическое значение, переносим в константу
            {
                return;
            }
            int ParsedIntInputString = Int32.Parse(inputString); //Интуитивно не понятно,
                                                                 //что обозначает эта переменная,
                                                                 //лучше давать мнемонические имена

            int Factorial = CountFactorial(ParsedIntInputString);
            int Sum = CountSum(ParsedIntInputString);
            int MaxEvenNumbered = CountMaxEvenNumberedValue(ParsedIntInputString);

            // Вообще спорная ситуация, т.к. в разных случаях нам может не понадобиться либо факториал либо сумма, максимальное число
            // поэтому лучше разделить на отдельные методы, но с другой стороны, это замедлит работу приложения

            Console.WriteLine("Факториал равет " + Factorial); Console.WriteLine("Сума от 1 до N равна " + Sum);

            Console.WriteLine("максимальное четное число меньше N равно" + MaxEvenNumbered);

            Console.ReadLine();
        }
        public static int CountFactorial(int num)
        {
            int returnableFactorialValue = 1;
            for (int i = 1; i <= num; i++)
            {
                returnableFactorialValue *= i;
            }
            return returnableFactorialValue;
        }
        public static int CountSum(int num)
        {
            int returnableSumValue = 0;
            for (int i = 0; i <= num; i++)
            {
                returnableSumValue += i;
            }
            return returnableSumValue;
        }
        public static int CountMaxEvenNumberedValue(int num)
        {
            int returnableMaxValue = 0;
            for (int i = 1; i < num; i++)
            {
                if(i % 2 == 0)
                {
                    returnableMaxValue = i;
                }
            }
            return returnableMaxValue;
        }
    }
}
