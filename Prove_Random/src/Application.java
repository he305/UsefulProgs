public class Application
{
    private static int size = 5;
    public static void main(String[] args)
    {
        Thread[] thread = new Randomizer[5];


        for (int i = 0; i < 5; i++)
        {
            thread[i] = new Randomizer(10);
            thread[i].start();
        }
    }
}
