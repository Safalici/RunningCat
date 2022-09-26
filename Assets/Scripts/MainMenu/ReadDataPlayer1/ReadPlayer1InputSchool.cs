
using UnityEngine;

public class ReadPlayer1InputSchool : MonoBehaviour
{
    private string Player1SchoolName;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ReadStringInputSchoolName(string s)
    {
        Player1SchoolName = s;
        
        PlayerPrefs.SetString("player1SchoolName", Player1SchoolName);

    }
    
}
