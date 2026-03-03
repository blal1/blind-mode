using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using YgomSystem.UI;

namespace YgomGame.Menu;

[Token(Token = "0x200138E")]
public class TextureImageDialogViewController : TweenViewController, IBokeSupported
{
	[Token(Token = "0x400C26A")]
	public const string ARGKEY_TEXTURE = "texture";

	[Token(Token = "0x400C26B")]
	public const string ARGKEY_WIDTH = "width";

	[Token(Token = "0x400C26C")]
	public const string ARGKEY_HEIGHT = "height";

	[Token(Token = "0x400C26D")]
	public const string ARGKEY_ANIM_ROT = "rotateAnim";

	[Token(Token = "0x400C26E")]
	public const string ARGKEY_ANIM_POS = "positionAnim";

	[Token(Token = "0x400C26F")]
	public const string ARGKEY_BGCOLOR = "bgcolor";

	[Token(Token = "0x400C270")]
	public const string ARGKEY_VOFS = "vofs";

	[Token(Token = "0x400C271")]
	public const string ARGKEY_CAPTION = "caption";

	[Token(Token = "0x400C272")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[SerializeField]
	private Text caption;

	[Token(Token = "0x400C273")]
	private const string PREFAB_NAME = "TextureImageDialog";

	[Token(Token = "0x400C274")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public RawImage rawImage;

	[Token(Token = "0x6007954")]
	[Address(RVA = "0xC26430", Offset = "0xC25630", VA = "0x180C26430")]
	public static void Push(Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x6007955")]
	[Address(RVA = "0xC26200", Offset = "0xC25400", VA = "0x180C26200")]
	public static void PushProtector(int sid, [Optional] Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x6007956")]
	[Address(RVA = "0xC25E00", Offset = "0xC25000", VA = "0x180C25E00", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6007957")]
	[Address(RVA = "0xC25E80", Offset = "0xC25080", VA = "0x180C25E80", Slot = "7")]
	public override void NotificationStackRemove()
	{
	}

	[Token(Token = "0x6007958")]
	[Address(RVA = "0xC26890", Offset = "0xC25A90", VA = "0x180C26890", Slot = "11")]
	public override void TransitionStart(TransitionType type)
	{
	}

	[Token(Token = "0x6007959")]
	[Address(RVA = "0xC264A0", Offset = "0xC256A0", VA = "0x180C264A0")]
	private void Start()
	{
	}

	[Token(Token = "0x600795A")]
	[Address(RVA = "0xC25ED0", Offset = "0xC250D0", VA = "0x180C25ED0")]
	public void OnPushed()
	{
	}

	[Token(Token = "0x600795B")]
	[Address(RVA = "0xB86CD0", Offset = "0xB85ED0", VA = "0x180B86CD0")]
	public TextureImageDialogViewController()
	{
	}
}
