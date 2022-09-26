using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class YıldızHarfSave : MonoBehaviour
{
    public Dropdown dropdown;
    public Dropdown dropdownInt;

    public Dropdown dropdownStringP1;
    public Dropdown dropdownIntP1;

    public GameObject okBtn;
    public Text errorText;
    public Text errorText1;

    private bool p2StringStar;
    private bool p2IntStar;
    private bool p1StrStar;
    public bool p1IntStar;

    // Start is called before the first frame update
    void Start()
    {
        okBtn.SetActive(false);

        dropdownDataSelected(dropdown);
        dropdown.onValueChanged.AddListener(delegate { dropdownDataSelected(dropdown); });

        dropDownDataSelectedInt(dropdownInt);
        dropdownInt.onValueChanged.AddListener(delegate { dropDownDataSelectedInt(dropdownInt); });

        dropdownDataSelectedStringP1(dropdownStringP1);
        dropdownStringP1.onValueChanged.AddListener(delegate { dropdownDataSelectedStringP1(dropdownStringP1); });

        dropDownDataSelectedIntP1(dropdownIntP1);
        dropdownIntP1.onValueChanged.AddListener(delegate { dropDownDataSelectedIntP1(dropdownIntP1); });
    }
    void dropdownDataSelected(Dropdown dropdown)
    {
        int index = dropdown.value;
        if(dropdown.options[index].text == "A"|| dropdown.options[index].text == "B" || dropdown.options[index].text == "C" || dropdown.options[index].text == "D" || dropdown.options[index].text == "E")
        {
            PlayerPrefs.SetString("player2StarString", dropdown.options[index].text);
            p2StringStar = true;

            Debug.Log(PlayerPrefs.GetString("player2StarString"));
            
        }
        else
        {
            errorText.text = "Lütfen yıldız değerlerini seç.";
            okBtn.SetActive(false);
        }
    }

    void dropDownDataSelectedInt(Dropdown dropdownInt)
    {
        int index = dropdownInt.value;
        if (dropdownInt.options[index].text == "1" || dropdownInt.options[index].text == "2" || dropdownInt.options[index].text == "3" || dropdownInt.options[index].text == "4" || dropdownInt.options[index].text == "5" || dropdownInt.options[index].text == "6" || dropdownInt.options[index].text == "7" || dropdownInt.options[index].text == "8" || dropdownInt.options[index].text == "9" || dropdownInt.options[index].text == "10" || dropdownInt.options[index].text == "11" || dropdownInt.options[index].text == "12" || dropdownInt.options[index].text == "13" || dropdownInt.options[index].text == "14" || dropdownInt.options[index].text == "15" || dropdownInt.options[index].text == "16")
        {
            PlayerPrefs.SetString("player2StarInteger", dropdownInt.options[index].text);
            p2IntStar = true;
            Debug.Log(PlayerPrefs.GetString("player2StarInteger"));
            
        }
        else
        {
            errorText.text = "Lütfen yıldız değerlerini seç.";
            okBtn.SetActive(false);
        }
    }

    void dropdownDataSelectedStringP1(Dropdown dropdown)
    {
        int index = dropdown.value;
        if (dropdown.options[index].text == "A" || dropdown.options[index].text == "B" || dropdown.options[index].text == "C" || dropdown.options[index].text == "D" || dropdown.options[index].text == "E")
        {
            PlayerPrefs.SetString("player1StarString", dropdown.options[index].text);
            p1StrStar = true;

            Debug.Log(PlayerPrefs.GetString("player1StarString"));

        }
        else
        {
            errorText1.text = "Lütfen yıldız değerlerini seç.";
            okBtn.SetActive(false);
        }
    }

    void dropDownDataSelectedIntP1(Dropdown dropdownInt)
    {
        int index = dropdownInt.value;
        if (dropdownInt.options[index].text == "1" || dropdownInt.options[index].text == "2" || dropdownInt.options[index].text == "3" || dropdownInt.options[index].text == "4" || dropdownInt.options[index].text == "5" || dropdownInt.options[index].text == "6" || dropdownInt.options[index].text == "7" || dropdownInt.options[index].text == "8" || dropdownInt.options[index].text == "9" || dropdownInt.options[index].text == "10" || dropdownInt.options[index].text == "11" || dropdownInt.options[index].text == "12" || dropdownInt.options[index].text == "13" || dropdownInt.options[index].text == "14" || dropdownInt.options[index].text == "15" || dropdownInt.options[index].text == "16")
        {
            PlayerPrefs.SetString("player1StarInteger", dropdownInt.options[index].text);
            p1IntStar = true;
            Debug.Log(PlayerPrefs.GetString("player1StarInteger"));

        }
        else
        {
            errorText1.text = "Lütfen yıldız değerlerini seç.";
            okBtn.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (p2StringStar && p2IntStar)
        {
            errorText.text = "";
        }
        if (p1StrStar && p1IntStar)
        {
            errorText1.text = "";
        }
        if (p2StringStar && p2IntStar && p1StrStar && p1IntStar)
        {
            okBtn.SetActive(true);
            
            
        }
    }
}
