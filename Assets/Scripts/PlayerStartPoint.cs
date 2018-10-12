using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStartPoint : MonoBehaviour {
    private PlayerController thePlayer;
    private CameraController theCamera;
    public Vector2 startDirection;
    public static bool gameStart = true;

    // Use this for initialization
    void Start () {
        thePlayer = FindObjectOfType<PlayerController>();
        thePlayer.transform.position = transform.position;
        thePlayer.lastMove = startDirection;

        theCamera = FindObjectOfType<CameraController>();
        theCamera.transform.position = new Vector3(transform.position.x, transform.position.y, theCamera.transform.position.z);
        if (gameStart)
        {
            thePlayer = FindObjectOfType<PlayerController>();
            thePlayer.transform.position = new Vector3(0, 0, 0);

            theCamera = FindObjectOfType<CameraController>();
            theCamera.transform.position = new Vector3(0, 0, theCamera.transform.position.z);
            gameStart = false;
        }
    }
	
	// Update is called once per frame
	void Update () {
	}
}
