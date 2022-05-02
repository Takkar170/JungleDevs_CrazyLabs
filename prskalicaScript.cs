using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prskalicaScript : MonoBehaviour
{
    public GameObject Brush;
    public float BrushSize = 0.14f;
   
    void Start()
    {

    }
    void Update () {
        if (Input.GetMouseButton(0))
        {
            var laser = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if(Physics.Raycast(laser, out hit))
            {
                if (hit.collider.gameObject.name == "drawingPlane"){
                    var brush = Instantiate(Brush, hit.point + Vector3.up * 0.14f, Quaternion.identity, transform);
                    brush.transform.localScale = Vector3.one * BrushSize;
                    Debug.Log("Hit "+hit.collider.gameObject.name);
                }
            }

        }
    }
}