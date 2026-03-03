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

[Token(Token = "0x200183C")]
public class CardCommand : MonoBehaviour, IGameObjectPool
{
	[Serializable]
	[Token(Token = "0x200183D")]
	private class CommandSetting
	{
		[Token(Token = "0x400E342")]
		[FieldOffset(Offset = "0x10")]
		public Engine.CommandType type;

		[Token(Token = "0x400E343")]
		[FieldOffset(Offset = "0x18")]
		public Sprite icon;

		[Token(Token = "0x400E344")]
		[FieldOffset(Offset = "0x20")]
		public Sprite iconSelect;

		[Token(Token = "0x400E345")]
		[FieldOffset(Offset = "0x28")]
		public Sprite iconDown;

		[Token(Token = "0x400E346")]
		[FieldOffset(Offset = "0x30")]
		public Sprite iconInactive;

		[Token(Token = "0x400E347")]
		[FieldOffset(Offset = "0x38")]
		public string textID;

		[Token(Token = "0x400E348")]
		[FieldOffset(Offset = "0x40")]
		public bool isPendulum;

		[Token(Token = "0x6009A4D")]
		[Address(RVA = "0xE66210", Offset = "0xE65410", VA = "0x180E66210")]
		public CommandSetting()
		{
		}
	}

	[Token(Token = "0x200183E")]
	public class CommandButton
	{
		[Token(Token = "0x400E349")]
		[FieldOffset(Offset = "0x10")]
		public ElementObjectManager root;

		[Token(Token = "0x400E34A")]
		[FieldOffset(Offset = "0x18")]
		public SelectionButton button;

		[Token(Token = "0x400E34B")]
		[FieldOffset(Offset = "0x20")]
		public ColorContainerImage icon;

		[Token(Token = "0x400E34C")]
		[FieldOffset(Offset = "0x28")]
		public ExtendedTextMeshProUGUI text;

		[Token(Token = "0x400E34D")]
		[FieldOffset(Offset = "0x30")]
		public Engine.CommandType command;

		[Token(Token = "0x6009A4E")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public CommandButton()
		{
		}
	}

	[Token(Token = "0x400E31F")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private List<CommandSetting> commandSettings;

	[Token(Token = "0x400E320")]
	[FieldOffset(Offset = "0x28")]
	private CommandButton[] buttons;

	[Token(Token = "0x400E321")]
	[FieldOffset(Offset = "0x30")]
	private ElementObjectManager ui;

	[Token(Token = "0x400E322")]
	[FieldOffset(Offset = "0x38")]
	private Selector selector;

	[Token(Token = "0x400E323")]
	[FieldOffset(Offset = "0x40")]
	private SelectionButton closeButton;

	[Token(Token = "0x400E324")]
	[FieldOffset(Offset = "0x48")]
	private ElementObjectManager affectButtonRoot;

	[Token(Token = "0x400E325")]
	[FieldOffset(Offset = "0x50")]
	private SelectionButton affectButton;

	[Token(Token = "0x400E326")]
	[FieldOffset(Offset = "0x58")]
	private Action onAffectCallback;

	[Token(Token = "0x400E327")]
	[FieldOffset(Offset = "0x60")]
	private RectTransform commandBG;

	[Token(Token = "0x400E328")]
	[FieldOffset(Offset = "0x68")]
	private Image commandBGImage;

	[Token(Token = "0x400E329")]
	[FieldOffset(Offset = "0x70")]
	private RectTransform commBase;

	[Token(Token = "0x400E32A")]
	[FieldOffset(Offset = "0x78")]
	private RectTransform commGrid;

	[Token(Token = "0x400E32B")]
	[FieldOffset(Offset = "0x80")]
	private RectTransform commGridPosHand;

	[Token(Token = "0x400E32C")]
	[FieldOffset(Offset = "0x88")]
	private RectTransform commGridPosField;

	[Token(Token = "0x400E32D")]
	[FieldOffset(Offset = "0x90")]
	private Vector2 dispPositionOrg;

	[Token(Token = "0x400E331")]
	[FieldOffset(Offset = "0xA4")]
	private bool isPendulum;

	[Token(Token = "0x400E332")]
	[FieldOffset(Offset = "0xA8")]
	private int currentCommandIndex;

	[Token(Token = "0x400E333")]
	[FieldOffset(Offset = "0xAC")]
	private bool docommand;

	[Token(Token = "0x400E334")]
	[FieldOffset(Offset = "0x0")]
	private static readonly string prefabPath;

	[Token(Token = "0x400E335")]
	[FieldOffset(Offset = "0xAD")]
	private bool pooled;

	[Token(Token = "0x400E33C")]
	[FieldOffset(Offset = "0xD9")]
	public bool dontClose;

	[Token(Token = "0x400E33D")]
	[FieldOffset(Offset = "0xDC")]
	private Vector3 actPosBase;

	[Token(Token = "0x400E33E")]
	[FieldOffset(Offset = "0xE8")]
	private RectTransform fixedPosition;

	[Token(Token = "0x400E341")]
	[FieldOffset(Offset = "0xF8")]
	private string key;

	[Token(Token = "0x1700174C")]
	public int cmdPlayer
	{
		[Token(Token = "0x6009A0D")]
		[Address(RVA = "0x3DDD20", Offset = "0x3DCF20", VA = "0x1803DDD20")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6009A0E")]
		[Address(RVA = "0x62DFF0", Offset = "0x62D1F0", VA = "0x18062DFF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1700174D")]
	public int cmdPosition
	{
		[Token(Token = "0x6009A0F")]
		[Address(RVA = "0x588970", Offset = "0x587B70", VA = "0x180588970")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6009A10")]
		[Address(RVA = "0xE55710", Offset = "0xE54910", VA = "0x180E55710")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1700174E")]
	public int cmdIndex
	{
		[Token(Token = "0x6009A11")]
		[Address(RVA = "0x662060", Offset = "0x661260", VA = "0x180662060")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6009A12")]
		[Address(RVA = "0xCBCFE0", Offset = "0xCBC1E0", VA = "0x180CBCFE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1700174F")]
	public Action<bool> OnClose
	{
		[Token(Token = "0x6009A14")]
		[Address(RVA = "0x49BB20", Offset = "0x49AD20", VA = "0x18049BB20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6009A13")]
		[Address(RVA = "0x42FF50", Offset = "0x42F150", VA = "0x18042FF50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17001750")]
	public Action<Engine.CommandType> onExecuteCommand
	{
		[Token(Token = "0x6009A15")]
		[Address(RVA = "0x49B7C0", Offset = "0x49A9C0", VA = "0x18049B7C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6009A16")]
		[Address(RVA = "0x42FF70", Offset = "0x42F170", VA = "0x18042FF70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17001751")]
	public Action<int, Vector2> onDragBegin
	{
		[Token(Token = "0x6009A17")]
		[Address(RVA = "0x49BB10", Offset = "0x49AD10", VA = "0x18049BB10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6009A18")]
		[Address(RVA = "0x3DAE90", Offset = "0x3DA090", VA = "0x1803DAE90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17001752")]
	public Action<int, Vector2> onDragging
	{
		[Token(Token = "0x6009A19")]
		[Address(RVA = "0x49BAD0", Offset = "0x49ACD0", VA = "0x18049BAD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6009A1A")]
		[Address(RVA = "0x42FF90", Offset = "0x42F190", VA = "0x18042FF90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17001753")]
	public Action<int, Vector2> onDragEnd
	{
		[Token(Token = "0x6009A1B")]
		[Address(RVA = "0x5857B0", Offset = "0x5849B0", VA = "0x1805857B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6009A1C")]
		[Address(RVA = "0x42FFB0", Offset = "0x42F1B0", VA = "0x18042FFB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17001754")]
	public bool opening
	{
		[Token(Token = "0x6009A1D")]
		[Address(RVA = "0xE55700", Offset = "0xE54900", VA = "0x180E55700")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6009A1E")]
		[Address(RVA = "0xE55720", Offset = "0xE54920", VA = "0x180E55720")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001755")]
	public int cmdMax
	{
		[Token(Token = "0x6009A1F")]
		[Address(RVA = "0x764490", Offset = "0x763690", VA = "0x180764490")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6009A20")]
		[Address(RVA = "0x8AF080", Offset = "0x8AE280", VA = "0x1808AF080")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001756")]
	public bool useAffectCommand
	{
		[Token(Token = "0x6009A21")]
		[Address(RVA = "0x91A840", Offset = "0x919A40", VA = "0x18091A840")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001757")]
	public int selectorPriority
	{
		[Token(Token = "0x6009A22")]
		[Address(RVA = "0xA2A0B0", Offset = "0xA292B0", VA = "0x180A2A0B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6009A23")]
		[Address(RVA = "0xA2A500", Offset = "0xA29700", VA = "0x180A2A500")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001758")]
	private Vector2 commandSize
	{
		[Token(Token = "0x6009A26")]
		[Address(RVA = "0xE55680", Offset = "0xE54880", VA = "0x180E55680")]
		get
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x17001759")]
	private Vector2 commandSizeRatio
	{
		[Token(Token = "0x6009A27")]
		[Address(RVA = "0xE55580", Offset = "0xE54780", VA = "0x180E55580")]
		get
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x1700175A")]
	public string poolKey
	{
		[Token(Token = "0x6009A28")]
		[Address(RVA = "0x596200", Offset = "0x595400", VA = "0x180596200", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700175B")]
	public GameObject pooledTarget
	{
		[Token(Token = "0x6009A29")]
		[Address(RVA = "0x4A1C50", Offset = "0x4A0E50", VA = "0x1804A1C50", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6009A24")]
	[Address(RVA = "0xE52D60", Offset = "0xE51F60", VA = "0x180E52D60")]
	public static void Create(Transform parent, DuelClient host, Action<CardCommand> onLoaded, string key)
	{
	}

	[Token(Token = "0x6009A25")]
	[Address(RVA = "0xE53200", Offset = "0xE52400", VA = "0x180E53200")]
	public void Initialize(DuelClient host, bool createUI = true)
	{
	}

	[Token(Token = "0x6009A2A")]
	[Address(RVA = "0xE53C90", Offset = "0xE52E90", VA = "0x180E53C90")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6009A2B")]
	[Address(RVA = "0xE52AF0", Offset = "0xE51CF0", VA = "0x180E52AF0")]
	public void Close()
	{
	}

	[Token(Token = "0x6009A2C")]
	[Address(RVA = "0xE52530", Offset = "0xE51730", VA = "0x180E52530")]
	public void Term()
	{
	}

	[Token(Token = "0x6009A2D")]
	[Address(RVA = "0xE53E80", Offset = "0xE53080", VA = "0x180E53E80")]
	public bool Open(uint command, int player, int position, int index, Vector2 screenPoint, Action affectButtonCallback)
	{
		return default(bool);
	}

	[Token(Token = "0x6009A2E")]
	[Address(RVA = "0xE543D0", Offset = "0xE535D0", VA = "0x180E543D0")]
	public void Open()
	{
	}

	[Token(Token = "0x6009A2F")]
	[Address(RVA = "0xE548A0", Offset = "0xE53AA0", VA = "0x180E548A0")]
	public void SetCommand(uint commandMask)
	{
	}

	[Token(Token = "0x6009A30")]
	[Address(RVA = "0xE54D60", Offset = "0xE53F60", VA = "0x180E54D60")]
	public void SetDefaultPosition()
	{
	}

	[Token(Token = "0x6009A31")]
	[Address(RVA = "0xE52F30", Offset = "0xE52130", VA = "0x180E52F30")]
	public void FixedPositionMode()
	{
	}

	[Token(Token = "0x6009A32")]
	[Address(RVA = "0xE51DB0", Offset = "0xE50FB0", VA = "0x180E51DB0")]
	public bool SelectCommand(int index)
	{
		return default(bool);
	}

	[Token(Token = "0x6009A33")]
	[Address(RVA = "0xE545E0", Offset = "0xE537E0", VA = "0x180E545E0")]
	public bool SelectCommand(Engine.CommandType command)
	{
		return default(bool);
	}

	[Token(Token = "0x6009A34")]
	[Address(RVA = "0xE52940", Offset = "0xE51B40", VA = "0x180E52940")]
	public void AlphaChange(bool setAlpha)
	{
	}

	[Token(Token = "0x6009A35")]
	[Address(RVA = "0xE54780", Offset = "0xE53980", VA = "0x180E54780")]
	public void SetButtonInteractable(Engine.CommandType command, bool interactable)
	{
	}

	[Token(Token = "0x6009A36")]
	[Address(RVA = "0xE54720", Offset = "0xE53920", VA = "0x180E54720")]
	public void SetButtonInteractable(int index, bool interactable)
	{
	}

	[Token(Token = "0x6009A37")]
	[Address(RVA = "0xE54670", Offset = "0xE53870", VA = "0x180E54670")]
	public void SetAllButtonInteractable(bool interactable)
	{
	}

	[Token(Token = "0x6009A38")]
	[Address(RVA = "0xE54FA0", Offset = "0xE541A0", VA = "0x180E54FA0")]
	public Vector3 SetPosition(Vector2 screenPoint)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6009A39")]
	[Address(RVA = "0xE54800", Offset = "0xE53A00", VA = "0x180E54800")]
	private void SetComBaseLocalPosition(Vector3 localPosition)
	{
	}

	[Token(Token = "0x6009A3A")]
	[Address(RVA = "0xE54850", Offset = "0xE53A50", VA = "0x180E54850")]
	private void SetComGridLocalPosition(Vector3 localPosition)
	{
	}

	[Token(Token = "0x6009A3B")]
	[Address(RVA = "0xE54590", Offset = "0xE53790", VA = "0x180E54590")]
	public Vector3 ReapplyPosition()
	{
		return default(Vector3);
	}

	[Token(Token = "0x6009A3C")]
	[Address(RVA = "0xE54F20", Offset = "0xE54120", VA = "0x180E54F20")]
	public void SetGridPositionHand()
	{
	}

	[Token(Token = "0x6009A3D")]
	[Address(RVA = "0xE54EA0", Offset = "0xE540A0", VA = "0x180E54EA0")]
	public void SetGridPositionField()
	{
	}

	[Token(Token = "0x6009A3E")]
	[Address(RVA = "0xE54650", Offset = "0xE53850", VA = "0x180E54650")]
	public void SetActiveCommandBG(bool active)
	{
	}

	[Token(Token = "0x6009A3F")]
	[Address(RVA = "0xE53C40", Offset = "0xE52E40", VA = "0x180E53C40")]
	public void OnCommand(int index)
	{
	}

	[Token(Token = "0x6009A40")]
	[Address(RVA = "0xE53BD0", Offset = "0xE52DD0", VA = "0x180E53BD0")]
	public void OnCommand(Engine.CommandType command)
	{
	}

	[Token(Token = "0x6009A41")]
	[Address(RVA = "0xE53B90", Offset = "0xE52D90", VA = "0x180E53B90")]
	public void OnAffectButton()
	{
	}

	[Token(Token = "0x6009A42")]
	[Address(RVA = "0xE530D0", Offset = "0xE522D0", VA = "0x180E530D0")]
	public Engine.CommandType GetCurrentCommand()
	{
		return default(Engine.CommandType);
	}

	[Token(Token = "0x6009A43")]
	[Address(RVA = "0xE52C40", Offset = "0xE51E40", VA = "0x180E52C40")]
	private void ComDoCommand(Engine.CommandType command)
	{
	}

	[Token(Token = "0x6009A44")]
	[Address(RVA = "0xE553A0", Offset = "0xE545A0", VA = "0x180E553A0")]
	public void SetSelectorPriority(SharedDefinition.DuelSelectorPriority priority = SharedDefinition.DuelSelectorPriority.HUD, int priorityInCluster = 8)
	{
	}

	[Token(Token = "0x6009A45")]
	[Address(RVA = "0xE53110", Offset = "0xE52310", VA = "0x180E53110")]
	private CommandSetting GetSetting(Engine.CommandType commandType, bool isPendulum)
	{
		return null;
	}

	[Token(Token = "0x6009A46")]
	[Address(RVA = "0xE53030", Offset = "0xE52230", VA = "0x180E53030")]
	private string GetCommandText(Engine.CommandType commandType, bool isPendulum)
	{
		return null;
	}

	[Token(Token = "0x6009A47")]
	[Address(RVA = "0xE544C0", Offset = "0xE536C0", VA = "0x180E544C0")]
	private void PlayTween(string label, string stopLabel)
	{
	}

	[Token(Token = "0x6009A48")]
	[Address(RVA = "0xE53D30", Offset = "0xE52F30", VA = "0x180E53D30", Slot = "6")]
	public void OnReturned()
	{
	}

	[Token(Token = "0x6009A49")]
	[Address(RVA = "0xE554C0", Offset = "0xE546C0", VA = "0x180E554C0")]
	public CardCommand()
	{
	}
}
