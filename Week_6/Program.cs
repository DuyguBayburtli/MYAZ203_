
namespace Week_6
{
    public class Program
    {
        private static int kHealth;

        public static void Main()
        {
            Knight knigth = new Knight("Sir Knigth");
            Enemy enemy = new Enemy();

            var kHealth = knigth.Health;
            var eHealth = enemy.Health;


            while (kHealth > 0)
            {
                knigth.Attack (ref eHealth);
                enemy.Attack (ref kHealth);
                Console.WriteLine(
                   $"-----------------\n" +
                   $"{enemy.Name} Health :{eHealth}\n" +
                   $"{knigth.Name} :{kHealth}");

            }


        }
    }
}
