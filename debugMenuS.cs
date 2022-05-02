using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class debugMenuS : MonoBehaviour
{
    [SerializeField]
    private Button Cam1;
    [SerializeField]
    private Button Cam2;
    [SerializeField]
    private Button Cam3;
    
    public GameObject Camera1;
    
    public GameObject Camera2;
    
    public GameObject Camera3;
    
    // Start is called before the first frame update
    void Start()
    {
        Cam1.onClick.AddListener(Cam1Start);
        Cam2.onClick.AddListener(Cam2Start);
        Cam3.onClick.AddListener(Cam3Start);
    }

    void Cam1Start()
    {
        Camera1.SetActive(true);
        Camera2.SetActive(false);
        Camera3.SetActive(false);
    }
    void Cam2Start()
    {
        Camera1.SetActive(false);
        Camera2.SetActive(true);
        Camera3.SetActive(false);
    }
    void Cam3Start()
    {
        Camera1.SetActive(false);
        Camera2.SetActive(false);
        Camera3.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
