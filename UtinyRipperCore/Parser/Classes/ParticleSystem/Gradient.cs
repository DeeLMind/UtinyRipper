﻿using UtinyRipper.AssetExporters;
using UtinyRipper.Exporter.YAML;

namespace UtinyRipper.Classes.ParticleSystems
{
	public struct Gradient : IAssetReadable, IYAMLExportable
	{
		private static int GetSerializedVersion(Version version)
		{
#warning TODO: serialized version acording to read version (current 2017.3.0f3)
			return 2;
		}

		public void Read(AssetStream stream)
		{
			Key0.Read(stream);
			Key1.Read(stream);
			Key2.Read(stream);
			Key3.Read(stream);
			Key4.Read(stream);
			Key5.Read(stream);
			Key6.Read(stream);
			Key7.Read(stream);
			Ctime0 = stream.ReadUInt16();
			Ctime1 = stream.ReadUInt16();
			Ctime2 = stream.ReadUInt16();
			Ctime3 = stream.ReadUInt16();
			Ctime4 = stream.ReadUInt16();
			Ctime5 = stream.ReadUInt16();
			Ctime6 = stream.ReadUInt16();
			Ctime7 = stream.ReadUInt16();
			Atime0 = stream.ReadUInt16();
			Atime1 = stream.ReadUInt16();
			Atime2 = stream.ReadUInt16();
			Atime3 = stream.ReadUInt16();
			Atime4 = stream.ReadUInt16();
			Atime5 = stream.ReadUInt16();
			Atime6 = stream.ReadUInt16();
			Atime7 = stream.ReadUInt16();
			Mode = stream.ReadInt32();
			NumColorKeys = stream.ReadByte();
			NumAlphaKeys = stream.ReadByte();
			stream.AlignStream(AlignType.Align4);
			
		}

		public YAMLNode ExportYAML(IAssetsExporter exporter)
		{
			YAMLMappingNode node = new YAMLMappingNode();
			node.AddSerializedVersion(GetSerializedVersion(exporter.Version));
			node.Add("key0", Key0.ExportYAML(exporter));
			node.Add("key1", Key1.ExportYAML(exporter));
			node.Add("key2", Key2.ExportYAML(exporter));
			node.Add("key3", Key3.ExportYAML(exporter));
			node.Add("key4", Key4.ExportYAML(exporter));
			node.Add("key5", Key5.ExportYAML(exporter));
			node.Add("key6", Key6.ExportYAML(exporter));
			node.Add("key7", Key7.ExportYAML(exporter));
			node.Add("ctime0", Ctime0);
			node.Add("ctime1", Ctime1);
			node.Add("ctime2", Ctime2);
			node.Add("ctime3", Ctime3);
			node.Add("ctime4", Ctime4);
			node.Add("ctime5", Ctime5);
			node.Add("ctime6", Ctime6);
			node.Add("ctime7", Ctime7);
			node.Add("atime0", Atime0);
			node.Add("atime1", Atime1);
			node.Add("atime2", Atime2);
			node.Add("atime3", Atime3);
			node.Add("atime4", Atime4);
			node.Add("atime5", Atime5);
			node.Add("atime6", Atime6);
			node.Add("atime7", Atime7);
			node.Add("m_Mode", Mode);
			node.Add("m_NumColorKeys", NumColorKeys);
			node.Add("m_NumAlphaKeys", NumAlphaKeys);
			return node;
		}

		public ushort Ctime0 { get; private set; }
		public ushort Ctime1 { get; private set; }
		public ushort Ctime2 { get; private set; }
		public ushort Ctime3 { get; private set; }
		public ushort Ctime4 { get; private set; }
		public ushort Ctime5 { get; private set; }
		public ushort Ctime6 { get; private set; }
		public ushort Ctime7 { get; private set; }
		public ushort Atime0 { get; private set; }
		public ushort Atime1 { get; private set; }
		public ushort Atime2 { get; private set; }
		public ushort Atime3 { get; private set; }
		public ushort Atime4 { get; private set; }
		public ushort Atime5 { get; private set; }
		public ushort Atime6 { get; private set; }
		public ushort Atime7 { get; private set; }
		public int Mode { get; private set; }
		public byte NumColorKeys { get; private set; }
		public byte NumAlphaKeys { get; private set; }

		public ColorRGBAf Key0;
		public ColorRGBAf Key1;
		public ColorRGBAf Key2;
		public ColorRGBAf Key3;
		public ColorRGBAf Key4;
		public ColorRGBAf Key5;
		public ColorRGBAf Key6;
		public ColorRGBAf Key7;
	}
}