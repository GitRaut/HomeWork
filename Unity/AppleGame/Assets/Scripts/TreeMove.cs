using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeMove : MonoBehaviour
{
    [Header("Settings:")]
    public float speed;
    private float destination_x;
    private float start_x;
    private float progress;
    private float diff;

    void Start()
    {
        start_x = transform.position.x;
        destination_x = Random.Range(-8, 8);
    }

    void Update()
    {
        Vector3 pos_start = new Vector3(
            start_x,
            transform.position.y,
            transform.position.z);

        Vector3 pos_finish = new Vector3(
            destination_x,
            transform.position.y,
            transform.position.z);

        transform.position = Vector3.Lerp(pos_start, pos_finish, progress);

        diff = Mathf.Abs(destination_x - start_x);
        progress += speed * Time.deltaTime / diff;
        if(progress > 1)
        {
            progress = 0;
            destination_x = Random.Range(-8, 8);
            start_x = transform.position.x;
        }
    } 
}
