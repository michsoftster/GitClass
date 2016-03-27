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
        yield return new WaitForSeconds(10f);
        transform.Rotate(-5,0,-15);
        GetComponent<MeshRenderer>().material.color = new Color(0,0,1,1);
    }
}

