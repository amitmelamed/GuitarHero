using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [Tooltip("Movement vector in meters per second")]
    [SerializeField] Vector3 velocity;

    float time = 0;
    [SerializeField] bool destroyAfterTime = true;
    [SerializeField] float timeToDestroy = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += velocity * Time.deltaTime;
        time+=Time.deltaTime;
        if (time > timeToDestroy && destroyAfterTime) 
        {
            Destroy(gameObject);
        }
    }
    public void SetVelocity(Vector3 newVelocity)
    {
        this.velocity = newVelocity;
    }
}
