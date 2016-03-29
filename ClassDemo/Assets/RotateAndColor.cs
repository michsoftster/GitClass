using UnityEngine;
using System.Collections;

public class RotateAndColor : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
    {
        StartCoroutine("RotateColor");
	}

    IEnumerator RotateColor()
    {     
        int x = 0;
	    int y = 0;
	    int z = 0;
	    int rojo = 0;
	    int verde = 0;
	    int azul = 0;	
	    System.Random rdm = new System.Random();

	    while(true)
	    {
	    	x = rdm.Next(0,30);
	    	y = rdm.Next(0,30);
	    	z = rdm.Next(0,30);

	    	rojo = rdm.Next(0,99);
	    	verde = rdm.Next(100,199);
	    	azul = rdm.Next(200,255);

	    	yield return new WaitForSeconds(0.5f);
            transform.Rotate(x,y,z);
            GetComponent<MeshRenderer>().material.color = new Color(rojo,verde,azul,1);
	    }   
    }
}

