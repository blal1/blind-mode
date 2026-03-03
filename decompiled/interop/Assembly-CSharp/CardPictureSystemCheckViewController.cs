using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

[Token(Token = "0x2000009")]
public class CardPictureSystemCheckViewController : ViewController, IGenericScrollViewSupport
{
	[Token(Token = "0x200000A")]
	private enum Mode
	{
		[Token(Token = "0x400001B")]
		Card,
		[Token(Token = "0x400001C")]
		Illust
	}

	[Token(Token = "0x400000C")]
	[FieldOffset(Offset = "0x48")]
	private bool m_Start;

	[Token(Token = "0x400000D")]
	[FieldOffset(Offset = "0x50")]
	private GenericScrollView m_Gsv;

	[Token(Token = "0x400000E")]
	[FieldOffset(Offset = "0x58")]
	private ElementObjectManager m_RootEom;

	[Token(Token = "0x400000F")]
	[FieldOffset(Offset = "0x60")]
	private ElementObjectManager m_CommonRootEom;

	[Token(Token = "0x4000010")]
	[FieldOffset(Offset = "0x68")]
	private ElementObjectManager m_CardRootEom;

	[Token(Token = "0x4000011")]
	[FieldOffset(Offset = "0x70")]
	private ElementObjectManager m_IllustRootEom;

	[Token(Token = "0x4000012")]
	[FieldOffset(Offset = "0x78")]
	private ElementObjectManager m_RandomScrollSliderEom;

	[Token(Token = "0x4000013")]
	[FieldOffset(Offset = "0x80")]
	private ElementObjectManager m_SimpleScrollSliderEom;

	[Token(Token = "0x4000014")]
	[FieldOffset(Offset = "0x88")]
	private List<int> m_DataList;

	[Token(Token = "0x4000015")]
	[FieldOffset(Offset = "0x90")]
	private Button m_IllustModeButton;

	[Token(Token = "0x4000016")]
	[FieldOffset(Offset = "0x98")]
	private Button m_CardModeButton;

	[Token(Token = "0x4000017")]
	[FieldOffset(Offset = "0xA0")]
	private Mode m_Mode;

	[Token(Token = "0x4000018")]
	[FieldOffset(Offset = "0xA8")]
	private Slider m_RandomScrollSlider;

	[Token(Token = "0x4000019")]
	[FieldOffset(Offset = "0xB0")]
	private Slider m_SimpleScrollSlider;

	[Token(Token = "0x6000010")]
	[Address(RVA = "0x3D5710", Offset = "0x3D4910", VA = "0x1803D5710")]
	private void Start()
	{
	}

	[Token(Token = "0x6000011")]
	[Address(RVA = "0x3D53A0", Offset = "0x3D45A0", VA = "0x1803D53A0")]
	private void OnReady()
	{
	}

	[Token(Token = "0x6000012")]
	[Address(RVA = "0x3D5E70", Offset = "0x3D5070", VA = "0x1803D5E70")]
	private void Update()
	{
	}

	[Token(Token = "0x6000013")]
	[Address(RVA = "0x3D54E0", Offset = "0x3D46E0", VA = "0x1803D54E0")]
	private void OnSelectMode(Mode mode)
	{
	}

	[Token(Token = "0x6000014")]
	[Address(RVA = "0x3D5150", Offset = "0x3D4350", VA = "0x1803D5150")]
	private float GetSimpleScrollValue()
	{
		return default(float);
	}

	[Token(Token = "0x6000015")]
	[Address(RVA = "0x3D5080", Offset = "0x3D4280", VA = "0x1803D5080")]
	private float GetRandomScrollValue()
	{
		return default(float);
	}

	[Token(Token = "0x6000016")]
	[Address(RVA = "0x3D5210", Offset = "0x3D4410", VA = "0x1803D5210", Slot = "16")]
	public void OnItemSetData(GameObject gob, int dataindex)
	{
	}

	[Token(Token = "0x6000017")]
	[Address(RVA = "0x3D5200", Offset = "0x3D4400", VA = "0x1803D5200", Slot = "18")]
	public void OnItemExit(GameObject gob, int dataindex)
	{
	}

	[Token(Token = "0x6000018")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "17")]
	public void OnItemEntry(GameObject gob, int dataindex)
	{
	}

	[Token(Token = "0x6000019")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "19")]
	public void OnItemInitialize(GameObject gob)
	{
	}

	[Token(Token = "0x600001A")]
	[Address(RVA = "0x3D5190", Offset = "0x3D4390", VA = "0x1803D5190", Slot = "20")]
	public void OnGsvStanby()
	{
	}

	[Token(Token = "0x600001B")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "21")]
	public void UpdateLayout()
	{
	}

	[Token(Token = "0x600001C")]
	[Address(RVA = "0x3D5FA0", Offset = "0x3D51A0", VA = "0x1803D5FA0")]
	public CardPictureSystemCheckViewController()
	{
	}
}
