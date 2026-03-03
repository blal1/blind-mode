using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame.Duel;

[Token(Token = "0x2001B8D")]
[RequireComponent(typeof(RectTransform))]
[RequireComponent(typeof(ElementObjectManager))]
public class EndlessScrollView : MonoBehaviour
{
	[Token(Token = "0x400F9C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	protected string templateLabel;

	[Token(Token = "0x400F9C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	protected string contentLabel;

	[Token(Token = "0x400F9C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	protected string viewportLabel;

	[Token(Token = "0x400F9C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	protected ScrollMode m_ScrollMode;

	[Token(Token = "0x400F9CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	protected Rect m_ScrollViewRT;

	[Token(Token = "0x400F9CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	protected GridLayoutGroup m_GridLayoutGroup_org;

	[Token(Token = "0x400F9CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	protected RectOffset m_Padding;

	[Token(Token = "0x400F9CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	protected Vector2 m_CellSize;

	[Token(Token = "0x400F9CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[SerializeField]
	protected Vector2 m_Spacing;

	[Token(Token = "0x400F9CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	protected TextAnchor m_ChildAlignment;

	[Token(Token = "0x400F9D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	protected UnityEvent onBlockBiasUpdate;

	[Token(Token = "0x400F9D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	protected UnityEvent onDataBiasUpdate;

	[Token(Token = "0x400F9D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	protected UnityEvent onDataNumChanged;

	[Token(Token = "0x400F9D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	protected UnityEvent onPaddingChanged;

	[Token(Token = "0x400F9D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public Func<int> getDataNum;

	[Token(Token = "0x400F9D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public Action<GameObject> onItemInitialize;

	[Token(Token = "0x400F9D6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public Action<GameObject, int> onItemUpdate;

	[Token(Token = "0x400F9D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	protected Vector2 m_ItemBias;

	[Token(Token = "0x400F9D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	protected Vector2 m_DataBias;

	[Token(Token = "0x400F9D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	protected Vector2 m_PosTrans;

	[Token(Token = "0x400F9DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	protected TweenPosition m_TweenMove;

	[Token(Token = "0x400F9DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	protected List<RectTransform> m_ItemRTList;

	[Token(Token = "0x400F9DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	protected int m_DataNum_Old;

	[Token(Token = "0x400F9DD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
	protected Vector2 m_ItemBias_Old;

	[Token(Token = "0x400F9DE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
	protected Vector2 m_DataBias_Old;

	[Token(Token = "0x400F9DF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
	protected Vector2 m_BlockBias_Old;

	[Token(Token = "0x400F9E0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
	protected Vector2 m_ContentPos_Old;

	[Token(Token = "0x400F9E1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	protected RectOffset m_Padding_Old;

	[Token(Token = "0x400F9E2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	protected bool m_Isinitialized;

	[Token(Token = "0x17001B6D")]
	protected RectTransform m_ContentRT
	{
		[Token(Token = "0x600B32C")]
		[Address(RVA = "0x4A60D0", Offset = "0x4A52D0", VA = "0x1804A60D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001B6E")]
	protected int m_ItemNum
	{
		[Token(Token = "0x600B32D")]
		[Address(RVA = "0x4A6710", Offset = "0x4A5910", VA = "0x1804A6710")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001B6F")]
	protected GridLayoutGroup m_GridLayoutGroup
	{
		[Token(Token = "0x600B32E")]
		[Address(RVA = "0x4A6450", Offset = "0x4A5650", VA = "0x1804A6450")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001B70")]
	public int viewItemRow
	{
		[Token(Token = "0x600B32F")]
		[Address(RVA = "0x4A6930", Offset = "0x4A5B30", VA = "0x1804A6930")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001B71")]
	public int viewItemColumn
	{
		[Token(Token = "0x600B330")]
		[Address(RVA = "0x4A68C0", Offset = "0x4A5AC0", VA = "0x1804A68C0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001B72")]
	public Vector2 dataBias
	{
		[Token(Token = "0x600B331")]
		[Address(RVA = "0x4A5B20", Offset = "0x4A4D20", VA = "0x1804A5B20")]
		get
		{
			return default(Vector2);
		}
		[Token(Token = "0x600B332")]
		[Address(RVA = "0x4A69A0", Offset = "0x4A5BA0", VA = "0x1804A69A0")]
		set
		{
		}
	}

	[Token(Token = "0x17001B73")]
	public Vector2 itemBias
	{
		[Token(Token = "0x600B333")]
		[Address(RVA = "0x4A5CA0", Offset = "0x4A4EA0", VA = "0x1804A5CA0")]
		get
		{
			return default(Vector2);
		}
		[Token(Token = "0x600B334")]
		[Address(RVA = "0x4A69C0", Offset = "0x4A5BC0", VA = "0x1804A69C0")]
		set
		{
		}
	}

	[Token(Token = "0x17001B74")]
	public bool isInitialized
	{
		[Token(Token = "0x600B335")]
		[Address(RVA = "0x49B880", Offset = "0x49AA80", VA = "0x18049B880")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001B75")]
	protected Vector2 m_BlockBias
	{
		[Token(Token = "0x600B336")]
		[Address(RVA = "0x4A5D50", Offset = "0x4A4F50", VA = "0x1804A5D50")]
		get
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x17001B76")]
	public Vector2 unitSize
	{
		[Token(Token = "0x600B337")]
		[Address(RVA = "0x4A68A0", Offset = "0x4A5AA0", VA = "0x1804A68A0")]
		get
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x17001B77")]
	public Vector2 blockSize
	{
		[Token(Token = "0x600B338")]
		[Address(RVA = "0x4A59F0", Offset = "0x4A4BF0", VA = "0x1804A59F0")]
		get
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x17001B78")]
	public ScrollMode endlessMode
	{
		[Token(Token = "0x600B339")]
		[Address(RVA = "0x40C450", Offset = "0x40B650", VA = "0x18040C450")]
		get
		{
			return default(ScrollMode);
		}
		[Token(Token = "0x600B33A")]
		[Address(RVA = "0x4A69B0", Offset = "0x4A5BB0", VA = "0x1804A69B0")]
		set
		{
		}
	}

	[Token(Token = "0x17001B79")]
	public bool isOnTop
	{
		[Token(Token = "0x600B33B")]
		[Address(RVA = "0x4A5BF0", Offset = "0x4A4DF0", VA = "0x1804A5BF0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001B7A")]
	public bool isOnBottom
	{
		[Token(Token = "0x600B33C")]
		[Address(RVA = "0x4A5B40", Offset = "0x4A4D40", VA = "0x1804A5B40")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001B7B")]
	protected bool m_DataNumChangedFlag
	{
		[Token(Token = "0x600B33D")]
		[Address(RVA = "0x4A63B0", Offset = "0x4A55B0", VA = "0x1804A63B0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001B7C")]
	protected bool m_DataBiasChangedFlag
	{
		[Token(Token = "0x600B33E")]
		[Address(RVA = "0x4A6140", Offset = "0x4A5340", VA = "0x1804A6140")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001B7D")]
	protected bool m_ItemBiasChangedFlag
	{
		[Token(Token = "0x600B33F")]
		[Address(RVA = "0x4A6620", Offset = "0x4A5820", VA = "0x1804A6620")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001B7E")]
	protected bool m_BlockBiasChangedFlag
	{
		[Token(Token = "0x600B340")]
		[Address(RVA = "0x4A5CC0", Offset = "0x4A4EC0", VA = "0x1804A5CC0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001B7F")]
	protected bool m_ContentPosChangedFlag
	{
		[Token(Token = "0x600B341")]
		[Address(RVA = "0x4A5F70", Offset = "0x4A5170", VA = "0x1804A5F70")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001B80")]
	protected bool m_PaddingChangedFlag
	{
		[Token(Token = "0x600B342")]
		[Address(RVA = "0x4A67F0", Offset = "0x4A59F0", VA = "0x1804A67F0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001B81")]
	protected ScrollRect m_ScrollRect
	{
		[Token(Token = "0x600B343")]
		[Address(RVA = "0x4A6860", Offset = "0x4A5A60", VA = "0x1804A6860")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001B82")]
	protected int m_DataNum
	{
		[Token(Token = "0x600B344")]
		[Address(RVA = "0x4A6420", Offset = "0x4A5620", VA = "0x1804A6420")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001B83")]
	protected int m_DataLineCount
	{
		[Token(Token = "0x600B345")]
		[Address(RVA = "0x4A6310", Offset = "0x4A5510", VA = "0x1804A6310")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001B84")]
	protected int m_ItemNumPerLine
	{
		[Token(Token = "0x600B346")]
		[Address(RVA = "0x4A6680", Offset = "0x4A5880", VA = "0x1804A6680")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001B85")]
	protected int m_DataBiasIndex
	{
		[Token(Token = "0x600B347")]
		[Address(RVA = "0x4A61A0", Offset = "0x4A53A0", VA = "0x1804A61A0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x600B348")]
	[Address(RVA = "0x4A42D0", Offset = "0x4A34D0", VA = "0x1804A42D0", Slot = "4")]
	public virtual void Initialize(Func<int> getDataNum, Action<GameObject, int> onItemUpdate, [Optional] Action<GameObject> onItemInitialize)
	{
	}

	[Token(Token = "0x600B349")]
	[Address(RVA = "0x4A3DA0", Offset = "0x4A2FA0", VA = "0x1804A3DA0")]
	public void ForceUpdateContent()
	{
	}

	[Token(Token = "0x600B34A")]
	[Address(RVA = "0x4A54B0", Offset = "0x4A46B0", VA = "0x1804A54B0", Slot = "5")]
	protected virtual void Update()
	{
	}

	[Token(Token = "0x600B34B")]
	[Address(RVA = "0x4A4620", Offset = "0x4A3820", VA = "0x1804A4620", Slot = "6")]
	protected virtual void Instantiation()
	{
	}

	[Token(Token = "0x600B34C")]
	[Address(RVA = "0x4A4E40", Offset = "0x4A4040", VA = "0x1804A4E40")]
	protected void SetViewSize()
	{
	}

	[Token(Token = "0x600B34D")]
	[Address(RVA = "0x4A36C0", Offset = "0x4A28C0", VA = "0x1804A36C0")]
	protected void AttachTween()
	{
	}

	[Token(Token = "0x600B34E")]
	[Address(RVA = "0x4A4B20", Offset = "0x4A3D20", VA = "0x1804A4B20")]
	protected void SetLayout()
	{
	}

	[Token(Token = "0x600B34F")]
	[Address(RVA = "0x4A51D0", Offset = "0x4A43D0", VA = "0x1804A51D0")]
	protected void UpdateItemData()
	{
	}

	[Token(Token = "0x600B350")]
	[Address(RVA = "0x4A4A90", Offset = "0x4A3C90", VA = "0x1804A4A90")]
	private void SetItemVisibility(int itemIndex, bool visibility)
	{
	}

	[Token(Token = "0x600B351")]
	[Address(RVA = "0x4A5010", Offset = "0x4A4210", VA = "0x1804A5010")]
	public void UpdateDataBias()
	{
	}

	[Token(Token = "0x600B352")]
	[Address(RVA = "0x4A52F0", Offset = "0x4A44F0", VA = "0x1804A52F0")]
	public void UpdatePadding()
	{
	}

	[Token(Token = "0x600B353")]
	[Address(RVA = "0x4A48D0", Offset = "0x4A3AD0", VA = "0x1804A48D0")]
	public void MoveContent(Vector2 move)
	{
	}

	[Token(Token = "0x600B354")]
	[Address(RVA = "0x4A4020", Offset = "0x4A3220", VA = "0x1804A4020")]
	public void IncreaseLine(bool loop = false, float lineNum = 1f)
	{
	}

	[Token(Token = "0x600B355")]
	[Address(RVA = "0x4A3AE0", Offset = "0x4A2CE0", VA = "0x1804A3AE0")]
	public void DecreaseLine(bool loop = false, float lineNum = 1f)
	{
	}

	[Token(Token = "0x600B356")]
	[Address(RVA = "0x4A3E00", Offset = "0x4A3000", VA = "0x1804A3E00")]
	public RectTransform GetItemByDataIndex(int dataIndex)
	{
		return null;
	}

	[Token(Token = "0x600B357")]
	[Address(RVA = "0x4A3ED0", Offset = "0x4A30D0", VA = "0x1804A3ED0")]
	public Vector2 GetItemPosByDataIndex(int dataIndex, [Optional] Vector2 pivot)
	{
		return default(Vector2);
	}

	[Token(Token = "0x600B358")]
	[Address(RVA = "0x4A3EB0", Offset = "0x4A30B0", VA = "0x1804A3EB0")]
	public int GetItemIdByDataIndex(int dataIndex)
	{
		return default(int);
	}

	[Token(Token = "0x600B359")]
	[Address(RVA = "0x4A3DE0", Offset = "0x4A2FE0", VA = "0x1804A3DE0")]
	public int GetDataIdByItemIndex(int itemIndex)
	{
		return default(int);
	}

	[Token(Token = "0x600B35A")]
	[Address(RVA = "0x4A3930", Offset = "0x4A2B30", VA = "0x1804A3930")]
	public bool CheckItemIndex(int itemIndex)
	{
		return default(bool);
	}

	[Token(Token = "0x600B35B")]
	[Address(RVA = "0x4A39A0", Offset = "0x4A2BA0", VA = "0x1804A39A0")]
	public int DataIndexCorrection(int dataIndex)
	{
		return default(int);
	}

	[Token(Token = "0x600B35C")]
	[Address(RVA = "0x4A5880", Offset = "0x4A4A80", VA = "0x1804A5880")]
	public EndlessScrollView()
	{
	}
}
