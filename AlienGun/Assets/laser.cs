using UnityEngine;
using System.Collections;

public class laser : MonoBehaviour 
{



	LineRenderer gun;
	Light fl;
	AudioSource la;



	void Start () 
	{
		gun = gameObject.GetComponent<LineRenderer> ();
		gun.enabled = false;
		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = (false);
		fl = gameObject.GetComponent<Light> ();
		fl.enabled = false;
		la = gameObject.GetComponent<AudioSource> ();
		la.enabled = false;
	}
	

	void Update ()
	{
		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = (false);
		if (Input.GetButtonDown("Fire1")) 
		{
			StopCoroutine("FireLaser");
			StartCoroutine("FireLaser");

		}
	
	}
	IEnumerator FireLaser()
	{

		gun.enabled = true;
		fl.enabled = true;
		la.enabled = true;


		while (Input.GetButton("Fire1")) 
		{


			Ray ray =new Ray(transform.position, transform.forward);
			RaycastHit hit;

			gun.SetPosition(0, ray.origin);
			if(Physics.Raycast(ray, out hit, 100))
			{
				gun.SetPosition(1,hit.point);
				if(hit.rigidbody)
				{
					hit.rigidbody.AddForceAtPosition(transform.up * 100, hit.point);
				
				}

			}
			else
			    gun.SetPosition(1, ray.GetPoint(100));

			yield return null;

		}
		gun.enabled = false;
		fl.enabled = false;
		la.enabled = false;

	}

}
