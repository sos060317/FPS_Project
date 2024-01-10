using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField] private Transform startPos;
    [SerializeField] private GameObject bullet;
    RaycastHit hit;
    float range = 1000.0f;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) Fire();
    }

    private void Fire()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit, range))
        {
            GameObject laser = Instantiate(bullet, startPos.position, startPos.rotation);
            laser.GetComponent<Bullet>().target = hit.point;
            Destroy(laser, 2f);
        }
    }
}
