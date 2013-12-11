using UnityEngine;
using System.Collections;

public class EnemyAi : MonoBehaviour {

	public Transform target;
	public int moveSpeed;
	public int rotationSpeed;
	private Transform myTransform;

	void Awake ()
	{
		myTransform = transform;
	}

	// Use this for initialization
	void Start () {
		GameObject go = GameObject.FindGameObjectWithTag("Player");

		target = go.transform;
	
	}
	
	// Update is called once per frame
	void Update () {
		Debug.DrawLine(target.position, myTransform.position, Color.yellow);
	}
}
