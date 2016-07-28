using UnityEngine;
using System.Collections;

public class ScrollTiles : MonoBehaviour
{

    public float scrollSpeed = 0.5F;
    void Start()
    {
    }
    void Update()
    {
        Vector2 offset = new Vector2(0, Time.time * scrollSpeed);
        GetComponent<Renderer>().material.mainTextureOffset = offset;
    }
}
