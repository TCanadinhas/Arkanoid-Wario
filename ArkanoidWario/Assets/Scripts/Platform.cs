using UnityEngine;
using System.Collections;

public class Platform : MonoBehaviour {
	
	float speed = 4.5f;
	void Update () 
	{
		if (Input.GetKey ("right")) 
		{
			transform.position += (Vector3.right * speed * Time.deltaTime);
		}
		if (Input.GetKey ("left")) 
		{
			transform.position += (Vector3.left * speed * Time.deltaTime);
		}
	}
}
