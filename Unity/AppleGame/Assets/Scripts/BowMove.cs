using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowMove : MonoBehaviour
{
    public bool drag;

    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Input.GetMouseButtonDown(0) && Physics.Raycast(ray, out hit))
        {
            if (hit.collider.gameObject == gameObject)
            {
                drag = true;
            }
        }

        if (Input.GetMouseButtonUp(0))
        {
            drag = false;
        }

        if (drag)
        {
            Vector2 mouse = Input.mousePosition;
            transform.position = Camera.main.ScreenToWorldPoint(
                new Vector3(mouse.x, mouse.y,
                transform.position.z - Camera.main.transform.position.z));
        }
    }
}
