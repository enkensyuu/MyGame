using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShot : MonoBehaviour
{
    // ボス
    private GameObject Boss;

    // ゲームオブジェクトをインスペクターから参照するための変数
    public GameObject Bullet;

    // 撃ち出す間隔を決める
    public float time = 0.25f;

    // 最初に撃ち出すまでの時間を決める
    public float delayTime = 0.25f;

    // 現在のタイマー時間
    float nowTime = 0;

    // スタート関数
    void Start()
    {
        // タイマーを初期化
        nowTime = delayTime;
    }

    void Update()
    {
        // もしボスの情報が入ってなかったら
        if (Boss == null)
        {
            // プロジェクトのBossを探して情報を取得する
            Boss = GameObject.FindGameObjectWithTag("Boss");
        }

        // タイマーを減らす
        nowTime -= Time.deltaTime;

        // もしタイマーが0以下になったら
        if (nowTime <= 0)
        {

            // 弾を生成する
            GameObject bulletClone = Instantiate(Bullet, transform.position, Quaternion.identity);

            // タイマーを初期化
            nowTime = time;
        }
    }

    private void CreateShotObject(float axis)
    {
        // ベクトルを取得
        var direction = Boss.transform.position - transform.position;

        // ベクトルのxを初期化
        direction.x = 0;

        // 向きを取得する
        var lookRotation = Quaternion.LookRotation(direction, Vector3.right);

        // 弾を生成する
        GameObject bulletClone = Instantiate(Bullet, transform.position, Quaternion.identity);

        // PlayerBulletのゲットコンポーネントを変数として保存
        var bulletObject = bulletClone.GetComponent<PlayerBullet>();

        // 弾を打ち出したオブジェクトの情報を渡す
        //bulletObject.SetCharacterObject
    }

}
