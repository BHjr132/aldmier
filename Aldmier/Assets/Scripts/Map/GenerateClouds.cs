using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class CloudData
{

    public Vector3 pos;

    public Vector3 scale;

    public Quaternion rot;

    private bool _isActive;

    public bool isActive
    {
        get
        {
            return _isActive;
        }
    }

    public int x;

    public int y;

    public float distFromCam;

    public Matrix4x4 matrix
    {
        get
        {
            return Matrix4x4.TRS(pos, rot, scale);
        }
    }

    public CloudData(Vector3 pos, Vector3 scale, Quaternion rot, int x, int y, float distFromCam)
    {
        this.pos = pos;
        this.scale = scale;
        this.rot = rot;
        SetActive(true);
        this.x = x;
        this.y = y;
        this.distFromCam = distFromCam;
    }

    public void SetActive(bool desState)
    {
        _isActive = desState;
    }


}

public class GenerateClouds : MonoBehaviour {

    public Mesh cloudMesh;

    public Material cloudMat;

    public float cloudSize = 5;

    public float maxScale = 1;

    public float timeScale = 1;

    public float texScale = 1;

    public float minNoiseSize = 0.5f;

    public float sizeScale = 0.25f;
    
    public Camera cam;

    public int maxDist;

    public int batchesToCreate;

    private Vector3 prevCamPos;

    private float offsetX = 1;

    private float offsetY = 1;

    private List<List<CloudData>> batches = new List<List<CloudData>>();

    private List<List<CloudData>> batchesToUpdate = new List<List<CloudData>>();

    private void Start()
    {
        for(int batchesX = 0; batchesX < batchesToCreate; batchesX++)
        {
            for(int batchesY = 0; batchesY < batchesToCreate; batchesY++)
            {

            }
        }
    }

}
