using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomGame.Duel;

namespace YgomSample.DuelEdit;

[Token(Token = "0x2001DC5")]
public class DuelPlacementTest : MonoBehaviour
{
	[Token(Token = "0x401052E")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private CameraViewSetting cameraViewSetting;

	[Token(Token = "0x401052F")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Transform objectsParent;

	[Token(Token = "0x4010530")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private GameObject cardPrefab;

	[Token(Token = "0x4010531")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private GameObject nearFieldPrefab;

	[Token(Token = "0x4010532")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private GameObject farFieldPrefab;

	[Token(Token = "0x4010533")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private float matOffset;

	[Token(Token = "0x4010534")]
	[FieldOffset(Offset = "0x50")]
	private GameObject nearMat;

	[Token(Token = "0x4010535")]
	[FieldOffset(Offset = "0x58")]
	private GameObject farMat;

	[Token(Token = "0x17001C33")]
	public List<GameObject> cards
	{
		[Token(Token = "0x600BE49")]
		[Address(RVA = "0x589E50", Offset = "0x589050", VA = "0x180589E50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600BE4A")]
		[Address(RVA = "0x589E60", Offset = "0x589060", VA = "0x180589E60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x600BE4B")]
	[Address(RVA = "0x589560", Offset = "0x588760", VA = "0x180589560")]
	public void SetupObjects()
	{
	}

	[Token(Token = "0x600BE4C")]
	[Address(RVA = "0x589480", Offset = "0x588680", VA = "0x180589480")]
	public void ClearObjects()
	{
	}

	[Token(Token = "0x600BE4D")]
	[Address(RVA = "0x589E40", Offset = "0x589040", VA = "0x180589E40")]
	public DuelPlacementTest()
	{
	}
}
