using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Menu;

[Token(Token = "0x200124D")]
public class ContentBlurOverlay : MonoBehaviour
{
	[Token(Token = "0x400BB0D")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private string m_TweenShow;

	[Token(Token = "0x400BB0E")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private string m_TweenHide;

	[Token(Token = "0x400BB0F")]
	[FieldOffset(Offset = "0x0")]
	private static ContentBlurOverlay s_Instance;

	[Token(Token = "0x400BB10")]
	[FieldOffset(Offset = "0x30")]
	private readonly List<GameObject> m_ContentViews;

	[Token(Token = "0x600720A")]
	[Address(RVA = "0xB72890", Offset = "0xB71A90", VA = "0x180B72890")]
	private void Awake()
	{
	}

	[Token(Token = "0x600720B")]
	[Address(RVA = "0xB73120", Offset = "0xB72320", VA = "0x180B73120")]
	public static bool isAssigned(GameObject contentView)
	{
		return default(bool);
	}

	[Token(Token = "0x600720C")]
	[Address(RVA = "0xB72710", Offset = "0xB71910", VA = "0x180B72710")]
	public static void Assign(GameObject contentView)
	{
	}

	[Token(Token = "0x600720D")]
	[Address(RVA = "0xB72F80", Offset = "0xB72180", VA = "0x180B72F80")]
	public static void Remove(GameObject contentView)
	{
	}

	[Token(Token = "0x600720E")]
	[Address(RVA = "0xB72910", Offset = "0xB71B10", VA = "0x180B72910")]
	private void CheckContent()
	{
	}

	[Token(Token = "0x600720F")]
	[Address(RVA = "0xB72E10", Offset = "0xB72010", VA = "0x180B72E10")]
	private void PlayShow()
	{
	}

	[Token(Token = "0x6007210")]
	[Address(RVA = "0xB72D60", Offset = "0xB71F60", VA = "0x180B72D60")]
	private void PlayHide()
	{
	}

	[Token(Token = "0x6007211")]
	[Address(RVA = "0xB72B60", Offset = "0xB71D60", VA = "0x180B72B60")]
	private void OnClickClose()
	{
	}

	[Token(Token = "0x6007212")]
	[Address(RVA = "0xB72CA0", Offset = "0xB71EA0", VA = "0x180B72CA0")]
	private void OnPlayShowBegin()
	{
	}

	[Token(Token = "0x6007213")]
	[Address(RVA = "0xB72BB0", Offset = "0xB71DB0", VA = "0x180B72BB0")]
	public void OnPlayHideFinish()
	{
	}

	[Token(Token = "0x6007214")]
	[Address(RVA = "0xB73050", Offset = "0xB72250", VA = "0x180B73050")]
	public ContentBlurOverlay()
	{
	}
}
