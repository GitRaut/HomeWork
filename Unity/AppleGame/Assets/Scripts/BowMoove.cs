using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowMoove : MonoBehaviour
{
    void Update()
    {
        Vector2 mouse = Input.mousePosition;
        transform.position = Camera.main.ScreenToWorldPoint(
            new Vector3(
                mouse.x, transform.position.y + 25,
                transform.position.z - Camera.main.transform.position.z));
        Vector3 pos = transform.position;
        pos.x = Mathf.Clamp(transform.position.x, -8.5f, 8.5f);
        transform.position = pos;
    }
}
