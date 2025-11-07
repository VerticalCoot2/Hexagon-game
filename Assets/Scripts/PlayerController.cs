using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 300.0f;
    [SerializeField] private float rotationRate = 7.5f;

    void PCinput()
    {
        #region rosszResz
        //if(Input.GetKey("left") || Input.GetKey(KeyCode.A))
        //{
        //    transform.RotateAround(Vector3.zero, Vector3.forward, moveSpeed * Time.deltaTime);
        //}

        //if (Input.GetKey("right") || Input.GetKey(KeyCode.D))
        //{
        //    transform.RotateAround(Vector3.zero, Vector3.forward, -moveSpeed * Time.deltaTime);
        //}
        #endregion
        transform.RotateAround(Vector3.zero, Vector3.forward,-Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime);
    }
    void PhoneInput()
    {
        foreach(Touch touch in Input.touches)
        {
            if(touch.phase == TouchPhase.Moved)
            {
                transform.RotateAround(Vector3.zero, Vector3.forward, -touch.deltaPosition.x * rotationRate / 10);
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PCinput();
        PhoneInput();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene("SampleScene");
    }
}
