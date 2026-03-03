using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20000A8")]
[RequireComponent(typeof(RectTransform))]
public class AutoAntiExtrusionForUI : MonoBehaviour
{
	[Token(Token = "0x400032F")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private RectOffset padding;

	[Token(Token = "0x4000330")]
	[FieldOffset(Offset = "0x28")]
	private RectTransform m_RectTransform;

	[Token(Token = "0x6000331")]
	[Address(RVA = "0x671130", Offset = "0x670330", VA = "0x180671130")]
	private void Start()
	{
	}

	[Token(Token = "0x6000332")]
	[Address(RVA = "0x671180", Offset = "0x670380", VA = "0x180671180")]
	private void Update()
	{
	}

	[Token(Token = "0x6000333")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public AutoAntiExtrusionForUI()
	{
	}
}
