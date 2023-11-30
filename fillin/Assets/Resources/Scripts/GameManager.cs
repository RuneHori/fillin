using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private GameManager instance;

    private void Awake()
    {
        //�����C���X�^���X�ϐ������ɑ��݂��Ă��ā@���@���܂��̃C���X�^���X����Ȃ��ꍇ
        if(instance!=null&&instance!=this)
        {
            Destroy(this.gameObject);
            return;
        }

        // ���̃Q�[���I�u�W�F�N�g���i��������
        DontDestroyOnLoad(this.gameObject);

        //�C���X�^���X��ݒ肷��
        instance = this;
    }

    //�V�[�������[�h����֐�
    public void LoadScene()
    {

    }
}
