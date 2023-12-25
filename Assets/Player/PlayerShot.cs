using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShot : MonoBehaviour
{
    // �{�X
    private GameObject Boss;

    // �Q�[���I�u�W�F�N�g���C���X�y�N�^�[����Q�Ƃ��邽�߂̕ϐ�
    public GameObject Bullet;

    // �����o���Ԋu�����߂�
    public float time = 0.25f;

    // �ŏ��Ɍ����o���܂ł̎��Ԃ����߂�
    public float delayTime = 0.25f;

    // ���݂̃^�C�}�[����
    float nowTime = 0;

    // �X�^�[�g�֐�
    void Start()
    {
        // �^�C�}�[��������
        nowTime = delayTime;
    }

    void Update()
    {
        // �����{�X�̏�񂪓����ĂȂ�������
        if (Boss == null)
        {
            // �v���W�F�N�g��Boss��T���ď����擾����
            Boss = GameObject.FindGameObjectWithTag("Boss");
        }

        // �^�C�}�[�����炷
        nowTime -= Time.deltaTime;

        // �����^�C�}�[��0�ȉ��ɂȂ�����
        if (nowTime <= 0)
        {

            // �e�𐶐�����
            GameObject bulletClone = Instantiate(Bullet, transform.position, Quaternion.identity);

            // �^�C�}�[��������
            nowTime = time;
        }
    }

    private void CreateShotObject(float axis)
    {
        // �x�N�g�����擾
        var direction = Boss.transform.position - transform.position;

        // �x�N�g����x��������
        direction.x = 0;

        // �������擾����
        var lookRotation = Quaternion.LookRotation(direction, Vector3.right);

        // �e�𐶐�����
        GameObject bulletClone = Instantiate(Bullet, transform.position, Quaternion.identity);

        // PlayerBullet�̃Q�b�g�R���|�[�l���g��ϐ��Ƃ��ĕۑ�
        var bulletObject = bulletClone.GetComponent<PlayerBullet>();

        // �e��ł��o�����I�u�W�F�N�g�̏���n��
        //bulletObject.SetCharacterObject
    }

}
