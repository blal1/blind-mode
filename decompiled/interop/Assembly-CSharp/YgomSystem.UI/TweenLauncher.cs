using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.UI;

[Token(Token = "0x200050D")]
public class TweenLauncher : MonoBehaviour
{
	[Token(Token = "0x40018D6")]
	[FieldOffset(Offset = "0x20")]
	[Tooltip("生成するTweenInfo")]
	public List<TweenInfo> infoList;

	[Token(Token = "0x40018D7")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Tooltip("AwakeでTween生成するか")]
	private bool generateTweensOnAwake;

	[Token(Token = "0x60020E6")]
	[Address(RVA = "0x63BE60", Offset = "0x63B060", VA = "0x18063BE60")]
	private void Awake()
	{
	}

	[Token(Token = "0x60020E7")]
	[Address(RVA = "0x63C990", Offset = "0x63BB90", VA = "0x18063C990")]
	public void GenerateTweens()
	{
	}

	[Token(Token = "0x60020E8")]
	[Address(RVA = "0x63BEC0", Offset = "0x63B0C0", VA = "0x18063BEC0")]
	private void GenerateTween(TweenInfo baseInfo, string prefix, string suffix)
	{
	}

	[Token(Token = "0x60020E9")]
	[Address(RVA = "0x63CAC0", Offset = "0x63BCC0", VA = "0x18063CAC0")]
	public TweenLauncher()
	{
	}
}
