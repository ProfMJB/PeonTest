using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshCreate : MonoBehaviour {
    // Use this for initialization
    void Start() {
        Mesh mesh = GetComponent<MeshFilter>().mesh;
        MeshRenderer renderer = GetComponent<MeshRenderer>();
        mesh.Clear();
        mesh.vertices = new Vector3[]
        {
            new Vector3(0,0,0),
            new Vector3(10,0,0),
            new Vector3(20,0,0),
            new Vector3(0,0,10),
            new Vector3(10,10,10),
            new Vector3(20,0,10),
            new Vector3(0,0,20),
            new Vector3(10,0,20),
            new Vector3(20,0,20)
    };
        mesh.triangles = new int[]
        {
            0,3,4,
            1,0,4,
            1,4,5,
            2,1,5,
            3,6,7,
            4,3,7,
            4,7,8,
            5,4,8,
        };
        mesh.uv = new Vector2[]
        {
            new Vector2(0,0),
            new Vector2(0.5f,0),
            new Vector2(1,0),
            new Vector2(0,0.5f),
            new Vector2(0.5f,0.5f),
            new Vector2(1,0.5f),
            new Vector2(0,1),
            new Vector2(0.5f,1),
            new Vector2(1,1)
    };
        WWW www = new WWW("https://maps.googleapis.com/maps/api/staticmap?center=%2252.591695,%20-1.161119%22&zoom=14&size=500x500&maptype=satellite");
        while (!www.isDone)
        {
        }
        renderer.material.mainTexture = www.texture;
        mesh.RecalculateNormals();
    }

    // Update is called once per frame
    void Update() {
    
    }
}
