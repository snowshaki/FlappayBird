using System.Collections;
using System.Collections.Specialized;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public float jumpPower = 5f;    //점프파워
    public GameObject imageBird;    //새 이미지
    public Vector3 lookDirection;
    public static Bird bird;

    void Awake()    //Awake 함수는 스크립트 객체의 라이트 타임동안 단 한번만 호출 게임이 시작할 때 객체를 초기화 시키는 기능
    {
        bird = this;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0) && this.transform.position.y < 5f)   //마우스를 클릭했을 경우 점프
        {
            this.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
            this.GetComponent<Rigidbody>().AddForce(0, jumpPower, 0, ForceMode.VelocityChange);
        }
        //새가 점프했을 경우 새의 LookDirection을 변화시켜 Y축으로 회전시켜주는 기능
        lookDirection.z = this.GetComponent<Rigidbody>().velocity.y * 10f + 20f;
        Quaternion R = Quaternion.Euler(lookDirection);
        imageBird.transform.rotation = Quaternion.RotateTowards(imageBird.transform.rotation, R, 5f);
    }
}
