using UnityEngine;
using System.Collections;

public class Line1 : MonoBehaviour {

	public GameObject line1;
	public static float blocksLine1 = 0;

	void OnCollisionEnter2D(Collision2D col)
	{
		Destroy (line1);
	}

	void ForInstantiate()
	{
		Instantiate (line1, new Vector3 (line1.transform.position.x + 1.5f, line1.transform.position.y, line1.transform.position.z),line1.transform.rotation);
	}

	void Update () 
	{
		if (blocksLine1 <= 288) 
		{
			ForInstantiate ();
			blocksLine1 += 1;
		} 
	}
}
