using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.ElementSystem;
using YgomSystem.YGomTMPro;

namespace YgomGame.Common;

[Token(Token = "0x2000C55")]
public class MatchingComment : MonoBehaviour
{
	[Token(Token = "0x2000C56")]
	protected internal enum Step
	{
		[Token(Token = "0x4009ABF")]
		INIT,
		[Token(Token = "0x4009AC0")]
		INVISIBLE,
		[Token(Token = "0x4009AC1")]
		SHOWING,
		[Token(Token = "0x4009AC2")]
		HIDING
	}

	[Token(Token = "0x4009AB7")]
	protected internal const string TWEEN_LABEL_SHOW = "Show";

	[Token(Token = "0x4009AB8")]
	protected internal const string TWEEN_LABEL_HIDE = "Hide";

	[Token(Token = "0x4009AB9")]
	[FieldOffset(Offset = "0x20")]
	protected ElementObjectManager _eom;

	[Token(Token = "0x4009ABA")]
	[FieldOffset(Offset = "0x28")]
	protected internal ExtendedTextMeshProUGUI _commentText;

	[Token(Token = "0x4009ABB")]
	[FieldOffset(Offset = "0x30")]
	protected Step _step;

	[Token(Token = "0x4009ABC")]
	[FieldOffset(Offset = "0x38")]
	protected string _nextShowingComment;

	[Token(Token = "0x4009ABD")]
	[FieldOffset(Offset = "0x40")]
	protected bool _invisiblePreserved;

	[Token(Token = "0x17000A2B")]
	public bool initialized
	{
		[Token(Token = "0x6004B02")]
		[Address(RVA = "0x93FE10", Offset = "0x93F010", VA = "0x18093FE10")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6004B03")]
	[Address(RVA = "0x93F8F0", Offset = "0x93EAF0", VA = "0x18093F8F0", Slot = "4")]
	protected virtual void Awake()
	{
	}

	[Token(Token = "0x6004B04")]
	[Address(RVA = "0x93FAD0", Offset = "0x93ECD0", VA = "0x18093FAD0")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6004B05")]
	[Address(RVA = "0x93F9A0", Offset = "0x93EBA0", VA = "0x18093F9A0")]
	public void Clear()
	{
	}

	[Token(Token = "0x6004B06")]
	[Address(RVA = "0x93FAE0", Offset = "0x93ECE0", VA = "0x18093FAE0", Slot = "5")]
	public virtual void SetComment(string newComment)
	{
	}

	[Token(Token = "0x6004B07")]
	[Address(RVA = "0x93FAC0", Offset = "0x93ECC0", VA = "0x18093FAC0", Slot = "6")]
	public virtual void HideComment()
	{
	}

	[Token(Token = "0x6004B08")]
	[Address(RVA = "0x93FB70", Offset = "0x93ED70", VA = "0x18093FB70", Slot = "7")]
	protected virtual void Update()
	{
	}

	[Token(Token = "0x6004B09")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public MatchingComment()
	{
	}
}
