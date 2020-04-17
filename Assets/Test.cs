using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
        int[] array = new int[5];
        array[0] = 1;
        array[1] = 6;
        array[2] = 10;
        array[3] = 248;
        array[4] = 4876;
        for (int i = 0; i < 5; i++){
            Debug.Log(array[i]);
        }
        for(int i = 4; i >= 0; i--){
            Debug.Log(array[i]);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
