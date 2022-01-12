using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
   
{
    public Transform ShootPosIni;
    public Transform Bullet;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
        if (Input.GetKeyDown("j"))
        {
            StartCoroutine(CallShootTwo());
        }
        if (Input.GetKeyDown("k"))
        {
            StartCoroutine(CallShootThree());
        }
        if (Input.GetKeyDown("l"))
        {
            StartCoroutine(CallShootFour());
        }

    }
    private void Shoot ()
    {
        Instantiate(Bullet,ShootPosIni.position, ShootPosIni.rotation);
    }

    IEnumerator CallShootTwo()
    {
        Shoot();
        yield return new WaitForSeconds(1f);
        Shoot();

    }
    IEnumerator CallShootThree()
    {
        Shoot();
        yield return new WaitForSeconds(1f);
        Shoot();
        yield return new WaitForSeconds(1f);
        Shoot();

    }
    IEnumerator CallShootFour()
    {
        Shoot();
        yield return new WaitForSeconds(1f);
        Shoot();
        yield return new WaitForSeconds(1f);
        Shoot();
        yield return new WaitForSeconds(1f);
        Shoot();

    }
}
