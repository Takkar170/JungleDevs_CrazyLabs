using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class startablebutton : MonoBehaviour
{
    [SerializeField]
    private int Scenes;
    
    [SerializeField]
    private Button starter;
    // Start is called before the first frame update
    void Start()
    {
        starter.onClick.AddListener(buttonStarterClick);
    }
    void buttonStarterClick()
    {
        SceneManager.LoadScene(Scenes);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
