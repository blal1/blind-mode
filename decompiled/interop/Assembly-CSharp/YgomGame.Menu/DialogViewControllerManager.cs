using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using YgomSystem.UI;

namespace YgomGame.Menu;

[Token(Token = "0x200125D")]
public class DialogViewControllerManager : ViewControllerManager
{
	[Token(Token = "0x400BB29")]
	[FieldOffset(Offset = "0x0")]
	public static DialogViewControllerManager Instance;

	[Token(Token = "0x400BB2A")]
	public const float FADESPEED = 0.2f;

	[Token(Token = "0x400BB2B")]
	[FieldOffset(Offset = "0xA8")]
	public Image fillImage;

	[Token(Token = "0x400BB2C")]
	[FieldOffset(Offset = "0xB0")]
	public BokehCamera bokeh;

	[Token(Token = "0x400BB2D")]
	[FieldOffset(Offset = "0xB8")]
	public GameObject hiddenScreen;

	[Token(Token = "0x400BB2E")]
	[FieldOffset(Offset = "0xC0")]
	public Color defaultFadeColor;

	[Token(Token = "0x400BB2F")]
	[FieldOffset(Offset = "0xD0")]
	private Color fadeColor;

	[Token(Token = "0x400BB30")]
	[FieldOffset(Offset = "0xE0")]
	private float disp;

	[Token(Token = "0x400BB31")]
	[FieldOffset(Offset = "0xE4")]
	private bool touchMask;

	[Token(Token = "0x400BB32")]
	[FieldOffset(Offset = "0xE5")]
	private bool pauseContent;

	[Token(Token = "0x400BB33")]
	[FieldOffset(Offset = "0xE8")]
	[SerializeField]
	private GraphicRaycaster[] maskRaycasterList;

	[Token(Token = "0x1700120A")]
	public override int selectorRootPriority
	{
		[Token(Token = "0x600725B")]
		[Address(RVA = "0xB89A70", Offset = "0xB88C70", VA = "0x180B89A70", Slot = "16")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x600725C")]
	[Address(RVA = "0xB89B30", Offset = "0xB88D30", VA = "0x180B89B30")]
	public static DialogViewControllerManager GetManager()
	{
		return null;
	}

	[Token(Token = "0x600725D")]
	[Address(RVA = "0xB89A80", Offset = "0xB88C80", VA = "0x180B89A80", Slot = "17")]
	public override void Awake()
	{
	}

	[Token(Token = "0x600725E")]
	[Address(RVA = "0xB89E70", Offset = "0xB89070", VA = "0x180B89E70", Slot = "18")]
	public override void OnDestroy()
	{
	}

	[Token(Token = "0x600725F")]
	[Address(RVA = "0xB8A170", Offset = "0xB89370", VA = "0x180B8A170")]
	private void Start()
	{
	}

	[Token(Token = "0x6007260")]
	[Address(RVA = "0xB8A3E0", Offset = "0xB895E0", VA = "0x180B8A3E0", Slot = "19")]
	public override void Update()
	{
	}

	[Token(Token = "0x6007261")]
	[Address(RVA = "0xB89FE0", Offset = "0xB891E0", VA = "0x180B89FE0")]
	public void SetFadeColorDefault()
	{
	}

	[Token(Token = "0x6007262")]
	[Address(RVA = "0xB8A0B0", Offset = "0xB892B0", VA = "0x180B8A0B0")]
	public void SetFadeColor(Color color)
	{
	}

	[Token(Token = "0x6007263")]
	[Address(RVA = "0xB89DE0", Offset = "0xB88FE0", VA = "0x180B89DE0", Slot = "13")]
	public override bool OnBack()
	{
		return default(bool);
	}

	[Token(Token = "0x6007264")]
	[Address(RVA = "0xB89C40", Offset = "0xB88E40", VA = "0x180B89C40", Slot = "8")]
	public override void NotificationStack(ViewControllerManager vcm, ViewController vc, bool isEntry)
	{
	}

	[Token(Token = "0x6007265")]
	[Address(RVA = "0xB89F20", Offset = "0xB89120", VA = "0x180B89F20")]
	private void SendStackActionAction(TransitionType type, ViewController vc, ViewController preVc)
	{
	}

	[Token(Token = "0x6007266")]
	[Address(RVA = "0xB8A740", Offset = "0xB89940", VA = "0x180B8A740")]
	public DialogViewControllerManager()
	{
	}
}
