using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
        enemies = new List<Enemy>();
    }

    // Update is called once per frame
    void Update()
    {
        spawnEnemy();
    }

    public void spawnEnemy() {
        deltaTime = Time.time;
        enemies = GameObject.FindObjectsOfType<Enemy>().ToList();
        if (enemies.Count < maxLength && (deltaTime - startTime) > spawnDelay) {
            Enemy newEnemy = GameObject.Instantiate(enemyType);
            startTime = deltaTime;
        }
    }

    double deltaTime = 0.0d;
    double startTime = 0.0d;

    public int spawnDelay;
    public int maxLength;
    public Enemy enemyType;
    List<Enemy> enemies;
}
