using UnityEngine;
using System.Collections;

public class tpToNextLevel : MonoBehaviour {
    public Transform target;

	void OnTriggerEnter(Collider other)
    {
        target.transform.position = new Vector3(0, 0, 0);
    }
}
