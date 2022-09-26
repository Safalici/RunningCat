using UnityEngine;
using UnityEngine.UI;
public class P2DataRead : MonoBehaviour
{
    // player2Name
    public string theName;
    public GameObject inputField;
    public GameObject textDisplay;
    void Start()
    {
        PlayerPrefs.SetString("player2Name", theName);
    }
    public void StoreName()
    {

        theName = inputField.GetComponent<Text>().text;
        PlayerPrefs.SetString("player2Name", theName);
        textDisplay.GetComponent<Text>().text = theName;
        Debug.Log(PlayerPrefs.GetString("player2Name"));

    }
}
