using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class milosSS : MonoBehaviour
{
    private int i =0;
    private int p1 = 1;
    public int p2 = 0;
    public int dirtyS = 0;
    public int BrQuadova = 0;
    public int BrBad = 0;
    public GameObject[] phase1Checker = new GameObject[0];
    public GameObject[] phase2Checker = new GameObject[0];
    public GameObject[] dirty = new GameObject[0];
    public GameObject[] myGameObjectsQuad = new GameObject[0];
    public GameObject[] myGameObjectsBad = new GameObject[0];
    public GameObject[] spiids = new GameObject[0];
    public int spiidsC = 0;
    public GameObject[] dirtHold = new GameObject[0];
    [SerializeField]
    private int Scenes;
    public GameObject text1;
    public GameObject text2;
    /*
    [SerializeField]
    private GameObject circleM1 = new GameObject();
    [SerializeField]
    private GameObject circleM2 = new GameObject();
    [SerializeField]
    private GameObject circleM3 = new GameObject();
    [SerializeField]
    private GameObject circleF1 = new GameObject();
    [SerializeField]
    private GameObject circleF2 = new GameObject();
    [SerializeField]
    private GameObject circleF3 = new GameObject();
    [SerializeField]
    private GameObject handler1 = new GameObject();
    [SerializeField]
    private GameObject handler2 = new GameObject();
    */
    public GameObject circleM1;
    public GameObject circleM3;

    public GameObject circleF1;
    public GameObject circleF3;

    public GameObject handler1;
    public GameObject handler3;

    public GameObject winScreen;
    
    public Button winMenu;
    
    void Start()
    {
        text1.SetActive(true);
        circleM1.SetActive(true);
        winMenu.onClick.AddListener(winScreenClick);
        GameObject phase1 = new GameObject();
        phase1 = new GameObject("phasee1");
        phase1.tag = "phaseIs1";
        phase1.transform.SetParent(this.transform);
    }
    
    void phase2Starts()
    {
        //circleF2.SetActive(true);
        circleM1.SetActive(false);
        handler1.SetActive(false);
        text1.SetActive(false);
        circleF1.SetActive(true);
        circleM3.SetActive(true);
        handler3.SetActive(true);
        
        text2.SetActive(true);
        
        //handler2.SetActive(true);
        Debug.Log("phase2Starts mothod");
        dirtHold = GameObject.FindGameObjectsWithTag("dirtHolder");
        foreach(GameObject item in dirtHold)
        {
            Destroy(item);
        }
        phase1Checker = GameObject.FindGameObjectsWithTag("phaseIs1");
        foreach(GameObject it in phase1Checker){
            Destroy(it);
            
        }
        GameObject phase2 = new GameObject();
        phase2 = new GameObject("phasee2");
        phase2.tag = "phaseIs2";
        phase2.transform.SetParent(this.transform);
        p2++;
        
        
    }
    
    void Update()
    {

        if(p1==1)
        {
            text1.SetActive(true);
            circleM1.SetActive(true);
            dirtyS = 0;
            dirty = GameObject.FindGameObjectsWithTag("dirt");
            //myGameObjectsBad = GameObject.FindGameObjectsWithTag("daBad");
            //myGameObjectsQuad = GameObject.FindGameObjectsWithTag("daQuad");
            foreach (GameObject item in dirty)
            {
                dirtyS ++;
            }
            if(dirtyS<5)
            {
                if(i==0)
                {
                    phase2Starts();
                    p2++;
                    i++;
                    p1 = 0;
                }
            }
            phase1Checker = GameObject.FindGameObjectsWithTag("phaseIs1");
            foreach(GameObject it in phase1Checker){
                
            }

        }
        if(p2>=1)
        {
            
            spiidsC=0;
            spiids = GameObject.FindGameObjectsWithTag("spids");
            foreach(GameObject cc in spiids)
            {
                Debug.Log("in");
                spiidsC++;
                

                
            }
            if(spiidsC==0)
                {
                    Debug.Log("enabled");
                    circleF3.SetActive(true);
                    winScreen.SetActive(true);
                    circleF1.SetActive(false);
                    circleM3.SetActive(false);
                    handler3.SetActive(false);
                    text2.SetActive(false);
                    p2=0;
                }
            
            
        }
        
    }
    void winScreenClick()
    {
        
        SceneManager.LoadScene(Scenes);


    }
        
        
    
}