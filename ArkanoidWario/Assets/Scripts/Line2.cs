using UnityEngine;
using System.Collections;

public class Line2 : MonoBehaviour {

	public GameObject line2;
	public static float blocksLine2 = 0;

	void OnCollisionEnter2D(Collision2D col2)
	{
		Destroy (line2);
	}

	void ForInstantiate()
	{
		Instantiate (line2, new Vector3 (line2.transform.position.x + 1.5f, line2.transform.position.y, line2.transform.position.z),line2.transform.rotation);
	}
	
	void Update () 
	{
		if (blocksLine2 <= 288) 
		{
			ForInstantiate ();
			blocksLine2 += 1;
		} 
	}
}