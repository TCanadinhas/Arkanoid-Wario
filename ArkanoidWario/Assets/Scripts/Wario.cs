using UnityEngine;
using System.Collections;

public class Wario : MonoBehaviour {

	public static bool collided = false;
	// Use this for initialization
	void Start () {
	
	}

	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.tag == "Walls") 
		{
			print ("piru");
			collided = true;
			transform.position += new Vector3 (0.06f, 0.06f, 0);
		} 
		else 
		{
			collided = false;
		}
	}
	// Update is called once per frame
	void Update () 
	{
		collider2D.enabled = false;
		gameObject.GetComponent<Animator> ().enabled = false;

	}
}
