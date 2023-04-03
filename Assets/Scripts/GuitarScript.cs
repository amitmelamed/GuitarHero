using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuitarScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "BlueNote" && enabled && Input.GetKeyDown(KeyCode.Z))
        {
            Destroy(other.gameObject);
        }
        if (other.tag == "RedNote" && enabled && Input.GetKeyDown(KeyCode.X))
        {
            Destroy(other.gameObject);
        }
        if (other.tag == "GreenNote" && enabled && Input.GetKeyDown(KeyCode.C))
        {
            Destroy(other.gameObject);
        }
    }

}
