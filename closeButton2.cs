using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class closeButton2 : MonoBehaviour
{
    [SerializeField]
    private Button closeButt;
    [SerializeField]
    private Animator animatorr2;
    private int i=0;
    private bool booll = false;
    //[SerializeField]
    //private Animator animator2;
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("started");
        
        closeButt.onClick.AddListener(closeButtClick);
        closeButt.onClick.AddListener(boolButt);
    }
    void closeButtClick()
    {
        //Debug.Log("inButtClick");
        animatorr2.SetTrigger("cDs");
    }
    void boolButt()
    {
        //Debug.Log("inBoolBut");
        booll = true;
        
    }
    // Update is called once per frame
    void Update()
    {
        //Debug.Log("nig + "+i);
        
        if(booll==true){
            i++;
            //Debug.Log("mig + "+i);
            if(i>=52){
                Debug.Log("cig");
                gameObject.SetActive(false);
                i=0;
                booll=false;
            }
        }
        
    }

}
