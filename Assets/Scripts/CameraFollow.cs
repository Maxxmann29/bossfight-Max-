using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;

    private void Update()
    {
        if (player == null)
        {
            return; //add behavior here later for player death yadda yadda
        }

        transform.position = player.position + offset;
    }
}
