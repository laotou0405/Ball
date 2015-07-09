using UnityEngine;
using System.Collections;

public class cube{

	// Use this for initialization
	private GameObject floor;
	public cube () {

		floor = GameObject.CreatePrimitive(PrimitiveType.Cube);
		floor.transform.position = new Vector3(0,0,0);
		floor.GetComponent<BoxCollider>();
		floor.GetComponent<BoxCollider>().isTrigger = true;
		floor.GetComponent<BoxCollider>().size = new Vector2(0.1f,0.1f);
	}
	
}
