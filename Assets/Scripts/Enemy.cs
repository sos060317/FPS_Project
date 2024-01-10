using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    int EnemyHp; //현재 적 Hp
    [SerializeField] int EnemyHpSetting; //기본 Hp 세팅값

    public int BulletPower;

    public void Awake()
    { 
        EnemyHp = EnemyHpSetting; //EnemyHP 초기값 세팅
    }
    private void EnemyHit(Collider other) //피격 이벤트
    {
        if (other.CompareTag("Bullet")) //태그가 Bullet라면 EnemyHp가 BulletPower만큼 닳고 디버그 로그에 Hit를 띄움
        {
            EnemyHp = EnemyHp - BulletPower;
            Debug.Log("HIt");
            if (EnemyHp <= 0)//HP가 0이 되었을때 게임오브젝트 파괴
            {
                Destroy(gameObject);
            }
            
        }
        
    }
    private void OnTriggerEnter(Collider other)
    {
        EnemyHit(other);
    }
}