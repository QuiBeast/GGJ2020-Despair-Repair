using System.Collections;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        enemies = new ArrayList();
    }

    // Update is called once per frame
    void Update()
    {
        spawnEnemy();
    }

    public void spawnEnemy() {
        if (enemies.Count < maxLength) {
            Enemy newEnemy = GameObject.Instantiate(enemyType);
            Debug.Log("OMG");
            enemies.Add(newEnemy);
        }
    }

    public int spawnDelay;
    public int maxLength;
    public Enemy enemyType;
    ArrayList enemies;
}
