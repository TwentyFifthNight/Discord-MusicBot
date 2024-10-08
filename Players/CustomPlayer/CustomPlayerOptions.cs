﻿using DSharpPlus.Entities;
using Lavalink4NET.Players.Queued;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remelites.Players.CustomPlayer
{
	public sealed record class CustomPlayerOptions : QueuedLavalinkPlayerOptions
	{
		public DiscordChannel TextChannel { get; init; }
		public ulong GuildId { get; init; }
	}
}
