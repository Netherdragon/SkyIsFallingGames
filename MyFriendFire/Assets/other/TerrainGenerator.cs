﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainGenerator : MonoBehaviour
{
    public int depth = 20;
    public int width = 256;
    public int height = 256;

    public float scale = 20f;

    public float offSetX = 100f;
    public float offSetY = 100f;

    private void Start()
    {
        offSetX = Random.Range(0f, 99999f);
        offSetX = Random.Range(0f, 99999f);
        Terrain terrain = GetComponent<Terrain>();
        terrain.terrainData = GenerateTerrain(terrain.terrainData);
    }

    /*private void Update()
    {
        
        Terrain terrain = GetComponent<Terrain>();
        terrain.terrainData = GenerateTerrain(terrain.terrainData);
        offSetX = Time.deltaTime * 5;

    }*/

    TerrainData GenerateTerrain(TerrainData terrainData)
    {
        terrainData.heightmapResolution = width + 1;
        terrainData.size = new Vector3(width, depth, height);
        terrainData.SetHeights(0, 0, GenerateHeights());
        return terrainData;
    }

    float[,] GenerateHeights()
    {
        float[,] heights = new float[width, height];
        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                heights[x, y] = CalculateHeight(x, y);
            }
        }

        return heights;
    }

    float CalculateHeight(int x, int y)
    {
        float xCoord = (float)x / width * scale;
        float yCoord = (float)y / height * scale;

        return Mathf.PerlinNoise(xCoord, yCoord);
    }
}
