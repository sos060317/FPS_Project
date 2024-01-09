using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    int EnemyHp;
    public void Awake()
    {
        EnemyHp = 10; //EnemyHP 초기값 세팅
        
    }
    void Update()
    {
        HP();
    }
    public void HP() 
    {
        if (EnemyHp <= 0)//HP가 0이 되었을때 게임오브젝트 파괴
        {
            Destroy(gameObject);
        }
    }
}