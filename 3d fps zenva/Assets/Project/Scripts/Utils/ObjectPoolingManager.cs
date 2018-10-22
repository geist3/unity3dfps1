using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPoolingManager : MonoBehaviour {

    private static ObjectPoolingManager instance;
    public static ObjectPoolingManager Instance { get { return instance;  } }
    public int bulletAmount = 10;
    public GameObject bulletPrefab;

    private List<GameObject> bullets;
  
	// Use this for initialization
	void Awake () {

        instance = this;
        bullets = new List<GameObject>(bulletAmount);

        for (int i = 0; i < bulletAmount; i++)
        {
            GameObject prefabInstance = Instantiate(bulletPrefab);
            prefabInstance.transform.SetParent(transform);
            prefabInstance.SetActive(false);

            bullets.Add(prefabInstance);
        }
	}

    public GameObject GetBullet()
    {
        foreach(GameObject bullet in bullets)
        {
            if (!bullet.activeInHierarchy)
            {
                bullet.SetActive(true);
                return bullet;
            }
        }

        GameObject prefabInstance = Instantiate(bulletPrefab);
        prefabInstance.transform.SetParent(transform);
        bullets.Add(prefabInstance);
        return prefabInstance;
    }
}
