using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFollow : MonoBehaviour {

    public Transform player;
    public Transform cam;
    public float cameraHeight = 18.0f;
    private Vector3 currentPosition;

    void Update () {
        if (player)
        {
            currentPosition = new Vector3(player.position.x, cameraHeight, player.position.z);
			cam.SetPositionAndRotation(currentPosition, Quaternion.Euler(90.0f, 0.0f, 0.0f));
        }
	}
}
