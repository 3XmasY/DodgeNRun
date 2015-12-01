using UnityEngine;
using System.Collections;

public class CharacterFollow : MonoBehaviour {

    public Transform target;
    public float dampTime = 0.15f;
    private Vector3 velocity = Vector3.zero;
    private Vector3 destination = Vector3.zero;
    // Use this for initialization
    void Start () {
        destination = new Vector3(target.transform.position.x, target.transform.position.y, -20);
    }
	
	// Update is called once per frame
	void Update () {
        destination = new Vector3(target.transform.position.x, target.transform.position.y, -10);
        transform.position = Vector3.SmoothDamp(transform.position, destination, ref velocity, dampTime);
    }
}
