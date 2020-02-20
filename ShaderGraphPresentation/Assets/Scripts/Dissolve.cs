using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dissolve : MonoBehaviour
{
    private Material material;
    [SerializeField]
    private float dissolveTime;
    private float dissolveDirection = -1;

    public float DissolveAmount 
    {
        get { return material.GetFloat("_DissolveAmount"); }
        set 
        {
            //Keep the value between 0 and 1
            if (value > 1)
            {
                value = 1;
            }
            else if(value < 0)
            {
                value = 0;
            }

            material.SetFloat("_DissolveAmount", value);
        }
    }

    void Awake()
    {
        material = GetComponent<MeshRenderer>().materials[0];
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            dissolveDirection *= -1;
        }

        DissolveAmount += dissolveDirection * Time.deltaTime * (1 / dissolveTime);
    }
}
