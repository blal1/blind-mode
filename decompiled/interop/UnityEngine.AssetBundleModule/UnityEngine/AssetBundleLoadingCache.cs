using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine;

[System.Serializable]
public static class AssetBundleLoadingCache
{
	private delegate uint get_maxBlocksPerFileDelegate();

	private delegate void set_maxBlocksPerFileDelegate(uint value);

	private delegate uint get_blockCountDelegate();

	private delegate void set_blockCountDelegate(uint value);

	private delegate uint get_blockSizeDelegate();

	public const int kMinAllowedBlockCount = 2;

	public const int kMinAllowedMaxBlocksPerFile = 2;

	private static readonly get_maxBlocksPerFileDelegate get_maxBlocksPerFileDelegateField = IL2CPP.ResolveICall<get_maxBlocksPerFileDelegate>("UnityEngine.AssetBundleLoadingCache::get_maxBlocksPerFile");

	private static readonly set_maxBlocksPerFileDelegate set_maxBlocksPerFileDelegateField = IL2CPP.ResolveICall<set_maxBlocksPerFileDelegate>("UnityEngine.AssetBundleLoadingCache::set_maxBlocksPerFile");

	private static readonly get_blockCountDelegate get_blockCountDelegateField = IL2CPP.ResolveICall<get_blockCountDelegate>("UnityEngine.AssetBundleLoadingCache::get_blockCount");

	private static readonly set_blockCountDelegate set_blockCountDelegateField = IL2CPP.ResolveICall<set_blockCountDelegate>("UnityEngine.AssetBundleLoadingCache::set_blockCount");

	private static readonly get_blockSizeDelegate get_blockSizeDelegateField = IL2CPP.ResolveICall<get_blockSizeDelegate>("UnityEngine.AssetBundleLoadingCache::get_blockSize");

	public static uint maxBlocksPerFile
	{
		get
		{
			return get_maxBlocksPerFileDelegateField();
		}
		set
		{
			set_maxBlocksPerFileDelegateField(value);
		}
	}

	public static uint blockCount
	{
		get
		{
			return get_blockCountDelegateField();
		}
		set
		{
			set_blockCountDelegateField(value);
		}
	}

	public static uint blockSize => get_blockSizeDelegateField();

	public static uint memoryBudgetKB
	{
		get
		{
			return blockCount * blockSize;
		}
		set
		{
			uint num = Il2CppSystem.Math.Max(value / blockSize, 2u);
			uint num2 = Il2CppSystem.Math.Max(blockCount / 4, 2u);
			if (num != blockCount || num2 != maxBlocksPerFile)
			{
				blockCount = num;
				maxBlocksPerFile = num2;
			}
		}
	}
}
