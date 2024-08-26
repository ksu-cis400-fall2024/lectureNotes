using Encapsulation;

public class Program
{
    private static List<string> _names;
    private static Dictionary<string, List<int>> _scores;
    private static Dictionary<string, string> _majors;

    public static void Main(string[] args)
    {
        //create PointStruct for (3,4)

        //make another one, set it equal to the first

        //change a value, print

        //what happens if we pass to a method?



        /*
        _names = new();
        _scores = new();
        _majors = new();

        //how to store this info?

        //Bob, CS, 80/70/92
        //Jill, CMPEN, 95/68/88

        //write get average method

        //change major of Bob to MATH

        */
    }

    public static int GetAverage(string name)
    {
        throw new NotImplementedException();
    }

    public static void ChangeMajor(string name, string newMajor)
    {
        throw new NotImplementedException();
    }
}