using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonController : MonoBehaviour
{
    //bulletプレハブ
    public GameObject bullet;
    //弾が生成されるポジションを保有するゲームオブジェクト
    //これはどの球でも共通
    public GameObject bulletPos;
    //弾丸のスピード

    public GameObject zangeki;


    public GameObject hadou;


    public int buki = 1;


    public float speed = 1500f;

    // Update is called once per frame
    void Update()
    {
        //スペースが押されたとき
        if (Input.GetKeyDown(KeyCode.A))
        {
          buki = 1;
        }

        if (Input.GetKeyDown(KeyCode.Z))
        {
          buki = 2;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
          buki = 3;
        }



        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(buki == 1)
            {
            //ballをインスタンス化して発射
            GameObject createdBullet = Instantiate(bullet) as GameObject;
            createdBullet.transform.position = bulletPos.transform.position;
            //発射ベクトル
            Vector3 force;
            //発射の向きと速度を決定
            force = bulletPos.transform.forward * speed;
            // Rigidbodyに力を加えて発射
            createdBullet.GetComponent<Rigidbody>().AddForce(force);
          }
          if(buki ==2)
          {
            //ballをインスタンス化して発射
            GameObject createdBullet = Instantiate(zangeki) as GameObject;
            createdBullet.transform.position = bulletPos.transform.position;
            //発射ベクトル
            Vector3 force;
            //発射の向きと速度を決定
            force = bulletPos.transform.forward * speed;
            // Rigidbodyに力を加えて発射
            createdBullet.GetComponent<Rigidbody>().AddForce(force);
          }

          if(buki ==3)
          {
            //ballをインスタンス化して発射
            GameObject createdBullet = Instantiate(hadou) as GameObject;
            createdBullet.transform.position = bulletPos.transform.position;
            //発射ベクトル
            Vector3 force;
            //発射の向きと速度を決定
            force = bulletPos.transform.forward * speed;
            // Rigidbodyに力を加えて発射
            createdBullet.GetComponent<Rigidbody>().AddForce(force);
          }

        }
    }
}
