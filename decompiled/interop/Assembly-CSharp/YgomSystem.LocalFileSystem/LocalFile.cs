using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.Utility;

namespace YgomSystem.LocalFileSystem;

[Token(Token = "0x20002E5")]
public static class LocalFile
{
	[StructLayout(3)]
	[Token(Token = "0x20002EF")]
	[CompilerGenerated]
	private struct _003CClearLocalDataStorage_003Ed__88 : IAsyncStateMachine
	{
		[Token(Token = "0x4000FEB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x4000FEC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncVoidMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x4000FED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Action finishCallback;

		[Token(Token = "0x4000FEE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TaskAwaiter _003C_003Eu__1;

		[Token(Token = "0x600120A")]
		[Address(RVA = "0x417F00", Offset = "0x417100", VA = "0x180417F00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x600120B")]
		[Address(RVA = "0x418110", Offset = "0x417310", VA = "0x180418110", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x4000FD1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static LocalFileManager s_manager;

	[Token(Token = "0x170001D2")]
	public static LocalFileManager manager
	{
		[Token(Token = "0x6001194")]
		[Address(RVA = "0x412AE0", Offset = "0x411CE0", VA = "0x180412AE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600118F")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	static LocalFile()
	{
	}

	[Token(Token = "0x6001190")]
	[Address(RVA = "0x40F090", Offset = "0x40E290", VA = "0x18040F090")]
	public static void Initialize(string env)
	{
	}

	[Token(Token = "0x6001191")]
	[Address(RVA = "0x40F240", Offset = "0x40E440", VA = "0x18040F240")]
	public static void Initialize(RuntimeEnvironment.ServerType serverType)
	{
	}

	[Token(Token = "0x6001192")]
	[Address(RVA = "0x40F990", Offset = "0x40EB90", VA = "0x18040F990")]
	public static bool IsInitialized()
	{
		return default(bool);
	}

	[Token(Token = "0x6001193")]
	public static T GetStorageIO<T>() where T : StorageIO
	{
		return null;
	}

	[Token(Token = "0x6001195")]
	[Address(RVA = "0x412860", Offset = "0x411A60", VA = "0x180412860")]
	private static void dispatchLocationNameType(FileNameType nameType, Action nomralCallback, Action plainCallback, Action rawCallback)
	{
	}

	[Token(Token = "0x6001196")]
	[Address(RVA = "0x40D200", Offset = "0x40C400", VA = "0x18040D200")]
	public static bool ExistsFile(Storage storage, string name, FileNameType nameType)
	{
		return default(bool);
	}

	[Token(Token = "0x6001197")]
	[Address(RVA = "0x40D530", Offset = "0x40C730", VA = "0x18040D530")]
	public static bool ExistsFile(Storage storage, string name)
	{
		return default(bool);
	}

	[Token(Token = "0x6001198")]
	[Address(RVA = "0x40D590", Offset = "0x40C790", VA = "0x18040D590")]
	public static bool ExistsFile(FileLocation location)
	{
		return default(bool);
	}

	[Token(Token = "0x6001199")]
	[Address(RVA = "0x40D410", Offset = "0x40C610", VA = "0x18040D410")]
	public static bool ExistsFile(string locationString)
	{
		return default(bool);
	}

	[Token(Token = "0x600119A")]
	[Address(RVA = "0x411A40", Offset = "0x410C40", VA = "0x180411A40")]
	public static void WriteFile(Storage storage, string name, FileNameType nameType, byte[] writeData, bool asNewFile)
	{
	}

	[Token(Token = "0x600119B")]
	[Address(RVA = "0x411900", Offset = "0x410B00", VA = "0x180411900")]
	public static void WriteFile(Storage storage, string name, byte[] writeData, bool asNewFile)
	{
	}

	[Token(Token = "0x600119C")]
	[Address(RVA = "0x411990", Offset = "0x410B90", VA = "0x180411990")]
	public static void WriteFile(FileLocation location, byte[] writeData, bool asNewFile)
	{
	}

	[Token(Token = "0x600119D")]
	[Address(RVA = "0x4117B0", Offset = "0x4109B0", VA = "0x1804117B0")]
	public static void WriteFile(string locationString, byte[] writeData, bool asNewFile)
	{
	}

	[Token(Token = "0x600119E")]
	[Address(RVA = "0x4123B0", Offset = "0x4115B0", VA = "0x1804123B0")]
	public static void WriteTextFile(Storage storage, string name, FileNameType nameType, string text, bool asNewFile)
	{
	}

	[Token(Token = "0x600119F")]
	[Address(RVA = "0x4125D0", Offset = "0x4117D0", VA = "0x1804125D0")]
	public static void WriteTextFile(Storage storage, string name, string text, bool asNewFile)
	{
	}

	[Token(Token = "0x60011A0")]
	[Address(RVA = "0x4127B0", Offset = "0x4119B0", VA = "0x1804127B0")]
	public static void WriteTextFile(FileLocation location, string text, bool asNewFile)
	{
	}

	[Token(Token = "0x60011A1")]
	[Address(RVA = "0x412660", Offset = "0x411860", VA = "0x180412660")]
	public static void WriteTextFile(string locationString, string text, bool asNewFile)
	{
	}

	[Token(Token = "0x60011A2")]
	[Address(RVA = "0x40FF40", Offset = "0x40F140", VA = "0x18040FF40")]
	public static byte[] ReadFile(Storage storage, string name, FileNameType nameType)
	{
		return null;
	}

	[Token(Token = "0x60011A3")]
	[Address(RVA = "0x40FEE0", Offset = "0x40F0E0", VA = "0x18040FEE0")]
	public static byte[] ReadFile(Storage storage, string name)
	{
		return null;
	}

	[Token(Token = "0x60011A4")]
	[Address(RVA = "0x410160", Offset = "0x40F360", VA = "0x180410160")]
	public static byte[] ReadFile(FileLocation location)
	{
		return null;
	}

	[Token(Token = "0x60011A5")]
	[Address(RVA = "0x4101E0", Offset = "0x40F3E0", VA = "0x1804101E0")]
	public static byte[] ReadFile(string locationString)
	{
		return null;
	}

	[Token(Token = "0x60011A6")]
	[Address(RVA = "0x4112F0", Offset = "0x4104F0", VA = "0x1804112F0")]
	public static string ReadTextFile(Storage storage, string name, FileNameType nameType)
	{
		return null;
	}

	[Token(Token = "0x60011A7")]
	[Address(RVA = "0x411170", Offset = "0x410370", VA = "0x180411170")]
	public static string ReadTextFile(Storage storage, string name)
	{
		return null;
	}

	[Token(Token = "0x60011A8")]
	[Address(RVA = "0x4110F0", Offset = "0x4102F0", VA = "0x1804110F0")]
	public static string ReadTextFile(FileLocation location)
	{
		return null;
	}

	[Token(Token = "0x60011A9")]
	[Address(RVA = "0x4111D0", Offset = "0x4103D0", VA = "0x1804111D0")]
	public static string ReadTextFile(string locationString)
	{
		return null;
	}

	[Token(Token = "0x60011AA")]
	[Address(RVA = "0x40CB30", Offset = "0x40BD30", VA = "0x18040CB30")]
	public static void DeleteFile(Storage storage, string name, FileNameType nameType)
	{
	}

	[Token(Token = "0x60011AB")]
	[Address(RVA = "0x40CA50", Offset = "0x40BC50", VA = "0x18040CA50")]
	public static void DeleteFile(Storage storage, string name)
	{
	}

	[Token(Token = "0x60011AC")]
	[Address(RVA = "0x40CAB0", Offset = "0x40BCB0", VA = "0x18040CAB0")]
	public static void DeleteFile(FileLocation location)
	{
	}

	[Token(Token = "0x60011AD")]
	[Address(RVA = "0x40CD30", Offset = "0x40BF30", VA = "0x18040CD30")]
	public static void DeleteFile(string locationString)
	{
	}

	[Token(Token = "0x60011AE")]
	[Address(RVA = "0x40E250", Offset = "0x40D450", VA = "0x18040E250")]
	public static long GetFileSize(Storage storage, string name, FileNameType nameType)
	{
		return default(long);
	}

	[Token(Token = "0x60011AF")]
	[Address(RVA = "0x40E460", Offset = "0x40D660", VA = "0x18040E460")]
	public static long GetFileSize(Storage storage, string name)
	{
		return default(long);
	}

	[Token(Token = "0x60011B0")]
	[Address(RVA = "0x40E1D0", Offset = "0x40D3D0", VA = "0x18040E1D0")]
	public static long GetFileSize(FileLocation location)
	{
		return default(long);
	}

	[Token(Token = "0x60011B1")]
	[Address(RVA = "0x40E4C0", Offset = "0x40D6C0", VA = "0x18040E4C0")]
	public static long GetFileSize(string locationString)
	{
		return default(long);
	}

	[Token(Token = "0x60011B2")]
	[Address(RVA = "0x40E790", Offset = "0x40D990", VA = "0x18040E790")]
	public static string GetLocationNativePath(FileLocation location)
	{
		return null;
	}

	[Token(Token = "0x60011B3")]
	[Address(RVA = "0x40E840", Offset = "0x40DA40", VA = "0x18040E840")]
	public static string GetLocationNativePath(string locationString)
	{
		return null;
	}

	[Token(Token = "0x60011B4")]
	[Address(RVA = "0x40E5E0", Offset = "0x40D7E0", VA = "0x18040E5E0")]
	public static string GetHashFileNativePath(Storage storage, string name)
	{
		return null;
	}

	[Token(Token = "0x60011B5")]
	[Address(RVA = "0x40D610", Offset = "0x40C810", VA = "0x18040D610")]
	public static bool ExistsHashFile(Storage storage, string name)
	{
		return default(bool);
	}

	[Token(Token = "0x60011B6")]
	[Address(RVA = "0x411C70", Offset = "0x410E70", VA = "0x180411C70")]
	public static void WriteHashFile(Storage storage, string name, byte[] writeData, bool asNewFile)
	{
	}

	[Token(Token = "0x60011B7")]
	[Address(RVA = "0x411DC0", Offset = "0x410FC0", VA = "0x180411DC0")]
	public static void WriteHashTextFile(Storage storage, string name, string text, bool asNewFile)
	{
	}

	[Token(Token = "0x60011B8")]
	[Address(RVA = "0x410300", Offset = "0x40F500", VA = "0x180410300")]
	public static byte[] ReadHashFile(Storage storage, string name)
	{
		return null;
	}

	[Token(Token = "0x60011B9")]
	[Address(RVA = "0x410490", Offset = "0x40F690", VA = "0x180410490")]
	public static string ReadHashTextFile(Storage storage, string name)
	{
		return null;
	}

	[Token(Token = "0x60011BA")]
	[Address(RVA = "0x40FD80", Offset = "0x40EF80", VA = "0x18040FD80")]
	public static byte[] ReadFileHeader(Storage storage, string name, int length)
	{
		return null;
	}

	[Token(Token = "0x60011BB")]
	[Address(RVA = "0x40CE50", Offset = "0x40C050", VA = "0x18040CE50")]
	public static void DeleteHashFile(Storage storage, string name)
	{
	}

	[Token(Token = "0x60011BC")]
	[Address(RVA = "0x40E640", Offset = "0x40D840", VA = "0x18040E640")]
	public static long GetHashFileSize(Storage storage, string name)
	{
		return default(long);
	}

	[Token(Token = "0x60011BD")]
	[Address(RVA = "0x40D800", Offset = "0x40CA00", VA = "0x18040D800")]
	public static bool ExistsRawHashFile(Storage storage, string hash)
	{
		return default(bool);
	}

	[Token(Token = "0x60011BE")]
	[Address(RVA = "0x412210", Offset = "0x411410", VA = "0x180412210")]
	public static void WriteRawHashFile(Storage storage, string hash, byte[] writeData, bool asNewFile)
	{
	}

	[Token(Token = "0x60011BF")]
	[Address(RVA = "0x410B90", Offset = "0x40FD90", VA = "0x180410B90")]
	public static byte[] ReadRawHashFile(Storage storage, string hash)
	{
		return null;
	}

	[Token(Token = "0x60011C0")]
	[Address(RVA = "0x4109E0", Offset = "0x40FBE0", VA = "0x1804109E0")]
	public static byte[] ReadRawHashFileHeader(Storage storage, string hash, int length)
	{
		return null;
	}

	[Token(Token = "0x60011C1")]
	[Address(RVA = "0x40D040", Offset = "0x40C240", VA = "0x18040D040")]
	public static void DeleteRawHashFile(Storage storage, string hash)
	{
	}

	[Token(Token = "0x60011C2")]
	[Address(RVA = "0x40ED00", Offset = "0x40DF00", VA = "0x18040ED00")]
	public static long GetRawHashFileSize(Storage storage, string hash)
	{
		return default(long);
	}

	[Token(Token = "0x60011C3")]
	[Address(RVA = "0x40ECA0", Offset = "0x40DEA0", VA = "0x18040ECA0")]
	public static string GetPlainNativePath(Storage storage, string path)
	{
		return null;
	}

	[Token(Token = "0x60011C4")]
	[Address(RVA = "0x40D730", Offset = "0x40C930", VA = "0x18040D730")]
	public static bool ExistsPlainFile(Storage storage, string path)
	{
		return default(bool);
	}

	[Token(Token = "0x60011C5")]
	[Address(RVA = "0x411F40", Offset = "0x411140", VA = "0x180411F40")]
	public static void WritePlainFile(Storage storage, string path, byte[] writeData, bool asNewFile)
	{
	}

	[Token(Token = "0x60011C6")]
	[Address(RVA = "0x412090", Offset = "0x411290", VA = "0x180412090")]
	public static void WritePlainTextFile(Storage storage, string path, string text, bool asNewFile)
	{
	}

	[Token(Token = "0x60011C7")]
	[Address(RVA = "0x410670", Offset = "0x40F870", VA = "0x180410670")]
	public static byte[] ReadPlainFile(Storage storage, string path)
	{
		return null;
	}

	[Token(Token = "0x60011C8")]
	[Address(RVA = "0x410800", Offset = "0x40FA00", VA = "0x180410800")]
	public static string ReadPlainTextFile(Storage storage, string path)
	{
		return null;
	}

	[Token(Token = "0x60011C9")]
	[Address(RVA = "0x40CF70", Offset = "0x40C170", VA = "0x18040CF70")]
	public static void DeletePlainFile(Storage storage, string path)
	{
	}

	[Token(Token = "0x60011CA")]
	[Address(RVA = "0x40E990", Offset = "0x40DB90", VA = "0x18040E990")]
	public static long GetPlainFileSize(Storage storage, string path)
	{
		return default(long);
	}

	[Token(Token = "0x60011CB")]
	[Address(RVA = "0x40FC90", Offset = "0x40EE90", VA = "0x18040FC90")]
	public static void MovePlainFile(Storage storage, string srcPath, string dstPath)
	{
	}

	[Token(Token = "0x60011CC")]
	[Address(RVA = "0x40EAA0", Offset = "0x40DCA0", VA = "0x18040EAA0")]
	public static EntryItem[] GetPlainFiles(Storage storage, string path = "", string searchPattern = "")
	{
		return null;
	}

	[Token(Token = "0x60011CD")]
	[Address(RVA = "0x40D130", Offset = "0x40C330", VA = "0x18040D130")]
	public static bool ExistsDirectory(Storage storage, string path)
	{
		return default(bool);
	}

	[Token(Token = "0x60011CE")]
	[Address(RVA = "0x40C890", Offset = "0x40BA90", VA = "0x18040C890")]
	public static void CreateDirectory(Storage storage, string path)
	{
	}

	[Token(Token = "0x60011CF")]
	[Address(RVA = "0x40D9A0", Offset = "0x40CBA0", VA = "0x18040D9A0")]
	public static EntryItem[] GetDirectories(Storage storage, string path = "")
	{
		return null;
	}

	[Token(Token = "0x60011D0")]
	[Address(RVA = "0x40C960", Offset = "0x40BB60", VA = "0x18040C960")]
	public static void DeleteDirectory(Storage storage, string path)
	{
	}

	[Token(Token = "0x60011D1")]
	[Address(RVA = "0x40FBA0", Offset = "0x40EDA0", VA = "0x18040FBA0")]
	public static void MoveDirectory(Storage storage, string srcPath, string dstPath)
	{
	}

	[Token(Token = "0x60011D2")]
	[Address(RVA = "0x40EE40", Offset = "0x40E040", VA = "0x18040EE40")]
	public static string GetStreamingAssetNativePath(string name)
	{
		return null;
	}

	[Token(Token = "0x60011D3")]
	[Address(RVA = "0x40D8F0", Offset = "0x40CAF0", VA = "0x18040D8F0")]
	public static bool ExistsStreamingAsset(string name)
	{
		return default(bool);
	}

	[Token(Token = "0x60011D4")]
	[Address(RVA = "0x411010", Offset = "0x410210", VA = "0x180411010")]
	public static byte[] ReadStreamingAsset(string name)
	{
		return null;
	}

	[Token(Token = "0x60011D5")]
	[Address(RVA = "0x410EA0", Offset = "0x4100A0", VA = "0x180410EA0")]
	public static byte[] ReadStreamingAssetHeader(string name, int length)
	{
		return null;
	}

	[Token(Token = "0x60011D6")]
	[Address(RVA = "0x410D50", Offset = "0x40FF50", VA = "0x180410D50")]
	public static void ReadStreamingAssetCallback(string name, Action<byte[]> readCallback)
	{
	}

	[Token(Token = "0x60011D7")]
	[Address(RVA = "0x412B30", Offset = "0x411D30", VA = "0x180412B30")]
	private static string sanitizeAssetBundlePath(string path)
	{
		return null;
	}

	[Token(Token = "0x60011D8")]
	[Address(RVA = "0x40F5B0", Offset = "0x40E7B0", VA = "0x18040F5B0")]
	public static bool IsExistAssetBundle(string path)
	{
		return default(bool);
	}

	[Token(Token = "0x60011D9")]
	[Address(RVA = "0x412950", Offset = "0x411B50", VA = "0x180412950")]
	private static string getAssetBundleNativePathDownload(string sanitizedPath)
	{
		return null;
	}

	[Token(Token = "0x60011DA")]
	[Address(RVA = "0x40F450", Offset = "0x40E650", VA = "0x18040F450")]
	public static bool IsExistAssetBundleDownload(string path)
	{
		return default(bool);
	}

	[Token(Token = "0x60011DB")]
	[Address(RVA = "0x40FA10", Offset = "0x40EC10", VA = "0x18040FA10")]
	public static AssetBundle LoadAssetBundleFromDownload(string path)
	{
		return null;
	}

	[Token(Token = "0x60011DC")]
	[Address(RVA = "0x411520", Offset = "0x410720", VA = "0x180411520")]
	public static LocalFileAssetBundleLoadRequest RequestAssetBundleFromDownload(string path)
	{
		return null;
	}

	[Token(Token = "0x60011DD")]
	[Address(RVA = "0x4129B0", Offset = "0x411BB0", VA = "0x1804129B0")]
	private static string getAssetBundleNativePathStreamingAssets(string sanitizedPath, bool relative)
	{
		return null;
	}

	[Token(Token = "0x60011DE")]
	[Address(RVA = "0x40EF00", Offset = "0x40E100", VA = "0x18040EF00")]
	public static string GetStreamingAssetsAssetBundleNativePath(string path)
	{
		return null;
	}

	[Token(Token = "0x60011DF")]
	[Address(RVA = "0x40EFA0", Offset = "0x40E1A0", VA = "0x18040EFA0")]
	public static string GetStreamingAssetsAssetBundleRelativePath(string path)
	{
		return null;
	}

	[Token(Token = "0x60011E0")]
	[Address(RVA = "0x40F870", Offset = "0x40EA70", VA = "0x18040F870")]
	public static bool IsExistStreamingAssetsAssetBundle(string path)
	{
		return default(bool);
	}

	[Token(Token = "0x60011E1")]
	[Address(RVA = "0x40FAF0", Offset = "0x40ECF0", VA = "0x18040FAF0")]
	public static AssetBundle LoadAssetBundleFromStreamingAssets(string path)
	{
		return null;
	}

	[Token(Token = "0x60011E2")]
	[Address(RVA = "0x411620", Offset = "0x410820", VA = "0x180411620")]
	public static LocalFileAssetBundleLoadRequest RequestAssetBundleFromStreamingAssets(string path)
	{
		return null;
	}

	[Token(Token = "0x60011E3")]
	[Address(RVA = "0x411740", Offset = "0x410940", VA = "0x180411740")]
	public static void SetAssetBundleLoadTaskLimit(int num)
	{
	}

	[Token(Token = "0x60011E4")]
	[Address(RVA = "0x4116E0", Offset = "0x4108E0", VA = "0x1804116E0")]
	public static void ResetAssetBundleLoadTaskLimit()
	{
	}

	[Token(Token = "0x60011E5")]
	[Address(RVA = "0x40C7E0", Offset = "0x40B9E0", VA = "0x18040C7E0")]
	[AsyncStateMachine(typeof(_003CClearLocalDataStorage_003Ed__88))]
	public static void ClearLocalDataStorage(Action finishCallback)
	{
	}

	[Token(Token = "0x60011E6")]
	[Address(RVA = "0x40F040", Offset = "0x40E240", VA = "0x18040F040")]
	public static string HashFileName(string path)
	{
		return null;
	}

	[Token(Token = "0x60011E7")]
	[Address(RVA = "0x40DBB0", Offset = "0x40CDB0", VA = "0x18040DBB0")]
	public static uint GetFileCRC32(Storage storage, string name, FileNameType nameType)
	{
		return default(uint);
	}

	[Token(Token = "0x60011E8")]
	[Address(RVA = "0x40DEA0", Offset = "0x40D0A0", VA = "0x18040DEA0")]
	public static byte[] GetFileSHA1(Storage storage, string name, FileNameType nameType)
	{
		return null;
	}
}
