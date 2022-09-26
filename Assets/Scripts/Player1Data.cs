using UnityEngine;
using UnityEngine.UI;

public class Player1Data : MonoBehaviour
{
    public string Time;
    public string name;
    public string schoolName;
    public string className;
    public string starString;
    public string starInt;


    public Player1Data(string name, string Time, string schoolName, string className, string starString, string starInt)
    {
        this.name = name;
        this.Time = Time;
        this.schoolName = schoolName;
        this.className = className;
        this.starString = starString;
        this.starInt = starInt;
    }

    public override string ToString()
    {
        return $"{name} at {schoolName} school and at {className} class, has played {Time} amount of seconds";
    }
}
