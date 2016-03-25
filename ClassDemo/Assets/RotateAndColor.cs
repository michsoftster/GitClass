using UnityEngine;
using System.Collections;
using System;

public class RotateAndColor : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
    {
        StartCoroutine("RotateColor");
	}

    IEnumerator RotateColor()
    {

	    int iX     = 0;
	    int iY     = 0;
	    int iZ     = 0;
	    int iRed   = 0;
	    int iBlue  = 0;
	    int iGreen = 0;	
	    Random rdm = new Random();

	    while(true)
	    {
	    	iX = rdm.Next(0,30);
	    	iY = rdm.Next(0,30);
	    	iZ = rdm.Next(0,30);

	    	iRed   = rdm.Next(0,255);
	    	iBlue  = rdm.Next(0,255);
	    	iGreen = rdm.Next(0,255);

	    	yield return new WaitForSeconds(1f);
            transform.Rotate(iX,iY,iZ);
            GetComponent<MeshRenderer>().material.color = new Color(iRed,iGreen,iBlue,1);
	    }       
    }
}
