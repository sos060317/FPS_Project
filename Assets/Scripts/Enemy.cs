using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    int EnemyHp; //���� �� Hp
    [SerializeField] int EnemyHpSetting; //�⺻ Hp
    int BulletPower;
    public void Awake()
    {
        
        EnemyHp = EnemyHpSetting; //EnemyHP �ʱⰪ ����
    }
    private void Update()
    {
        HPsystem();
    }
    private void HPsystem() //HP
    {
        if (EnemyHp <= 0)//HP�� 0�� �Ǿ����� ���ӿ�����Ʈ �ı�
        {
            Destroy(gameObject);
        }
    }
    private void EnemyHit(Collider other) //�ǰ� �̺�Ʈ
    {
        if (other.gameObject.CompareTag("Bullet")) //�±װ� Bullet��� EnemyHp�� BulletPower��ŭ ��� ����� �α׿� Hit�� ���
        {
            EnemyHp = EnemyHp - BulletPower;
            Debug.Log("HIt");
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        EnemyHit(other);
    }
}