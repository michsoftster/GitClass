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
        yield return new WaitForSeconds(3f);
        transform.Rotate(0,10,0);
        GetComponent<MeshRenderer>().material.color = new Color(0,1,0,1);
    }
}
