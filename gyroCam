using System.Collections;
using System.Collections.Generic;
using UnityEngine; 


//このスクリプトはMainCameraにアサインしてください
public class gyroCam : MonoBehaviour {

 Quaternion gyro;

 //最初の1回だけ実行。初期設定や初期化などはたいていvoid stat内に書く
 void Start () {
 //ジャイロを使用可能にする
 Input.gyro.enabled = true; 
 } 

 

 //void Updateは毎フレーム実行するの意味
 //Landscapeモード（横位置）用

 void Update () {
 //このスクリプトがアサインされた物はとにかくジャイロセンサーに応じて回転させます。
 transform.rotation = Quaternion.AngleAxis(90.0f,Vector3.right)*Input.gyro.attitude*Quaternion.AngleAxis(180.0f,Vector3.forward);
 }

}

