using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spiderOnTrigger : MonoBehaviour
{
    [SerializeField]
    private int tapV = 10;
    [SerializeField]
    private int debugV = 0;
    [SerializeField]
    private Animator animatorSpider;
    public GameObject spid;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="muvomlat")
        {
            tapV--;
            animatorSpider.SetTrigger("trigger");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if(tapV-debugV == 0)
        {
            spid.SetActive(false);
        }
    }
}
