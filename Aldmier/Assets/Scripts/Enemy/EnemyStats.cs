using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStats : MonoBehaviour {

    public string EnemyName;
    public float curHP;
    public float maxHP;

    public GameObject EnemyText;
    public bool isSelected;

    public bool isDead;
    public float respawnTime;
    public GameObject RespawnPointLoc;

    public bool inCombat;
    public float wanderTime;
    public float movementSpeed = 0.1f;
	
	void Update () {

        if (EnemyText != null)
        {
            EnemyText.transform.LookAt(Camera.main.transform.position);
            EnemyText.transform.Rotate(0, 180, 0);
            EnemyText.GetComponent<TextMesh>().color = Color.red;
            EnemyText.GetComponent<TextMesh>().text = EnemyName;

        }

        if(!isDead)
        {
            if (wanderTime > 0)
            {
                transform.Translate(Vector3.forward * movementSpeed);
                wanderTime -= Time.deltaTime;
            }else
            {
                wanderTime = Random.Range(2.0f, 8.0f);
                Wander();
            }
        }

		if(curHP <= 0 && !isDead)
        {
            isDead = true;
            curHP = 0;
            StartCoroutine(Death());
        }
	}

    void Wander()
    {
        transform.eulerAngles = new Vector3(0, Random.Range(0, 360), 0);
    }

    public void RecieveDamage (float dmg)
    {
        curHP -= dmg;
    }

    IEnumerator Death()
    {
        yield return new WaitForSeconds(respawnTime);
        RespawnPointLoc.GetComponent<RespawnPoint>().SpawnEnemy();
        Destroy(this.gameObject);
    }
}
