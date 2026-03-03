using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using YgomSystem.ElementSystem;

namespace YgomSystem.UI;

[Token(Token = "0x2000433")]
public class HoldIndicator : MonoBehaviour
{
	[Token(Token = "0x4001490")]
	[FieldOffset(Offset = "0x20")]
	private ElementObjectManager ui;

	[Token(Token = "0x4001491")]
	[FieldOffset(Offset = "0x28")]
	private GameObject indicatorRoot;

	[Token(Token = "0x4001492")]
	[FieldOffset(Offset = "0x30")]
	private RectTransform indicatorPosition;

	[Token(Token = "0x4001493")]
	[FieldOffset(Offset = "0x38")]
	private Image indicator;

	[Token(Token = "0x4001494")]
	[FieldOffset(Offset = "0x40")]
	private float ignoreRate;

	[Token(Token = "0x4001495")]
	[FieldOffset(Offset = "0x44")]
	private bool show;

	[Token(Token = "0x6001AEC")]
	[Address(RVA = "0x5EAA60", Offset = "0x5E9C60", VA = "0x1805EAA60")]
	private void Awake()
	{
	}

	[Token(Token = "0x6001AED")]
	[Address(RVA = "0x5EAA60", Offset = "0x5E9C60", VA = "0x1805EAA60")]
	private void Initialize()
	{
	}

	[Token(Token = "0x6001AEE")]
	[Address(RVA = "0x5EAED0", Offset = "0x5EA0D0", VA = "0x1805EAED0")]
	public void Show(bool resetIndicator = true)
	{
	}

	[Token(Token = "0x6001AEF")]
	[Address(RVA = "0x5EAB90", Offset = "0x5E9D90", VA = "0x1805EAB90")]
	public void Hide()
	{
	}

	[Token(Token = "0x6001AF0")]
	[Address(RVA = "0x5EABC0", Offset = "0x5E9DC0", VA = "0x1805EABC0")]
	private void SetDispRoot(bool disp)
	{
	}

	[Token(Token = "0x6001AF1")]
	[Address(RVA = "0x5EABE0", Offset = "0x5E9DE0", VA = "0x1805EABE0")]
	public void SetIndication(float time, float max)
	{
	}

	[Token(Token = "0x6001AF2")]
	[Address(RVA = "0x5EADC0", Offset = "0x5E9FC0", VA = "0x1805EADC0")]
	public void SetPoint(Vector2 screenPoint)
	{
	}

	[Token(Token = "0x6001AF3")]
	[Address(RVA = "0x5EAC80", Offset = "0x5E9E80", VA = "0x1805EAC80")]
	public void SetPointUseCurrentScreenPoint()
	{
	}

	[Token(Token = "0x6001AF4")]
	[Address(RVA = "0x5EAF60", Offset = "0x5EA160", VA = "0x1805EAF60")]
	public HoldIndicator()
	{
	}
}
