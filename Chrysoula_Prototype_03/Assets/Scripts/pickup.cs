using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickup : MonoBehaviour
{

  public string tag;
  public Vector3 rotation = new Vector3(1.0f,0,0);

  public AudioSource audioSource;




    // Start is called before the first frame update
    void Start()
    {


      audioSource = GetComponent<AudioSource> ();
    }

    // Update is called once per frame
    void Update()
    {
        this.GetComponent<Transform>().Rotate(rotation);
    }

    private void OnCollisionEnter(Collision collision)
  {
      if (collision.collider.gameObject.tag == "pickup")
      {

          Destroy(collision.collider.gameObject);
          audioSource.Play ();
          score.scoreAmount += 1;

      }

  }


}
