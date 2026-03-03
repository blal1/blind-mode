using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.LocalFileSystem;

[Token(Token = "0x20002E4")]
public class LocalFileManager : MonoBehaviour
{
	[Token(Token = "0x4000FCB")]
	[FieldOffset(Offset = "0x20")]
	private bool m_initialized;

	[Token(Token = "0x4000FCC")]
	[FieldOffset(Offset = "0x28")]
	private ulong m_frameCounter;

	[Token(Token = "0x4000FCD")]
	[FieldOffset(Offset = "0x30")]
	private Queue<LocalFileAssetBundleLoadRequest> m_assetBundleLoadQueue;

	[Token(Token = "0x4000FCE")]
	[FieldOffset(Offset = "0x38")]
	private List<LocalFileAssetBundleLoadRequest> m_assetBundleLoadTask;

	[Token(Token = "0x4000FCF")]
	private const int defaultLoadTaskLimit = 10;

	[Token(Token = "0x4000FD0")]
	[FieldOffset(Offset = "0x40")]
	private int m_loadTaskLimit;

	[Token(Token = "0x170001D1")]
	public ulong frameCounter
	{
		[Token(Token = "0x600118D")]
		[Address(RVA = "0x4030F0", Offset = "0x4022F0", VA = "0x1804030F0")]
		get
		{
			return default(ulong);
		}
	}

	[Token(Token = "0x6001185")]
	[Address(RVA = "0x409900", Offset = "0x408B00", VA = "0x180409900")]
	private void Awake()
	{
	}

	[Token(Token = "0x6001186")]
	[Address(RVA = "0x409A70", Offset = "0x408C70", VA = "0x180409A70")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6001187")]
	[Address(RVA = "0x409CE0", Offset = "0x408EE0", VA = "0x180409CE0")]
	private void Update()
	{
	}

	[Token(Token = "0x6001188")]
	[Address(RVA = "0x409A00", Offset = "0x408C00", VA = "0x180409A00")]
	public void Initialize(string env, bool enableLog)
	{
	}

	[Token(Token = "0x6001189")]
	[Address(RVA = "0x409CD0", Offset = "0x408ED0", VA = "0x180409CD0")]
	public void SetLoadTaskLimit(int num)
	{
	}

	[Token(Token = "0x600118A")]
	[Address(RVA = "0x409CC0", Offset = "0x408EC0", VA = "0x180409CC0")]
	public void ResetLoadTaskLimit()
	{
	}

	[Token(Token = "0x600118B")]
	[Address(RVA = "0x409C00", Offset = "0x408E00", VA = "0x180409C00")]
	public LocalFileAssetBundleLoadRequest RequestAssetBundleLoad(string nativePath)
	{
		return null;
	}

	[Token(Token = "0x600118C")]
	[Address(RVA = "0x4099C0", Offset = "0x408BC0", VA = "0x1804099C0")]
	public int GetAssetBundleRequestQueueCount()
	{
		return default(int);
	}

	[Token(Token = "0x600118E")]
	[Address(RVA = "0x409EC0", Offset = "0x4090C0", VA = "0x180409EC0")]
	public LocalFileManager()
	{
	}
}
