using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Color color;
    public SpriteRenderer rend;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 4 * Time.deltaTime, 0, Space.Self);
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, -2f * Time.deltaTime, 0, Space.Self);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, 0, 360 * Time.deltaTime);
            rend.color = new Color(0, 1, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, 0, -360 * Time.deltaTime);
            rend.color = new Color(0f, 0, 1f);
        }
    }
}
