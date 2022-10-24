///ドリフト対策用スクリプトです
using System.Collections;
using UnityEngine;

public class dragCam : MonoBehaviour
{
//回転速度 public宣言しているのでInsepctorで調整できます
public Vector2 rotSpeed = new Vector2(0.1f, 0.1f);

//piblic宣言などしなければprivateです
//カメラ
Camera mainCam;
//直前の位置
Vector2 lastPos;
//移動先2次元座標宣言と初期化
Vector2 currentPos = Vector2.zero;

//最初の1回だけ実施・初期化などに使用
void Start()
{
//カメラを取得
mainCam = Camera.main;
}

//毎フレーム実施
void Update()
{
//マウスをクリックした瞬間
if (Input.GetMouseButtonDown(0))
{
//カメラの角度を取得
currentPos = mainCam.transform.localEulerAngles;
//マウスをクリックした瞬間の位置を取得
lastPos = Input.mousePosition;
}
//マウスを押していたら
else if (Input.GetMouseButton(0))
{
//さっきの位置lastPosに現在の位置を足す
currentPos.y += (lastPos.x - Input.mousePosition.x) * rotSpeed.y;
currentPos.x += (Input.mousePosition.y - lastPos.y) * rotSpeed.x;

//カメラを回転させる
mainCam.transform.localEulerAngles = currentPos;
//次に備えて現在の位置をlastPosに入れる
lastPos = Input.mousePosition;
}

// Ray（Rayの始点と方向）をつくる，名前はrayにする。このスクリプトがアサインされた位置（transform.position）から、前方向（transform.forward　＝　Z軸方向）のものを。
Ray ray = new Ray(transform.position, transform.forward);

// outパラメータ用に、Rayのヒット情報を取得するための変数を用意
RaycastHit hit;
// Rayのhit情報を取得してhitに格納する。Rayの始点と方向は（変数の）ray。半径は0.1m、情報をhitとして出力、Rayの長さは20m
if (Physics.SphereCast(ray, 0.1f, out hit, 20.0f)){//Rayで球を飛ばす

//Rayを可視化する（デバッグ用、本番では消すかコメントアウト）
Debug.DrawRay(ray.origin, ray.direction, Color.green);

// Rayがhitしたオブジェクトのタグ名を取得
string hitTag = hit.collider.tag;
Debug.Log(hitTag);

//追加　もしもタグの文字列がEnemyなら、色を赤に変える
if(hitTag == "Enemy"){
//hit情報からGameObjectを取得して、Redererコンポーネントのマテリアルの_colorを赤にする
hit.collider.gameObject.GetComponent<Renderer>().material.SetColor("_Color", Color.red);
}


}


}
} 
