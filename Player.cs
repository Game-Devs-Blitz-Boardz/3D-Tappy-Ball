using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    Rigidbody rb;
    public float jumpForce;

    void Awake() {
        rb = GetComponent<Rigidbody>();    
    }

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            rb.velocity = Vector3.up * jumpForce;
        }
    }

    void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag == "Obstacle") {
            GameOver();
        }
    }

    void GameOver() {
        SceneManager.LoadScene("Game");
    }


    void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "ScoreChecker") {
            ObstacleSpawner.spawnerInstance.ScoreUp();
        }
    }

    void OnBecameInvisible() {
        GameOver();
    }
}
