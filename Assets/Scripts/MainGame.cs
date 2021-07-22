using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainGame : MonoBehaviour
{
    private GameObject mGoBackground = null;
    private List<GameObject> mCubePrefabs = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        mGoBackground = GameObject.Find("Plane");
        LoadResource();
        CreateChesses();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void LoadResource()
    {
        for (int i = 1; i < 9; ++i)
        {
            mCubePrefabs.Add(Resources.Load("cube" + i) as GameObject);
        }
    }

    private void CreateChesses()
    {
        for (int i = 0; i < 9; ++i)
        {
            for (int j = 0; j < 9; ++j)
            {
                int range = (int)Mathf.Ceil(Random.Range(0, 8));
                GameObject cubePrefabs = mCubePrefabs[range];
                GameObject cubeItem = GameObject.Instantiate(cubePrefabs);
                cubeItem.transform.position = new Vector3(i, j, 0);
                cubeItem.name = range.ToString();
                cubeItem.transform.parent = mGoBackground.transform;

            }
        }
    }
}
