using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace YgomSystem.Home;

[Token(Token = "0x200038D")]
public class InstantiateTopicsPacks : MonoBehaviour
{
	[Token(Token = "0x4001230")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Image packImage;

	[Token(Token = "0x4001231")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private GameObject parentLayout;

	[Token(Token = "0x4001232")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private string imagePath;

	[Token(Token = "0x4001233")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private int num;

	[Token(Token = "0x4001234")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	[Tooltip("失敗時（imagePathが未設定時等）に非アクティブにするGameObject群、何も設定していなければ自身を非表示にする")]
	private GameObject[] failedTargets;

	[Token(Token = "0x4001235")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	[Min(1f)]
	[Tooltip("最大束数")]
	private int maxBundles;

	[Token(Token = "0x4001236")]
	[FieldOffset(Offset = "0x4C")]
	[SerializeField]
	[Min(1f)]
	[Tooltip("1つの束の最大数、最大束数(maxBundles)を超えてしまう場合はこちらの値は無視されます")]
	private int preferredMaxPacks;

	[Token(Token = "0x4001237")]
	[FieldOffset(Offset = "0x50")]
	private bool loadStart;

	[Token(Token = "0x60015C6")]
	[Address(RVA = "0x5247F0", Offset = "0x5239F0", VA = "0x1805247F0")]
	private void Start()
	{
	}

	[Token(Token = "0x60015C7")]
	[Address(RVA = "0x5243B0", Offset = "0x5235B0", VA = "0x1805243B0")]
	private void SetPacks()
	{
	}

	[Token(Token = "0x60015C8")]
	[Address(RVA = "0x524970", Offset = "0x523B70", VA = "0x180524970")]
	public InstantiateTopicsPacks()
	{
	}
}
