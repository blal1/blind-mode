using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace YgomSystem.LocalFileSystem;

[Token(Token = "0x20002F9")]
public abstract class StorageIO
{
	[Token(Token = "0x20002FA")]
	public class StorageInfo
	{
		[Token(Token = "0x4001019")]
		[FieldOffset(Offset = "0x10")]
		public Storage storage;

		[Token(Token = "0x400101A")]
		[FieldOffset(Offset = "0x18")]
		public string mountPath;

		[Token(Token = "0x400101B")]
		[FieldOffset(Offset = "0x20")]
		public bool isWritable;

		[Token(Token = "0x400101C")]
		[FieldOffset(Offset = "0x28")]
		public string envRoot;

		[Token(Token = "0x400101D")]
		[FieldOffset(Offset = "0x30")]
		public string writeHashRoot;

		[Token(Token = "0x400101E")]
		[FieldOffset(Offset = "0x38")]
		public bool useHashDir;

		[Token(Token = "0x400101F")]
		[FieldOffset(Offset = "0x40")]
		public string writePlainRoot;

		[Token(Token = "0x60012AA")]
		[Address(RVA = "0x417DA0", Offset = "0x416FA0", VA = "0x180417DA0")]
		public StorageInfo(Storage st)
		{
		}
	}

	[Token(Token = "0x4001017")]
	[FieldOffset(Offset = "0x10")]
	private StorageInfo[] m_storageInfos;

	[Token(Token = "0x170001DD")]
	protected string environment
	{
		[Token(Token = "0x600128F")]
		[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6001290")]
		[Address(RVA = "0x417C80", Offset = "0x416E80", VA = "0x180417C80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x600128D")]
	[Address(RVA = "0x4179D0", Offset = "0x416BD0", VA = "0x1804179D0")]
	protected StorageInfo getStorageInfo(Storage type)
	{
		return null;
	}

	[Token(Token = "0x600128E")]
	[Address(RVA = "0x417C90", Offset = "0x416E90", VA = "0x180417C90")]
	protected void setupStorageInfo(Storage storage, string mountPath, string envRoot, string hashRootPath, bool useHashDir, string plainRootPath)
	{
	}

	[Token(Token = "0x6001291")]
	[Address(RVA = "0x417A00", Offset = "0x416C00", VA = "0x180417A00")]
	public void Initialize(string envName)
	{
	}

	[Token(Token = "0x6001292")]
	[Address(RVA = "0x417C60", Offset = "0x416E60", VA = "0x180417C60")]
	public void Terminate()
	{
	}

	[Token(Token = "0x6001293")]
	[Address(RVA = "0x4179D0", Offset = "0x416BD0", VA = "0x1804179D0")]
	public StorageInfo GetStorageInfo(Storage type)
	{
		return null;
	}

	[Token(Token = "0x6001294")]
	[Address(RVA = "0x417850", Offset = "0x416A50", VA = "0x180417850")]
	public string GetMountNativePath(Storage storage)
	{
		return null;
	}

	[Token(Token = "0x6001295")]
	[Address(RVA = "0x417570", Offset = "0x416770", VA = "0x180417570")]
	public string GetEnvRootNativePath(Storage storage)
	{
		return null;
	}

	[Token(Token = "0x6001296")]
	[Address(RVA = "0x417600", Offset = "0x416800", VA = "0x180417600")]
	public string GetHashedFileNativePath(Storage storage, string hash)
	{
		return null;
	}

	[Token(Token = "0x6001297")]
	[Address(RVA = "0x4178E0", Offset = "0x416AE0", VA = "0x1804178E0")]
	public string GetPlainNativePath(Storage storage, string path)
	{
		return null;
	}

	[Token(Token = "0x6001298")]
	protected abstract void OnInitialize();

	[Token(Token = "0x6001299")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
	protected virtual void OnTerminate()
	{
	}

	[Token(Token = "0x600129A")]
	public abstract bool ExistsFile(string nativePath);

	[Token(Token = "0x600129B")]
	public abstract void DeleteFile(string nativePath);

	[Token(Token = "0x600129C")]
	public abstract long GetFileSize(string nativePath);

	[Token(Token = "0x600129D")]
	public abstract void MoveFile(string srcNativePath, string dstNativePath);

	[Token(Token = "0x600129E")]
	public abstract bool ExistsDirectory(string nativePath);

	[Token(Token = "0x600129F")]
	public abstract void CreateDirectory(string nativePath);

	[Token(Token = "0x60012A0")]
	public abstract string[] GetDirectories(string nativePath);

	[Token(Token = "0x60012A1")]
	public abstract string[] GetFiles(string nativePath, string searchPattern);

	[Token(Token = "0x60012A2")]
	public abstract void DeleteDirectory(string nativePath);

	[Token(Token = "0x60012A3")]
	public abstract void MoveDirectory(string srcNativePath, string dstNativePath);

	[Token(Token = "0x60012A4")]
	public abstract string GetStreamingAssetNativePath(string name);

	[Token(Token = "0x60012A5")]
	public abstract bool ExistsStreamingAsset(string name);

	[Token(Token = "0x60012A6")]
	public abstract byte[] ReadStreamingAsset(string name);

	[Token(Token = "0x60012A7")]
	public abstract void ReadStreamingAssetCallback(string name, Action<byte[]> readCallback);

	[Token(Token = "0x60012A8")]
	public abstract void ClearLocalDataStorage(Action finishCallback);

	[Token(Token = "0x60012A9")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	protected StorageIO()
	{
	}
}
