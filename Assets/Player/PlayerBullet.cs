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
        // �e�̃��[���h���W���擾
        Vector3 pos = transform.position;

        // �E�ɂ܂��������
        pos.x += 0.25f;

        // �e�̈ړ�
        transform.position = new Vector3(pos.x, pos.y, pos.z);

        // ��苗���i�񂾂���ł���
        if (pos.x >= 10)
        {
            Destroy(this.gameObject);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        // �������������I�u�W�F�N�g�̃^�O��Boss��������
        if (other.gameObject.tag == "Boss")
        {
            // ���������ł�����
            Destroy(this.gameObject);
        }
    }

    // �e��ł��o�����L�����N�^�[�̏���n���֐�
    public void SetCharacterObject(GameObject character)
    {
        // �e��ł��o�����L�����N�^�[�̏����󂯎��
        //this.Boss = character;
    }
}
