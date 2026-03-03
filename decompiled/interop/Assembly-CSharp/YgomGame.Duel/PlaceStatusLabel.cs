using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.YGomTMPro;

namespace YgomGame.Duel;

[Token(Token = "0x2001920")]
public class PlaceStatusLabel : MonoBehaviour
{
	[Token(Token = "0x400EAC6")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private GameObject prefabUI;

	[Token(Token = "0x400EAC7")]
	[FieldOffset(Offset = "0x28")]
	private ElementObjectManager ui;

	[Token(Token = "0x400EAC8")]
	[FieldOffset(Offset = "0x30")]
	private Vector2 defaultSize;

	[Token(Token = "0x400EAC9")]
	[FieldOffset(Offset = "0x38")]
	private ExtendedTextMeshProUGUI numCardsValue;

	[Token(Token = "0x400EACA")]
	[FieldOffset(Offset = "0x40")]
	private int preNumCardValue;

	[Token(Token = "0x400EACB")]
	[FieldOffset(Offset = "0x44")]
	private bool hiding;

	[Token(Token = "0x400EACC")]
	[FieldOffset(Offset = "0x48")]
	private Camera uiCamera;

	[Token(Token = "0x400EACD")]
	[FieldOffset(Offset = "0x50")]
	private PlaceStatusManager manager;

	[Token(Token = "0x170018C5")]
	public TweenScale tweenScale
	{
		[Token(Token = "0x600A1EF")]
		[Address(RVA = "0x5EA220", Offset = "0x5E9420", VA = "0x1805EA220")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600A1F0")]
		[Address(RVA = "0x81BD60", Offset = "0x81AF60", VA = "0x18081BD60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x170018C6")]
	public TweenEvent startTween
	{
		[Token(Token = "0x600A1F1")]
		[Address(RVA = "0x589E50", Offset = "0x589050", VA = "0x180589E50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600A1F2")]
		[Address(RVA = "0x589E60", Offset = "0x589060", VA = "0x180589E60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x170018C7")]
	public TweenEvent stopTween
	{
		[Token(Token = "0x600A1F3")]
		[Address(RVA = "0x49B9F0", Offset = "0x49ABF0", VA = "0x18049B9F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600A1F4")]
		[Address(RVA = "0x49C1F0", Offset = "0x49B3F0", VA = "0x18049C1F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x600A1F5")]
	[Address(RVA = "0xEF6930", Offset = "0xEF5B30", VA = "0x180EF6930")]
	public void Initialize(PlaceStatusManager manager)
	{
	}

	[Token(Token = "0x600A1F6")]
	[Address(RVA = "0xEF6D10", Offset = "0xEF5F10", VA = "0x180EF6D10")]
	public void Setup(SharedDefinition.Location location, bool lieDown)
	{
	}

	[Token(Token = "0x600A1F7")]
	[Address(RVA = "0xEF7010", Offset = "0xEF6210", VA = "0x180EF7010")]
	public void Show(bool immediate)
	{
	}

	[Token(Token = "0x600A1F8")]
	[Address(RVA = "0xEF67F0", Offset = "0xEF59F0", VA = "0x180EF67F0")]
	public void Hide(bool immediate)
	{
	}

	[Token(Token = "0x600A1F9")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	private void OnFinishedTweenShow()
	{
	}

	[Token(Token = "0x600A1FA")]
	[Address(RVA = "0xEF6CD0", Offset = "0xEF5ED0", VA = "0x180EF6CD0")]
	private void OnFinishedTweenHide()
	{
	}

	[Token(Token = "0x600A1FB")]
	[Address(RVA = "0xEF7170", Offset = "0xEF6370", VA = "0x180EF7170")]
	public void UpdateNumCards(Vector2 scrPos, int numCards, bool force = false)
	{
	}

	[Token(Token = "0x600A1FC")]
	[Address(RVA = "0xEF66C0", Offset = "0xEF58C0", VA = "0x180EF66C0")]
	private void ApplyPosition(GameObject go, Vector2 scrPos)
	{
	}

	[Token(Token = "0x600A1FD")]
	[Address(RVA = "0xEF7320", Offset = "0xEF6520", VA = "0x180EF7320")]
	public PlaceStatusLabel()
	{
	}
}
