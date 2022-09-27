using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody PlayerRigid;
    public Camera mainCam;
    // Start is called before the first frame update
    void Start()
    {
        PlayerRigid = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float inputX = Input.GetAxis("Horizontal");
        float inputZ = Input.GetAxis("Vertical");

        Vector3 move =
            mainCam.transform.forward * Input.GetAxis("Vertical") +
            mainCam.transform.right * Input.GetAxis("Horizontal");

        // 이동량을 좌표에 반영
        transform.position += move * speed * Time.deltaTime;
    }
}
