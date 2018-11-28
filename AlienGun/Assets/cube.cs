using UnityEngine;
using System.Collections;

public class cube : MonoBehaviour 
{


	void Start () 
	{
	
	}
	

	void Update () 
	{
	   if (Input.GetKeyDown (KeyCode.Mouse0)) {
			gameObject.GetComponent<Renderer> ().material.color=Color.green;

		} if (Input.GetKeyUp (KeyCode.Mouse0))
			gameObject.GetComponent<Renderer> ().material.color = Color.white;
	}
}
