using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour {


    public float speed = 2;
    Vector3 tempMove;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (2 > 1)
        {
            transform.Translate(speed * Time.deltaTime, 0, 0);           
         }
    }
}
