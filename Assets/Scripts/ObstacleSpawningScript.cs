﻿using UnityEngine;

public class ObstacleSpawningScript : MonoBehaviour
{
    // List of obstacles
    public GameObject carObstacle;
    
    public float spawnRate = 8f;
    float nextSpawn = 0f;

    private float screenHeight = 0f;
    private float screenWidth = 0f;

    private void Start() {
        Vector2 topRightCorner = new Vector2(1, 1);
        Vector2 edgeVector = Camera.main.ViewportToWorldPoint(topRightCorner);
        screenHeight = edgeVector.y * 2;
        screenWidth = edgeVector.x * 2;
    }

    // Update is called once per frame
    void Update() {
        
        if (Time.time > nextSpawn) {
            spawnObstacle();
        }

    }

    private void spawnObstacle() {

        nextSpawn = Time.time + spawnRate;        

        // spawn a car
        float randOffsetY = Random.Range(-1.2f, 1.2f);
        Vector3 spawnPoint = new Vector3 (screenWidth + 1f, randOffsetY, -5f);
        Instantiate (carObstacle, spawnPoint, Quaternion.identity);

    }
}
