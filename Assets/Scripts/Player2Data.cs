
using UnityEngine;

public class Player2Data : MonoBehaviour
{
    public string time;
    public string name;
    public string schoolName;
    public string className;

    public Player2Data(string name, string time, string schoolName, string className)
    {
        this.name = name;
        this.time = time;
        this.schoolName = schoolName;
        this.className = className;
    }
   
    public override string ToString()
    {
        return $"{name} at {schoolName} school and at {className} class, has played {time} amount of seconds";
    }
}
