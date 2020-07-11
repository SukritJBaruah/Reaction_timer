using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class HitObjectSpawn : MonoBehaviour
{

    [SerializeField]
    GameObject prefabHitObject;

    float timeelapsed = 0;

    // add delay time on opening
    //float timeDelay = 0;

    const int SpawnBorderSize = 20;
    int minSpawnX;
    int maxSpawnX;
    int minSpawnY;
    int maxSpawnY;

    int times = 0;

    GameObject Current_HitObject;

    // Start is called before the first frame update
    void Start()
    {
        //spawn area
        minSpawnX = SpawnBorderSize;
        maxSpawnX = Screen.width - SpawnBorderSize;
        minSpawnY = SpawnBorderSize;
        maxSpawnY = Screen.height - SpawnBorderSize;

    }

    // Update is called once per frame
    void Update()
    {
        //Spawns hitbox only when previous one's destroyed
        Current_HitObject = GameObject.FindWithTag("HitObject");
        if (Current_HitObject == null)
        {
            if (times < 15)
            {
                Spawn();
                times += 1;
            }
        }

        //total time taken
        Current_HitObject = GameObject.FindWithTag("HitObject");
        if (Current_HitObject != null)
        {
            timeelapsed += Time.deltaTime;
        }
        if((times == 15) && (Current_HitObject==null))
        {
            times += 1;
        }

    }
    void Spawn()
    {
        // generate random location and create new HitObject
        Vector3 location = new Vector3(Random.Range(minSpawnX, maxSpawnX),
            Random.Range(minSpawnY, maxSpawnY),
            -Camera.main.transform.position.z);
        Vector3 worldLocation = Camera.main.ScreenToWorldPoint(location);
        GameObject HitObject = Instantiate(prefabHitObject) as GameObject;
        HitObject.transform.position = worldLocation;
    }

    void OnGUI()
    {
        //printing reaction values on screen
        if ((times == 16))
        {
            GUILayout.Label("Total time taken: " + timeelapsed+"\nAverage reaction time: " +(timeelapsed/15));
        }
    }
}
