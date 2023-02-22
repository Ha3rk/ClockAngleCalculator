using System;


namespace Calculator
    {
        class Program
    {
        static void Main(string[] args)
        {
            var input = new Input();
            var clock = new Clock();
            var output = new Output();

            var hours = input.GetHours();
            var minutes = input.GetMinutes();

            var angle = clock.CalculateAngle(hours, minutes);
            output.DisplayAngle(angle);
        }
    }
}
