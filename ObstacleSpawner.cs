using System.Collections;
using UnityEngine;
using TMPro;

public class ObstacleSpawner : MonoBehaviour
{

    public GameObject[] obstacles;
    public float maxYPos = 2;
    Vector3 spawnPos;

    public float spawnRate;
    public bool spawnObstacles;

    public static ObstacleSpawner spawnerInstance;

    public int score = 0;

    public TextMeshProUGUI scoreText;

    private void Awake() {
        spawnerInstance = this;
    }

    void Start()
    {
        spawnPos = transform.position;
        StartSpawning();
    }

    void Update()
    {
        
    }

    public void StartSpawning() {
        spawnObstacles = true;
        StartCoroutine(SpawnObstacle());
    }

    IEnumerator SpawnObstacle() {
         yield return new WaitForSeconds(0.5f);

         while (spawnObstacles) {
            int randomObstacle = Random.Range(0, obstacles.Length);
            spawnPos.y = Random.Range(-maxYPos, maxYPos);
            Instantiate(obstacles[randomObstacle], spawnPos, Quaternion.identity);

            yield return new WaitForSeconds(spawnRate);
         }
    }

    public void ScoreUp() {
        score++;
        scoreText.text = score.ToString();
    }


}
