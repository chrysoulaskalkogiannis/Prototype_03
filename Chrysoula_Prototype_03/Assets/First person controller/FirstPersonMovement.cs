using UnityEngine;

public class FirstPersonMovement : MonoBehaviour
{
    public float speed = 5;
    Vector2 velocity;
    public Vector3 forward = new Vector3(0.3f, 0, 0);


    void FixedUpdate()
    {

      this.GetComponent<Transform>().Translate(-forward);

        velocity.x = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        transform.Translate(0, 0, velocity.x);
    }
}
