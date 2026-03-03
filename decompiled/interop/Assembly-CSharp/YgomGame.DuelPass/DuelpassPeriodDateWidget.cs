using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace YgomGame.Duelpass;

[Token(Token = "0x2000ED8")]
public class DuelpassPeriodDateWidget : MonoBehaviour
{
	[Token(Token = "0x400A500")]
	[FieldOffset(Offset = "0x20")]
	private int endTimeStamp;

	[Token(Token = "0x400A501")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private TMP_Text periodDateText;

	[Token(Token = "0x400A502")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private GameObject panelColor;

	[Token(Token = "0x60059FB")]
	[Address(RVA = "0x9F0840", Offset = "0x9EFA40", VA = "0x1809F0840")]
	public void Init()
	{
	}

	[Token(Token = "0x60059FC")]
	[Address(RVA = "0x9F08F0", Offset = "0x9EFAF0", VA = "0x1809F08F0")]
	private void OnLimitGettingCloser()
	{
	}

	[Token(Token = "0x60059FD")]
	[Address(RVA = "0x9F0960", Offset = "0x9EFB60", VA = "0x1809F0960")]
	private void OnLimitNotClose()
	{
	}

	[Token(Token = "0x60059FE")]
	[Address(RVA = "0x9F08E0", Offset = "0x9EFAE0", VA = "0x1809F08E0")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60059FF")]
	[Address(RVA = "0x9F0710", Offset = "0x9EF910", VA = "0x1809F0710")]
	private void CountStart()
	{
	}

	[Token(Token = "0x6005A00")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public DuelpassPeriodDateWidget()
	{
	}
}
