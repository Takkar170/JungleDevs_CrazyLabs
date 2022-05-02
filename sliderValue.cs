using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class sliderValue : MonoBehaviour
{
    //private int i =0;
    private int p1 = 0;
    private int sliderDirtyS = 0;
    public int sliderSpidS = 0;
    //private int BrQuadova = 0;
   // private int BrBad = 0;
    public Slider autoSlider;
    //private GameObject[] destroy1 = new GameObject[0];
    private GameObject[] sliderDirty = new GameObject[0];
    public GameObject[] sliderSpid = new GameObject[0];
 
    void Start()
    {
        //GameObject phase1 = new GameObject();
        //phase1 = new GameObject("phasee1");
        //phase1.tag = "phaseIs1";
        //phase1.transform.SetParent(this.transform);
    }
    //void phase2Starts()
    //{
        //GameObject phase2 = new GameObject();
        //phase2 = new GameObject("phasee2");
        //phase2.tag = "phaseIs2";
        //phase2.transform.SetParent(this.transform);
        
        //destroy1 = GameObject.FindGameObjectsWithTag("phaseIs1");
        //foreach(GameObject it in destroy1){
            //Destroy(it);
        //}
   //}
    void Update()
    {
        if(p1==0)
        {
            
            sliderDirtyS = 0;
            sliderDirty = GameObject.FindGameObjectsWithTag("dirt");
            //myGameObjectsBad = GameObject.FindGameObjectsWithTag("daBad");
            //myGameObjectsQuad = GameObject.FindGameObjectsWithTag("daQuad");
            foreach (GameObject item in sliderDirty)
            {
                sliderDirtyS ++;

            }
            autoSlider.value = 300-sliderDirtyS;
            if(sliderDirtyS<5)
            {
                //phase2Starts();
                p1++;
                autoSlider.value = 0;

            
            }
        }
        if(p1==1)
        {
            sliderSpidS = 0;
            sliderSpid = GameObject.FindGameObjectsWithTag("spids");
            //myGameObjectsBad = GameObject.FindGameObjectsWithTag("daBad");
            //myGameObjectsQuad = GameObject.FindGameObjectsWithTag("daQuad");
            foreach (GameObject item in sliderSpid)
            {
                sliderSpidS = sliderSpidS + 100;
            }
            autoSlider.value = 300-sliderSpidS;
            if(sliderSpidS==0)
            {
                //phase2Starts();
                p1++;
                autoSlider.value = 0;

            
            }


        }
        

        /*
        foreach (GameObject item in myGameObjectsQuad)
        {
            BrQuadova ++;
        }
        foreach (GameObject item in myGameObjectsBad)
        {
            BrBad ++;
        }
        */
     
       

        /* OVO PRAVI PHASOVE< TJ OVO JE KONTROLER
        objToSpawn = new GameObject("Start");



        */
    }

        
        
    
}