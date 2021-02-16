using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class CameraStick1 : Graphic, IEndDragHandler, IDragHandler, IPointerDownHandler, IPointerUpHandler
{
    public Transform padObjectTransform;//位置・回転を保持
    private float padMovableRadius = 100;//padの可動範囲
    private static Vector2 axis = Vector2.zero;//Vector2(0, 0) と同じ意味

    public static float GetAxisHorizontal()
    {
        Debug.Log(9);
        return axis.x;//操作対象にaxis.xを返す

    }

    public static float GetAxisVertical()
    {
        Debug.Log(10);
        return axis.y;//操作対象にaxis.yを返す

    }

    protected override void Awake()
    {
        base.Awake();

        Debug.Log(1);

        Image padImage = padObjectTransform.GetComponent<Image>();//imageコンポーネントを参照
        padImage.raycastTarget = false;//imageコンポーネントのraycasttargetをオフ

        raycastTarget = true;//アタッチオブジェクトのraycasttargetはオン

        Debug.Log(2);
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log(3);
        OnDrag(eventData);//ドラッグ開始された時OnDrag発動


    }

    public void OnPointerUp(PointerEventData eventData)
    {
        Debug.Log(7);
        OnEndDrag(eventData);//ドラッグ終了時OnEndDrag発動
    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log(4);
        //CanvasがScreen Space - Overlayの場合のみ//
        Vector2 tapPosition = transform.InverseTransformPoint(eventData.position);
        //ワールド空間からローカル空間へ position を変換


        //タップ位置の半径が指定半径より長かったら修正//
        if (Vector3.Distance(Vector3.zero, tapPosition) > padMovableRadius)
        {
            tapPosition = GetRadiusLimitedPosition(tapPosition, padMovableRadius);
            //最大可動域以上ドラッグされたらradiusに対して値を最大可動域のところで止める
            Debug.Log(5);
        }

        SetPadObjectPosition(tapPosition);
    }

    //指定半径に収めた座標を返す//
    private Vector2 GetRadiusLimitedPosition(Vector2 tapPosition, float radius)
    {
        float radian = Mathf.Atan2(tapPosition.y, tapPosition.x);
        // y/x になる角度をラジアンで返す float Atan2 (float y, float x);

        Vector2 limitedPosition = Vector2.zero;
        limitedPosition.x = radius * Mathf.Cos(radian);
        limitedPosition.y = radius * Mathf.Sin(radian);
        //limitedPositionを元に最大スティック可動域360度分を表している

        return limitedPosition;
    }

    //JoyStickのPad位置を設定//
    public void SetPadObjectPosition(Vector3 position)
    {
        Debug.Log(6);

        padObjectTransform.localPosition = position;//スクリプトのアタッチオブジェクトの座標をpositionとする

        axis = new Vector2(
            padObjectTransform.localPosition.x / padMovableRadius,
            padObjectTransform.localPosition.y / padMovableRadius
        );//pad座標変化を操作対象に反映
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log(8);
        SetPadObjectPosition(Vector3.zero);//ドラッグ終了時初期地点にpadが戻る
    }
}