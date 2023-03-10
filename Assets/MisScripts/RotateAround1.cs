using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAround1 : MonoBehaviour
{
    public Transform target;
    public int speed;

    void Start()
    {
        if (target == null)
        {
            target = this.gameObject.transform;
            Debug.Log("RotateAround target not specified. Defaulting to parent GameObject");
        }   
    }

    // Update is called once per frame
    void Update() {
        
        transform.RotateAround(target.transform.position , target.transform.up , speed * Time.deltaTime); 
    }
}
