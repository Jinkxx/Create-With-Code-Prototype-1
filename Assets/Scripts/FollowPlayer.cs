using UnityEngine;

public class FollowPlayer : MonoBehaviour
{   
    public GameObject player;
    private Vector3 offset = new Vector3(0, 5, -7);
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // LateUpdate is used here to get rid of the jittering camera.
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
