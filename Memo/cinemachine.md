# [Cinemachine](http://www.cinemachineimagery.com/)の導入

既存のカメラアニメーションを取り除く。
Timelineからカメラ関連のトラックをミュートにして、CameraSwitcherからDOF以外の機能を削除する。
2カ所止めれば動かなくなる。

```cs
    void Update()
    {
#if false
        // Update the follow point with the exponential easing function.
        var param = Mathf.Exp(-rotationSpeed * Time.deltaTime);
        followPoint = Vector3.Lerp(target.position, followPoint, param);

        // Look at the follow point.
        transform.LookAt(followPoint);
#endif    

    public void ChangePosition(Transform destination, bool forceStable = false)
    {
        return;
```

再生して初期位置にカメラが静止することを確認する。

* [Unity2017のCinemachineをやってみた](http://blog.applibot.co.jp/blog/2017/07/31/unity2017-cinemachine/)

AssetStoreからImport。
https://www.assetstore.unity3d.com/en/#!/content/79898


