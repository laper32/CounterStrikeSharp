// <auto-generated />
#nullable enable
#pragma warning disable CS1591

using System;
using System.Diagnostics;
using System.Drawing;
using CounterStrikeSharp;
using CounterStrikeSharp.API.Modules.Events;
using CounterStrikeSharp.API.Modules.Entities;
using CounterStrikeSharp.API.Modules.Memory;
using CounterStrikeSharp.API.Modules.Utils;
using CounterStrikeSharp.API.Core.Attributes;

namespace CounterStrikeSharp.API.Core;

public partial class CCSPlayerController_DamageServices : CPlayerControllerComponent
{
    public CCSPlayerController_DamageServices (IntPtr pointer) : base(pointer) {}

	// m_nSendUpdate
	[SchemaMember("CCSPlayerController_DamageServices", "m_nSendUpdate")]
	public ref Int32 SendUpdate => ref Schema.GetRef<Int32>(this.Handle, "CCSPlayerController_DamageServices", "m_nSendUpdate");

	// m_DamageList
	[SchemaMember("CCSPlayerController_DamageServices", "m_DamageList")]
	public NetworkedVector<CDamageRecord> DamageList => Schema.GetDeclaredClass<NetworkedVector<CDamageRecord>>(this.Handle, "CCSPlayerController_DamageServices", "m_DamageList");

}