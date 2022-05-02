using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class storeButton : MonoBehaviour
{
    public Button storeButt;
    public Animator animatorr;
    //[SerializeField]
    //private Animator animator2;
    // Start is called before the first frame update
    void Start()
    {
        storeButt.onClick.AddListener(storeButtClick);
        gameObject.SetActive(false);
    }
    void storeButtClick()
    {
    gameObject.SetActive(true);
    animatorr.SetTrigger("oDs");
    
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
