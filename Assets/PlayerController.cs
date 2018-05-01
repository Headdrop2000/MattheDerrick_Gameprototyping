using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public Rigidbody2D Rigid;
    public float JumpForce;
    public float GravityMultipler;
    float AddGravity;

    // Use this for initialization
    void Start () {


        {
            AddGravity += GravityMultipler;
        }
           
        


	}

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Rigid.AddForce(force: Vector2.right * JumpForce, mode: ForceMode2D.Impulse);

        }

        {
            Rigid.AddForce((Vector3.left * AddGravity), ForceMode2D.Impulse);
        }
    }


}
    
