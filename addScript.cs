//追加のスクリプトです。gyrocam.csに追加してください
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
