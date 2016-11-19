using UnityEngine;
using System.Collections;

public class VideoControl : MonoBehaviour {

    private MoviePlayerSample player;
    private int button = 0;
    // Use this for initialization
    void Start () {
         player = GetComponent<MoviePlayerSample>();
        Debug.Log("test");
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetMouseButtonDown(button)) { 
            player.SetPaused(!player.videoPaused);
        } 

    }
}
