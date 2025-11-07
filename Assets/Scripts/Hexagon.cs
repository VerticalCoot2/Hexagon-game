using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Hexagon : MonoBehaviour
{
    [SerializeField] private float shrink = 3;

    int Counnt = 0;
    [SerializeField] TMP_Text text;
    void Start()
    {
        transform.Rotate(Vector3.forward * Random.Range(0, 360));
        transform.localScale = Vector3.one * 10f;
    }

    void Update()
    {
        transform.localScale -= Vector3.one * shrink * Time.deltaTime;
        if(transform.localScale.x <= 0.05f)
        {
            Destroy(gameObject);
            Counnt++;
        }

        text.text = "" + Counnt;
    }
}
