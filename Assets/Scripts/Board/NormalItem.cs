using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalItem : Item
{
    public enum eNormalType
    {
        TYPE_ONE = 1,
        TYPE_TWO = 2,
        TYPE_THREE = 3,
        TYPE_FOUR = 4,
        TYPE_FIVE = 5,
        TYPE_SIX = 6,
        TYPE_SEVEN = 7
    }

    public eNormalType ItemType;

    public void SetType(eNormalType type)
    {
        ItemType = type;
    }

    protected override string GetPrefabName()
    {
        // string prefabname = string.Empty;
        // switch (ItemType)
        // {
        //     case eNormalType.TYPE_ONE:
        //         // prefabname = Constants.PREFAB_NORMAL;

        //         break;
        //     case eNormalType.TYPE_TWO:
        //         // prefabname = Constants.PREFAB_NORMAL_TYPE_TWO;
        //         break;
        //     case eNormalType.TYPE_THREE:
        //         // prefabname = Constants.PREFAB_NORMAL_TYPE_THREE;
        //         break;
        //     case eNormalType.TYPE_FOUR:
        //         // prefabname = Constants.PREFAB_NORMAL_TYPE_FOUR;
        //         break;
        //     case eNormalType.TYPE_FIVE:
        //         // prefabname = Constants.PREFAB_NORMAL_TYPE_FIVE;
        //         break;
        //     case eNormalType.TYPE_SIX:
        //         // prefabname = Constants.PREFAB_NORMAL_TYPE_SIX;
        //         break;
        //     case eNormalType.TYPE_SEVEN:
        //         // prefabname = Constants.PREFAB_NORMAL_TYPE_SEVEN;
        //         break;
        // }

        return string.Empty;
    }

    public override void SetView()
    {
        ItemInGame _View = GameObject.Instantiate(Resources.Load<GameObject>(Constants.PREFAB_NORMAL)).GetComponent<ItemInGame>();
        SetView(_View);

        _View.SetSkinItem(Resources.Load<SkinItemSObject>(Constants.SKINSITEM + (int)ItemType).GetSkinItem(GameManager.static_typeSkinItem));
    }

    internal override bool IsSameType(Item other)
    {
        NormalItem it = other as NormalItem;

        return it != null && it.ItemType == this.ItemType;
    }
}
