using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // 弾のワールド座標を取得
        Vector3 pos = transform.position;

        // 右にまっすぐ飛ぶ
        pos.x += 0.25f;

        // 弾の移動
        transform.position = new Vector3(pos.x, pos.y, pos.z);

        // 一定距離進んだら消滅する
        if (pos.x >= 10)
        {
            Destroy(this.gameObject);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        // もし当たったオブジェクトのタグがBossだったら
        if (other.gameObject.tag == "Boss")
        {
            // 自分を消滅させる
            Destroy(this.gameObject);
        }
    }

    // 弾を打ち出したキャラクターの情報を渡す関数
    public void SetCharacterObject(GameObject character)
    {
        // 弾を打ち出したキャラクターの情報を受け取る
        //this.Boss = character;
    }
}
