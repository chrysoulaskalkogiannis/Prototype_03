using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

public Vector3 forward = new Vector3(0.3f, 0, 0);

public Vector3 side = new Vector3(0, 0, 0.5f);
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        this.GetComponent<Transform>().Translate(-forward);

      if (Input.GetKey(KeyCode.A))
      {
this.GetComponent<Transform>().Translate(-side);


      }else if (Input.GetKey(KeyCode.D)){

        this.GetComponent<Transform>().Translate(side);
      }
    }
}
