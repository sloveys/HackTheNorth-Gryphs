using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class FlipNormals : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Mesh mesh = this.GetComponent<MeshFilter>().mesh;
        mesh.normals.Select(normal => normal * -1);
        mesh.triangles = mesh.triangles.Reverse().ToArray();
    }
}
