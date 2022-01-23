using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatchApple : MonoBehaviour
{
    private void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.gameObject);
    }
}
