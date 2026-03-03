using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using YgomSystem.UI;
using YgomSystem.YGomTMPro;

namespace YgomGame.Lottery;

[Token(Token = "0x2001734")]
public class ResultCardsWidget : MonoBehaviour
{
	[Token(Token = "0x400DB02")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly string k_Shade;

	[Token(Token = "0x400DB03")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly string k_Text;

	[Token(Token = "0x400DB04")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private int m_CardNum;

	[Token(Token = "0x400DB05")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private List<(RawImage, SelectionButton)> m_Cards;

	[Token(Token = "0x400DB06")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private GameObject m_ShadeObj;

	[Token(Token = "0x400DB07")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private ExtendedTextMeshProUGUI m_Text;

	[Token(Token = "0x400DB08")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private SelectionButton m_DefaultButton;

	[Token(Token = "0x400DB09")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private bool m_IsActive;

	[Token(Token = "0x17001656")]
	public SelectionButton defaultButton
	{
		[Token(Token = "0x6009194")]
		[Address(RVA = "0x580700", Offset = "0x57F900", VA = "0x180580700")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001657")]
	public bool isActive
	{
		[Token(Token = "0x6009195")]
		[Address(RVA = "0x453D30", Offset = "0x452F30", VA = "0x180453D30")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6009196")]
	[Address(RVA = "0xDB2420", Offset = "0xDB1620", VA = "0x180DB2420")]
	public void Initialize()
	{
	}

	[Token(Token = "0x6009197")]
	[Address(RVA = "0xDB2A10", Offset = "0xDB1C10", VA = "0x180DB2A10")]
	public void SetInfo(int[] mrks, [Optional] List<int> allCards)
	{
	}

	[Token(Token = "0x6009198")]
	[Address(RVA = "0xDB2E30", Offset = "0xDB2030", VA = "0x180DB2E30")]
	public void SetUpperButton(SelectionButton upperButton)
	{
	}

	[Token(Token = "0x6009199")]
	[Address(RVA = "0xDB2650", Offset = "0xDB1850", VA = "0x180DB2650")]
	public void SetDownerButton(SelectionButton downerButton)
	{
	}

	[Token(Token = "0x600919A")]
	[Address(RVA = "0xDB2780", Offset = "0xDB1980", VA = "0x180DB2780")]
	public void SetInfo(int dayCount)
	{
	}

	[Token(Token = "0x600919B")]
	[Address(RVA = "0xDB2FB0", Offset = "0xDB21B0", VA = "0x180DB2FB0")]
	public ResultCardsWidget()
	{
	}
}
