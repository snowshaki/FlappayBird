using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollMove : MonoBehaviour
{
    public float scrollSpeed;
    float targetoffset;
    void Update()
    {
        targetoffset += Time.deltaTime * scrollSpeed;
        GetComponent<Renderer>().material.mainTextureOffset = new Vector2(targetoffset, 0);
    }
}