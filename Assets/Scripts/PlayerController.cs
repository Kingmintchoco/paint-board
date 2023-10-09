using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    private bool isMoving = false;
    private Vector3 moveDirection;


    public GameObject bulletPrefab;

    void Update()
    {
        if (Input.GetMouseButtonDown(0)){
            isMoving = true;
            UpdateMoveDirection();
        }

        if (Input.GetMouseButtonUp(0)){
            isMoving = false;
        }

        if (isMoving){
            UpdateMoveDirection();              // 이동 방향 업데이트
            transform.position += moveDirection * moveSpeed * Time.deltaTime;
            ShootBullet();
        }

        ShootBullet();
    }

    void UpdateMoveDirection(){
        // 마우스 포인터 방향으로 이동
        Vector3 targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        targetPosition.z = transform.position.z;
        moveDirection = (targetPosition - transform.position).normalized;
    }

    void ShootBullet(){
        if(bulletPrefab == null) return;

        GameObject bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
        
        // player의 이동방향과 탄알방향이 일치
        Vector3 bulletDirection = moveDirection;

    }
}
