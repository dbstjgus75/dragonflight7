using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float moveSpeed = 1.3f;
    void Start()
    {

    }

    void Update()
    {
        //움직임을 변수로 만들기
        float distanceY = moveSpeed * Time.deltaTime;
        //움직이기
        transform.Translate(0, -distanceY, 0);
    }


    // 컨트롤 + shift + m : Unity 등록 메서드 찾기
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // 이게 더 안전함 ?
        if (collision.gameObject.CompareTag("Bullet"))
        {
            //미사일 충돌
            //미사일 삭제
            Destroy(collision.gameObject); // 미사일 오브젝트

            Destroy(gameObject); // enemy 오브젝트
        }

        //if(collision.gameObject.tag == "Enemy")
        //{

        //}
    }
}
