using UnityEngine;
using UnityEngine.UI;
using System.IO;


public class SaveTime : MonoBehaviour
{
       
    private Player1Data FirstPlayerData;
    public Text player1TimeAmountText;
    private string path = "";
    private string persistentPath = "";
    private float PlayerData;
    private string Player1Name;
    private string player1SchoolName;
    private string player1ClassName;
    private void Start()
    {
        PrefsData();
        SetPaths();
    }

    private void Update()
    {
        PlayerPrefs.SetString("player1Time", player1TimeAmountText.text);
    }
    private void PrefsData()
    {
        Player1Name = PlayerPrefs.GetString("player1Name");
        player1SchoolName = PlayerPrefs.GetString("player1SchoolName");
        player1ClassName = PlayerPrefs.GetString("player1ClassName");
    }
    /*public void clickSaveButton()
    {
        SaveData();
        CreatePlayer1Data();
       
    }*/
    /*private void CreatePlayer1Data()
    {

        FirstPlayerData = new Player1Data(Player1Name, player1TimeAmountText.text, player1SchoolName, player1ClassName);
    }*/
    private void SetPaths()
    {
        path = Application.dataPath + Path.AltDirectorySeparatorChar + "SaveData1.json";//Used to test in Unity
        persistentPath = Application.persistentDataPath + Path.AltDirectorySeparatorChar + "SaveData1.json";//ACtually location the data will be saved after publishing
    }

    public void SaveData()
    {
        string savePath = path;

        Debug.Log("Saving data at " + savePath);

        string json = JsonUtility.ToJson(FirstPlayerData);
        Debug.Log(json);

        using StreamWriter writer = new StreamWriter(savePath);
        writer.Write(json);
        
    }
}
