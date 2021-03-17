using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class TestCharacterController : MonoBehaviour
{

    public float movementSpeed = 10f;
    public SpawnManager spawnManager;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        

    }

    private void OnTriggerEnter(Collider other)
    {
        spawnManager.SpawnTriggerEntered();
    }
}
