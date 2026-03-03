using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.UI;

namespace YgomGame.Deck;

[Token(Token = "0x20010E4")]
public class FilterCheckShortcut : MonoBehaviour
{
	[Token(Token = "0x400B26B")]
	private const string k_LABEL_SHORTCUT = "FilterCheckShortcut";

	[Token(Token = "0x400B26D")]
	[FieldOffset(Offset = "0x28")]
	private List<FilterCheck> m_FilterCheckList;

	[Token(Token = "0x170010F9")]
	public SelectionButton m_Button
	{
		[Token(Token = "0x6006A0E")]
		[Address(RVA = "0x3D8370", Offset = "0x3D7570", VA = "0x1803D8370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6006A0F")]
		[Address(RVA = "0x3D8380", Offset = "0x3D7580", VA = "0x1803D8380")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x6006A10")]
	[Address(RVA = "0xB0E7E0", Offset = "0xB0D9E0", VA = "0x180B0E7E0")]
	private void InitializeElements()
	{
	}

	[Token(Token = "0x6006A11")]
	[Address(RVA = "0xB0E830", Offset = "0xB0DA30", VA = "0x180B0E830")]
	public void Initialize(List<FilterCheck> filterChecks)
	{
	}

	[Token(Token = "0x6006A12")]
	[Address(RVA = "0xB0E7E0", Offset = "0xB0D9E0", VA = "0x180B0E7E0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6006A13")]
	[Address(RVA = "0xB0E8C0", Offset = "0xB0DAC0", VA = "0x180B0E8C0")]
	private void Start()
	{
	}

	[Token(Token = "0x6006A14")]
	[Address(RVA = "0xB0EAE0", Offset = "0xB0DCE0", VA = "0x180B0EAE0")]
	public FilterCheckShortcut()
	{
	}
}
