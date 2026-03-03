using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.Effect;

[Token(Token = "0x2000321")]
public class ScreenEffect : MonoBehaviour
{
	[Token(Token = "0x2000322")]
	public enum ViewType
	{
		[Token(Token = "0x400111C")]
		View2D,
		[Token(Token = "0x400111D")]
		View3D
	}

	[Token(Token = "0x4001112")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public bool useCameraSetting;

	[Token(Token = "0x4001113")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
	public bool useMainCameraSetting;

	[Token(Token = "0x4001114")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public Vector3 cameraPosition;

	[Token(Token = "0x4001115")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public Vector3 cameraAngle;

	[Token(Token = "0x4001116")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	public ViewType cameraViewType;

	[Token(Token = "0x4001117")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public float camera2DSize;

	[Token(Token = "0x4001118")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
	public bool overUI;

	[Token(Token = "0x4001119")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x45")]
	public bool setupOnAwake;

	[Token(Token = "0x170001F0")]
	public Camera targetCamera
	{
		[Token(Token = "0x6001385")]
		[Address(RVA = "0x414E80", Offset = "0x414080", VA = "0x180414E80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6001386")]
		[Address(RVA = "0x414E90", Offset = "0x414090", VA = "0x180414E90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x6001387")]
	[Address(RVA = "0x414080", Offset = "0x413280", VA = "0x180414080")]
	private void Awake()
	{
	}

	[Token(Token = "0x6001388")]
	[Address(RVA = "0x414100", Offset = "0x413300", VA = "0x180414100")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6001389")]
	[Address(RVA = "0x414090", Offset = "0x413290", VA = "0x180414090")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600138A")]
	[Address(RVA = "0x4147B0", Offset = "0x4139B0", VA = "0x1804147B0")]
	public void Setup()
	{
	}

	[Token(Token = "0x600138B")]
	[Address(RVA = "0x414160", Offset = "0x413360", VA = "0x180414160")]
	public void SetupCamera(Camera target)
	{
	}

	[Token(Token = "0x600138C")]
	[Address(RVA = "0x4149F0", Offset = "0x413BF0", VA = "0x1804149F0")]
	public void TraceCameraSetting(Camera target, string viewInfoLabel = "Top")
	{
	}

	[Token(Token = "0x600138D")]
	[Address(RVA = "0x414D20", Offset = "0x413F20", VA = "0x180414D20")]
	public static void TraceMainCameraSetting(Camera target)
	{
	}

	[Token(Token = "0x600138E")]
	[Address(RVA = "0x414540", Offset = "0x413740", VA = "0x180414540")]
	public void SetupLayer(int layer)
	{
	}

	[Token(Token = "0x600138F")]
	[Address(RVA = "0x4146D0", Offset = "0x4138D0", VA = "0x1804146D0")]
	public void SetupSpriteScaler()
	{
	}

	[Token(Token = "0x6001390")]
	[Address(RVA = "0x4145B0", Offset = "0x4137B0", VA = "0x1804145B0")]
	public void SetupSpriteScaler(float screenWidth, float screenHeight, [Optional] Camera setupCamera)
	{
	}

	[Token(Token = "0x6001391")]
	[Address(RVA = "0x414E30", Offset = "0x414030", VA = "0x180414E30")]
	public ScreenEffect()
	{
	}
}
