using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform target;
    public float smoothing;
    public Vector2 maxPositon;
    public Vector2 minPosition;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if(transform.position != target.position)
        {
            Vector3 targetPosition = new Vector3(target.position.x, target.position.y, transform.position.z);
            targetPosition.x = Mathf.Clamp(targetPosition.x, minPosition.x, maxPositon.x);
            targetPosition.y = Mathf.Clamp(targetPosition.y, minPosition.y, maxPositon.y);      
            transform.position = Vector3.Lerp(transform.position, targetPosition, smoothing);
        }   
    }
}
