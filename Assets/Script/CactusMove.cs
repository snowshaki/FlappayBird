using System.Collections;
using UnityEngine;

public class CactusMove : MonoBehaviour{
    public float cactusSpeed; //선인장 장애물의 속도

    void Update(){
        transform.Translate (Vector3.left * cactusSpeed * Time.deltaTime); //왼쪽으로 속도값 만큼 움직임
        if(this.transform.position.x < -6f){
            Destroy(this.gameObject); //오브젝트 포지션이(x축) -6을 넘어설때 객체는 사라짐
        }
    }
    void OnEnable(){
        this.transform.position = new Vector3 (6f, Random.Range (-1, 1.5f), 0); //y축은 랜덤값을 주어서 높낮이가 랜덤으로 생성됨
    }
} //OnEnable() : Start()함수보다 먼저 선언되는 메서드 객체를 초기화 시켜주는 메서드