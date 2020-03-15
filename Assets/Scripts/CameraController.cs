using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour
{

    public GameObject player;        //Public variable to store a reference to the player game object
    public bool fixY = false;


    private Vector3 offset;            //Private variable to store the offset distance between the player and camera

    // Use this for initialization
    void Start()
    {
        offset = transform.position - player.transform.position;
    }

    // LateUpdate is called after Update each frame
    void LateUpdate()
    {
        // Set the position of the camera's transform to be the same as the player's, but offset by the calculated offset distance.
        if (fixY)
            transform.position = new Vector3(player.transform.position.x + offset.x, transform.position.y, player.transform.position.z + offset.z);
        else
            transform.position = player.transform.position + offset;
    }
}