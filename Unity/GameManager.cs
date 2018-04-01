using UnityEngine;
using System.Collections;



public class GameManager : MonoBehaviour {

	private int x = -10;

	private void Start () {
		BeginGame();
	}

	private void Update () {
		if (Input.GetKeyDown(KeyCode.Space)) {
			RestartGame();
		}
	} 

	private void BeginGame () {
		for (int z = -10; z < 10; z++) {
			
			GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
			cube.AddComponent<Rigidbody>();
			cube.transform.position = new Vector3(x, 1, z);
			x = x + 1;
		}
	}

	private void RestartGame () {}
}