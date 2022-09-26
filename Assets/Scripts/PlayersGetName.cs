
using UnityEngine;
using UnityEngine.UI;

public class PlayersGetName : MonoBehaviour
{
    public Text player1Name;
    public Text player2Name;
    // Start is called before the first frame update
    void Start()
    {
        player1Name.text = PlayerPrefs.GetString("player1Name");
        player2Name.text = PlayerPrefs.GetString("player2Name");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
