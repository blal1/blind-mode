using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.ElementSystem;

namespace YgomSystem.UI;

[Token(Token = "0x2000553")]
[AddComponentMenu("Ygom/UI/uGUI/Scroll Rect Page Snap Buttons")]
[RequireComponent(typeof(ScrollRectPageSnap))]
public class ScrollRectPageSnapButtons : MonoBehaviour
{
	[Token(Token = "0x40019EA")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	public ElementObjectManager eom;

	[Token(Token = "0x40019EB")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	public string backButtonLabel;

	[Token(Token = "0x40019EC")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	public string nextButtonLabel;

	[Token(Token = "0x40019ED")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	public bool hideOnEmpty;

	[Token(Token = "0x40019EE")]
	[FieldOffset(Offset = "0x40")]
	private ScrollRectPageSnap m_PageSnap;

	[Token(Token = "0x170003B3")]
	public SelectionButton backButton
	{
		[Token(Token = "0x60022AA")]
		[Address(RVA = "0x6503A0", Offset = "0x64F5A0", VA = "0x1806503A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170003B4")]
	public SelectionButton nextButton
	{
		[Token(Token = "0x60022AB")]
		[Address(RVA = "0x650400", Offset = "0x64F600", VA = "0x180650400")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60022AC")]
	[Address(RVA = "0x650060", Offset = "0x64F260", VA = "0x180650060")]
	private void Start()
	{
	}

	[Token(Token = "0x60022AD")]
	[Address(RVA = "0x64FC20", Offset = "0x64EE20", VA = "0x18064FC20")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60022AE")]
	[Address(RVA = "0x64FD50", Offset = "0x64EF50", VA = "0x18064FD50")]
	private void Refresh()
	{
	}

	[Token(Token = "0x60022AF")]
	[Address(RVA = "0x64FD40", Offset = "0x64EF40", VA = "0x18064FD40")]
	private void OnPageChanged()
	{
	}

	[Token(Token = "0x60022B0")]
	[Address(RVA = "0x64FBA0", Offset = "0x64EDA0", VA = "0x18064FBA0")]
	private void OnClickBack()
	{
	}

	[Token(Token = "0x60022B1")]
	[Address(RVA = "0x64FBE0", Offset = "0x64EDE0", VA = "0x18064FBE0")]
	private void OnClickNext()
	{
	}

	[Token(Token = "0x60022B2")]
	[Address(RVA = "0x650320", Offset = "0x64F520", VA = "0x180650320")]
	public ScrollRectPageSnapButtons()
	{
	}
}
