using Encapsulation;

public class Program
{
    private static List<string> _names;
    private static Dictionary<string, List<int>> _scores;
    private static Dictionary<string, string> _majors;

    public static void Main(string[] args)
    {
        //from Monday:

        /*
        //LabRoom r = new() { Windows = false };

        //NO!!! can't change now
        //r.Windows = true;

        LabRoom r = new(false);

        //create PointStruct for (3,4)

        PointStruct point1 = new(3, 4);
        PointStruct point2 = point1;

        //doesn't work - PointStruct is now immutable
        //point2.X = 10;

        point1.Print();
        point2.Print();
        */

        //Wednesday:

        LabRoom room1 = new(false);
        LabRoom room2 = new(true);

        //how to change drinks policy?

        LabRoom.DrinksAllowed = true;



        /*
        _names = new();
        _scores = new();
        _majors = new();

        //how to store this info?

        //Bob, CS, 80/70/92
        //Jill, CMPEN, 95/68/88

        //how to get average?

        //change major of Bob to MATH

        */

        _names.Add("Bob");
        _majors.Add("Bob", "CS");
        _scores.Add("bob", new List<int>());
        _scores["Bob"].Add(80);

        Student s = new("Bob", "CS");
        s.AddScore(80);

        double val = s.Average;
    }
}