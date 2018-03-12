using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapToPlay : MonoBehaviour {

    public GameObject TapCanvas;
	// Use this for initialization
	void Start () {
        Time.timeScale = 0;
	}
	
	// Update is called once per frame
	void Update ()
    {
        //foreach (Touch touch in Input.touches)
        //{
        //    if (touch.phase == TouchPhase.Began)
        //    {
        //        Time.timeScale = 1;
        //        TapCanvas.SetActive(false);
        //    }
        //}

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Time.timeScale = 1;
            TapCanvas.SetActive(false);
        }


    }
}
