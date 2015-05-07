using UnityEngine;
using System.Collections;

public class WarioRun : MonoBehaviour {

	bool warioJump = false;
	public GameObject warioRun;
	public void jump()
	{
		this.transform.Translate (0, 1, 0);
		warioJump = true;
	}

	void Update () 
	{
		if(warioJump == false)
		{
			transform.position += new Vector3 (0.05f,0,0);
			print ("piru");
		}
		if (transform.position.x >= 0.3f && warioJump == false) 
		{
			transform.position = new Vector3 (0, -4.2f, 0);
		}
		if(transform.position.y >= -3.2)
		{
			Destroy (warioRun);
			Wario.gameObject.GetComponent<Animator> ().enabled = true;
		}
	}
}
