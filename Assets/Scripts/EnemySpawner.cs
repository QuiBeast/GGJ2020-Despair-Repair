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
        this.verticalOffset = 2;
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
            Transform spawnLoc = this.transform;
            spawnLoc.position.Set( spawnLoc.position.x, spawnLoc.position.y - verticalOffset, spawnLoc.position.z);
            Enemy newEnemy = GameObject.Instantiate(enemyType, spawnLoc);
            startTime = deltaTime;
        }
    }

    double deltaTime = 0.0d;
    double startTime = 0.0d;

    public float verticalOffset;
    public int spawnDelay;
    public int maxLength;
    public Enemy enemyType;
    List<Enemy> enemies;
}
