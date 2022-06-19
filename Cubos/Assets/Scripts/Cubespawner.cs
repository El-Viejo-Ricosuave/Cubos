using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubespawner : MonoBehaviour
{

    public GameObject prefabcubo;
  

    // Start is called before the first frame update
    void Start()
    {
        GameObject Objeto = Instantiate(prefabcubo);

    }

    // Update is called once per frame
    void Update()
    {
        GameObject Objeto = Instantiate(prefabcubo);
        prefabcubo.transform.position = new Vector3(Random.Range(1, 5), Random.Range(6, 12), Random.Range(13, 20));
        prefabcubo.GetComponent<MeshRenderer>().material.color = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
    }

    private void OnEnable()
    {
        GameObject Objeto = Instantiate(prefabcubo);
        prefabcubo.transform.position = new Vector3(Random.Range(1, 5), Random.Range(6, 12), Random.Range(13, 20));
        prefabcubo.GetComponent<MeshRenderer>().material.color = new Color (Random.Range(0.0f,1.0f), Random.Range(0.0f,1.0f), Random.Range(0.0f,1.0f));



    }

    private void OnDisable()
    {
        GameObject Objeto = Instantiate(prefabcubo);
        prefabcubo.transform.position = new Vector3(Random.Range(0, 9), Random.Range(9, 12), Random.Range(13, 20));
        prefabcubo.GetComponent<MeshRenderer>().material.color = new(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
    }

}
