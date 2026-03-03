using System;
using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.ElementSystem;

namespace YgomSystem.UI;

[Serializable]
[Token(Token = "0x200057B")]
public class ViewCreater
{
	[Token(Token = "0x200057C")]
	public enum CreateType
	{
		[Token(Token = "0x4001ABE")]
		None = 0,
		[Token(Token = "0x4001ABF")]
		PrefRef = 1,
		[Token(Token = "0x4001AC0")]
		PrefPath = 2,
		[Token(Token = "0x4001AC1")]
		PrefLinker = 4,
		[Token(Token = "0x4001AC2")]
		ManualInstance = 3
	}

	[Token(Token = "0x4001AB6")]
	[FieldOffset(Offset = "0x10")]
	[SerializeField]
	private CreateType m_CreateType;

	[Token(Token = "0x4001AB7")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private ElementObjectManager m_PrefRef;

	[Token(Token = "0x4001AB8")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private string m_PrefPath;

	[Token(Token = "0x4001AB9")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private string m_PrefLinkerLabel;

	[Token(Token = "0x4001ABA")]
	[FieldOffset(Offset = "0x30")]
	private ElementObjectManager m_ManualInstance;

	[Token(Token = "0x4001ABB")]
	[FieldOffset(Offset = "0x38")]
	private Transform m_Parent;

	[Token(Token = "0x4001ABC")]
	[FieldOffset(Offset = "0x40")]
	private bool m_IsManualParent;

	[Token(Token = "0x170003D4")]
	public CreateType createType
	{
		[Token(Token = "0x60023AB")]
		[Address(RVA = "0x3C7100", Offset = "0x3C6300", VA = "0x1803C7100")]
		get
		{
			return default(CreateType);
		}
		[Token(Token = "0x60023AC")]
		[Address(RVA = "0x5F4710", Offset = "0x5F3910", VA = "0x1805F4710")]
		set
		{
		}
	}

	[Token(Token = "0x170003D5")]
	public ElementObjectManager prefRef
	{
		[Token(Token = "0x60023AD")]
		[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30")]
		get
		{
			return null;
		}
		[Token(Token = "0x60023AE")]
		[Address(RVA = "0x417C80", Offset = "0x416E80", VA = "0x180417C80")]
		set
		{
		}
	}

	[Token(Token = "0x170003D6")]
	public string prefPath
	{
		[Token(Token = "0x60023AF")]
		[Address(RVA = "0x3D8370", Offset = "0x3D7570", VA = "0x1803D8370")]
		get
		{
			return null;
		}
		[Token(Token = "0x60023B0")]
		[Address(RVA = "0x3D8380", Offset = "0x3D7580", VA = "0x1803D8380")]
		set
		{
		}
	}

	[Token(Token = "0x170003D7")]
	public string prefLinkerLabel
	{
		[Token(Token = "0x60023B1")]
		[Address(RVA = "0x4030F0", Offset = "0x4022F0", VA = "0x1804030F0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60023B2")]
		[Address(RVA = "0x402FB0", Offset = "0x4021B0", VA = "0x180402FB0")]
		set
		{
		}
	}

	[Token(Token = "0x170003D8")]
	public ElementObjectManager manualInstance
	{
		[Token(Token = "0x60023B3")]
		[Address(RVA = "0x402CE0", Offset = "0x401EE0", VA = "0x180402CE0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60023B4")]
		[Address(RVA = "0x4130D0", Offset = "0x4122D0", VA = "0x1804130D0")]
		set
		{
		}
	}

	[Token(Token = "0x170003D9")]
	public Transform parent
	{
		[Token(Token = "0x60023B5")]
		[Address(RVA = "0x404860", Offset = "0x403A60", VA = "0x180404860")]
		get
		{
			return null;
		}
		[Token(Token = "0x60023B6")]
		[Address(RVA = "0x670EE0", Offset = "0x6700E0", VA = "0x180670EE0")]
		set
		{
		}
	}

	[Token(Token = "0x170003DA")]
	public bool isManualParent
	{
		[Token(Token = "0x60023B7")]
		[Address(RVA = "0x416640", Offset = "0x415840", VA = "0x180416640")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60023B8")]
	[Address(RVA = "0x670B40", Offset = "0x66FD40", VA = "0x180670B40")]
	public void Create(GameObject woner, Action<ElementObjectManager> onComplete)
	{
	}

	[Token(Token = "0x60023B9")]
	[Address(RVA = "0x670E90", Offset = "0x670090", VA = "0x180670E90")]
	public ViewCreater()
	{
	}
}
