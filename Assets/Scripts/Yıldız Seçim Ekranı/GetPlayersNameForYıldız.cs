
using UnityEngine;
using UnityEngine.UI;
public class GetPlayersNameForYıldız : MonoBehaviour
{
    public Text Player1Text;
    public Text player2Text;
    // Start is called before the first frame update
    void Start()
    {
        //Player1Text.text = PlayerPrefs.GetString("player1Name");
        //player2Text.text = PlayerPrefs.GetString("player2Name");
    }

    // Update is called once per frame
    void Update()
    {
        Player1Text.text = PlayerPrefs.GetString("player1Name");
        player2Text.text = PlayerPrefs.GetString("player2Name");
    }
}
