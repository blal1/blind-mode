using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.Utility;

[Token(Token = "0x20003E8")]
public class LayerSetter : MonoBehaviour
{
	[Token(Token = "0x20003E9")]
	public enum Layer
	{
		[Token(Token = "0x4001390")]
		Default,
		[Token(Token = "0x4001391")]
		Overlay3D,
		[Token(Token = "0x4001392")]
		Overlay2D,
		[Token(Token = "0x4001393")]
		OverlayEffect3D,
		[Token(Token = "0x4001394")]
		OverlayEffect2D
	}

	[Token(Token = "0x400138C")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Layer _layer;

	[Token(Token = "0x400138D")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private bool _autoUpdate;

	[Token(Token = "0x400138E")]
	[FieldOffset(Offset = "0x25")]
	[SerializeField]
	private bool _setOnAwake;

	[Token(Token = "0x17000258")]
	public Layer layer
	{
		[Token(Token = "0x600190D")]
		[Address(RVA = "0x4BDC30", Offset = "0x4BCE30", VA = "0x1804BDC30")]
		get
		{
			return default(Layer);
		}
		[Token(Token = "0x600190E")]
		[Address(RVA = "0x51E0C0", Offset = "0x51D2C0", VA = "0x18051E0C0")]
		set
		{
		}
	}

	[Token(Token = "0x17000259")]
	public bool autoUpdate
	{
		[Token(Token = "0x600190F")]
		[Address(RVA = "0x5CF080", Offset = "0x5CE280", VA = "0x1805CF080")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001910")]
		[Address(RVA = "0x5CF0A0", Offset = "0x5CE2A0", VA = "0x1805CF0A0")]
		set
		{
		}
	}

	[Token(Token = "0x1700025A")]
	public bool setOnAwake
	{
		[Token(Token = "0x6001911")]
		[Address(RVA = "0x5CF090", Offset = "0x5CE290", VA = "0x1805CF090")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001912")]
		[Address(RVA = "0x5CF0B0", Offset = "0x5CE2B0", VA = "0x1805CF0B0")]
		set
		{
		}
	}

	[Token(Token = "0x6001913")]
	[Address(RVA = "0x5CEEC0", Offset = "0x5CE0C0", VA = "0x1805CEEC0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6001914")]
	[Address(RVA = "0x5CEFF0", Offset = "0x5CE1F0", VA = "0x1805CEFF0")]
	private void Update()
	{
	}

	[Token(Token = "0x6001915")]
	[Address(RVA = "0x5CEE50", Offset = "0x5CE050", VA = "0x1805CEE50")]
	public void Apply()
	{
	}

	[Token(Token = "0x6001916")]
	[Address(RVA = "0x5CEF80", Offset = "0x5CE180", VA = "0x1805CEF80")]
	public void SetLayer(Layer layer)
	{
	}

	[Token(Token = "0x6001917")]
	[Address(RVA = "0x5CEF40", Offset = "0x5CE140", VA = "0x1805CEF40")]
	public static int GetLayer(Layer layer)
	{
		return default(int);
	}

	[Token(Token = "0x6001918")]
	[Address(RVA = "0x5CF070", Offset = "0x5CE270", VA = "0x1805CF070")]
	public LayerSetter()
	{
	}
}
