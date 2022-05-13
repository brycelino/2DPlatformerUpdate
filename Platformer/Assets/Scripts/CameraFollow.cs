using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float speed = 1;
    // Start is called before the first frame update
    void Start()
    {
       

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetPosition = target.position;
        targetPosition.z = transform.position.z;

        //  transform.position = target.position;
        transform.position = Vector3.Lerp(transform.position,
                                          targetPosition,
                                          speed * Time.deltaTime);
    }
}
