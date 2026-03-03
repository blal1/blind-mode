using System.Text;
using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.YGomTMPro;

[Token(Token = "0x2000091")]
public class TdyTextAnimation : MonoBehaviour
{
	[Token(Token = "0x40002E6")]
	[FieldOffset(Offset = "0x20")]
	private readonly string _randomCharacters;

	[Token(Token = "0x40002E7")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[Tooltip("Awake時にテキストアニメを再生させるかどうか")]
	private bool _playOnAwake;

	[Token(Token = "0x40002E8")]
	[FieldOffset(Offset = "0x30")]
	private ExtendedTextMeshProUGUI _uiText;

	[Token(Token = "0x40002E9")]
	[FieldOffset(Offset = "0x38")]
	private int _frameCount;

	[Token(Token = "0x40002EA")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	[Tooltip("ランダムテキストアニメーション開始までの待機フレーム数")]
	private int _waitFrame;

	[Token(Token = "0x40002EB")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Tooltip("文字表示開始からランダムテキスト表示を維持するフレーム数")]
	private int randomTextFrame;

	[Token(Token = "0x40002EC")]
	[FieldOffset(Offset = "0x48")]
	private string _text;

	[Token(Token = "0x40002ED")]
	[FieldOffset(Offset = "0x50")]
	private StringBuilder _randomTextBuf;

	[Token(Token = "0x17000049")]
	public string text
	{
		[Token(Token = "0x60002C5")]
		[Address(RVA = "0x3FBAB0", Offset = "0x3FACB0", VA = "0x1803FBAB0")]
		set
		{
		}
	}

	[Token(Token = "0x60002C6")]
	[Address(RVA = "0x3FB920", Offset = "0x3FAB20", VA = "0x1803FB920")]
	private string setRandomText(string origin, int frameNum)
	{
		return null;
	}

	[Token(Token = "0x60002C7")]
	[Address(RVA = "0x3FB540", Offset = "0x3FA740", VA = "0x1803FB540")]
	private void Awake()
	{
	}

	[Token(Token = "0x60002C8")]
	[Address(RVA = "0x3FB830", Offset = "0x3FAA30", VA = "0x1803FB830")]
	private void Start()
	{
	}

	[Token(Token = "0x60002C9")]
	[Address(RVA = "0x3FB620", Offset = "0x3FA820", VA = "0x1803FB620")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60002CA")]
	[Address(RVA = "0x3FB7D0", Offset = "0x3FA9D0", VA = "0x1803FB7D0")]
	public void PlayChangingText(string newText, int waitFrame = 0)
	{
	}

	[Token(Token = "0x60002CB")]
	[Address(RVA = "0x3FB890", Offset = "0x3FAA90", VA = "0x1803FB890")]
	public TdyTextAnimation()
	{
	}
}
