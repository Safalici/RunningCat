using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ChechkInputs : MonoBehaviour
{
    private bool SchoolChanged;
    private bool ClassChanged;

    public GameObject okbtn;
    public Dropdown Schooldropdown;
    public Dropdown ClassDropdown;

    // Start is called before the first frame update
    void Start()
    {
        SchoolChanged = false;
        ClassChanged = false;
        okbtn.SetActive(false);

         
    
    }
    public void OnChangeSchool()
    {
        SchoolChanged = true;
    }
    public void OnChangeClass()
    {
        ClassChanged = true;
    }
    // Update is called once per frame
    void Update()
    {
        if(SchoolChanged && ClassChanged)
        {
            okbtn.SetActive(true);
        }
    }

}
