using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.Utility;

namespace YgomGame.Duel;

[Token(Token = "0x200188B")]
public class DuelCursorJump : MonoBehaviour, IGameObjectPool
{
	[Token(Token = "0x400E631")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject prefabUI;

	[Token(Token = "0x400E632")]
	[FieldOffset(Offset = "0x28")]
	private ElementObjectManager ui;

	[Token(Token = "0x400E633")]
	[FieldOffset(Offset = "0x30")]
	private DuelGameObjectManager goManager;

	[Token(Token = "0x400E634")]
	[FieldOffset(Offset = "0x38")]
	private Selector selector;

	[Token(Token = "0x400E635")]
	[FieldOffset(Offset = "0x40")]
	private SelectionButton openButton;

	[Token(Token = "0x400E636")]
	[FieldOffset(Offset = "0x48")]
	private Image upIcon;

	[Token(Token = "0x400E637")]
	[FieldOffset(Offset = "0x50")]
	private Image downIcon;

	[Token(Token = "0x400E638")]
	[FieldOffset(Offset = "0x58")]
	private Image rightIcon;

	[Token(Token = "0x400E639")]
	[FieldOffset(Offset = "0x60")]
	private Image leftIcon;

	[Token(Token = "0x400E63A")]
	[FieldOffset(Offset = "0x68")]
	private Image northIcon;

	[Token(Token = "0x400E63B")]
	[FieldOffset(Offset = "0x70")]
	private Image eastIcon;

	[Token(Token = "0x400E63C")]
	[FieldOffset(Offset = "0x78")]
	private Image southIcon;

	[Token(Token = "0x400E63D")]
	[FieldOffset(Offset = "0x80")]
	private Image westIcon;

	[Token(Token = "0x400E63E")]
	[FieldOffset(Offset = "0x88")]
	private Image profileNearIcon;

	[Token(Token = "0x400E63F")]
	[FieldOffset(Offset = "0x90")]
	private Image profileFarIcon;

	[Token(Token = "0x400E640")]
	[FieldOffset(Offset = "0x98")]
	private Image mateNearIcon;

	[Token(Token = "0x400E641")]
	[FieldOffset(Offset = "0xA0")]
	private Image mateFarIcon;

	[Token(Token = "0x400E642")]
	[FieldOffset(Offset = "0xA8")]
	private Image cheatIcon;

	[Token(Token = "0x400E643")]
	[FieldOffset(Offset = "0xB0")]
	private bool isPlayableBgEffectNear;

	[Token(Token = "0x400E644")]
	[FieldOffset(Offset = "0xB1")]
	private bool isPlayableBgEffectFar;

	[Token(Token = "0x400E646")]
	private const string key = "DuelCursorJump";

	[Token(Token = "0x400E647")]
	[FieldOffset(Offset = "0xB3")]
	private bool reqOpen;

	[Token(Token = "0x400E648")]
	[FieldOffset(Offset = "0xB8")]
	private Func<bool> isOpenActive;

	[Token(Token = "0x400E649")]
	[FieldOffset(Offset = "0xC0")]
	private bool initialized;

	[Token(Token = "0x400E64A")]
	private const string prefabPath = "Prefabs/Duel/DuelCursorJump";

	[Token(Token = "0x400E64B")]
	[FieldOffset(Offset = "0xC1")]
	public bool useCheatIcon;

	[Token(Token = "0x400E64C")]
	[FieldOffset(Offset = "0xC8")]
	public Action cheatCardInfoCallback;

	[Token(Token = "0x400E64D")]
	[FieldOffset(Offset = "0xD0")]
	public Action lastSelectFocusCallback;

	[Token(Token = "0x170017EE")]
	public bool opening
	{
		[Token(Token = "0x6009D19")]
		[Address(RVA = "0xEA6CE0", Offset = "0xEA5EE0", VA = "0x180EA6CE0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6009D1A")]
		[Address(RVA = "0xEA6D20", Offset = "0xEA5F20", VA = "0x180EA6D20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x170017EF")]
	public string poolKey
	{
		[Token(Token = "0x6009D1B")]
		[Address(RVA = "0xEA6CF0", Offset = "0xEA5EF0", VA = "0x180EA6CF0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170017F0")]
	public GameObject pooledTarget
	{
		[Token(Token = "0x6009D1C")]
		[Address(RVA = "0x4A1C50", Offset = "0x4A0E50", VA = "0x1804A1C50", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6009D1D")]
	[Address(RVA = "0xEA49D0", Offset = "0xEA3BD0", VA = "0x180EA49D0")]
	public static void Create(DuelGameObjectManager goManager, Func<bool> isOpenActiveFunc, Transform parent, Action<DuelCursorJump> finishCallback)
	{
	}

	[Token(Token = "0x6009D1E")]
	[Address(RVA = "0xEA4C90", Offset = "0xEA3E90", VA = "0x180EA4C90")]
	private void Initialize(DuelGameObjectManager goManager, bool createUI = true)
	{
	}

	[Token(Token = "0x6009D1F")]
	[Address(RVA = "0xEA6AF0", Offset = "0xEA5CF0", VA = "0x180EA6AF0")]
	private void SelectItem(SharedDefinition.Location location, int position)
	{
	}

	[Token(Token = "0x6009D20")]
	[Address(RVA = "0xEA6030", Offset = "0xEA5230", VA = "0x180EA6030")]
	public void Open()
	{
	}

	[Token(Token = "0x6009D21")]
	[Address(RVA = "0xEA5DA0", Offset = "0xEA4FA0", VA = "0x180EA5DA0")]
	private bool IsListExpand()
	{
		return default(bool);
	}

	[Token(Token = "0x6009D22")]
	[Address(RVA = "0xEA46E0", Offset = "0xEA38E0", VA = "0x180EA46E0")]
	public void Close(bool force)
	{
	}

	[Token(Token = "0x6009D23")]
	[Address(RVA = "0xEA6C00", Offset = "0xEA5E00", VA = "0x180EA6C00")]
	public void SetMateFarIcon(bool active)
	{
	}

	[Token(Token = "0x6009D24")]
	[Address(RVA = "0xEA4C10", Offset = "0xEA3E10", VA = "0x180EA4C10")]
	private Vector2 GetPlaceScreenPoint(SharedDefinition.Location location, int position)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6009D25")]
	[Address(RVA = "0xEA4BD0", Offset = "0xEA3DD0", VA = "0x180EA4BD0")]
	private Vector2 GetMateScreenPoint(SharedDefinition.Location location)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6009D26")]
	[Address(RVA = "0xEA6CA0", Offset = "0xEA5EA0", VA = "0x180EA6CA0")]
	private void Update()
	{
	}

	[Token(Token = "0x6009D27")]
	[Address(RVA = "0xEA5FA0", Offset = "0xEA51A0", VA = "0x180EA5FA0")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6009D28")]
	[Address(RVA = "0xEA6BA0", Offset = "0xEA5DA0", VA = "0x180EA6BA0")]
	public void SetActive(bool active)
	{
	}

	[Token(Token = "0x6009D29")]
	[Address(RVA = "0xEA5FC0", Offset = "0xEA51C0", VA = "0x180EA5FC0", Slot = "6")]
	public void OnReturned()
	{
	}

	[Token(Token = "0x6009D2A")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public DuelCursorJump()
	{
	}
}
