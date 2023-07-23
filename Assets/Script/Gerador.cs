using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gerador : MonoBehaviour
{
    public GameObject[] obstaculos;
    public List<Obstaculos> ObstaculosToSpawn;
    // Start is called before the first frame update
    void Start()
    {
        InitObstaculos();
    }

    public void GerarObstaculos() 
    {
        StartCoroutine(SpawnRandomObstaculos());
    }

    public void PararGerador() 
    {
      StopAllCoroutines();
    }
    void InitObstaculos() 
    {
        int index = 0;
        for(int i = 0; i < obstaculos.Length * 3; i++) 
        {
          GameObject obj = Instantiate(obstaculos[index], transform.position, Quaternion.identity);
            obj.SetActive(false);
            ObstaculosToSpawn.Add(obj.GetComponent<Obstaculos>());

            index++;
            if(index == obstaculos.Length) 
            {
                index = 0;
            }
        }
    }

    IEnumerator SpawnRandomObstaculos() 
    {
        yield return new WaitForSeconds(Random.Range(0.5f, 5f));
        int index = Random.Range(0, ObstaculosToSpawn.Count);

        while (true) 
        {
          Obstaculos obstaculo = ObstaculosToSpawn[index];
            if (!obstaculo.gameObject.activeInHierarchy) 
            {
                ObstaculosToSpawn[index].gameObject.SetActive(true);
                ObstaculosToSpawn[index].transform.position = transform.position;
                break;
            }
            else 
            {
                index = Random.Range(0, ObstaculosToSpawn.Count);
            }
        }
        StartCoroutine(SpawnRandomObstaculos());

    }
}
