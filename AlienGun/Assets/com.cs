using UnityEngine;
using System.Collections;

public class com : MonoBehaviour {

	Light a;

	void Start () 
	{
		a = GetComponent<Light> ();

	}
	

	void Update () 
	{
	  if(Input.GetKeyDown(KeyCode.Space))
		   a.enabled=!a.enabled;

	}
}
