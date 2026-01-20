using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float moveSpeed = 1f;
    public GameObject effect;
    void Start()
    {
        
    }

    void Update()
    {
        //y축 이동
        transform.Translate(0, moveSpeed * Time.deltaTime, 0);
    }

    //화면밖으로 나가면 호출되는 함수
    private void OnBecameInvisible()
    {
        //미사일 지우기
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {

            //적 죽는 소리 재생
            SoundManager.instance.SoundDie();

            //이펙트 생성
            GameObject fireEffect = Instantiate(effect, transform.position, Quaternion.identity);
            Destroy(fireEffect, 1);


            //적 삭제
            Destroy(collision.gameObject);
            //자기자신 삭제
            Destroy(gameObject);
        }
    }
}
