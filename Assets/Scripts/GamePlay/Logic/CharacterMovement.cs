using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float MoveSpeed = 3f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CheckMovement();
    }
    void CheckMovement()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        transform.TransformDirection(x, y, 0);

        var pos = transform.position;
        pos.x += x * Time.deltaTime * MoveSpeed;
        pos.y += y * Time.deltaTime * MoveSpeed;
        transform.position = pos;
    }
}
