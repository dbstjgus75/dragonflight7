using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public Object enemy; // 적 오브젝트

    public bool enableSpawn = true;
   
    void Start()
    {
        print("안녕하세요.");
        InvokeRepeating("mosterSpawn", 0.5f, 1f);
    }

    void Update()
    {

    }

    public void mosterSpawn()
    {
        float randomX = Random.Range(-2.3f, 2.3f);

        if (enableSpawn)
        {
            Instantiate(enemy, new Vector3(randomX, transform.position.y, 0f), Quaternion.identity);

        }
    }

   
}
