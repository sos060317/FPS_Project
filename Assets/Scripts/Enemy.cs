using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    int EnemyHp;
    public void Awake()
    {
        EnemyHp = 10; //EnemyHP �ʱⰪ ����
        
    }
    void Update()
    {
        HP();
    }
    public void HP() 
    {
        if (EnemyHp <= 0)//HP�� 0�� �Ǿ����� ���ӿ�����Ʈ �ı�
        {
            Destroy(gameObject);
        }
    }
}