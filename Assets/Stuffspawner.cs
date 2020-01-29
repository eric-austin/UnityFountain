using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stuffspawner : MonoBehaviour
{
    //public means that we will see in unity editor
    public float timeBetweenSpawns;
    public Stuff[] stuffPrefabs;
    float timeSinceLastSpawn;
    public float velocity;
    public Material stuffMaterial;

    void FixedUpdate() {
        timeSinceLastSpawn += Time.deltaTime;
        if (timeSinceLastSpawn >= timeBetweenSpawns) {
            timeSinceLastSpawn -= timeBetweenSpawns;
            SpawnStuff();
        }
    }

    void SpawnStuff() {
        Stuff prefab = stuffPrefabs[Random.Range(0, stuffPrefabs.Length)];
        Stuff spawn = Instantiate<Stuff>(prefab);
        spawn.transform.position = transform.position;
        spawn.body.velocity = transform.up * velocity;
    }
}
