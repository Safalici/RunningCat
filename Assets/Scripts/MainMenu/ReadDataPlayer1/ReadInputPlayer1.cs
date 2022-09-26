
using UnityEngine;
using UnityEngine.UI;

public class ReadInputPlayer1 : MonoBehaviour
{
    private string Player1Name;



    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetString("player1Name", "");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ReadStringInput(string s)
    {
        Player1Name = s;
        
        PlayerPrefs.SetString("player1Name", Player1Name);
    }
}
