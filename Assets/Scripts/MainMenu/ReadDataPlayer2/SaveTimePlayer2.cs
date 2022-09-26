using UnityEngine.UI;
using System.IO;
using UnityEngine;

public class SaveTimePlayer2 : MonoBehaviour
{
    private Player2Data SecondPlayerData;
    public Text player2TimeAmountText;
    private string path = "";
    private string persistentPath = "";
    private float PlayerData;
    private string Player2Name;
    private string Player2SchoolName;
    private string Player2ClassName;


    
    void Start()
    {
        PrefsData();
        SetPaths();
    }
    private void Update()
    {
        
        PlayerPrefs.SetString("player2Time", player2TimeAmountText.text);
    }
    private void PrefsData()
    {
        Player2Name = PlayerPrefs.GetString("player2Name");
        Player2SchoolName = PlayerPrefs.GetString("player2SchoolName");
        Player2ClassName = PlayerPrefs.GetString("player2ClassName");
    }

    public void clickPlayer2SaveButton()
    {
        SaveDataP2();
        CreatePlayer2Data();
    }

    private void CreatePlayer2Data()
    {
        SecondPlayerData = new Player2Data(Player2Name, player2TimeAmountText.text, Player2SchoolName, Player2ClassName);
    }

    private void SetPaths()
    {
        path = Application.dataPath + Path.AltDirectorySeparatorChar + "SaveData2.json";//Test path for data
        persistentPath = Application.persistentDataPath + Path.AltDirectorySeparatorChar + "SaveData2.json";//ACtually location the data will be saved after publishing
    }
       
    public void SaveDataP2()
    {
        string savePath = path;//Son halini alýnca burayý persistentPath yap
        Debug.Log("Saving data at " + savePath);

        string json = JsonUtility.ToJson(SecondPlayerData);
        Debug.Log(json);

        using StreamWriter writer = new StreamWriter(savePath);
        writer.Write(json);
    }
}
