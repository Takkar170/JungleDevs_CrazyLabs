using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newTouchMove : MonoBehaviour
{
    [SerializeField]
    private Vector3 vecc;

    void Update () {
        if (Input.GetMouseButton(0))
        {
            var Ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if(Physics.Raycast(Ray, out hit))
            {
                if (hit.collider.gameObject.name == "drawingPlane"){
                    transform.position = hit.point;
                }
                else
                {
                    transform.position = vecc;
                }
            }

            

        }
        if(Input.GetMouseButtonUp(0))
        {
            transform.position = vecc;
        }
    }
}