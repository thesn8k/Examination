using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public int LastPrint;
    public SpriteRenderer rend1;
    public int RandomColor1 = 0;
    public int RandomColor2 = 0;
    public int RandomColor3 = 0;
    public float timer;
    public Color color;
    public SpriteRenderer rend;
    public int Speed;

    // Use this for initialization
    void Start()
    {
        //gör att skeppet spawnar vid en random position på skärmen
        transform.position =  new Vector3(Random.Range(-10, 10), Random.Range(-10, 10));
        // gör att skeppet får en random fart när man startar spelet
        Speed = Random.Range(2, 8);
    }

    // Update is called once per frame
    void Update()
    {   //skeppet kommer alltid att åka framåt
        transform.Translate(0, Speed * Time.deltaTime, 0, Space.Self);
        //om man trycker S så kommer skeppet att flyga hälfet så snabbt
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, -Speed / 2 * Time.deltaTime, 0, Space.Self);
        }
        //när man trycker A kommer skeppet flyga åt vänster och byta färg till grön
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, 0, 180 * Time.deltaTime);
            rend.color = new Color(0, 1, 0);
        }
        //när man trycker på D kommer skeppet att flyga åt höger och byta färg till blå
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, 0, -360 * Time.deltaTime);
            rend.color = new Color(0f, 0, 1f);
        }
        
        //när man trycker på SpaceBaren så kommer skeppets färg att ändras till en random rärg
        if (Input.GetKeyDown(KeyCode.Space))
        {
            float RandomColor1 = Random.Range(0f, 1f);
            float RandomColor2 = Random.Range(0f, 1f);
            float RandomColor3 = Random.Range(0f, 1f);
            Color color = new Color(RandomColor1, RandomColor2, RandomColor3);
            rend.color = color;
        }
        //när det absoluta x värdet blir mer än 10 (veresig det är neg/pos) 
        //så flyttas skeppet till den motsatta x positionen
        if (Mathf.Abs(transform.position.x) > 10)
        {
            transform.position = new Vector3(transform.position.x * -1, (transform.position.y));
        }
        //när det absoluta y värdet blir mer än 10 (veresig det är neg/pos) 
        //så flyttas skeppet till den motsatta y positionen
       if (Mathf.Abs(transform.position.y) > 10)
        {
            transform.position = new Vector3(transform.position.x, (transform.position.y * -1));
        }
       //timer, 
        if (Time.time > LastPrint + 1f)
        {
            LastPrint = Mathf.RoundToInt(Time.time);
            Debug.Log("timer:" + LastPrint);

            float RandomColor1 = Random.Range(0f, 1f);
            float RandomColor2 = Random.Range(0f, 1f);
            float RandomColor3 = Random.Range(0f, 1f);
            Color color = new Color(RandomColor1, RandomColor2, RandomColor3);
            rend.color = color;
        }
    }
}
