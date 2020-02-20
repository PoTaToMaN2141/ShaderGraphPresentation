using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dissolve : MonoBehaviour
{
    private Material material;
    [SerializeField]
    private float dissolveTime;

    public float DissolveAmount 
    {
        get { return material.GetFloat("_DissolveAmount"); }
        set { material.SetFloat("_DissovleAmount", value); }
    }

    void Awake()
    {
        material = GetComponent<MeshRenderer>().materials[0];
    }

    private void Update()
    {
        
    }
}
