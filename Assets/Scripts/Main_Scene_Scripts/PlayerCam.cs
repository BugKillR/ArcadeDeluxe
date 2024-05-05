using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCam : MonoBehaviour
{
    public GameObject player, cam;

    [SerializeField] private float distanceX, distanceY;

    private void Update()
    {
        cam.transform.position = new Vector3(player.transform.position.x + distanceX, player.transform.position.y + distanceY, player.transform.position.z);
    }
}
