import java.util.ArrayList;
import java.util.Collections;

public class Randomizer extends Thread
{
    private int size;
    private ArrayList<Integer> etalon;
    private ArrayList<Integer> mass;

    public Randomizer(int size)
    {
        this.size = size;
        etalon = new ArrayList<>();
        mass = new ArrayList<>();

        for (int i = 0; i < size; i++)
        {
            etalon.add(i);
            mass.add(i);
        }

        Collections.shuffle(mass);
    }

    public void run()
    {
        while (!etalon.equals(mass))
        {
            Collections.shuffle(mass);
        }

        System.out.println("Shuffled");
        for (Integer integer : mass)
        {
            System.out.print(integer + " ");
        }
        System.out.println();
    }
}
