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
        yield return new WaitForSeconds(0.1f);
        transform.Rotate(0,45,0);
        GetComponent<MeshRenderer>().material.color = new Color(1,0,1,1);
    }
}
