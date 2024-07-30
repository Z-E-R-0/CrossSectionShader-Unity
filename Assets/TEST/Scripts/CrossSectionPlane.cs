using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[ExecuteInEditMode]
public class CrossSectionPlane : MonoBehaviour
{
    public Material[] materials;

    void Update()
    {
        foreach (Material material in materials)
        {
            material.SetVector("_Plane_Position", transform.position);
            material.SetVector("_PlaneNormal", transform.forward);
        }
    }
}
