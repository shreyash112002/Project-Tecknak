using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public InputField UsernameText;
    public GameObject LoginBtn;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update");
        if(UsernameText.text.Length >=5)
        {
            LoginBtn.SetActive(true);
        }
        else
        {
            LoginBtn.SetActive(false);
        }
    }
    public void OnStartPressed()
    {
        SceneManager.LoadScene("Game");

    }
}
