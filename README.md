# conf-report

Tele-Conference Participants Reporting System

遠隔会議参加報告システム

## ユーザ体験

* 参加報告をメールで集めるのはうんざりだよ
  * 参加者は投入可能
  * 報告を集める人は、一括でデータを取得し、様式にコピペして報告

## データ構造（M)

### 会議概要

参加報告を集めたい人が会議を作る

* 会議名
* 日時
* 内容（大きめ）
* デバイス、ソフト
* 参加URL（ハイパーリンク）、参加電話番号*

### 参加者

参加報告をしたい人が会議に参加者を登録する

* 所属 - マスターデータからプルダウン - 名前を絞る
* 名前 - マスターデータからプルダウン - エリコのエクセルからデータ取得
* メールアドレス - 名前から紐づく　（今回はMLで登録しよう！みたいな場合は？）

## ビュー（V)

![遷移図](http://yuml.me/diagram/nofunky;dir:TB/activity/(start)-%3E%5BIndex%5D-%3E%7Ca%7C,%20%7Ca%7C-%3E%5BDelete%5D-%3E%5BIndex%5D,%20%7Ca%7C-%3E%5BDetail%5D-%3E%5BCreate/Edit%20Participant%5D-%3E%5BDetail%5D,%20%7Ca%7C-%3E%5BCreate/Edit%20Conference%5D-%3E%5BDetail%5D,%20%5BDetail%5D-%3E%5BCreate/Edit%20Conference%5D,%20%5BDetail%5D-%3E%5BDelete%5D)

### index （会議一覧）

* 会議名 -> detail へ
* editボタン -> editA へ
* deleteボタン
* createボタン - 新しい ID を振って、空の会議を作る。edit で編集

### detail (会議概要)

* 上記会議概要の表示
* 参加者一覧
* editボタン -> editA へ
* (deleteボタン)
* 参加者報告ボタン -> editB へ
* データ出力ボタン

### editA　（会議情報投入）

* 会議概要の投入
* 投入完了ボタン -> detail へ

### editB　（参加者投入）

* 参加者の投入
* 投入完了ボタン -> detail へ

## 出力（C）

* エクセルにコピペで投入できるようなテキストデータ
  * 報告様式は毎回まちまちであるため
