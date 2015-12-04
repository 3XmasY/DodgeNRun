using UnityEngine;
using System.Collections;

public class Teleport : MonoBehaviour {

    public Transform destination;
    public Transform player;

    void OnTriggerEnter2D(Collider2D other)
    {
        player.transform.position = destination.transform.position;
        if(Application.loadedLevelName.Equals("_Scene1"))
          Application.LoadLevel("_Scene2");
        if (Application.loadedLevelName.Equals("_Scene2"))
            Application.LoadLevel("_Scene3");
        if (Application.loadedLevelName.Equals("_Scene3"))
            Application.LoadLevel("_Scene4");
        if (Application.loadedLevelName.Equals("_Scene4"))
            Application.LoadLevel("_Scene5");
        if (Application.loadedLevelName.Equals("_Scene5"))
            Application.LoadLevel("_Scene6");
        if (Application.loadedLevelName.Equals("_Scene6"))
            Application.LoadLevel("_Scene7");
        if (Application.loadedLevelName.Equals("_Scene7"))
            Application.LoadLevel("_Scene8");
        if (Application.loadedLevelName.Equals("_Scene8"))
            Application.LoadLevel("_Scene9");
        if (Application.loadedLevelName.Equals("_Scene9"))
            Application.LoadLevel("_Scene10");
    }
}
