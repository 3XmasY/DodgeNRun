using System;
using UnityEngine;

namespace UnityStandardAssets._2D
{
    public class Restarter : MonoBehaviour
    {
        public Transform mtrans;
        private Vector3 pos;
        private void Awake()
        {
            pos = mtrans.position;
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.tag == "Player")
            {
                other.transform.position = new Vector3(pos.x, pos.y, 0);
            }
        }
    }
}
