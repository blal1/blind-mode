using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame;

[Token(Token = "0x2000710")]
public class ResidentCreator : MonoBehaviour
{
	[Token(Token = "0x4002340")]
	private const string DownloadDataRevision = "dl_rev";

	[Token(Token = "0x4002341")]
	private const string DownloadListIndex = "dllstidx";

	[Token(Token = "0x4002342")]
	[FieldOffset(Offset = "0x0")]
	public static readonly string ResidentTag;

	[Token(Token = "0x4002343")]
	[FieldOffset(Offset = "0x8")]
	private static readonly Type[] ResidentGroups;

	[Token(Token = "0x170005C8")]
	public static bool isReady
	{
		[Token(Token = "0x6002EAA")]
		[Address(RVA = "0x722320", Offset = "0x721520", VA = "0x180722320")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6002EA9")]
		[Address(RVA = "0x722370", Offset = "0x721570", VA = "0x180722370")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x6002EAB")]
	[Address(RVA = "0x7213D0", Offset = "0x7205D0", VA = "0x1807213D0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6002EAC")]
	[Address(RVA = "0x7212A0", Offset = "0x7204A0", VA = "0x1807212A0")]
	private void AddObject(GameObject parent, string objectName, Type type)
	{
	}

	[Token(Token = "0x6002EAD")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public ResidentCreator()
	{
	}
}
