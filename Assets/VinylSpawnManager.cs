using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VinylSpawnManager : MonoBehaviour {
    public GameObject RecordPlatform;
    MeshFilter recordMesh;
    public GameObject Groove;

    // Use this for initialization
    void Start () {
        recordMesh = RecordPlatform.GetComponent<MeshFilter>();

        InvokeRepeating("SpawnRecordGrooves", 1.0f, 1.0f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void SpawnRecordGrooves() {
        Mesh mesh = recordMesh.mesh;
        int variance = Random.Range(10, 15);
        Vector3 randomSpawn = new Vector3(0, .11f, variance);
        GameObject newGroove = Instantiate(Groove, RecordPlatform.transform.position + randomSpawn, RecordPlatform.transform.rotation);
        newGroove.transform.parent = RecordPlatform.transform;
        
    }
}
