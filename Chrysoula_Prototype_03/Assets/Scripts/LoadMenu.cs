using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadMenu : MonoBehaviour
{

  public string tag;







    // Start is called before the first frame update
    void Start()
    {



    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision coll)
  {
      if (coll.gameObject.tag == "exit")
      {
//          Application.sce("MainMenu");
          Application.LoadLevel("MainMenu");

      }

  }


}
