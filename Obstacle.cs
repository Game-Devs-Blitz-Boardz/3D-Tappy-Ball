using UnityEngine;

public class Obstacle : MonoBehaviour
{

    public float moveSpeed;

    void Update()
    {
        transform.Translate(-moveSpeed * Time.deltaTime, 0, 0);

        if (transform.position.x <= -10) {
            Destroy(gameObject);
        }
    }
}
