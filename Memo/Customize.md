# UnityChan CRS 解読メモ

* Unity2017.2.0f3

## UnityChanStage/Director/StageDirector.csを[PlayableDirector](https://docs.unity3d.com/Manual/class-PlayableDirector.html)に置き換えてみる

[プロジェクトの基本構造について](https://github.com/unity3d-jp/unitychan-crs/wiki)の解説によると

> Stage Director はアニメーションカーブとアニメーションイベントによって制御されています。

とある。
![StageDirector](StageDirector.jpg)
![StageDirector AnimationClip](StartMusic.jpg)

なるほど。

StageDirector.csを読むとAwakeで各種Prefabのインスタンス化と、アニメーションクリップStageDirectorから発生するアニメーションイベントを受け付けていることがわかった。

StartMusic, ActiveProps, SwitchCamera(int 0), StartAutoCameraChange, StopAutoCameraChange, SwitchCamera(int 1), FastForward, StartAutoCameraChange, StopAutoCameraChange, StartAutoCameraChange, StopAutoCamraChange, SwitchCamera(int 2), EndPerformanceが設定されていた。

やってみよう。



### CameraRig

### Overlay

### Confetti, Stage, CandyRockStar, LipSyncController, Back Screen, Back Screen Camera Rig, Background, Character Light, Visualizer

諸々、シーンに展開してTimelineに乗せてみた。

## default Timeline

## PostEffect

## UnityChan Shader

## 歌詞

## CameraMachine

## 動画

## Gif動画

