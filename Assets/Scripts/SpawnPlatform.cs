using UnityEngine;
using System.Collections;

public class SpawnPlatform : MonoBehaviour {

    public GameObject obstacle = null;
    float y = 1;

    public int movespeed;
    private Vector3 Direction;
    private GameObject[] platforms;

    void Start()
    {
        movespeed = 5;   // i increased this to make it easier to see
        Direction = Vector3.down;
    }

    // Update is called once per frame
    void Update () {
        float x = Random.Range(0.5f, 9.0f);
        if (y < 10)
        {
            Instantiate(obstacle, new Vector3(x, y * 4.0f, 0), Quaternion.identity);
            y++;
        }else
        {
            platforms = GameObject.FindGameObjectsWithTag("platform");
            foreach (GameObject r in platforms)
                r.transform.Translate(Direction * movespeed * Time.deltaTime);

        }
    }
}
