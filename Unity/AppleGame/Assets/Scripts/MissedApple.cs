using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MissedApple : MonoBehaviour
{
    public List<GameObject> health;
    public GameObject obj;

    private void Update()
    {
        if(health.Count == 0)
        {
            SceneManager.LoadScene("Main");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        ClearAll();
        Destroy(other.gameObject);
        int count = health.Count;
        if(health.Count > 0)
        {
            Destroy(health[count - 1].gameObject);
            health.Remove(health[count - 1]);
        }
        GameObject scriptholder = GameObject.Find("/Main Camera");
        NutsSpawner nutspawner = scriptholder.GetComponent<NutsSpawner>();
        if (nutspawner)
        {
            nutspawner.TimeSpawn = 1f;
        }
    }

    private void ClearAll()
    {
        GameObject parent = GameObject.Find("/NutsParent");
        foreach (Transform i in parent.transform)
        {
            Destroy(i.gameObject);
        }
    }
}
