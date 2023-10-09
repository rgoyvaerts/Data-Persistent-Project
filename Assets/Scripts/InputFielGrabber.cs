using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InputFielGrabber : MonoBehaviour
{
    public string inputUsername;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GrabFromInputField(string input)
    {
        inputUsername = input;
        Debug.Log("Username Input: " + inputUsername);
        //SaveUsername();
    }

    public void SaveUsername()
    {
        DataManager.Instance.username = inputUsername;
        DataManager.Instance.WriteData();
        Debug.Log("Saved Username is: " + inputUsername);

    }
}
