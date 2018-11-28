using UnityEngine;
using System.Collections;

public class ch : MonoBehaviour {

	Light al;

	void Start () 
	{
		al = GetComponent<Light> ();
	}
	

	void Update () 
	{
	 if (Input.GetKeyDown(KeyCode.Space))
		    
		       al.enabled=!al.enabled;
		    
	} 
}
