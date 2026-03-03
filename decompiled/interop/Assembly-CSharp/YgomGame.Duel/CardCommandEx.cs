using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.Utility;
using YgomSystem.YGomTMPro;

namespace YgomGame.Duel;

[Token(Token = "0x2001843")]
public class CardCommandEx : MonoBehaviour, IGameObjectPool
{
	[Token(Token = "0x2001844")]
	public enum StandType
	{
		[Token(Token = "0x400E371")]
		FrontAtk = 0,
		[Token(Token = "0x400E372")]
		FrontDef = 1,
		[Token(Token = "0x400E373")]
		BackDef = 2,
		[Token(Token = "0x400E374")]
		NONE = -1
	}

	[Serializable]
	[Token(Token = "0x2001845")]
	private class CommandSetting
	{
		[Token(Token = "0x400E375")]
		[FieldOffset(Offset = "0x10")]
		public StandType type;

		[Token(Token = "0x400E376")]
		[FieldOffset(Offset = "0x18")]
		public Sprite icon;

		[Token(Token = "0x400E377")]
		[FieldOffset(Offset = "0x20")]
		public Sprite iconSelect;

		[Token(Token = "0x400E378")]
		[FieldOffset(Offset = "0x28")]
		public Sprite iconDown;

		[Token(Token = "0x400E379")]
		[FieldOffset(Offset = "0x30")]
		public Sprite iconInactive;

		[Token(Token = "0x400E37A")]
		[FieldOffset(Offset = "0x38")]
		public string textID;

		[Token(Token = "0x6009A89")]
		[Address(RVA = "0xE66250", Offset = "0xE65450", VA = "0x180E66250")]
		public CommandSetting()
		{
		}
	}

	[Token(Token = "0x2001846")]
	public class CommandButton
	{
		[Token(Token = "0x400E37B")]
		[FieldOffset(Offset = "0x10")]
		public ElementObjectManager root;

		[Token(Token = "0x400E37C")]
		[FieldOffset(Offset = "0x18")]
		public SelectionButton button;

		[Token(Token = "0x400E37D")]
		[FieldOffset(Offset = "0x20")]
		public ColorContainerImage icon;

		[Token(Token = "0x400E37E")]
		[FieldOffset(Offset = "0x28")]
		public ExtendedTextMeshProUGUI text;

		[Token(Token = "0x400E37F")]
		[FieldOffset(Offset = "0x30")]
		public StandType battlePosition;

		[Token(Token = "0x400E380")]
		[FieldOffset(Offset = "0x34")]
		public uint engineParam;

		[Token(Token = "0x6009A8A")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public CommandButton()
		{
		}
	}

	[Token(Token = "0x400E358")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private List<CommandSetting> commandSettings;

	[Token(Token = "0x400E359")]
	[FieldOffset(Offset = "0x28")]
	private CommandButton[] buttons;

	[Token(Token = "0x400E35A")]
	[FieldOffset(Offset = "0x30")]
	private RectTransform commandBG;

	[Token(Token = "0x400E35B")]
	[FieldOffset(Offset = "0x38")]
	private Image commandBGImage;

	[Token(Token = "0x400E35C")]
	[FieldOffset(Offset = "0x40")]
	private Selector selector;

	[Token(Token = "0x400E35D")]
	[FieldOffset(Offset = "0x48")]
	private RectTransform commBase;

	[Token(Token = "0x400E35E")]
	[FieldOffset(Offset = "0x50")]
	private RectTransform commGrid;

	[Token(Token = "0x400E35F")]
	[FieldOffset(Offset = "0x58")]
	private RectTransform commGridPosHand;

	[Token(Token = "0x400E360")]
	[FieldOffset(Offset = "0x60")]
	private RectTransform commGridPosField;

	[Token(Token = "0x400E361")]
	[FieldOffset(Offset = "0x68")]
	private bool docommand;

	[Token(Token = "0x400E362")]
	[FieldOffset(Offset = "0x0")]
	private static readonly string prefabPath;

	[Token(Token = "0x400E369")]
	[FieldOffset(Offset = "0x9C")]
	private Vector3 actPosBase;

	[Token(Token = "0x400E36A")]
	[FieldOffset(Offset = "0xA8")]
	private RectTransform fixedPosition;

	[Token(Token = "0x400E36B")]
	[FieldOffset(Offset = "0xB0")]
	private int bpFace;

	[Token(Token = "0x400E36C")]
	[FieldOffset(Offset = "0xB4")]
	private int cmdMax;

	[Token(Token = "0x400E36D")]
	[FieldOffset(Offset = "0xB8")]
	private int currentCommandIndex;

	[Token(Token = "0x400E36E")]
	private const string key = "CardCommandEx";

	[Token(Token = "0x400E36F")]
	[FieldOffset(Offset = "0xBC")]
	private bool pooled;

	[Token(Token = "0x1700175E")]
	public Action<bool> OnClose
	{
		[Token(Token = "0x6009A5D")]
		[Address(RVA = "0x449820", Offset = "0x448A20", VA = "0x180449820")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6009A5C")]
		[Address(RVA = "0x3D77E0", Offset = "0x3D69E0", VA = "0x1803D77E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700175F")]
	public Action<uint> OnCommandClick
	{
		[Token(Token = "0x6009A5F")]
		[Address(RVA = "0x49BD10", Offset = "0x49AF10", VA = "0x18049BD10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6009A5E")]
		[Address(RVA = "0x4573F0", Offset = "0x4565F0", VA = "0x1804573F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17001760")]
	public Action<uint, Vector2> onDragBegin
	{
		[Token(Token = "0x6009A60")]
		[Address(RVA = "0x49B7F0", Offset = "0x49A9F0", VA = "0x18049B7F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6009A61")]
		[Address(RVA = "0x457400", Offset = "0x456600", VA = "0x180457400")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17001761")]
	public Action<uint, Vector2> onDragging
	{
		[Token(Token = "0x6009A62")]
		[Address(RVA = "0x49BEA0", Offset = "0x49B0A0", VA = "0x18049BEA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6009A63")]
		[Address(RVA = "0x457410", Offset = "0x456610", VA = "0x180457410")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17001762")]
	public Action<uint, Vector2> onDragEnd
	{
		[Token(Token = "0x6009A64")]
		[Address(RVA = "0x49BDC0", Offset = "0x49AFC0", VA = "0x18049BDC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6009A65")]
		[Address(RVA = "0x4989A0", Offset = "0x497BA0", VA = "0x1804989A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17001763")]
	public bool opening
	{
		[Token(Token = "0x6009A66")]
		[Address(RVA = "0xDB8210", Offset = "0xDB7410", VA = "0x180DB8210")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6009A67")]
		[Address(RVA = "0xE348F0", Offset = "0xE33AF0", VA = "0x180E348F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001764")]
	private Vector2 commandSize
	{
		[Token(Token = "0x6009A68")]
		[Address(RVA = "0xE52770", Offset = "0xE51970", VA = "0x180E52770")]
		get
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x17001765")]
	private Vector2 commandSizeRatio
	{
		[Token(Token = "0x6009A69")]
		[Address(RVA = "0xE52670", Offset = "0xE51870", VA = "0x180E52670")]
		get
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x17001766")]
	public string poolKey
	{
		[Token(Token = "0x6009A6A")]
		[Address(RVA = "0xE527F0", Offset = "0xE519F0", VA = "0x180E527F0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001767")]
	public GameObject pooledTarget
	{
		[Token(Token = "0x6009A6B")]
		[Address(RVA = "0x4A1C50", Offset = "0x4A0E50", VA = "0x1804A1C50", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6009A6C")]
	[Address(RVA = "0xE4E7B0", Offset = "0xE4D9B0", VA = "0x180E4E7B0")]
	public static void Create(Transform parent, DuelClient host, Action<CardCommandEx> onLoaded)
	{
	}

	[Token(Token = "0x6009A6D")]
	[Address(RVA = "0xE4ECC0", Offset = "0xE4DEC0", VA = "0x180E4ECC0")]
	public void Initialize(DuelClient host, bool createUI = true)
	{
	}

	[Token(Token = "0x6009A6E")]
	[Address(RVA = "0xE4F820", Offset = "0xE4EA20", VA = "0x180E4F820")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6009A6F")]
	[Address(RVA = "0xE4E640", Offset = "0xE4D840", VA = "0x180E4E640")]
	public void Close()
	{
	}

	[Token(Token = "0x6009A70")]
	[Address(RVA = "0xE52530", Offset = "0xE51730", VA = "0x180E52530")]
	public void Term()
	{
	}

	[Token(Token = "0x6009A71")]
	[Address(RVA = "0xE4F9D0", Offset = "0xE4EBD0", VA = "0x180E4F9D0")]
	public void Open(int cardID, int face, Vector3 screenPoint)
	{
	}

	[Token(Token = "0x6009A72")]
	[Address(RVA = "0xE51B60", Offset = "0xE50D60", VA = "0x180E51B60")]
	public void Open()
	{
	}

	[Token(Token = "0x6009A73")]
	[Address(RVA = "0xE52010", Offset = "0xE51210", VA = "0x180E52010")]
	public void SetDispButton(uint standType)
	{
	}

	[Token(Token = "0x6009A74")]
	[Address(RVA = "0xE51F70", Offset = "0xE51170", VA = "0x180E51F70")]
	public void SetDispAllButton(bool disp)
	{
	}

	[Token(Token = "0x6009A75")]
	[Address(RVA = "0xE51E30", Offset = "0xE51030", VA = "0x180E51E30")]
	public void SetDefaultPosition()
	{
	}

	[Token(Token = "0x6009A76")]
	[Address(RVA = "0xE4E970", Offset = "0xE4DB70", VA = "0x180E4E970")]
	public void FixedPositionMode()
	{
	}

	[Token(Token = "0x6009A77")]
	[Address(RVA = "0xE51DB0", Offset = "0xE50FB0", VA = "0x180E51DB0")]
	public bool SelectCommand(int index)
	{
		return default(bool);
	}

	[Token(Token = "0x6009A78")]
	[Address(RVA = "0xE51D40", Offset = "0xE50F40", VA = "0x180E51D40")]
	public bool SelectCommandByStandType(uint standType)
	{
		return default(bool);
	}

	[Token(Token = "0x6009A79")]
	[Address(RVA = "0xE4E490", Offset = "0xE4D690", VA = "0x180E4E490")]
	public void AlphaChange(bool setAlpha)
	{
	}

	[Token(Token = "0x6009A7A")]
	[Address(RVA = "0xE52140", Offset = "0xE51340", VA = "0x180E52140")]
	public Vector3 SetPosition(Vector2 screenPoint)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6009A7B")]
	[Address(RVA = "0xE52100", Offset = "0xE51300", VA = "0x180E52100")]
	public void SetGridPositionHand()
	{
	}

	[Token(Token = "0x6009A7C")]
	[Address(RVA = "0xE520C0", Offset = "0xE512C0", VA = "0x180E520C0")]
	public void SetGridPositionField()
	{
	}

	[Token(Token = "0x6009A7D")]
	[Address(RVA = "0xE51E10", Offset = "0xE51010", VA = "0x180E51E10")]
	public void SetActiveCommandBG(bool active)
	{
	}

	[Token(Token = "0x6009A7E")]
	[Address(RVA = "0xE4F510", Offset = "0xE4E710", VA = "0x180E4F510")]
	public void OnCommand(int index)
	{
	}

	[Token(Token = "0x6009A7F")]
	[Address(RVA = "0xE4EB10", Offset = "0xE4DD10", VA = "0x180E4EB10")]
	public StandType GetCurrentBattlePosition()
	{
		return default(StandType);
	}

	[Token(Token = "0x6009A80")]
	[Address(RVA = "0xE4EB50", Offset = "0xE4DD50", VA = "0x180E4EB50")]
	public uint GetCurrentResultParam()
	{
		return default(uint);
	}

	[Token(Token = "0x6009A81")]
	[Address(RVA = "0xE4EA10", Offset = "0xE4DC10", VA = "0x180E4EA10")]
	private uint GetCommandExToResultParam(StandType battlePosition)
	{
		return default(uint);
	}

	[Token(Token = "0x6009A82")]
	[Address(RVA = "0xE51CF0", Offset = "0xE50EF0", VA = "0x180E51CF0")]
	public StandType ResultParamToStandType(uint resultParam)
	{
		return default(StandType);
	}

	[Token(Token = "0x6009A83")]
	[Address(RVA = "0xE4EC00", Offset = "0xE4DE00", VA = "0x180E4EC00")]
	private CommandSetting GetSetting(StandType commandType)
	{
		return null;
	}

	[Token(Token = "0x6009A84")]
	[Address(RVA = "0xE4EA80", Offset = "0xE4DC80", VA = "0x180E4EA80")]
	private string GetCommandText(StandType commandType)
	{
		return null;
	}

	[Token(Token = "0x6009A85")]
	[Address(RVA = "0xE51C20", Offset = "0xE50E20", VA = "0x180E51C20")]
	private void PlayTween(string label, string stopLabel)
	{
	}

	[Token(Token = "0x6009A86")]
	[Address(RVA = "0xE4F8A0", Offset = "0xE4EAA0", VA = "0x180E4F8A0", Slot = "6")]
	public void OnReturned()
	{
	}

	[Token(Token = "0x6009A87")]
	[Address(RVA = "0xE525B0", Offset = "0xE517B0", VA = "0x180E525B0")]
	public CardCommandEx()
	{
	}
}
