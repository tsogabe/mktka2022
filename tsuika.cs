//以下のスクリプトを所定の場所に追加してください
//もしもタグの文字列がEnemyなら、色を赤に変える
if(hitTag == "Enemy"){
//hit情報からGameObjectを取得して、Redererコンポーネントのマテリアルの_colorを赤にする
hit.collider.gameObject.GetComponent<Renderer>().material.SetColor("_Color", Color.red);
} 
