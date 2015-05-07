using UnityEngine;
using System.Collections;

public class Line3 : MonoBehaviour {

	public GameObject line3;
	public static float blocksline3 = 0;

	void OnCollisionEnter2D(Collision2D col3)
	{
		Destroy (line3);
	}

	void ForInstantiate()
	{
		Instantiate (line3, new Vector3 (line3.transform.position.x + 1.5f, line3.transform.position.y, line3.transform.position.z),line3.transform.rotation);
	}
	
	void Update () 
	{
		if (blocksline3 <= 288) 
		{
			ForInstantiate ();
			blocksline3 += 1;
		} 
	}
}
