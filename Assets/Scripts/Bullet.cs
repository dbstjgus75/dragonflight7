using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float moveSpeed = 1f;
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

    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    if (collision.gameObject.CompareTag("Enemy"))
    //    {
    //        Destroy(collision.gameObject);

    //        Destroy(gameObject);
    //    }
    //}
}
