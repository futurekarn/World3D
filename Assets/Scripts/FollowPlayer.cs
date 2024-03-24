using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player  ;
    private Vector3 off= new Vector3(0,5,-7);
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()

    {// sets the camera behind the player
        transform.position= player.transform.position + off;
        
    }
}
