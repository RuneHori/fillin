using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private GameManager instance;

    private void Awake()
    {
        //もしインスタンス変数が既に存在していて　かつ　いまこのインスタンスじゃない場合
        if(instance!=null&&instance!=this)
        {
            Destroy(this.gameObject);
            return;
        }

        // このゲームオブジェクトを永続化する
        DontDestroyOnLoad(this.gameObject);

        //インスタンスを設定する
        instance = this;
    }

    //シーンをロードする関数
    public void LoadScene()
    {

    }
}
