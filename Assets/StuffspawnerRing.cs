using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StuffspawnerRing : MonoBehaviour
{
    public int numberOfSpawners;
    public float radius, tiltAngle;
    public Stuffspawner spawnerPrefab;
    public Material[] stuffMaterials;

    void Awake() {
        for (int i = 0; i <numberOfSpawners; i++) {
            CreateSpawner(i);
        }
    }

    void CreateSpawner(int index) {
        Transform rotator = new GameObject("Rotator").transform;
        rotator.SetParent(this.transform, false);
        rotator.localRotation = Quaternion.Euler(0f, index * 360f/numberOfSpawners, 0f);
        Stuffspawner spawner = Instantiate<Stuffspawner>(spawnerPrefab);
        spawner.transform.SetParent(rotator, false);
        spawner.transform.localPosition = new Vector3(0f, 0f, radius);
        spawner.transform.localRotation = Quaternion.Euler(tiltAngle, 0f, 0f);
    }
}
