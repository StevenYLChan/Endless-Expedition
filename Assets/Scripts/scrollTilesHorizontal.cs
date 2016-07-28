using UnityEngine;
using System.Collections;

public class scrollTilesHorizontal : MonoBehaviour {

    public float scrollSpeed = 0.25F;
    void Start()
    {
    }
    void Update()
    {
        Vector2 offset = new Vector2(Time.time * scrollSpeed,0);
        GetComponent<Renderer>().material.mainTextureOffset = offset;
    }
}
