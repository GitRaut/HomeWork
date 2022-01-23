using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NutsSpawner : MonoBehaviour
{
    [Header("Settings:")]
    public GameObject FollowedObject;
    public GameObject SpawnedObject ;
    public GameObject SpawnerObject;
    public GameObject Parent;
    public float TimeSpawn;

    void Start()
    {
        StartCoroutine(NutSpawn());
    }

    private void Update()
    {
        TimeSpawn = Mathf.Max(0.3f, TimeSpawn - 0.05f * Time.deltaTime);
    }

    void Repeat()
    {
        StartCoroutine(NutSpawn());
    }

    IEnumerator NutSpawn()
    {
        yield return new WaitForSeconds(TimeSpawn);
        Vector3 pos = FollowedObject.transform.position;
        pos.y += 1.5f;
        SpawnerObject.transform.position = pos;
        GameObject NutClone = Instantiate(
            SpawnedObject, SpawnerObject.transform.position,
            Quaternion.Euler(new Vector3(-90,0,0)), Parent.transform);
        NutClone.GetComponent<Rigidbody>().AddForce(new Vector3(Random.Range(-25, 25), 0, 0));
        Repeat();
    }
}
