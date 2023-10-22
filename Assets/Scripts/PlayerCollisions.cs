using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisions : MonoBehaviour
{
    private bool doorIsOpen = false;
    private double doorTimer = 0.0f;
    public double doorOpenTime = 3.0f;
    public AudioClip doorOpenSound, doorShutSound;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnControllerColliderHit(ControllerColliderHit hit) {

        if(hit.gameObject.tag == "playerDoor" && doorIsOpen == false) {
            OpenDoor(hit.gameObject);
        }
    }

    void OpenDoor(GameObject door) {
        doorIsOpen = true;
        door.GetComponent<AudioSource>().PlayOneShot(doorOpenSound);
        door.transform.parent.GetComponent<Animation>().Play("dooropen");
    }
}
