using UnityEngine;

public class Launcher : MonoBehaviour
{
    public GameObject bullet;

    void Start()
    {
        //InvokeRepeating("함수이름", 초기지연시간, 지연할 시간)
        InvokeRepeating("Shoot", 0.5f, 1f);
    }

    void Shoot()
    {
        
        //미사일 프리팹, 런쳐포시젼, 방향값 없음
        Instantiate(bullet, transform.position, Quaternion.identity);
    }
    void Update()
    {
        
    }
}
